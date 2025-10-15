using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using core.Clases;
using core.Clases.Huellas;
using System.Data.SqlClient;
using NormacApp.Models;
using JAGUAR_PRO.Clases;
using ACS.Classes;
using GrFingerXLib;

namespace Proyecto.Huellas
{
    public partial class frmControlAsistencias : Form
    {
        public const int ERR_INVALID_TEMPLATE = -997;
        AxGrFingerXLib.AxGrFingerXCtrl _grfingerx;
        private TTemplate _tpt;
        Util myUtil;

        SqlConnection PsConnetion;
        hr_employee vEmpleado;
        public frmControlAsistencias(SqlConnection pConnection, UserLogin pUser)
        {
            InitializeComponent();

            
            PsConnetion = pConnection;

            fingerPrint = new FingerprintCore();
            fingerPrint.onStatus += new StatusEventHandler(fingerPrint_onStatus);
            fingerPrint.onImage += new ImageEventHandler(fingerPrint_onImage);

        }

        FingerprintCore fingerPrint;
        GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;

        public void InicializarEscanerHuellaDigital()
        {
            //Create a new Template
            //if (_tpt == null)
            //    _tpt = new TTemplate();
            //_grfingerx.CapInitialize();
            //int ret = _grfingerx.StartEnroll((int)GRConstants.GR_DEFAULT_CONTEXT);
            int err;

            // initialize util class
            myUtil = new Util();

            // Initialize the GrFingerX Library
            err = myUtil.InitializeGrFinger(axGrFingerXCtrl1);
            // print the result in the log
            if (err < 0)
            {
                myUtil.WriteError((GRConstants)err);
                MessageBox.Show("Ocurrio un error al activar el scanner." + (GRConstants)err);
            }
            else
            {
                myUtil.WriteLog("**Lector de Huella Inicializado Satisfactoriamente**");
            }
        }

