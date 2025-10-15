using ACS.Classes;
using core.Clases;
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

namespace administracion.Huellas
{
    public partial class frmGestionAsistencia : Form
    {
        SqlConnection psConnection;
        public frmGestionAsistencia()
        {
            InitializeComponent();
            //psConnection = pConnection;
            //ConfiguracionSuccess conf = new ConfiguracionSuccess(psConnection);
            //DateTime Fechanow = conf.FechaNowTime();
            //DateTime Desde = new DateTime(Fechanow.Year, Fechanow.Month, Fechanow.Day, 7, 0, 0);
            //dtDesde1.EditValue = xDesdeN.EditValue = Desde;
            //dtHasta1.EditValue = xHastaN.EditValue = Fechanow;
            LoadCursosEnable();
        }

        private void LoadCursosEnable()
        {
            try
            {
                //dsEstudiantes1.estudiantes.Clear();
                string sql = @"select * from admon.ft_get_cursos_activos();";
                SqlCommand cmd = new SqlCommand(sql, psConnection);
                //cmd.Parameters.Add("p_desde", PgSqlType.Date).Value = dateTimePickerDesde.Value;
                //cmd.Parameters.Add("p_hasta", PgSqlType.Date).Value = dateTimePickerHasta.Value;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsEstudiantes1.cursos);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            try
            {
                //dsEstudiantes1.estudiantes.Clear();
                string sql = @"select * from admon.ft_cargar_asistencia_perfecta (
                                                                                  :p_desde,
                                                                                  :p_hasta);";
                SqlCommand cmd = new SqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("p_desde",  dateTimePickerDesde.Value);
                cmd.Parameters.AddWithValue("p_hasta", dateTimePickerHasta.Value);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsEstudiantes1.estudiantes);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            //dsEstudiantes1.estudiantes.Clear();
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //dsEstudiantes2.estudiantes.Clear();
                string sql = @"select * from admon.ft_cargar_faltistas (
                                                                                  :p_desde,
                                                                                  :p_hasta);";
                SqlCommand cmd = new SqlCommand(sql, psConnection);
                //cmd.Parameters.Add("p_desde", PgSqlType.Date).Value = dateTimePickerDesdeFaltantes.Value;
                //cmd.Parameters.Add("p_hasta", PgSqlType.Date).Value = dateTimePickerHastaFaltantes.Value;
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsEstudiantes2.estudiantes);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {

            //dsEstudiantes2.estudiantes.Clear();
        }

        private void xrefresh_Click(object sender, EventArgs e)
        {

            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl1.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select * from admon.ft_get_asistencia_marcada (:p_desde, :p_hasta);";
                SqlCommand cmd = new SqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("p_desde", xDesdeN.EditValue);
                cmd.Parameters.AddWithValue("p_hasta", xHastaN.EditValue);
                
                DataTable tab = new DataTable();
                //dsEstudiantes1.horas.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsEstudiantes1.horas);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void cmdFaltistas_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (string.IsNullOrEmpty(gridLookUpEdit2.Text))
                {
                    sql = @"select * from admon.ft_get_ausencias (
                                                                      :pdesde,
                                                                      :phasta);";
                }
                else
                {
                    sql = @"select * from admon.ft_get_ausencias_by_curso (
                                                                      :pdesde,
                                                                      :phasta,
                                                                      :pidcurso);";
                }

                SqlCommand cmd = new SqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("pdesde", dtDesde1.EditValue);
                cmd.Parameters.AddWithValue("phasta", dtHasta1.EditValue);

                if (!string.IsNullOrEmpty(gridLookUpEdit2.Text))
                {
                    cmd.Parameters.AddWithValue("pidcurso", gridLookUpEdit2.EditValue);
                }

                //DataTable tab = new DataTable();
                //dsEstudiantes1.ausentes.Clear();
                //SqlDataAdapter adat = new SqlDataAdapter(cmd);
                //adat.Fill(dsEstudiantes1.ausentes);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl2.ExportToXlsx(dialog.FileName);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            //gridControl3
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gridControl3.ExportToXlsx(dialog.FileName);
            }
        }
    }
}
