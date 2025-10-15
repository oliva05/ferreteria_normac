using ACS.Classes;
using core.Clases;
using core.Clases.Huellas;
using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.DataTypes;
using JAGUAR_PRO.Calidad.LoteConfConsumo;
using JAGUAR_PRO.Clases;
using JAGUAR_PRO.RRHH_Planilla.Mantenimientos.MaestrosEmpleado;
using LOSA.Calidad.LoteConfConsumo;
using NormacApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Huellas
{
    public partial class frmMantenimientoHuellas : Form
    {
        int Barra;
        int barraProgreso = 0;
        Clases.EstadoHuella ClaseColores;
        public hr_employee EmpleadoActual;

        //FingerprintCore fingerprint = new FingerprintCore();


        UserLogin UsuarioLogueado;


        FingerprintTemplate h1;
        FingerprintTemplate h2;
        FingerprintTemplate h3;
        FingerprintTemplate h4;
        FingerprintTemplate h5;
        FingerprintTemplate h6;
        FingerprintTemplate h7;
        FingerprintTemplate h8;
        FingerprintTemplate h9;
        FingerprintTemplate h10;

        int Calidad1;
        int Calidad2;
        int Calidad3;
        int Calidad4;
        int Calidad5;
        int Calidad6;
        int Calidad7;
        int Calidad8;
        int Calidad9;
        int Calidad10;

        public frmMantenimientoHuellas(UserLogin  pUser)
        {
            InitializeComponent();
            UsuarioLogueado = pUser;
            ClaseColores =new Clases.EstadoHuella();
            EmpleadoActual = new  hr_employee();
        }

        private void txtEstudiante_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyData==Keys.F2)
            //{
            //    //accion
            //    DataOperations dp = new DataOperations();
            //    SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //    psConnection.Open();
            //    frmBuscarEmpleado frm = new frmBuscarEmpleado(this.UsuarioLogueado);
                
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        if (frm.EmpleadoBusqueda.Id > 0)
            //        {
            //            if(EmpleadoActual.GetById(frm.EmpleadoBusqueda.Id))
            //            {
            //                txtEstudiante.Text = EmpleadoActual.Name;
            //                //vamo a cargar las huellitas del estudiantes
            //                DBClass dbHuellas = new DBClass();
            //                //dbHuellas.getTemplate_EstudianteID(EmpleadoActual.IdEstudiante);
            //                dbHuellas.getTemplate_EstudianteID(EmpleadoActual.Id);
            //                if (dbHuellas.dtHuellasCollection.Huellas.Count > 0)
            //                {
            //                    foreach (dsDetalleHuellas.HuellasRow row in dbHuellas.dtHuellasCollection.Huellas.Rows)
            //                    {
            //                        switch (row.dedo)
            //                        {
            //                            case 1:
            //                                if (row.huella != null)
            //                                    pb1.Image = acceptPict.Image;
            //                                //pb1.Image = dbHuellas.ToImage(row.huella);
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 2:
            //                                if (row.huella != null)
            //                                    pb2.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                    break;
            //                            case 3:
            //                                if (row.huella != null)
            //                                    pb3.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 4:
            //                                if (row.huella != null)
            //                                    pb4.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 5:
            //                                if (row.huella != null)
            //                                    pb5.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 6:
            //                                if (row.huella != null)
            //                                    pb6.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 7:
            //                                if (row.huella != null)
            //                                    pb7.Image= acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 8:
            //                                if (row.huella != null)
            //                                    pb8.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 9:
            //                                if (row.huella != null)
            //                                    pb9.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                            case 10:
            //                                if (row.huella != null)
            //                                    pb10.Image = acceptPict.Image;
            //                                else
            //                                    pb1.Image = deletePict.Image;
            //                                break;
            //                        }
            //                        CargarBarraProgreso();
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                txtEstudiante.Text = "";
            //            }
            //        }
            //    }
            //}
        }

       

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

         

        private void ultraPictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            
            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            
            //    pb2.BackColor = Color.Green;
            //else
            //    pb2.BackColor = Color.Red;
            

            CargarBarraProgreso();

        }


        void CargarBarraProgreso()
        {

            //barraProgreso = ClaseColores.CantVerde(pb1, pb2, pb3,pb4,pb5,pb6,pb7,pb8,pb9,pb10);
           
            //ultraProgressBar1.Value = barraProgreso;

        }

     
        private void pb1_DoubleClick(object sender, EventArgs e)
        {
            

            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    
                        //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                        LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                        //frmDetectarHuella.pictureBox1.Image = pb1.Image;
                        //frmDetectarHuella.lblNumero.Text = "1";
                        if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                        {
                            //h1 = frmDetectarHuella._template;
                            //pb1.Image = frmDetectarHuella.pictureBox1.Image;
                        }
                        CargarBarraProgreso();
                    
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb3_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb3.BackColor = Color.Green;
            //else
            //    pb3.BackColor = Color.Red;
           
            CargarBarraProgreso();
            

        }

        private void pb4_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb4.BackColor = Color.Green;
            //else
            //    pb4.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb5_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb5.BackColor = Color.Green;
            //else
            //    pb5.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb10_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb10.BackColor = Color.Green;
            //else
            //    pb10.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb9_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    //pb9.BackColor = Color.Green;
            //else
            //    pb9.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb8.BackColor = Color.Green;
            //else
            //    pb8.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb9.BackColor = Color.Green;
            //else
            //    pb9.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb6_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb6.BackColor = Color.Green;
            //else
            //    pb6.BackColor = Color.Red;


            CargarBarraProgreso();
        }

        private void pb7_DoubleClick(object sender, EventArgs e)
        {
            Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();

            //if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            //    pb7.BackColor = Color.Green;
            //else
            //    pb7.BackColor = Color.Red;


            CargarBarraProgreso();
        }



        public enum TipoEdicion
        {
            Nuevo = 1,
            Editar = 2,
            Consulta = 3
        }
        private TipoEdicion OperacionActual;

      

        private void cmdIniciarAsistente_Click(object sender, EventArgs e)
        {
            
            AbrirAsistenteVar = true;
            for (int i = 1; i <= 10; i++)
            {
                if (AbrirAsistenteVar)
                    AbrirAsistente(i);
                else
                    i=10;
            }
        }

        bool AbrirAsistenteVar = false;
        public void AbrirAsistente(int pNumeroPicturebox)
        {
            frm_addHuella frmDetectarHuella = new frm_addHuella();
            if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
            {
                switch (pNumeroPicturebox)
                {
                    case 1:
                        h1 = frmDetectarHuella._template;
                        break;
                    case 2:
                        h2 = frmDetectarHuella._template;
                        break;
                    case 3:
                        h4 = frmDetectarHuella._template;
                        break;
                    case 4:
                        h4 = frmDetectarHuella._template;
                        break;
                    case 5:
                        h5 = frmDetectarHuella._template;
                        break;
                    case 6:
                        h6 = frmDetectarHuella._template;
                        break;
                    case 7:
                        h7 = frmDetectarHuella._template;
                        break;
                    case 8:
                        h8 = frmDetectarHuella._template;
                        break;
                    case 9:
                        h9 = frmDetectarHuella._template;
                        break;
                    case 10:
                        h10 = frmDetectarHuella._template;
                        break;
                }
            }
            else
            {
                AbrirAsistenteVar = false;
            }
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtEmpleado.Text = "";
            DialogResult r = CajaDialogo.Pregunta("Desea reiniciar las lecturas?");
            if (r == System.Windows.Forms.DialogResult.Yes)
            {
                txtEmpleado.Text = "";

                EmpleadoActual = new hr_employee();
                txtEmpleado.Text = "";
                dsHuellasManto1.HuellasManoIzquierda.Clear();
                dsHuellasManto1.HuellasManoDerecha.Clear();
                txtEmpleado.Focus();
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int cant = 0;

            cant = dsHuellasManto1.HuellasManoIzquierda.Count + dsHuellasManto1.HuellasManoDerecha.Count;

            if (cant <= 2)
            {
                CajaDialogo.Error("Se requiere un minimo de dos (2) huellas para crear el registro!");
                return;
            }

            DialogResult r = CajaDialogo.Pregunta("Desea guardar estas Huellas?");
            if (r != System.Windows.Forms.DialogResult.Yes)
                return;

            if (h1 != null)
                SalvarBaseDatos(1, 1, h1, Calidad1);

            if (h2 != null)
                SalvarBaseDatos(1, 2, h2, Calidad2);

            if (h3 != null)
                SalvarBaseDatos(1, 3, h3, Calidad3);

            if (h4 != null)
                SalvarBaseDatos(1, 4, h4, Calidad4);

            if (h5 != null)
                SalvarBaseDatos(1, 5, h5, Calidad5);

            if (h6 != null)
                SalvarBaseDatos(2, 6, h6, Calidad6);

            if (h7 != null)
                SalvarBaseDatos(2, 7, h7, Calidad7);

            if (h8 != null)
                SalvarBaseDatos(2, 8, h8, Calidad8);

            if (h9 != null)
                SalvarBaseDatos(2, 9, h9, Calidad9);

            if (h10 != null)
                SalvarBaseDatos(2, 10, h10, Calidad10);

            CajaDialogo.Information("Registro exitoso!");
            cmdNuevo_Click(sender, new EventArgs());
        }


        private bool SalvarBaseDatos(int pmano, int pdedo, FingerprintTemplate _templatex, int pCalidad)
        {
            if (EmpleadoActual == null)
            {
                CajaDialogo.Error("No hay ningun empleado Seleccionado!");
                return false;
            }

            if (!EmpleadoActual.Recuperado)
            {
                CajaDialogo.Error("No hay ningun empleado Seleccionado!");
                return false;
            }

            if (EmpleadoActual.TieneHuella(pdedo, EmpleadoActual.Id))
                OperacionActual = TipoEdicion.Editar;
            else
                OperacionActual = TipoEdicion.Nuevo;

            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                psConnection.Open();

                string sql = "";
                SqlCommand cmd;
                switch (OperacionActual)
                {
                    case TipoEdicion.Nuevo:
                        sql = @"dbo.sp_set_insert_huella_empleado";
                        cmd = new SqlCommand(sql, psConnection);
                        cmd.Parameters.AddWithValue("@id_empleado", EmpleadoActual.Id);
                        cmd.Parameters.AddWithValue("@quality", pCalidad);
                        cmd.Parameters.AddWithValue("@mano", pmano);
                        cmd.Parameters.AddWithValue("@dedo", pdedo);
                        cmd.Parameters.AddWithValue("@id_usuario_created", this.UsuarioLogueado.Id);
                        DBClass dbHuellas = new DBClass();

                        System.Byte[] temp = new System.Byte[_templatex.Size + 1];
                        System.Array.Copy(_templatex.Buffer, 0, temp, 0, _templatex.Size);
                        
                        cmd.Parameters.AddWithValue("@huella", temp);

                        cmd.ExecuteNonQuery();
                        
                        break;
                    case TipoEdicion.Editar:
                        if (_templatex != null)
                        {
                            sql = @"dbo.sp_set_update_huella_empleado";
                            cmd = new SqlCommand(sql, psConnection);
                            DBClass dbHuellas1 = new DBClass();
                            //cmd.Parameters.Add("huella", PgSqlType.ByteA).Value = dbHuellas1.ImageToByte((System.Drawing.Image)pPictureBox.Image);

                            // Create parameter for ? contained in the SQL statement.
                            System.Byte[] temp1 = new System.Byte[_templatex.Size + 1];
                            System.Array.Copy(_templatex.Buffer, 0, temp1, 0, _templatex.Size);

                            //PARAMETRO DE SqlCommand DEL CONNECTOR VIEJO SQL VERSION DE POSTGRES 6.0
                            cmd.Parameters.AddWithValue("@huella", temp1);

                            cmd.Parameters.AddWithValue("@id", EmpleadoActual.Id);
                            cmd.Parameters.AddWithValue("@quality", pCalidad);
                            cmd.ExecuteNonQuery();
                        }
                        break;

                }
                return true;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                return false;
            }
        }

        private void pb2_DoubleClick(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb2.Image;
                    //frmDetectarHuella.lblNumero.Text = "2";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        //pb2.Image = frmDetectarHuella.pictureBox1.Image;
                        h2 = frmDetectarHuella._template;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb3_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb3.Image;
                    //frmDetectarHuella.lblNumero.Text = "3";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        //pb3.Image = frmDetectarHuella.pictureBox1.Image;
                        h3 = frmDetectarHuella._template;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb4_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb4.Image;
                    //frmDetectarHuella.lblNumero.Text = "4";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        h4 = frmDetectarHuella._template;
                        //pb4.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb5_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb5.Image;
                    //frmDetectarHuella.lblNumero.Text = "5";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        h5 = frmDetectarHuella._template;
                        //pb5.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb6_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb6.Image;
                    //frmDetectarHuella.lblNumero.Text = "6";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        h6 = frmDetectarHuella._template;
                        //pb6.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb7_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb7.Image;
                    //frmDetectarHuella.lblNumero.Text = "7";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        h7 = frmDetectarHuella._template;
                       // pb7.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                   // txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb8_DoubleClick(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb8.Image;
                    //frmDetectarHuella.lblNumero.Text = "8";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        //h8 = frmDetectarHuella._template;
                        //pb8.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb9_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb9.Image;
                    //frmDetectarHuella.lblNumero.Text = "9";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        //h9 = frmDetectarHuella._template;
                        //pb9.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                   // txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void pb10_DoubleClick_1(object sender, EventArgs e)
        {
            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Recuperado)
                {
                    //Huellas.frm_addHuella frmDetectarHuella = new frm_addHuella();
                    LectorHuellasv2 frmDetectarHuella = new LectorHuellasv2();
                    //frmDetectarHuella.pictureBox1.Image = pb10.Image;
                    //frmDetectarHuella.lblNumero.Text = "10";
                    if (frmDetectarHuella.ShowDialog() == DialogResult.OK)
                    {
                        //h10 = frmDetectarHuella._template;
                        //pb10.Image = frmDetectarHuella.pictureBox1.Image;
                    }
                    CargarBarraProgreso();
                }
                else
                {
                    CajaDialogo.Error("Necesita seleccionar el estudiante!");
                    //txtEstudiante.Focus();
                }
            }
            else
            {
                CajaDialogo.Error("Necesita seleccionar el estudiante!");
                //txtEstudiante.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //fingerprint.Initialize();
            //fingerprint.CaptureInitialize();

            //fingerprint.Finalizer();
            //fingerprint.CaptureFinalize();
        }

    
        private void frmMantenimientoHuellas_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void frmMantenimientoHuellas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            frmSearchDefault frm = new frmSearchDefault(frmSearchDefault.TipoBusqueda.Empleados);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                //if(EmpleadoActual.GetById(frm.)
            }
        }

        private void cmdEliminarHuellaManoI_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //cmdEliminarHuellaManoI
        }

        private void cmdEliminarHuellaManoD_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //cmdEliminarHuellaManoD
        }

        private void cmdAddIzquierda_Click(object sender, EventArgs e)
        {
            int contadorI = dsHuellasManto1.HuellasManoIzquierda.Count;
            if (contadorI < 5)
            {
                AbrirAsistente(contadorI);
            }
            else
            {
                CajaDialogo.Error("Ya se registraron 5 marcas para la mano izquierda!");
            }
        }

        private void cmdAddDerecha_Click(object sender, EventArgs e)
        {
            int contadorD = dsHuellasManto1.HuellasManoDerecha.Count;
            if (contadorD < 5)
            {
                AbrirAsistente(contadorD);
            }
            else
            {
                CajaDialogo.Error("Ya se registraron 5 marcas para la mano derecha!");
            }
        }
    }
}
