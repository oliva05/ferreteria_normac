using ACS.Classes;
using DevExpress.Xpo;
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

namespace JAGUAR_PRO.Facturacion.Entrega
{
    public partial class fmrEntregaVerDetalle : DevExpress.XtraEditors.XtraForm
    {
        UserLogin UsuarioLogueado;
        DataOperations dp;
        int IdBodega;
        int IdHeader;
        public fmrEntregaVerDetalle(int idh, UserLogin userLogin, int idBodega)
        {
            InitializeComponent();

            IdBodega = idBodega;
            UsuarioLogueado = userLogin;
            IdHeader = idh;
            LoadData();

            if (IdBodega == 3)
            {
                gridView1.Columns["entrega"].Visible = true;
        
            }
            else
            {
                gridView1.Columns["entrega"].Visible = false;
            
            }
        }

        private void LoadData()
        {
            try
            {
                dp = new DataOperations();
                //string query = @"sp_get_detalle_pedidos";
                string query = @"[dbo].[sp_get_detalle_pedidosV2]";
                SqlConnection conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdHeader", IdHeader);
                cmd.Parameters.AddWithValue("@IdBodega", IdBodega);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsEntregaPedidos1.detalle_entrega.Clear();
                adat.Fill(dsEntregaPedidos1.detalle_entrega);
 

                SqlCommand cmd2 = new SqlCommand("sp_get_detalle_pedidos_completo", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@IdHeader", IdHeader);
                SqlDataAdapter adat2 = new SqlDataAdapter(cmd2);
                dsEntregaPedidos1.detalle_entrega_completo.Clear();
                adat2.Fill(dsEntregaPedidos1.detalle_entrega_completo);
                conn.Close();

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}