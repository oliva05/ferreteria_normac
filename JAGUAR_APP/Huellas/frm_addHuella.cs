//using GriauleFingerprintLibrary;
using ACS.Classes;
using GriauleFingerprintLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Huellas
{
    public partial class frm_addHuella : Form
    {
        FingerprintCore fingerprint = new FingerprintCore();
        public GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawimage;
        public GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;
        public int CalidadHuellaInt;
        public frm_addHuella()
        {
            InitializeComponent();
            fingerprint = new FingerprintCore();
            fingerprint.onStatus += new StatusEventHandler(Fingerprint_onStatus);
            fingerprint.onImage += new ImageEventHandler(FingerPrint_onImage);
            //fingerprint.StartCapture();
        }

        void Fingerprint_onStatus(object sender, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            try
            {
                if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
                {
                    fingerprint.StartCapture(sender.ToString());
                    return;
                }
                else
                {
                    CajaDialogo.Error("SENSOR NO DETECTADO, FAVOR VERIFICAR");
                    fingerprint.StopCapture(sender);
                    cmdCancelar_Click(new object(), new EventArgs());
                }

            }
            catch (Exception ERROR)
            {
                CajaDialogo.Error(ERROR.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            //ultraPictureBox1.Appearance.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Stretched;
            //this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frm_addHuella_Load(object sender, EventArgs e)
        {
            fingerprint.Initialize();
            fingerprint.CaptureInitialize();
        }

        private delegate void delSetImage(Image img);
        void SetImage(Image img)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delSetImage(SetImage), new object[] { img });
            }
            else
            {
                Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }
        }

        void ExtractTemplate()
        {
            if (rawimage != null)
            {
                try
                {
                    _template = null;
                    fingerprint.Extract(rawimage, ref _template);
                    SetQualityBar(_template.Quality);
                    DisplayImage(_template, false);
                }
                catch
                {
                    SetQualityBar(-1);
                }
            }
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate ptemplate, bool p)
        {
            IntPtr hdc_ = FingerprintCore.GetDC();
            IntPtr image = new IntPtr();
            if (p)
            {
                fingerprint.GetBiometricDisplay(ptemplate, rawimage, hdc_, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else
            {
                fingerprint.GetBiometricDisplay(ptemplate, rawimage, hdc_, ref image, FingerprintConstants.GR_NO_CONTEXT);
            }
            SetImage(Bitmap.FromHbitmap(image));
            FingerprintCore.ReleaseDC(hdc_);
        }

        void FingerPrint_onImage(object sender, GriauleFingerprintLibrary.Events.ImageEventArgs se)
        {

            rawimage = se.RawImage;
            SetImage(se.RawImage.Image);
            ExtractTemplate();

            if (Convert.ToDouble(pbQuality.Position) > 60)
            {
                cmdGuardar_Click(new object(), new EventArgs());
            }
            else
                CajaDialogo.Error("Huella muy debil");

        }

        delegate void delsetQualityBar(int quality);
        void SetQualityBar(int quality)
        {
            if (pbQuality.InvokeRequired == true)
            {
                this.Invoke(new delsetQualityBar(SetQualityBar), new object[] { quality });
            }
            else
            {
                switch (quality)
                {
                    case 0:
                        {
                            pbQuality.Position = pbQuality.Properties.Maximum / 3;
                        }
                        break;

                    case 1:
                        {
                            pbQuality.Position = (pbQuality.Properties.Maximum / 3) * 2;
                        }
                        break;

                    case 2:
                        {
                            pbQuality.Position = pbQuality.Properties.Maximum;
                        }
                        break;

                    default:
                        {
                            pbQuality.Position = 0;
                        }
                        break;
                }
            }

            CalidadHuellaInt = pbQuality.Position;
        }

        static void Procesando()
        {
            //int TiempoP = 100;
            administracion.Huellas.frmProcesando frmProceso = new administracion.Huellas.frmProcesando();

            frmProceso.ShowDialog();
            //Thread.Sleep(TiempoP);
            frmProceso.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (pbQuality.Position > 60)
            {
                CalidadHuellaInt = pbQuality.Position;
                Thread tr = new Thread(Procesando);
                tr.Start();
                fingerprint.CaptureFinalize();
                fingerprint.Finalizer();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                CajaDialogo.Error("Huella Digital de mala calidad, ingresela nuevamente");
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                fingerprint.CaptureFinalize();
                //fingerprint.StopCapture(sender);
                fingerprint.Finalizer();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            catch(Exception ex) 
            {

            }
        }

        private void frm_addHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fingerprint.Initialize();
                fingerprint.CaptureInitialize();

                fingerprint.Finalizer();
                fingerprint.CaptureFinalize();
            }
            catch
            {
            }
        }
    }
}
