//using GriauleFingerprintLibrary;
using ACS.Classes;
using core.Clases.Huellas;
using GriauleFingerprintLibrary;
using JAGUAR_PRO.Huellas;
using NormacApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        FingerprintCore fingerPrint = new FingerprintCore();
        private GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage_Huella;
        public GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;
        public int CalidadHuellaInt;
        public frm_addHuella()
        {
            InitializeComponent();
            fingerPrint = new GriauleFingerprintLibrary.FingerprintCore();
            fingerPrint.onStatus += new StatusEventHandler(fingerPrint_onStatus);
            fingerPrint.onImage += new ImageEventHandler(fingerPrint_onImage);

        }

        //void Fingerprint_onStatus(object sender, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        //{
        //try
        //{
        //    if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
        //    {
        //        fingerprint.StartCapture(sender.ToString());
        //        return;
        //    }
        //    else
        //    {
        //        CajaDialogo.Error("SENSOR NO DETECTADO, FAVOR VERIFICAR");
        //        //fingerprint.StopCapture(sender);
        //        //fingerprint.CaptureFinalize();
        //        //fingerprint.Finalizer();
        //        cmdCancelar_Click(new object(), new EventArgs());
        //    }
        //}
        //catch (Exception ERROR)
        //{
        //    CajaDialogo.Error(ERROR.Message);
        //}
        //}
        void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                fingerPrint.StartCapture(source.ToString());
            }
            else
            {
                //Comentario por Danys el 19 nov 2025
                //fingerPrint.StopCapture(source);
            }
        }

        void fingerPrint_Onstatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                //core.StartCapture(source);
                fingerPrint.StartCapture(source);
                return;
            }
            else
            {
                CajaDialogo.Error("SENSOR NO DETECTADO, FAVOR VERIFICAR");
                fingerPrint.StopCapture(source);
                //cmdCancelar_Click(new object(), new EventArgs());
            }
        }


        //void FingerPrint_onImage(object sender, GriauleFingerprintLibrary.Events.ImageEventArgs se)
        //{

        //    rawimage = se.RawImage;
        //    SetImage(se.RawImage.Image);
        //    //ExtractTemplate();

        //    //if (rawimage != null)
        //    //{
        //    //    if (Convert.ToDouble(pbQuality.Position) > 60)
        //    //    {
        //    //        cmdGuardar_Click(new object(), new EventArgs());
        //    //    }
        //    //    else
        //    //        CajaDialogo.Error("Huella muy debil");

        //    //}
        //    bool Guardo = false;
        //    if (rawimage != null)
        //    {
        //        //try
        //        //{
        //        //    CheckForIllegalCrossThreadCalls = false;
        //        //    fingerprint = new GriauleFingerprintLibrary.FingerprintCore();
        //        //    fingerprint.Initialize();
        //        //    fingerprint.CaptureInitialize();



        //        //    fingerprint.onStatus += new GriauleFingerprintLibrary.StatusEventHandler(Fingerprint_onStatus);
        //        //    fingerprint.onImage += new GriauleFingerprintLibrary.ImageEventHandler(FingerPrint_onImage);
        //        //}
        //        //catch { }

        //        try
        //        {
        //            _template = null;

        //            fingerprint.Extract(rawimage, ref _template);
        //            SetQualityBar(_template.Quality);
        //            DisplayImage(_template, false);
        //            Thread.Sleep(600);

        //            if (Convert.ToDouble(pbQuality.Position) > 60)
        //            {
        //                Guardo = true;
        //                cmdGuardar_Click(new object(), new EventArgs());
        //            }
        //        }
        //        catch
        //        {
        //        }
        //    }

        //    if (!Guardo)
        //        FingerPrint_onImage(sender, se);

        void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            rawImage_Huella = ie.RawImage;
            SetImage(ie.RawImage.Image);
            if (rawImage_Huella != null)
            {
                try
                {
                    _template = null;
                    fingerPrint.Extract(rawImage_Huella, ref _template);
                    SetQualityBar(_template.Quality);
                    DisplayImage(_template, false);
                }
                catch
                {

                }
            }

            fingerPrint_OnImage(source, ie);
        }

        void fingerPrint_OnImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            try
            {
                rawImage_Huella = ie.RawImage;
                //_template = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();
                fingerPrint.Extract(rawImage_Huella, ref _template);
                byte[] dataTemp;
                GriauleFingerprintLibrary.DataTypes.FingerprintTemplate templateTemp;
                int precision, calidad;


                fingerPrint.IdentifyPrepare(_template);


                //foreach (dsHuellasManto.HuellasAll_employeesRow huella in dsHuellasManto1.HuellasAll_employees.Rows)
                //{

                //    dataTemp = (byte[])huella.huella;
                //    calidad = 50;
                //    templateTemp = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();
                //    templateTemp.Buffer = dataTemp;
                //    templateTemp.Size = dataTemp.Length;
                //    templateTemp.Quality = calidad;

                //    precision = 1;

                //    int result = fingerPrint.Identify(templateTemp, out precision);
                //    //int result = 1;
                //    //WriteLog("kj");
                //    if (result == 1)
                //    {
                //        hr_employee ess = new hr_employee();
                //        if (ess.GetById(huella.id_empleado))
                //        {
                //            EmpleadoIdentificado = ess;
                //            DateTime FechaActual = dp.Now();
                //            //CajaDialogo.Information("Cantarito: " + ess.Name);
                //            //lblNombre.Text = ess.Nombres + " " + ess.Apellidos;
                //            //lblAsistencia.Visible = lblNombre.Visible = true;


                //            //MessageBox.Show("Huella encontrada con exito!");
                //            //SendKeys.Send("{ENTER}");
                //            //Onhr_employeeEncontrado(source, new EventArgs());

                //            //Thread tr = new Thread(Procesando);
                //            //tr.Start();
                //            if (MarcarAsistencia(EmpleadoIdentificado.Id, FechaActual))
                //            {
                //                lbl_MensajeAsistencia.Text = "Marca realizada con exito!";
                //                lbl_MensajeAsistencia.BackColor = Color.Transparent;
                //                lbl_MensajeAsistencia.ForeColor = Color.Blue;
                //                lblHoraMarcada.Visible = true;
                //                lblHoraMarcada.ForeColor = Color.DodgerBlue;
                //                lblHoraMarcada.BackColor = Color.Transparent;
                //                //lblHoraMarcada.Text = string.Format("{0:dd/MM/yyyy HH:mm}", FechaActual);
                //                lblHoraMarcada.Text = FechaActual.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                //                this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0}", ess.Name) });
                //                lblHoraMarcada.Text = string.Format("{0:dd/MM/yyyy HH:mm}", FechaActual);
                //            }
                //            else
                //            {
                //                //lbl_MensajeAsistencia.Text = "No se pudo realizar el marcaje!";
                //                lbl_MensajeAsistencia.BackColor = Color.LightPink;
                //                lbl_MensajeAsistencia.ForeColor = Color.Black;
                //                lblHoraMarcada.Visible = false;
                //                lblHoraMarcada.Text = "";
                //                this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0}", ess.Name) });
                //            }
                //            //this.Invoke(new CleanData(CleanAll), new object[] { });

                //            return;
                //        }
                //        break;
                //    }//end if
                //}
            }
            catch (Exception ex)
            {
                //statusStrip1.Text = ex.Message;
                MessageBox.Show(ex.Message);
                //this.Invoke(new SetName(SetNameError), new object[] { String.Format("{0}", ex.Message) });
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
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                fingerPrint.Initialize();
                fingerPrint.CaptureInitialize();

                fingerPrint = new GriauleFingerprintLibrary.FingerprintCore();

                fingerPrint.onStatus += new GriauleFingerprintLibrary.StatusEventHandler(fingerPrint_Onstatus);
                fingerPrint.onImage += new GriauleFingerprintLibrary.ImageEventHandler(fingerPrint_OnImage);
            }
            catch { }
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
            if (rawImage_Huella != null)
            {
                try
                {
                    _template = null;
                    fingerPrint.Extract(rawImage_Huella, ref _template);
                    SetQualityBar(_template.Quality);
                    CalidadHuellaInt = _template.Quality;
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
                fingerPrint.GetBiometricDisplay(ptemplate, rawImage_Huella, hdc_, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else
            {
                fingerPrint.GetBiometricDisplay(ptemplate, rawImage_Huella, hdc_, ref image, FingerprintConstants.GR_NO_CONTEXT);
            }
            SetImage(Bitmap.FromHbitmap(image));
            FingerprintCore.ReleaseDC(hdc_);
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

                //CheckForIllegalCrossThreadCalls = false;
                ////fingerprint.StopCapture(sender);
                //fingerPrint.CaptureFinalize();
                ////fingerprint.StopCapture(sender);
                ////fingerprint.DestroyContext(1);
                //fingerPrint.Finalizer();
                //fingerPrint = null;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
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
                //CheckForIllegalCrossThreadCalls = false;
                //fingerprint.Initialize();
                //fingerprint.CaptureInitialize();

                //fingerprint.CaptureFinalize();
                //fingerprint.Finalizer();
                CheckForIllegalCrossThreadCalls = false;
                //fingerprint.StopCapture(sender);
                fingerPrint.CaptureFinalize();
                fingerPrint.Finalizer();
                fingerPrint = null;
            }
            catch
            {
            }
        }

        private void frm_addHuella_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                //fingerPrint.StopCapture(sender);
                fingerPrint.CaptureFinalize();
                fingerPrint.Finalizer();

            }
            catch { }

        }
    }
}
