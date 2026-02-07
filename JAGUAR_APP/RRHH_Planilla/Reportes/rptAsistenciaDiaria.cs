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

            xrFecha.Value = fecha;
            PuntoVentaActual = pDV;
            
            
            lblCompanyName.Text = PuntoVentaActual.Nombre;
            lblLegalName.Text = PuntoVentaActual.NombreLegal;
            
        }

    }
}
