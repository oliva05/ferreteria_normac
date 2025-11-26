using ACS.Classes;
using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases.Colaborador;
using JAGUAR_PRO.Clases.Planilla;
//using LOSA.Logistica;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace JAGUAR_PRO.RRHH_Planilla.Planilla.Reportes
{
    public partial class rptVoucherHE : DevExpress.XtraReports.UI.XtraReport
    {
        int slipId = 0;

        public rptVoucherHE(string descripcion_payslip,int employee_id, int pSlipId)
        {
            InitializeComponent();
            HrEmployee empleadoActual = new HrEmployee();
            Payslip_Run payslip_Run = new Payslip_Run();

            slipId = pSlipId;
            string salary_rule_name;
            decimal monto = 0;

            

            empleadoActual.RecuperarDatosPorId(employee_id);
            payslip_Run.RecuperarRegistroBySlipId(pSlipId);

            lblPlanilla.Text = descripcion_payslip;
            lblIFechaImpresion.Text = "Impreso el: " + DateTime.Now.ToString("dd/MM/yyyy");

            rtColaborador.Html = "<font face='Segoe UI' size='2'>"
                +$"<b>Colaborador:</b> {empleadoActual.Name}";

            rtCodigo.Html = "<font face='Segoe UI' size='2'>"
               + $"<b>Código:</b> {empleadoActual.Barcode}";

            rtCargo.Html = "<font face='Segoe UI' size='2'>"
               + $"<b>Cargo:</b> {empleadoActual.Puesto}";

            rtDepartamento.Html = "<font face='Segoe UI' size='2'>"
               + $"<b>Departamento:</b> {empleadoActual.DepartmentTitle}";

            rtTurno.Html = "<font face='Segoe UI' size='2'>"
               + $"<b>Turno:</b> {empleadoActual.Turno}";

            rtFechaPago.Html = "<font face='Segoe UI' size='2'>"
              + $"<b>Departamento:</b> {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";

            string filtro = string.Empty;
            switch (payslip_Run.PayrollTypeId)
            {
                case 3://Planilla Horas Extras
                    LoadDetalleNominasHE(slipId);
                    // Definir la condición de búsqueda
                    filtro = "salary_rule_name = 'Total Horas Extra'";
                    break;

                case 11://Planilla de Comisiones
                    LoadDetalleNominasComisiones(slipId);
                    // Definir la condición de búsqueda
                    filtro = "salary_rule_name = 'Total Comisiones'";
                    break;

                default:
                    break;
            }

           

            

            // Buscar filas que coincidan con la condición
            DataRow[] filasAEliminar = dsReporte1.rpt_voucher_detail_HE.Select(filtro);

            xrTCRegla.Text= filasAEliminar[0].ItemArray[3].ToString();
            xrTCMonto.Text= filasAEliminar[0].ItemArray[7].ToString();
            xrTCCantidad.Text= filasAEliminar[0].ItemArray[8].ToString();
        
            // Eliminar cada fila encontrada
            foreach (DataRow fila in filasAEliminar)
            {

                dsReporte1.rpt_voucher_detail_HE.Rows.Remove(fila);
            }

            

        }

        private void LoadDetalleNominasComisiones(int SlipId)
        {
            //
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[rptPlanillasEmpleadosLineas_Detalle_Comisiones]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", SlipId);

                dsReporte1.rpt_voucher_detail_HE.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rpt_voucher_detail_HE);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadDetalleNominasHE(int SlipId)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[rptPlanillasEmpleadosLineas_Detalle_HE]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@slip_id", SlipId);

                dsReporte1.rpt_voucher_detail_HE .Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rpt_voucher_detail_HE);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

         
    }
}
