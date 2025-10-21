using ACS.Classes;
using core.Clases;
using core.Clases.Huellas;
using GriauleFingerprintLibrary;
using JAGUAR_PRO.Huellas;
using NormacApp.Models;

//using GrFingerXLib;
//using GriauleFingerprintLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administracion.Huellas
{
    public partial class frmIdentificar : Form
    {
        Huella huella;
        hr_employee EmpleadoIdentificado;
        dsHuellasX dsHuellas = new dsHuellasX();
        public event EventHandler Onhr_employeeEncontrado;
        DataOperations dp;

        public frmIdentificar()
        {
            InitializeComponent();
            dp = new DataOperations();
            try
            {
                huella = new Huella();
                fingerPrint = new GriauleFingerprintLibrary.FingerprintCore();
                fingerPrint.onStatus += new StatusEventHandler(fingerPrint_onStatus);
                fingerPrint.onImage += new ImageEventHandler(fingerPrint_onImage);


                DataOperations dp = new DataOperations();
                SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                psConnection.Open();
                // selecciono 
                SqlCommand cmdGetTemplates;
                string sql = @"dbo.sp_get_all_huellas";

                //Configurando el comando
                cmdGetTemplates = new SqlCommand(sql, psConnection);
                cmdGetTemplates.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adap = new SqlDataAdapter(cmdGetTemplates);

                dsHuellasManto1.HuellasAll_employees.Clear();
                adap.Fill(dsHuellasManto1.HuellasAll_employees);

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                //statusStrip1.Text = ec.Message;
            }
        }

        private GriauleFingerprintLibrary.FingerprintCore fingerPrint;
        private GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage_Huella;
        private GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;
        void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                fingerPrint.StartCapture(source.ToString());
            }
            else
            {
                fingerPrint.StopCapture(source);
            }
        }

        void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            rawImage_Huella = ie.RawImage;
            setImage(ie.RawImage.Image);
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


                foreach (dsHuellasManto.HuellasAll_employeesRow huella in dsHuellasManto1.HuellasAll_employees.Rows)
                {

                    dataTemp = (byte[])huella.huella;
                    calidad = 50;
                    templateTemp = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();
                    templateTemp.Buffer = dataTemp;
                    templateTemp.Size = dataTemp.Length;
                    templateTemp.Quality = calidad;

                    precision = 1;

                    int result = fingerPrint.Identify(templateTemp, out precision);
                    //int result = 1;
                    //WriteLog("kj");
                    if (result == 1)
                    {
                        hr_employee ess = new hr_employee();
                        if (ess.GetById(huella.id_empleado))
                        {
                            EmpleadoIdentificado = ess;
                            DateTime FechaActual = dp.Now();
                            //CajaDialogo.Information("Cantarito: " + ess.Name);
                            //lblNombre.Text = ess.Nombres + " " + ess.Apellidos;
                            //lblAsistencia.Visible = lblNombre.Visible = true;


                            //MessageBox.Show("Huella encontrada con exito!");
                            //SendKeys.Send("{ENTER}");
                            //Onhr_employeeEncontrado(source, new EventArgs());

                            //Thread tr = new Thread(Procesando);
                            //tr.Start();
                            if (MarcarAsistencia(EmpleadoIdentificado.Id, FechaActual))
                            {
                                lbl_MensajeAsistencia.Text = "Marca realizada con exito!";
                                lbl_MensajeAsistencia.BackColor = Color.Transparent;
                                lbl_MensajeAsistencia.ForeColor = Color.Blue;
                                lblHoraMarcada.Visible = true;
                                lblHoraMarcada.ForeColor = Color.DodgerBlue;
                                lblHoraMarcada.BackColor = Color.Transparent;
                                //lblHoraMarcada.Text = string.Format("{0:dd/MM/yyyy HH:mm}", FechaActual);
                                lblHoraMarcada.Text = FechaActual.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                                this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0}", ess.Name) });
                                lblHoraMarcada.Text = string.Format("{0:dd/MM/yyyy HH:mm}", FechaActual); 
                            }
                            else
                            {
                                //lbl_MensajeAsistencia.Text = "No se pudo realizar el marcaje!";
                                lbl_MensajeAsistencia.BackColor = Color.LightPink;
                                lbl_MensajeAsistencia.ForeColor = Color.Black;
                                lblHoraMarcada.Visible = false;
                                lblHoraMarcada.Text = "";
                                this.Invoke(new SetName(SetNameF), new object[] { String.Format("{0}", ess.Name) });
                            }
                            //this.Invoke(new CleanData(CleanAll), new object[] { });

                            return;
                        }
                        break;
                    }//end if
                }
            }
            catch (Exception ex)
            {
                //statusStrip1.Text = ex.Message;
                MessageBox.Show(ex.Message);
                this.Invoke(new SetName(SetNameError), new object[] { String.Format("{0}", ex.Message) });
            }
        }

        void SetNameError(string a)
        {
            //lblMensaje.Visible = true;
            //lblMensaje.Text = a;
            //lblNombre.Text = LblHoraMarcada.Text = "";
            //LblHoraMarcada.Visible = lblNombre.Visible = false;
            timerResetLabels.Start();
        }



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

        private void ExtractTemplate()
        {
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
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify)
        {
            IntPtr hdc = FingerprintCore.GetDC();
            IntPtr image = new IntPtr();

            if (identify)
            {
                fingerPrint.GetBiometricDisplay(template, rawImage_Huella, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }
            else
            {
                fingerPrint.GetBiometricDisplay(template, rawImage_Huella, hdc, ref image, FingerprintConstants.GR_NO_CONTEXT);
            }
            setImage(Bitmap.FromHbitmap(image));
            FingerprintCore.ReleaseDC(hdc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fingerPrint.Initialize();
            fingerPrint.CaptureInitialize();
        }

        delegate void delsetQuality(int quality);

        private void SetQualityBar(int quality)
        {
        }

        private void frmIdentificar_Load(object sender, EventArgs e)
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
            //txtCode.Focus();
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
        //                          eh.id_hr_employee,
        //                          huella,
        //                          mano,
        //                          dedo
        //                        FROM admon.hr_employees_huellas eh join
        //                             admon.hr_employee ee on
        //                             eh.id_hr_employee = ee.id_hr_employee
        //                        where ee.habilitado order by eh.id_hr_employee asc";

        //        //Configurando el comando
        //        cmdGetTemplates = new SqlCommand(sql, psConnection);

        //        SqlDataAdapter adap = new SqlDataAdapter(cmdGetTemplates);
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
        //                hr_employee ess = new hr_employee(psConnection);
        //                if (ess.RecuperarRegistro(huella.id_hr_employee))
        //                {
        //                    EmpleadoIdentificado = ess;
        //                    //lblNombre.Text = ess.Nombres + " " + ess.Apellidos;
        //                    //lblAsistencia.Visible = lblNombre.Visible = acceptPict.Visible = true;


        //                    //MessageBox.Show("Huella encontrada con exito!");
        //                    //SendKeys.Send("{ENTER}");
        //                    //Onhr_employeeEncontrado(source, new EventArgs());

        //                    //Thread tr = new Thread(Procesando);
        //                    //tr.Start();
        //                    if (MarcarAsistencia(EmpleadoIdentificado.Idhr_employee))
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

        bool MarcarAsistencia(int id_hr_employee, DateTime FechaActual)
        {
            //ConfiguracionSuccess conf1 = new ConfiguracionSuccess(psConnection);
            bool result = false;
            int dia = 0;
            switch (FechaActual.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dia = 2;
                    break;
                case DayOfWeek.Tuesday:
                    dia = 3;
                    break;
                case DayOfWeek.Wednesday:
                    dia = 4;
                    break;
                case DayOfWeek.Thursday:
                    dia = 5;
                    break;
                case DayOfWeek.Friday:
                    dia = 6;
                    break;
                case DayOfWeek.Saturday:
                    dia = 7;
                    break;
                case DayOfWeek.Sunday:
                    dia = 1;
                    break;
            }

            
            try
            {
                string sql = "dbo.sp_set_marcaje_asistencia_empleado";
                SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                psConnection.Open();
                SqlCommand cmd = new SqlCommand(sql, psConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_hr_employee", id_hr_employee);
                cmd.Parameters.AddWithValue("@id_dia", dia);
                //FechaActual = Convert.ToDateTime("10/18/2025 07:16:30 AM");
                cmd.Parameters.AddWithValue("@delta_time", FechaActual);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id_msj = 0;

                    if (!dr.IsDBNull(dr.GetOrdinal("mensaje")))
                        id_msj = dr.GetInt32(0);

                    if (!dr.IsDBNull(dr.GetOrdinal("mensaje")))
                        result = dr.GetBoolean(1);

                    switch (id_msj) 
                    {
                        case 1:
                            lbl_MensajeAsistencia.Text = "Tiene marcas abiertas de dias anteriores... No se registró la marca";
                            break;
                        case 2:
                            lbl_MensajeAsistencia.Text = "Esta marcando entrada tarde! No se registrará la marca...";
                            break;
                        case 3:
                            lbl_MensajeAsistencia.Text = "No se permite marcar, ha marcado hace menos de 10 minutos!";
                            break;
                        case 4:
                            lbl_MensajeAsistencia.Text = "Esta marcando Tarde el regreso de almuerzo. No se registrará la marca...";
                            break;
                        case 5:
                            lbl_MensajeAsistencia.Text = "Esta marcando antes de la hora de salida. No se registrará la marca...";
                            break;
                        default:
                            lbl_MensajeAsistencia.Text = "";
                            break;
                    }

                }

                dr.Close();
                psConnection.Close();   
            }
            catch (Exception ec)
            {
                //CajaDialogo.Error(ec.Message);
                throw new Exception(ec.Message);
                //return false;
            }
            return result;
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
            lblNombre.Visible= lbl_MensajeAsistencia.Visible = true;
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
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                fingerPrint.StopCapture(sender);
                fingerPrint.CaptureFinalize();
                fingerPrint.Finalizer();

            }
            catch { }
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
        }

        private void timerResetLabels_Tick(object sender, EventArgs e)
        {
            lblNombre.Visible = lbl_MensajeAsistencia.Visible = false;
            lblHoraMarcada.Text = "";
            //lblNombre.BackColor = Color.White;
            timerResetLabels.Enabled = false;
            timerResetLabels.Stop();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
           
        }

        private void acceptPict_Click(object sender, EventArgs e)
        {
           
        }

        private void frmIdentificar_Click(object sender, EventArgs e)
        {
           
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
            //try
            //{
            //    id_token = txtCode.Text;
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.Message);
            //}

            //txtCode.Text = "";

            //try
            //{
            //    hr_employee ess = new hr_employee();
            //    ess.Id = ess.GetIdStudentFromToken(id_token);
            //    if (ess.Idhr_employee>0)
            //    {
                   
            //        if (ess.RecuperarRegistro(ess.Idhr_employee))
            //        {
            //            EmpleadoIdentificado = ess;
            //            txtCode.Text = "";
            //            if (MarcarAsistencia(EmpleadoIdentificado.Idhr_employee))
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