        void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                InicializarEscanerHuellaDigital();
                fingerPrint.StartCapture(source.ToString());
            }
            else
            {
                fingerPrint.StopCapture(source);
            }
        }

        private void axGrFingerXCtrl1_SensorPlug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorPlugEvent e)
        {
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Evento: Enchufado.");
            axGrFingerXCtrl1.CapStartCapture(e.idSensor);
        }

        private void axGrFingerXCtrl1_FingerUp(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerUpEvent e)
        {
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Evento: Dedo removido.");
        }

        private void axGrFingerXCtrl1_FingerDown(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_FingerDownEvent e)
        {
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Evento: Dedo colocado.");
        }

        private void axGrFingerXCtrl1_SensorUnplug(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_SensorUnplugEvent e)
        {
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Event: Desenchufado.");
            axGrFingerXCtrl1.CapStopCapture(e.idSensor);
        }
        private void axGrFingerXCtrl1_ImageAcquired(object sender, AxGrFingerXLib._IGrFingerXCtrlEvents_ImageAcquiredEvent e)
        {
            // Copying aquired image
            myUtil._raw.img = e.rawImage;
            myUtil._raw.height = (int)e.height;
            myUtil._raw.width = (int)e.width;
            myUtil._raw.Res = e.res;

            // Signaling that an Image Event occurred.
            myUtil.WriteLog("Sensor: " + e.idSensor + ". Evento: Imagen capturada.");
            try
            {
                // display fingerprint image
                myUtil.PrintBiometricDisplay(false, GRConstants.GR_DEFAULT_CONTEXT);
            }
            catch (Exception ex)
            {
                myUtil.WriteLog(ex.Message);
            }
            // now we have a fingerprint, so we can extract the template
            if (!myUtil._isEnrolling)
            {
                //btnExtract.Enabled = true;
                //btIdentify.Enabled = false;
                //btVerify.Enabled = false;

                //// extracting template from the image
                //if (cbAutoExtract.Checked)
                //{
                //    btnExtract_Click(sender, EventArgs.Empty);
                //}
                //// identify fingerprint
                //if (cbAutoIdentify.Checked)
                //{
                //    btIdentify_Click(sender, EventArgs.Empty);
                //}

            }
            else // the enrollment is started
            {
                int ret = myUtil.Consolidate();
                if (ret < 0)
                    myUtil.WriteError((GRConstants)ret);
                else
                {
                    //display minutiae/segments/directions of the current image
                    //btnExtract.Enabled = true;
                    //btnExtract.PerformClick();
                    //btnExtract.Enabled = false;

                    bool saveConsolidatedTemplate = false;
                    switch ((GRConstants)ret)
                    {
                        case GRConstants.GR_ENROLL_NOT_READY:
                            myUtil._numberOfConsolidated++;
                            myUtil.WriteLog("El sistema de inscripción no esta listo");
                            myUtil.WriteLog("Coloque el dedo nuevamente.");
                            break;
                        case GRConstants.GR_ENROLL_SUFFICIENT:
                            myUtil._numberOfConsolidated++;
                            myUtil.WriteLog("Suficiente inscripción");
                            //if we consolidated at least 8 templates and did not reach GR_ENROLL_GOOD, 
                            //we stop consolidation and save the current consolidated template
                            if (myUtil._numberOfConsolidated > 7)
                                saveConsolidatedTemplate = true;
                            else
                                myUtil.WriteLog("Coloque el dedo nuevamente.");
                            break;
                        case GRConstants.GR_ENROLL_GOOD:
                            myUtil._numberOfConsolidated++;
                            saveConsolidatedTemplate = true;
                            myUtil.WriteLog("Buena inscripción.");
                            break;
                        case GRConstants.GR_ENROLL_VERY_GOOD:
                            myUtil._numberOfConsolidated++;
                            saveConsolidatedTemplate = true;
                            myUtil.WriteLog("Muy buena inscripción.");
                            break;
                        case GRConstants.GR_ENROLL_MAX_LIMIT_REACHED:
                            // no more templates can be consolidated
                            // save the current consolidated template
                            saveConsolidatedTemplate = true;
                            break;
                    }
                    if (saveConsolidatedTemplate)
                    {
                        int id;

                        // add fingerprint
                        id = myUtil.Enroll();
                        // write the result to the log
                        if (id >= 0)
                        {
                            this.myUtil._DB.getTemplates();

                            myUtil.WriteLog("Plantilla consolidada fue registrada con el Código #" + id);
                            MessageBox.Show("¡Huella Registrada Satisfactoriamente!", "ALLAS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Empleado empleado_ = new Empleado(psConnection);
                            //empleado_.CargarDatosEmpleado(this.empleado.Codigoempleado);
                        }
                        else
                        {
                            myUtil.WriteLog("Error: Plantilla consolidada no pudo ser registrada");
                        }
                        //btEnroll.PerformClick(); //stop consolidation
                    }
                }
            }
        }

        int Identify(ref int score)
        {
            
            GRConstants result;
            int id;
            TTemplate tptRef;

            // Checking if template is valid.
            if (!TemplateIsValid()) return ERR_INVALID_TEMPLATE;
            // Starting identification process and supplying query template.
            result = (GRConstants)_grfingerx.IdentifyPrepare(ref _tpt._tpt,
                (int)GRConstants.GR_DEFAULT_CONTEXT);
            // error?
            if (result < 0) return (int)result;
            // Getting enrolled templates from database.	

            ///Traer todas las huellas para realizar la comparacion
            DBClass dll = new DBClass();

            dsDetalleHuellas dsDetalleHuellas = new dsDetalleHuellas();
            //dsDetalleHuellas = dll.getTemplates2();
            

            foreach (dsDetalleHuellas.HuellasRow huella in dsDetalleHuellas.Huellas.Rows)
            {
                // Getting current template from recordset.
                //tptRef = dll.getTemplate(huella);

                // Comparing current template.
                //result = (GRConstants)_grfingerx.Identify(ref tptRef._tpt, ref score, (int)GRConstants.GR_DEFAULT_CONTEXT);

                // Checking if query template and the reference template match.
                if (result == GRConstants.GR_MATCH)
                {
                    //id = _DB.getId(rs);
                    id = huella.id_huella;

                    //rs.Close();
                    return id;
                }
                else if (result < 0)
                {
                    ///rs.Close();
                    //return (int)result;
                }
            }

            return (int)GRConstants.GR_NOT_MATCH;
        }

        bool Identify(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate testTemplate, out int score)
        {
            return fingerPrint.Identify(testTemplate, out score) == 1 ? true : false;
        }


        private bool TemplateIsValid()
        {
            if (_tpt == null)
            {
                _tpt = new TTemplate();
            }

            // Check the template size and data
            return ((_tpt._size > 0) && (_tpt._tpt != null));
        }



        void USERID(string nombre)
        {
            //lblNombre.Visible = true;
            // lblNombre.Text = nombre;
        }

        void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify)
        {
            IntPtr hdc = FingerprintCore.GetDC();

            IntPtr image = new IntPtr();

            if (identify)
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
            }

            SetImage(Bitmap.FromHbitmap(image));

            FingerprintCore.ReleaseDC(hdc);

           

          }

        private delegate void delSetImage(Image img);
        private delegate void xEmpleado(hr_employee es);

        void RecuperaEstudiante(hr_employee pestudiante)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new xEmpleado(RecuperaEstudiante), vEmpleado);
            }
            else
            {
                vEmpleado = pestudiante;
                if (vEmpleado.Recuperado)
                {
                    //lblNombre.Text = vEmpleado.Name;// + " " + vEmpleado.Apellidos;
                    //lblNombre.Appearance.BackColor = Color.LightGreen;
                    
                }
                else
                {
                    CajaDialogo.Error("El empleado no tiene huellas registradas en el sistema!");
                    //lblNombre.Appearance.BackColor = Color.LightCyan;
                }
            }
        }
        void SetImage(Image img)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delSetImage(SetImage), new object[] { img });
            }
            else
            {
                //Bitmap bmp = new Bitmap(img, pbHuella.Width,pbHuella.Height);
                //pbHuella.Image = bmp;
            }

           
        }

        void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            rawImage = ie.RawImage;
            SetImage(ie.RawImage.Image);
            button1_Click(source, new EventArgs());
            ExtractTemplate();

            // Identify();
        }

         void ExtractTemplate()
        {
            if (rawImage != null)
            {
                try
                {
                    _template = null;
                    fingerPrint.Extract(rawImage, ref _template);

                   SetQualityBar(_template.Quality);
                    DisplayImage(_template, false);
                    
                }
                catch
                {
                   // SetQualityBar(-1);
                }
            }
            
        }

         private void frmControlAsistencias_Load(object sender, EventArgs e)
         {
             fingerPrint.Initialize();
             fingerPrint.CaptureInitialize();
             //lblfecha.Text = DateTime.Now.ToLongDateString();
             button1_Click_1(sender, e);
         }

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
             //                //pbQuality.Value = pbQuality.Maximum / 3;
             //            }
             //            break;

             //        case 1:
             //            {
             //                //pbQuality.Value = (pbQuality.Maximum / 3) * 2;
             //            } break;

             //        case 2:
             //            {
             //                //pbQuality.Value = pbQuality.Maximum;
             //            } break;

             //        default:
             //            {
             //                //pbQuality.Value = 0;
             //            } break;
             //    }
             //}
         }

         private void frmControlAsistencias_FormClosing(object sender, FormClosingEventArgs e)
         {
             try
             {
                 fingerPrint.CaptureFinalize();
                 fingerPrint.Finalizer();
             }
             catch
             {

             }
         }

         private void button1_Click(object sender, EventArgs e)
         {
             int ret, score;

             score = 0;
             Identify(ref score);
         }

         private void button1_Click_1(object sender, EventArgs e)
         {
             int ret, score;
             //cAnalizadorHuellasDigitales cAnalizador = new cAnalizadorHuellasDigitales();

             score = 0;
             Identify(ref score);
         }

         private void cmbSalir_Click(object sender, EventArgs e)
         {
             this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
             this.Close();
         }

         

    }
}
