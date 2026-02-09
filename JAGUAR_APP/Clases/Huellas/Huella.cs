using ACS.Classes;
using JAGUAR_PRO.Facturacion.CoreFacturas;
using NormacApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Clases.Huellas
{
    public class Huella
    {

        //PgSqlConnection psConnection;
        int iHuellaID;
        public hr_employee Empleado;

        TTemplate phPlantilla_Huella;

        public TTemplate Plantilla_Huella
        {
            get { return phPlantilla_Huella; }
            set { phPlantilla_Huella = value; }
        }


        public bool Recuperado { get; set; }

        public Huella()
        {
            //psConnection = pConnection;
            phPlantilla_Huella = null;
            Recuperado = false;
        }

        /// <summary>
        /// Funcion que recupera los datos de una huella
        /// </summary>
        /// <param name="HuellaID">Codigo de la Huella</param>
        /// <returns>Verdadero ó Falso</returns>
        public bool RecuperarRegistro(int pHuellaID)
        {
            Empleado = new hr_employee();
            string sql = @" select hue.id_huella,
	                               hue.id_Empleado,
                                   hue.huella,
                                   hue.mano,
                                   hue.dedo,
                                   hue.quality
                            from admon.Empleados_huellas hue
                            where hue.id_huella = :huellaid";
            DataOperations dp = new DataOperations();
            SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            psConnection.Open();
            SqlCommand cmd = new SqlCommand(sql, psConnection);
            cmd.Parameters.AddWithValue("huellaid", pHuellaID);

            Recuperado = false;
            phPlantilla_Huella = new TTemplate();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                iHuellaID = dr.GetInt32(0);
                Empleado.Id = dr.GetInt32(1);
                long readedBytes = 0;

                // Crear el espacio
                //System.Byte[] temp = new System.Byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];

                // Leer los bytes
                //readedBytes = dr.GetBytes(2, 0, temp, 0, temp.Length);
                //phPlantilla_Huella._size = 0;

                //// Copiar a Estructura
                //System.Array.Copy(temp, 0, phPlantilla_Huella._tpt, 0, (int)readedBytes);

                //// Configurar el tamaño verdadero
                //phPlantilla_Huella._size = (int)readedBytes;

                Recuperado = true;
            }
            else
            {
                Recuperado = false;
                iHuellaID = -1;
                phPlantilla_Huella = new TTemplate();
            }

            dr.Close();

            return Recuperado;
        }


        public int GetCantidadMarcasDelDia(int pIdEmployee, DateTime pFecha)
        {
            int cant = 0;
            try
            {
                DataOperations dp = new DataOperations();
                SqlConnection con = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
                con.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[sp_get_cant_marcas_by_employee]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_employee", pIdEmployee);
                cmd.Parameters.AddWithValue("@fecha", pFecha);
                cant = Convert.ToInt32(cmd.ExecuteScalar());    
                con.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

            return cant;
        }


    }
}
