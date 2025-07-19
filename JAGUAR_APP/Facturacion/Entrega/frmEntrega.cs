using ACS.Classes;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Commands.Internal;
using DocumentFormat.OpenXml.Office2010.Excel;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.LogisticaJaguar;
using JAGUAR_PRO.Mantenimientos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Facturacion.Entrega
{
    public partial class frmEntrega : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogeado;
        DataOperations dp;
        int IdBodega;
        int PDVId;
        public frmEntrega(UserLogin pUserLogin, PDV puntoVenta)
        {
            InitializeComponent();

            UsuarioLogeado = pUserLogin;

            //Generar factura
            string HostName = Dns.GetHostName();
            FacturacionEquipo EquipoActual = new FacturacionEquipo();
            PDV puntoVenta1 = new PDV();

            if (EquipoActual.RecuperarRegistro(HostName))
            {
                if (EquipoActual.id_bodega_entrega == 0)
                {
                    CajaDialogo.Error("Este Equipo de nombre: " + HostName + " no tiene una Bodega de Entrega configurada!");
                    return;
                }
            }
            else
            {
                CajaDialogo.Error("Este equipo de nombre: " + HostName + " no esta configurado en ningun punto de venta!");
                return;
            }
            dp = new DataOperations();
            dtDesde.DateTime = dp.Now().AddDays(-7);
            dtHasta.DateTime = dp.Now();

            if (EquipoActual.id_bodega_entrega > 0)
            {
                Bodega bodegas = new Bodega();
                if (bodegas.RecuperarRegistro(EquipoActual.id_bodega_entrega))
                {
                    txtEquipoBodega.Text = bodegas.Descripcion;
                    IdBodega = bodegas.Id;
                }
               
            }

            
            IdBodega = EquipoActual.id_bodega_entrega;
            PDVId = EquipoActual.id_punto_venta;

            tggIncluirDocCerrados.IsOn = false;
            LoadData(IdBodega, PDVId);

        }

        private void LoadData(int idBodega, int PuntoVentaId)
        {
            try
            {
                dp = new DataOperations();
                string query = @"sp_get_pedidos_h_list";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_bodega", idBodega);
                cmd.Parameters.AddWithValue("@idPuntoVenta", PuntoVentaId);
                cmd.Parameters.AddWithValue("@DocCerrados", tggIncluirDocCerrados.IsOn);
                cmd.Parameters.AddWithValue("@dtDesde", dtDesde.DateTime);
                cmd.Parameters.AddWithValue("@dtHasta", dtHasta.DateTime);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEntregaPedidos1.list_entregas.Clear();
                adat.Fill(dsEntregaPedidos1.list_entregas);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void tggIncluirDocCerrados_Toggled(object sender, EventArgs e)
        {
            LoadData(IdBodega, PDVId);
        }

        private void cmdVerDetalle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsEntregaPedidos.list_entregasRow)gridview.GetFocusedDataRow();

            if (row != null)
            {
                fmrEntregaVerDetalle frm = new fmrEntregaVerDetalle(row.id, UsuarioLogeado, IdBodega);
                frm.ShowDialog();
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            LoadData(IdBodega, PDVId);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void cmdConcluirEntrega_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsEntregaPedidos.list_entregasRow)gridview.GetFocusedDataRow();

            bool Permitir = false;
            if (row != null)
            {
                switch (row.id_estado)
                {
                    case 1://Confirmado
                        CajaDialogo.Error("Este pedido no se a facturado, no se puede concluir la entrega!");
                        break;

                    case 2://Facturado
                        Permitir = true;
                        //CajaDialogo.Error("Este pedido ya fue Facturado, no se puede concluir la entrega!");
                        break;

                    case 3://Entregado
                        CajaDialogo.Error("Este pedido ya fue Entregado, no se puede concluir la entrega!");
                        break;

                    case 4://Cancelado
                        CajaDialogo.Error("Este pedido fue Cancelado, no se puede concluir la entrega!");
                        break;

                    case 5://Anulado
                        CajaDialogo.Error("Este pedido fue Anulado, no se puede concluir la entrega!");
                        break;

                    case 6://Nuevo
                        CajaDialogo.Error("Este pedido esta en estado: Nuevo, no se puede concluir la entrega!");
                        break;

                    default:
                        break;
                }

                if (Permitir)
                {
                    frmEntregaGestion frm = new frmEntregaGestion(UsuarioLogeado, row.id, IdBodega);
                    frm.ShowDialog();
                }    
            }
        }

        private void cmdImprimir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridview = (GridView)gridControl1.FocusedView;
            var row = (dsEntregaPedidos.list_entregasRow)gridview.GetFocusedDataRow();



            xrptEntrega rpt = new xrptEntrega(row.id, IdBodega, UsuarioLogeado);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            if (rpt.Conteo > 0)
            {
                printTool.Print();
            }
            else {
                CajaDialogo.Error("No se a entregado ningun item");
                return;
            }
                
        }
    }
}