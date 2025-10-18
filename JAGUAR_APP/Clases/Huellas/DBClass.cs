
using System;
using System.Data;
using System.Data.OleDb;
//using GrFingerXLib;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using core.Clases;
using core.Clases.Huellas;
using NormacApp.Models;
using ACS.Classes;
using System.Data.SqlClient;
//using GriauleFingerprintLibrary.DataTypes;

// the template class
public class TTemplate
{
    // Template data.
    public System.Array _tpt;
    // Template size
    public int _size;

    public TTemplate()
    {
        // Create a byte buffer for the template
        //_tpt = new byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];
        _size = 0;
    }
}




// the database class
public class DBClass
{
    /// <summary>
    /// Objeto de Conexion
    /// </summary>
    
    public hr_employee vEmpleado;


    public enum Manito
    {
        Izquierda = 1,
        Derecha = 2
    }

    public Manito Mano
    {
        get;
        set;
    }



    // Agregar plantilla a la base de datos y devolver el codigo de huella
    public bool addTemplate(TTemplate tpt, ref int id)
    {
        try
        {
            string sql = "select * from planilla.sp_insert_huella_empleado(:codigoempleado,:mano,:dedo,:plantilla_huella)";

            //ALMACENANDO LAS HUELLAS CON EL NUEVO CONNECTOR SQL
            DataOperations dp = new DataOperations();
            SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            Conn.Open();
            SqlCommand cmdx = new SqlCommand(sql, Conn);

            // Create parameter for ? contained in the SQL statement.
            System.Byte[] temp = new System.Byte[tpt._size + 1];
            System.Array.Copy(tpt._tpt, 0, temp, 0, tpt._size);

            //PARAMETRO DE SqlCommand DEL CONNECTOR VIEJO SQL VERSION DE POSTGRES 6.0
            cmdx.Parameters.AddWithValue("plantilla_huella", temp);

            //EJECUTAMOS LA NUEVA CONSULTA CON EL NUEVO CONECTOR

            id = Convert.ToInt32(cmdx.ExecuteScalar());
            return true;

        }
        catch (Exception ec)
        {

            return false;
        }
    }

   

    public int Dedo { get; set; }


    // temporary template for retrieving data from DB
    private TTemplate tptBlob;

    public IDataReader obtenerTemplates()
    {
        try
        {
            DataOperations dp = new DataOperations();
            SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            Conn.Open();
            string sql = @" SELECT 
                              id_huella,
                              id_estudiante,
                              huella,
                              mano,
                              dedo
                            FROM admon.estudiantes_huellas eh";

            // string strCommand = "SELECT * FROM USUARIO";

            SqlCommand pgsCommand = new SqlCommand(sql, Conn);

            return pgsCommand.ExecuteReader();
        }
        catch (Exception ec) 
        {
            return null;
        }
    }


    public dsDetalleHuellas getTemplates2()
    {
        try
        {
            DataOperations dp = new DataOperations();
            SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            Conn.Open();
            SqlCommand cmdGetTemplates;

            string sql = @" SELECT 
                              id_huella,
                              id_estudiante,
                              huella,
                              mano,
                              dedo
                            FROM admon.estudiantes_huellas eh";

            //Configurando el comando
            cmdGetTemplates = new SqlCommand(sql, Conn);

            SqlDataAdapter adap = new SqlDataAdapter(cmdGetTemplates);

            dsDetalleHuellas ds = new dsDetalleHuellas();
            adap.Fill(ds.Huellas);

            return ds;
        }
        catch { return null; }
    }

    /// <summary>
    /// Guardar la huella en la base de datos y devolver el codigo de huella 
    /// </summary>
    /// <param name="tpt"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool InsertarHuellaEnDB(TTemplate tpt, ref int id)
    {
        try
        {
            DataOperations dp = new DataOperations();
            SqlConnection Conn = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            Conn.Open();
        
            string sql = @"INSERT INTO admon.estudiantes_huellas(
                                                                  id_estudiante,
                                                                  huella,
                                                                  mano,
                                                                  dedo)
                                                        VALUES (
                                                                  :id_estudiante,
                                                                  :huella,
                                                                  :mano,
                                                                  :dedo);";

            //ALMACENANDO LAS HUELLAS CON EL NUEVO CONNECTOR SQL
            SqlCommand cmdx = new SqlCommand(sql, Conn);
            cmdx.Parameters.AddWithValue("id_estudiante", this.vEmpleado.Id);// empleado.Codigoempleado.Trim();
            cmdx.Parameters.AddWithValue("mano",(int)Mano);
            cmdx.Parameters.AddWithValue("dedo", Dedo);// dedo.TipoDedo;

            // Create parameter for ? contained in the SQL statement.
            System.Byte[] temp = new System.Byte[tpt._size + 1];
            System.Array.Copy(tpt._tpt, 0, temp, 0, tpt._size);

            cmdx.Parameters.AddWithValue("huella", temp);

            //EJECUTAMOS LA NUEVA CONSULTA CON EL NUEVO CONECTOR
            if (Conn.State == ConnectionState.Open)
            {
                try
                {
                    id = Convert.ToInt32(cmdx.ExecuteScalar());
                    return true;
                }
                catch (Exception ec)
                {
                    CajaDialogo.Error(ec.Message);
                    return false;
                }
            }
            Conn.Close();
        }
        catch (Exception ec)
        {
            CajaDialogo.Error(ec.Message);
            return false;
        }

