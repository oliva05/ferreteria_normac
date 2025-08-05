using ACS.Classes;
using DevExpress.XtraEditors;
using JAGUAR_PRO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Facturacion.CoreFacturas
{
    public partial class frmEditarFactura : DevExpress.XtraEditors.XtraForm
    {
        Factura FacturaActual;
        FacturaEstado EstadoFacturaActual;
        int IdEstadoActual;
        int IdEstadoNuevo;

        public frmEditarFactura(long pIdFacturaH)
        {
            InitializeComponent();
            FacturaActual = new Factura();
            if (FacturaActual.RecuperarRegistro(pIdFacturaH))
            {
                txtDireccion.Text = FacturaActual.direccion_cliente;
                txtNombreCliente.Text = FacturaActual.ClienteNombre;
                txtRTN.Text = FacturaActual.RTN;
                IdEstadoActual = FacturaActual.IdEstado;
                EstadoFacturaActual = new FacturaEstado();
                LoadDetalleRecibos(FacturaActual.NumeroDocumento);

                if (EstadoFacturaActual.RecuperarRegistro(FacturaActual.IdEstado))
                {
                    lblEstadoActual.Text = EstadoFacturaActual.Descripcion;
                }

                switch (IdEstadoActual)
                {
                    //case 1://Emitida
                        
                    //    break;
                    case 2://Pagada
                        dsMantoFacturas.estados_facturaRow row1 = dsMantoFacturas1.estados_factura.Newestados_facturaRow();
                        row1.id = 3;
                        row1.descripcion = "Anulada";
                        row1.seleccionar = false;
                        dsMantoFacturas1.estados_factura.Addestados_facturaRow(row1);
                        dsMantoFacturas1.AcceptChanges();
                        break;
                    case 3://Anulada
                        dsMantoFacturas.estados_facturaRow row3 = dsMantoFacturas1.estados_factura.Newestados_facturaRow();
                        row3.id = 2;
                        row3.descripcion = "Pagada";
                        row3.seleccionar = false;
                        dsMantoFacturas1.estados_factura.Addestados_facturaRow(row3);
                        dsMantoFacturas1.AcceptChanges();
                        break;
                }
            }
        }

        public void LoadDetalleRecibos(string pNumeroFactura)
        {
            //sp_get_detalle_pagos_de_Factura_H
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_detalle_pagos_de_Factura_H]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doc_num", pNumeroFactura);
                //cmd.Parameters.AddWithValue("@desde", dtDesde.EditValue);
                //cmd.Parameters.AddWithValue("@hasta", dtHasta.EditValue);

                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsMantoFacturas1.recibos_por_factura.Clear();
                adat.Fill(dsMantoFacturas1.recibos_por_factura);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}