//using GriauleFingerprintLibrary;
using ACS.Classes;
using GriauleFingerprintLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace core.Clases.Huellas
{
    public partial class LectorHuellasv2 : Form
    {

        FingerprintCore fingerprint = new FingerprintCore();
        public GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawimage;
        public GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;


        public LectorHuellasv2()
        {
            InitializeComponent(); 
            //fingerprint = new FingerprintCore();
            //fingerprint.onStatus += new StatusEventHandler(Fingerprint_onStatus);
            //fingerprint.onImage += new ImageEventHandler(FingerPrint_onImage);
        }

        //void FingerPrint_onImage(object sender, GriauleFingerprintLibrary.Events.ImageEventArgs se)
        //{
           
        //    rawimage = se.RawImage;
        //    SetImage(se.RawImage.Image);
        //    ExtractTemplate();

        //    if (Convert.ToDouble(pbQuality.Value) > 60)
        //    {
                
        //        cmdGuardar_Click(new object(), new EventArgs());
        //    }
        //    else
        //       CajaDialogo.CajaDialogo.Error("Huella muy debil");
           
        //}

        //void ExtractTemplate()
        //{
        //    if (rawimage != null)
        //    {
        //        try
        //        {
        //            _template = null;
        //            fingerprint.Extract(rawimage, ref _template);
        //            SetQualityBar(_template.Quality);
        //            DisplayImage(_template, false);

        //        }
        //        catch
        //        {
        //            SetQualityBar(-1);
        //        }
        //    }
        //}

        //private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate ptemplate, bool p)
        //{
        //    IntPtr hdc_ = FingerprintCore.GetDC();
        //    IntPtr image = new IntPtr();
        //    if (p)
        //    {
        //        fingerprint.GetBiometricDisplay(ptemplate,rawimage, hdc_, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
        //    }
        //    else
        //    {
        //        fingerprint.GetBiometricDisplay(ptemplate,rawimage,hdc_,ref image, FingerprintConstants.GR_NO_CONTEXT);
        //    }
        //    SetImage(Bitmap.FromHbitmap(image));
        //    FingerprintCore.ReleaseDC(hdc_);

           
        //}

        private delegate void delSetImage(Image img);
        void SetImage(Image img)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delSetImage(SetImage), new object[] { img });
            }
            else
            {
                //Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                //pictureBox1.Image = bmp;
            }
        }


        //void Fingerprint_onStatus(object sender,  GriauleFingerprintLibrary.Events.StatusEventArgs se)
        //{
        //  try
        //    {              
        //            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
        //            {
        //                fingerprint.StartCapture(sender.ToString());
        //                return;
        //            }
        //            else
        //            {
        //                CajaDialogo.CajaDialogo.Error("SENSOR NO DETECTADO, FAVOR VERIFICAR");                        
        //                fingerprint.StopCapture(sender);
        //                cmdCancelar_Click(new object(), new EventArgs());
        //            }
                
        //    }
        //    catch(Exception ERROR)
        //    {
        //        CajaDialogo.CajaDialogo.Error(ERROR.Message);
        //    }
        //}

        delegate void delsetQualityBar(int quality);
        void SetQualityBar(int quality)
        {
            //if (pbQuality.InvokeRequired == true)
            //{
            //    this.Invoke(new delsetQualityBar(SetQualityBar), new object[] { quality });
            //}
            //else
            //{
            //    switch (quality)
            //    {
            //        case 0:
            //            {
            //                pbQuality.Value = pbQuality.Maximum / 3;
            //            }
            //            break;

            //        case 1:
            //            {
            //                pbQuality.Value = (pbQuality.Maximum / 3) * 2;
            //            } break;

            //        case 2:
            //            {
            //                pbQuality.Value = pbQuality.Maximum;
            //            } break;

            //        default:
            //            {
            //                pbQuality.Value = 0;
            //            } break;
            //    }
            //}
        }
     
        private void LectorHuellasv2_Load(object sender, EventArgs e)
        {
            //fingerprint.Initialize();
            //fingerprint.CaptureInitialize();
                       
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                //fingerprint.CaptureFinalize();
                //fingerprint.Finalizer();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
            catch
            {

            }


        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            //if (_template != null)
            //{

            //if (pbQuality.Value > 60)
            //{
            //    Thread tr = new Thread(Procesando);
            //    tr.Start();
            //    //fingerprint.CaptureFinalize();
            //    //fingerprint.Finalizer();

            //    this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //}
            //else
            //CajaDialogo.Error("Huella Digital de mala calidad, ingresela nuevamente" );
          

        }

        static void Procesando()
        {
            int TiempoP = 3000;
            administracion.Huellas.frmProcesando frmProceso = new administracion.Huellas.frmProcesando();
            
            frmProceso.ShowDialog();
            Thread.Sleep(TiempoP);
            frmProceso.Close();
        }

        int ConteoEvento = 0;
        private void cmdCancelar_KeyDown(object sender, KeyEventArgs e)
        {
            //ConteoEvento++;
            //if (ConteoEvento > 1)
            //{
                Thread tr = new Thread(Procesando);
                tr.Start();
                aceptarAutomatic(e.KeyCode);
                ConteoEvento = 0;
            //}
        }

        void aceptarAutomatic(Keys pkey)
        {
            if (pkey == Keys.F12 || pkey == Keys.Left)
                cmdGuardar_Click(new object(), new EventArgs());

            if (pkey == Keys.Escape)
                cmdCancelar_Click(new object(), new EventArgs());
        }

        private void LectorHuellasv2_Activated(object sender, EventArgs e)
        {
            cmdGuardar.Focus();
        }

        private void pbQuality_ValueChanged(object sender, EventArgs e)
        {
            Thread.Sleep(1);

            
        }

        private void LectorHuellasv2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {


                //fingerprint.Initialize();
                //fingerprint.CaptureInitialize();

                //fingerprint.Finalizer();
                //fingerprint.CaptureFinalize();
            }
            catch
            { 
            }
        }

       
      

        
    }
}
