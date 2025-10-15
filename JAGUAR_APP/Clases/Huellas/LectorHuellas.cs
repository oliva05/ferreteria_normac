using GriauleFingerprintLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace core.Clases.Huellas
{
    public partial class LectorHuellas : Form
    {
        
        FingerprintCore fingerprint = new FingerprintCore();
        GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawimage;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;


        public LectorHuellas()
        {
            InitializeComponent();
            fingerprint = new FingerprintCore();
            fingerprint.onStatus += new StatusEventHandler(Fingerprint_onStatus);
            fingerprint.onImage += new ImageEventHandler(FingerPrint_onImage);
        }

        void FingerPrint_onImage(object sender, GriauleFingerprintLibrary.Events.ImageEventArgs se)
        {
            rawimage = se.RawImage;
            SetImage(se.RawImage.Image);
            ExtractTemplate();
        }

        void ExtractTemplate()
        {
            if (rawimage != null)
            {
                try
                {
                    _template = null;
                    fingerprint.Extract(rawimage, ref _template);

                    DisplayImage(_template, false);

                }
                catch
                {

                }
            }
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate ptemplate, bool p)
        {
            IntPtr hdc_ = FingerprintCore.GetDC();
            IntPtr image = new IntPtr();
            if (p)
            {
                fingerprint.GetBiometricDisplay(ptemplate,rawimage, hdc_, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else
            {
                fingerprint.GetBiometricDisplay(ptemplate,rawimage,hdc_,ref image, FingerprintConstants.GR_NO_CONTEXT);
            }
            SetImage(Bitmap.FromHbitmap(image));
            FingerprintCore.ReleaseDC(hdc_);
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


        void Fingerprint_onStatus(object sender, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                fingerprint.StartCapture(sender.ToString());
            }
            else
            {
                fingerprint.StopCapture(sender);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fingerprint.Initialize();
            fingerprint.CaptureInitialize();
        }

        private void LectorHuellas_Load(object sender, EventArgs e)
        {
            fingerprint.Initialize();
            fingerprint.CaptureInitialize();
        }
    }
}
