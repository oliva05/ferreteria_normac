using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using JAGUAR_PRO.Clases.Planilla;

namespace JAGUAR_PRO.RRHH_Planilla.Planilla.Reportes
{
    public partial class rptInformePlanillaGeneral : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInformePlanillaGeneral(int id_payslip_run)
        {
            InitializeComponent();
            LoadPlanillaGeneral(id_payslip_run);

            Payslip_Run payslip_Run = new Payslip_Run();

            payslip_Run.RecuperarRegistro(id_payslip_run);

            lblPayslip.Text = payslip_Run.Name;
            lblFecha.Text = $"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}";
            lblRango.Text = $"Desde: {payslip_Run.DateStart.ToString("dd/MM/yyyy")} Hasta: {payslip_Run.DateEnd.ToString("dd/MM/yyyy")}";

            tcTotalIngreso.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda

            tcSalarioBase.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcOtrosIngresos.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcPagoVacDeven.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcPagoVacac.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcPagoIncapa34.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcPagoIncapa100.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcDiaExtra.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcAFP.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcEmbargo.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcImpuesto.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcBanco.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell50.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda       
            tcPrestamoRap.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcPrestamo.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tc1SeguroMedico.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcIHSS.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcISR.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcTotalEgresos.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcTotalPagar.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda


            //Summay Group
            tcG1.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell60.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG3.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG4.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG5.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell57.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG7.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell65.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell66.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell51.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG12.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG13.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG14.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG17.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG18.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda
            tcG19.TextFormatString = payslip_Run.CurrencySymbol+"{0:N2}"; // Asegura que el formato sea moneda


            //Summay Group
            tcT1.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell71.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell69.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell70.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT3.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT4.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT5.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell26.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT7.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell57.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT9.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT10.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT11.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT12.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT13.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT14.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT15.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            //tcT16.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT17.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            tcT18.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell93.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell52.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell59.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell60.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell67.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell68.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell20.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell21.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell35.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
            xrTableCell37.TextFormatString = payslip_Run.CurrencySymbol + "{0:N2}"; // Asegura que el formato sea moneda
        }

        private void LoadPlanillaGeneral(int payslip_run)
        {
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("dbo.[usp_rpt_PlanillGeneral]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@payslip_run_id", payslip_run);

                dsReporte1.rptPlanillaGeneral.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsReporte1.rptPlanillaGeneral);

                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }
    }
}
