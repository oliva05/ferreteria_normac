using DevExpress.XtraReports.UI;
using JAGUAR_PRO.Clases;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace JAGUAR_PRO.LogisticaJaguar
{
    public partial class xrptBarCode : DevExpress.XtraReports.UI.XtraReport
    {
        public xrptBarCode(string pCodePT)
        {
            InitializeComponent();

            xrBarCode.Text = pCodePT;

        }

    }
}