        return true;
    }



    //Funcion para convertir una imagen en arreglo de bytes.       
    public byte[] ImageToByte(Image img)
    {
        ImageConverter converter = new ImageConverter();
        return (byte[])converter.ConvertTo(img, typeof(byte[]));
    }

    //funcion para convertir un arreglo de bytes a imagen.
    public Image ToImage(byte[] arreglo)
    {
        Image img = null;
        if (arreglo != null)
        {
            if (arreglo.Length > 0)
            {
                //ImageConverter ic = new ImageConverter();
                //img = (Image)ic.ConvertFrom(arreglo);

                MemoryStream ms = new MemoryStream(arreglo);
                //Image returnImage = Image.FromStream(ms);
                Bitmap bitmap1 = new Bitmap(ms);

                return (Image)bitmap1;
                //img = returnImage;

            }
        }

        return null;
        //return img;
    }


    /// <summary>
    /// Retorna un set de datos en forma de Tabla
    /// </summary>
    /// <returns></returns>
    public dsDetalleHuellas getTemplates()
    {
        try
        {
            DataOperations dp = new DataOperations();
            SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            psConnection.Open();
            SqlCommand cmdGetTemplates;

            string sql = @" SELECT 
                              id_huella,
                              id_estudiante,
                              huella,
                              mano,
                              dedo
                            FROM admon.estudiantes_huellas eh";

            //Configurando el comando
            cmdGetTemplates = new SqlCommand(sql, psConnection);

            SqlDataAdapter adap = new SqlDataAdapter(cmdGetTemplates);

            dsDetalleHuellas ds = new dsDetalleHuellas();
            adap.Fill(ds.Huellas);

            return ds;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public dsDetalleHuellas dtHuellasCollection;

    // Retorna la plantilla de determinado codigo de huella
    public TTemplate getTemplate(int phuellaid)
    {
        try
        {
            DataOperations dp = new DataOperations();
            SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            psConnection.Open();

            SqlCommand cmd = null;
            SqlDataReader dr = null;
            tptBlob._size = 0;
            try
            {
                string sql = @"SELECT 
                                  id_huella,
                                  id_estudiante,
                                  huella,
                                  mano,
                                  dedo
                                FROM admon.estudiantes_huellas eh
                                where eh.id_huella = :id";


                cmd = new SqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("id", phuellaid);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd);
                if (dtHuellasCollection == null)
                    dtHuellasCollection = new dsDetalleHuellas();

                adat1.Fill(dtHuellasCollection.Huellas);

                dr = cmd.ExecuteReader();
                // Get query response
                if (dr.Read())
                {
                    getTemplate(dr);
                }

                dr.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                dr.Close();
            }
            return tptBlob;
        }
        catch
        {
            return null;
        }
    }


    public TTemplate getTemplate_EstudianteID(int pEstudianteId)
    {
        try
        {
            DataOperations dp = new DataOperations();
            SqlConnection psConnection = new SqlConnection(dp.ConnectionStringJAGUAR_DB);
            psConnection.Open();

            SqlCommand cmd = null;
            SqlDataReader dr = null;
            tptBlob._size = 0;
            try
            {
                string sql = @"SELECT 
                                  id_huella,
                                  id_estudiante,
                                  huella,
                                  mano,
                                  dedo
                                FROM admon.estudiantes_huellas eh
                                where eh.id_estudiante = :id";


                cmd = new SqlCommand(sql, psConnection);
                cmd.Parameters.AddWithValue("id", pEstudianteId);
                SqlDataAdapter adat1 = new SqlDataAdapter(cmd);
                if (dtHuellasCollection == null)
                    dtHuellasCollection = new dsDetalleHuellas();

                adat1.Fill(dtHuellasCollection.Huellas);

                dr = cmd.ExecuteReader();
                // Get query response
                if (dr.Read())
                {
                    getTemplate(dr);
                }

                dr.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
                dr.Close();
            }
            return tptBlob;
        }
        catch
        {
            return null;
        }
    }

    // Retorna data de la plantilla desde un SqlDataReader
    public TTemplate getTemplate(SqlDataReader rs)
    {
        long readedBytes;

        tptBlob._size = 0;
        // Reserva espacio

        //System.Byte[] temp = new System.Byte[
        //(int)GRConstants.GR_MAX_SIZE_TEMPLATE];

        //Obtiene los bytes
        //readedBytes = rs.GetBytes(4, 0, temp, 0, temp.Length);

        // Copia bytes a estructura
        //System.Array.Copy(temp, 0, tptBlob._tpt, 0, (int)readedBytes);

        //Configura el tamaño de la plantilla en bytes
        //tptBlob._size = (int)readedBytes;

        return tptBlob;
    }

    // Retorna data de la plantilla desde un SqlDataReader
    public TTemplate getTemplate(dsDetalleHuellas.HuellasRow pHuella)
    {
        //long readedBytes;

        tptBlob._size = 0;
        // Reserva espacio

        //System.Byte[] temp = new System.Byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];

        //System.Byte[] temp = new System.Byte[pHuella.plantilla_huella.Length];

        //temp = pHuella.huella;

        //tptBlob._tpt = temp;
        ////Configura el tamaño de la plantilla en bytes
        //tptBlob._size = temp.Length;

        return tptBlob;
    }

    // Retorn el codigo de huella desde un SqlDataReader
    public int getId(SqlDataReader rs)
    {
        return rs.GetInt32(0);
    }
}
