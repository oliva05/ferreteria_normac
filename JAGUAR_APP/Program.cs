﻿using ACS.Classes;
using JAGUAR_PRO.Clases;
using PRININ.Gestion_de_Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var customCulture = new System.Globalization.CultureInfo("es-ES", true);

            // Configura separadores decimales y de miles como los de en-US
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            customCulture.NumberFormat.CurrencyDecimalSeparator = ".";
            customCulture.NumberFormat.NumberGroupSeparator = ",";

            // Asignar a la aplicación
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            string name_ = Environment.MachineName.ToString();
            //DataOperations dp = new DataOperations();
            //string query = "sp_get_verify_is_tablet_alosy";
            //SqlConnection cn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            //bool val = true;
            //try
            //{
            //    cn.Open();
            //    SqlCommand cmd = new SqlCommand(query, cn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.AddWithValue("@name_", name_);
            //    val = Convert.ToBoolean(cmd.ExecuteScalar());
            //    cn.Close();
            //}
            //catch (Exception ex)
            //{
            //    CajaDialogo.Error("Error al cargar la informacion: " + ex.Message);
            //}

            //if(val)//es una tablet encontrada en el registro
            //    Application.Run(new frmMain());
            //else
            //    Application.Run(new MDIParentFormLOSA());


            //Aplicacion Run para JAGUAR 
            Application.Run(new MDIParentFormLOSA());
            //Aplicacion Run para JAGUAR para crear usuario
            //Application.Run(new frmUser(frmUser.TipoEdicion.Nuevo, new UserLogin() ));

        }
    }
}
