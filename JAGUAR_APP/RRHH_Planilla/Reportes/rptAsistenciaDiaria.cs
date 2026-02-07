using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_PRO.RRHH_Planilla.Reportes
{
    public partial class rptAsistenciaDiaria : DevExpress.XtraReports.UI.XtraReport
    {
        public rptAsistenciaDiaria(DateTime fecha)
        {
            InitializeComponent();

            xrFecha.Value = fecha;
        }

    }
}
