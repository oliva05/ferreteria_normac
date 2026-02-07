using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    public partial class rptAsistenciaDiaria : DevExpress.XtraReports.UI.XtraReport
    {
        PDV PuntoVentaActual;
        public rptAsistenciaDiaria(DateTime fecha, PDV pDV)
        {
            InitializeComponent();

            xrFecha.Text = "Fecha: " + fecha.ToString("dd/MM/yyyy");
            PuntoVentaActual = pDV;
            
            
            lblCompanyName.Text = PuntoVentaActual.Nombre;
            lblLegalName.Text = PuntoVentaActual.NombreLegal;
            
        }

    }
}
