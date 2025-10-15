using core.Clases;
using core.Clases.Huellas;
using NormacApp.Models;

//using GrFingerXLib;
//using GriauleFingerprintLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administracion.Huellas
{
    public partial class frmIdentificar : Form
    {
        //FingerprintCore fingerprint = new FingerprintCore();
        DBClass _DB;
        //Util myUtil;
        SqlConnection psConnection;
        Huella huella;
        hr_employee EmpleadoIdentificado;
        dsHuellasX dsHuellas = new dsHuellasX();
        public event EventHandler OnEstudianteEncontrado;

        public frmIdentificar(SqlConnection pConnection)
        {
            InitializeComponent();

            psConnection = pConnection;

            huella = new Huella();
            _DB = new DBClass();
            ////myUtil = new Util(pConnection);
            //fingerPrint = new GriauleFingerprintLibrary.FingerprintCore();
            //fingerPrint.onStatus += new GriauleFingerprintLibrary.StatusEventHandler(fingerPrint_onStatus);
            //fingerPrint.onImage += new GriauleFingerprintLibrary.ImageEventHandler(fingerPrint_onImage);
        }

        //private GriauleFingerprintLibrary.FingerprintCore fingerPrint;
        //private GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage_Huella;
        //private GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;
        //void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        //{
        //    if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
        //    {
        //        fingerPrint.StartCapture(source.ToString());
        //    }
        //    else
        //    {
        //        fingerPrint.StopCapture(source);
        //    }
        //}

        //void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        //{
        //    //rawImage_Huella = ie.RawImage;
        //    //setImage(ie.RawImage.Image);
        //    //if (rawImage_Huella != null)
        //    //{
        //    //    try
        //    //    {
        //    //        _template = null;
        //    //        fingerPrint.Extract(rawImage_Huella, ref _template);
        //    //        SetQualityBar(_template.Quality);
        //    //        DisplayImage(_template, false);
        //    //    }
        //    //    catch
        //    //    {

        //    //    }
        //    //}

        //    fingerPrint_OnImage(source, ie);
        //}

        private delegate void delSetImage(Image img);
        void setImage(Image img)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new delSetImage(setImage), new object[] { img });
            }
            else
            {
                Bitmap bmp = new Bitmap(img);
                //pictureBox1.Image = bmp;
            }
        }

        //private void ExtractTemplate()
        //{
        //    if (rawImage_Huella != null)
        //    {
        //        try
        //        {
        //            _template = null;
        //            fingerPrint.Extract(rawImage_Huella, ref _template);
        //            SetQualityBar(_template.Quality);
        //            DisplayImage(_template, false);
        //        }
        //        catch
        //        {

        //        }
        //    }
        //}

        //private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify)
        //{
        //    IntPtr hdc = FingerprintCore.GetDC();
        //    IntPtr image = new IntPtr();

        //    if (identify)
        //    {
        //        fingerPrint.GetBiometricDisplay(template, rawImage_Huella, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
        //    }
        //    else
        //    {
        //        fingerPrint.GetBiometricDisplay(template, rawImage_Huella, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
        //    }
        //    setImage(Bitmap.FromHbitmap(image));
        //    FingerprintCore.ReleaseDC(hdc);
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    fingerPrint.Initialize();
        //    fingerPrint.CaptureInitialize();
        //}

        delegate void delsetQuality(int quality);

        private void SetQualityBar(int quality)
        {
        }

        private void frmIdentificar_Load(object sender, EventArgs e)
        {

            //CheckForIllegalCrossThreadCalls = false;
            //fingerPrint.Initialize();
            //fingerPrint.CaptureInitialize();

            //fingerPrint = new GriauleFingerprintLibrary.FingerprintCore();

            //fingerPrint.onStatus += new GriauleFingerprintLibrary.StatusEventHandler(fingerPrint_Onstatus);
            //fingerPrint.onImage += new GriauleFingerprintLibrary.ImageEventHandler(fingerPrint_OnImage);
            txtCode.Focus();
        }

        //void fingerPrint_Onstatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        //{
        //    if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
        //    {
        //        //core.StartCapture(source);
        //        fingerPrint.StartCapture(source);
        //        return;
        //    }
        //    else
        //    {
        //        CajaDialogo.Error("SENSOR NO DETECTADO, FAVOR VERIFICAR");
        //        fingerPrint.StopCapture(source);
        //        //cmdCancelar_Click(new object(), new EventArgs());
        //    }
        //}

        //void fingerPrint_OnImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        //{
        //    try
        //    {
        //        //rawImage_Huella = ie.RawImage;
        //        //fingerPrint.Extract(rawImage_Huella, ref _template);
        //        byte[] dataTemp;
        //        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate templateTemp;
        //        int precision, calidad;

        //        // selecciono 
        //        SqlCommand cmdGetTemplates;
        //        string sql = @" SELECT 
        //                          id_huella,
        //                          eh.id_estudiante,
        //                          huella,
        //                          mano,
        //                          dedo
        //                        FROM admon.estudiantes_huellas eh join
        //                             admon.estudiante ee on
        //                             eh.id_estudiante = ee.id_estudiante
        //                        where ee.habilitado order by eh.id_estudiante asc";

        //        //Configurando el comando
        //        cmdGetTemplates = new SqlCommand(sql, psConnection);

        //        PgSqlDataAdapter adap = new PgSqlDataAdapter(cmdGetTemplates);
        //        dsHuellas.Huellas.Clear();
        //        adap.Fill(dsHuellas.Huellas);
        //        //fingerPrint.IdentifyPrepare(_template);


        //        foreach (dsHuellasX.HuellasRow huella in dsHuellas.Huellas.Rows)
        //        {
                    
        //            dataTemp = (byte[])huella.huella;
        //            calidad = 50;
        //            templateTemp = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();
        //            templateTemp.Buffer = dataTemp;
        //            templateTemp.Size = dataTemp.Length;
        //            templateTemp.Quality = calidad;

        //            precision = 1;

        //            //if (fingerPrint == null)
        //            //{
        //            //    fingerPrint = new FingerprintCore();
        //            //}

        //            int result = 1;// fingerPrint.Identify(templateTemp, out precision);
        //            //WriteLog("kj");
        //            if (result == 1)
        //            {
        //                Estudiante ess = new Estudiante(psConnection);
        //                if (ess.RecuperarRegistro(huella.id_estudiante))
        //                {
        //                    EmpleadoIdentificado = ess;
        //                    //lblNombre.Text = ess.Nombres + " " + ess.Apellidos;
        //                    //lblAsistencia.Visible = lblNombre.Visible = acceptPict.Visible = true;


        //                    //MessageBox.Show("Huella encontrada con exito!");
        //                    //SendKeys.Send("{ENTER}");
        //                    //OnEstudianteEncontrado(source, new EventArgs());

        //                    //Thread tr = new Thread(Procesando);
        //                    //tr.Start();
        //                    if (MarcarAsistencia(EmpleadoIdentificado.IdEstudiante))
        //                    {
        //                        lblAsistencia.Text = "Asistencia marcada con exito!";
        //                        lblAsistencia.BackColor = Color.LightGreen;
        //                        this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0} {1}", ess.Nombres, ess.Apellidos) });
        //                    }
        //                    else
        //                    {
        //                        lblAsistencia.Text = "Ud no tiene clases a esta hora!";
        //                        lblAsistencia.BackColor = Color.LightPink;
        //                        this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0} {1}", ess.Nombres, ess.Apellidos) });
        //                    }
        //                    //this.Invoke(new CleanData(CleanAll), new object[] { });
                            
        //                    return;
        //                }
        //                break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblAsistencia.Text = ex.Message;
        //        lblAsistencia.BackColor = Color.LightCoral;
        //        lblAsistencia.ForeColor = Color.Black;
        //        this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0} {1}", EmpleadoIdentificado.Nombres, EmpleadoIdentificado.Apellidos) }); 
        //        timerResetLabels.Enabled = true;
        //        timerResetLabels.Start();
        //        //MessageBox.Show(ex.Message);
        //    }
        //}

        bool MarcarAsistencia(int id_Estudiante)
        {
            //ConfiguracionSuccess conf1 = new ConfiguracionSuccess(psConnection);
            //DateTime FechaActual = conf1.FechaNow();
            //int dia = 0;
            //switch (FechaActual.DayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        dia =1;
            //        break;
            //    case DayOfWeek.Tuesday:
            //        dia = 2;
            //        break;
            //    case DayOfWeek.Wednesday:
            //        dia = 3;
            //        break;
            //    case DayOfWeek.Thursday:
            //        dia = 4;
            //        break;
            //    case DayOfWeek.Friday:
            //        dia = 5;
            //        break;
            //    case DayOfWeek.Saturday:
            //        dia = 6;
            //        break;
            //    case DayOfWeek.Sunday:
            //        dia = 7;
            //        break;
            //}

            //try
            //{
            //    string sql = "select * from admon.ft_asistencia_huella (:p_id_estudiante, :p_id_dia)";
            //    SqlCommand cmd = new SqlCommand(sql, psConnection);
            //    cmd.Parameters.AddWithValue("p_id_estudiante", id_Estudiante);
            //    cmd.Parameters.AddWithValue("p_id_dia", dia);
            //    return Convert.ToBoolean(cmd.ExecuteScalar());

            //}
            //catch (Exception ec)
            //{
            //    //CajaDialogo.Error(ec.Message);
            //    throw new Exception(ec.Message);
            //    //return false;
            //}
            return false;
        }


        private void WriteLog(string log)
        {
            
            string fileName = "log_" + DateTime.Now.Date.ToShortDateString().Replace('/', '-') + ".txt";
            System.IO.StreamWriter writer = System.IO.File.AppendText(fileName);
            writer.WriteLine(DateTime.Now.ToString());
            writer.WriteLine(log);
            writer.Close();
        }

        private delegate void SetName(string name);
        void SetNameF(string a)
        {
            lblNombre.Text = a;
            lblNombre.Visible= lblAsistencia.Visible = true;
            lblNombre.BackColor = Color.White;
            timerResetLabels.Enabled = true;
            timerResetLabels.Start();
        }

        

        static void Procesando()
        {
            int TiempoP = 100;
            administracion.Huellas.frmProcesando frm = new administracion.Huellas.frmProcesando();

            //frmIdentificado frm = new frmIdentificado(lblNombre.Text);

            frm.ShowDialog();
            Thread.Sleep(TiempoP);
            frm.Close();
        }

        private void frmIdentificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    fingerPrint.CaptureFinalize();
            //    fingerPrint.Finalizer();
            //}
            //catch { }
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        private void timerResetLabels_Tick(object sender, EventArgs e)
        {
            lblNombre.Visible = lblAsistencia.Visible = false;
            //lblNombre.BackColor = Color.White;
            timerResetLabels.Enabled = false;
            timerResetLabels.Stop();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        private void acceptPict_Click(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        private void frmIdentificar_Click(object sender, EventArgs e)
        {
            txtCode.Focus();
        }

        private void txtCode_Click(object sender, EventArgs e)
        {
            //txtCode.Focus();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            //identificar
            string id_token = "";
            try
            {
                id_token = txtCode.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            txtCode.Text = "";

            //try
            //{
            //    hr_employee ess = new hr_employee();
            //    ess.Id = ess.GetIdStudentFromToken(id_token);
            //    if (ess.IdEstudiante>0)
            //    {
                   
            //        if (ess.RecuperarRegistro(ess.IdEstudiante))
            //        {
            //            EmpleadoIdentificado = ess;
            //            txtCode.Text = "";
            //            if (MarcarAsistencia(EmpleadoIdentificado.IdEstudiante))
            //            {
            //                lblAsistencia.Text = "Asistencia marcada con exito!";
            //                lblAsistencia.BackColor = Color.LightGreen;
            //                this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0} {1}", ess.Nombres, ess.Apellidos) });
            //            }
            //            else
            //            {
            //                lblAsistencia.Text = "Ud no tiene clases a esta hora!";
            //                lblAsistencia.BackColor = Color.LightPink;
            //                this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0} {1}", ess.Nombres, ess.Apellidos) });
            //            }
            //            return;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    lblAsistencia.Text = ex.Message;
            //    lblAsistencia.BackColor = Color.LightCoral;
            //    lblAsistencia.ForeColor = Color.Black;
            //    this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0} {1}", EmpleadoIdentificado.Nombres, EmpleadoIdentificado.Apellidos) });
            //    timerResetLabels.Enabled = true;
            //    timerResetLabels.Start();
            //}
            
        }

    }
}
