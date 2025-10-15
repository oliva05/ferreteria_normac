/*
 -------------------------------------------------------------------------------
 GrFinger Sample
 (c) 2005 - 2010 Griaule Biometrics Ltda.
 http://www.griaulebiometrics.com
 -------------------------------------------------------------------------------

 This sample is provided with "GrFinger Fingerprint Recognition Library" and
 can't run without it. It's provided just as an example of using GrFinger
 Fingerprint Recognition Library and should not be used as basis for any
 commercial product.

 Griaule Biometrics makes no representations concerning either the merchantability
 of this software or the suitability of this sample for any particular purpose.

 THIS SAMPLE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
 IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 IN NO EVENT SHALL GRIAULE BE LIABLE FOR ANY DIRECT, INDIRECT,
 INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 You can download the trial version of GrFinger directly from Griaule website.
                                                                   
 These notices must be retained in any copies of any part of this
 documentation and/or sample.

 -------------------------------------------------------------------------------
*/

// -----------------------------------------------------------------------------------
// Support and fingerprint management routines
// -----------------------------------------------------------------------------------

using GrFingerXLib;
using System;
using System.Drawing;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using core.Clases.Huellas;
using AxGrFingerXLib;
//using Planillass.Clases;
//using Planillass.Huella_Digital;
//using Allas.Core.Huella_Digital;
//using Planillass.Clases;

// Raw image data type.
//public struct TRawImage
//{
//    // Image data.
//    public object img;
//    // Image width.
//    public int width;
//    // Image height.
//    public int height;
//    // Image resolution.
//    public int Res;
//};

public class Util2
{

    // Some constants to make our code cleaner
    public const int ERR_CANT_OPEN_BD = -999;
    public const int ERR_INVALID_ID = -998;
    public const int ERR_INVALID_TEMPLATE = -997;

    public bool MantenimientoDeHuellas = false;

    string sSucursal;

    // -----------------------------------------------------------------------------------
    // Support functions
    // -----------------------------------------------------------------------------------

    // This class creates an Util class with some functions
    // to help us to develop our GrFinger Application
    public Util2(ListBox lbLog, PictureBox pbPic,
        Button btEnroll, Button btnExtract, Button btIdentify, Button btVerify,
        CheckBox cbAutoExtract, CheckBox cbAutoIdentify, string pSucursal)
    {
        _lbLog = lbLog;
        _pbPic = pbPic;
        _btEnroll = btEnroll;
        _btExtract = btnExtract;
        _btIdentify = btIdentify;
        _btVerify = btVerify;
        _cbAutoExtract = cbAutoExtract;
        _cbAutoIdentify = cbAutoIdentify;
        _DB = null;
        _tpt = null;
        _consolidatedTpt = null;
        sSucursal = pSucursal;
    }

    ~Util2()
    {
        WriteLog("Apagando Lectura de Huellas...");
        FinalizeUtil();
    }

    //  Write a message in log box.
    public void WriteLog(String msg)
    {
        _lbLog.Items.Add(msg);
        _lbLog.SelectedIndex = _lbLog.Items.Count - 1;
        _lbLog.ClearSelected();
    }

    // Write and describe an error.
    public void WriteError(GrFingerXLib.GRConstants errorCode)
    {
        switch ((int)errorCode)
        {
            case (int)GRConstants.GR_ERROR_INITIALIZE_FAIL:
                WriteLog("Intento fallido por inicial la aplicación de registro de huellas. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_NOT_INITIALIZED:
                WriteLog("La libreria de la aplicación de registro de huella no esta inicializada. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_FAIL_LICENSE_READ:
                WriteLog("Licencia no encontrada. Ver manual para resolver este problema. (Error:" + errorCode + ")");
                MessageBox.Show("Licencia no encontrada. Ver manual para resolver este problema.");
                return;
            case (int)GRConstants.GR_ERROR_NO_VALID_LICENSE:
                WriteLog("La licencia no es valida. Ver manual para resolver este problema. (Error:" + errorCode + ")");
                MessageBox.Show("La licencia no es valida. Ver manual para resolver este problema.");
                return;
            case (int)GRConstants.GR_ERROR_NULL_ARGUMENT:
                WriteLog("El parametro tiene un valor nulo. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_FAIL:
                WriteLog("Intento fallido en crear un objeto GDI. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_ALLOC:
                WriteLog("Intento fallido al crear un contexto. No se puede reservar memoria. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_PARAMETERS:
                WriteLog("Uno ó mas parametros estan fuera del limite. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_WRONG_USE:
                WriteLog("Esta función no puede ser llamada en este momento. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_EXTRACT:
                WriteLog("Intento fallido al extraer la planilla. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_SIZE_OFF_RANGE:
                WriteLog("La imagen es demasiado grande ó es demasiado pequeña.  (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_RES_OFF_RANGE:
                WriteLog("La imagen tiene muy baja ó muy alta resolución. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_CONTEXT_NOT_CREATED:
                WriteLog("No se pudo crear el contexto.. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_INVALID_CONTEXT:
                WriteLog("El contexto no existe. (Error:" + errorCode + ")");
                return;
            // Capture error codes
            case (int)GRConstants.GR_ERROR_CONNECT_SENSOR:
                WriteLog("Error mientrar se realizaba la conexión con el sensor. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_CAPTURING:
                WriteLog("Error mientras se capturaba desde el sensor. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_CANCEL_CAPTURING:
                WriteLog("Error mientras se trataba de detener la captura desde el sensor. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_INVALID_ID_SENSOR:
                WriteLog("El ID del sensor es inválido. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_SENSOR_NOT_CAPTURING:
                WriteLog("El sensor no esta capturando. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_INVALID_EXT:
                WriteLog("El archivo tiene una extensión desconocida. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_INVALID_FILENAME:
                WriteLog("El nombre del archivo es inválido. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_INVALID_FILETYPE:
                WriteLog("El tipo de archivo es invalido. (Error:" + errorCode + ")");
                return;
            case (int)GRConstants.GR_ERROR_SENSOR:
                WriteLog("El sensor devolvio un error. (Error:" + errorCode + ")");
                return;
            // Our error codes
            case ERR_INVALID_TEMPLATE:
                WriteLog("Plantilla Invalida. (Error:" + errorCode + ")");
                return;
            case ERR_INVALID_ID:
                WriteLog("Codigo Invalida. (Error:" + errorCode + ")");
                return;
            case ERR_CANT_OPEN_BD:
                WriteLog("No se puede conectar con la base de datos. (Error:" + errorCode + ")");
                return;

            default:
                WriteLog("Error:" + errorCode);
                return;
        }
    }

    // Check if we have a valid template
    private bool TemplateIsValid()
    {
        // Check the template size and data
        return ((_tpt._size > 0) && (_tpt._tpt != null));
    }

    // Check if we have a valid template
    private bool ConsolidatedTemplateIsValid()
    {
        // Check the template size and data
        return ((_consolidatedTpt._size > 0) && (_consolidatedTpt._tpt != null));
    }

    // -----------------------------------------------------------------------------------
    // Main functions for fingerprint recognition management
    // -----------------------------------------------------------------------------------

    // Initializes GrFinger ActiveX and all necessary utilities.
    public int InitializeGrFinger(AxGrFingerXLib.AxGrFingerXCtrl grfingerx)
    {
        GRConstants result;
        _DB = new DBClass();

        _grfingerx = grfingerx;

        ///Ver el estado de la conexion de la base de datos
        try
        {
            //if (psConnection.State != System.Data.ConnectionState.Open)
            //    psConnection.Open();

            //_DB.PGConexion = psConnection;

            dsDetalleHuellas = _DB.getTemplates();
        }
        catch (Exception exc)
        {
            return ERR_CANT_OPEN_BD;
        }

        //Create a new Template
        if (_tpt == null)
            _tpt = new TTemplate();

        //Create a new consolidated template
        if (_consolidatedTpt == null)
            _consolidatedTpt = new TTemplate();

        //Create a new raw image
        _raw = new TRawImage();

        //Initialize library
        result = (GRConstants)_grfingerx.Initialize();
        if (result < 0)
        {
            //return (int)result;
        }

        return (int)_grfingerx.CapInitialize();
    }

    // Initializes GrFinger ActiveX and all necessary utilities.
    public int InitializeGrFinger(AxGrFingerXCtrl grfingerx, dsDetalleHuellas pDetalleHuellas)
    {
        GRConstants result;
        _DB = new DBClass();

        _grfingerx = grfingerx;

        ///Ver el estado de la conexion de la base de datos
        try
        {
   
            dsDetalleHuellas = pDetalleHuellas;  // _DB.getTemplates(sSucursal);

            if (dsDetalleHuellas.Huellas.Rows.Count == 0)
            {
                dsDetalleHuellas = _DB.getTemplates();
            }
        }
        catch (Exception exc)
        {
            return ERR_CANT_OPEN_BD;
        }

        //Create a new Template
        if (_tpt == null)
            _tpt = new TTemplate();

        //Create a new consolidated template
        if (_consolidatedTpt == null)
            _consolidatedTpt = new TTemplate();

        //Create a new raw image
        _raw = new TRawImage();

        //Initialize library
        result = (GRConstants)_grfingerx.Initialize();
        if (result < 0)
        {
            return (int)result;
        }

        return (int)_grfingerx.CapInitialize();
    }

    //  Finalizes library and close DB.
    public void FinalizeUtil()
    {
        // finalize library
        try
        {
            _grfingerx.Finalize();
        }
        catch (Exception exc) { WriteLog(exc.Message); }

        try
        {
            _grfingerx.CapFinalize();
        }
        catch (Exception exc) { WriteLog(exc.Message); }

        // close DB
        //if (_DB != null)
        //    _DB.closeDB();
        _raw.img = null;
        _tpt = null;
        _consolidatedTpt = null;
        _DB = null;
    }

    // Display fingerprint image on screen
    public void PrintBiometricDisplay(bool isBiometric, GrFingerXLib.GRConstants contextId)
    {
        // handle to finger image
        System.Drawing.Image handle = null;
        // screen HDC
        IntPtr hdc = GetDC(System.IntPtr.Zero);

        if (isBiometric)
        {
            // get image with biometric info
            _grfingerx.BiometricDisplay(ref _tpt._tpt,
                ref _raw.img, _raw.width, _raw.height, _raw.Res, hdc.ToInt32(),
                ref handle, (int)contextId);
        }
        else
        {
            // get raw image
            _grfingerx.CapRawImageToHandle(ref _raw.img, _raw.width,
                _raw.height, hdc.ToInt32(), ref handle);
        }

        // draw image on picture box
        if (handle != null)
        {
            _pbPic.Image = handle;
            _pbPic.Update();
        }

        // release screen HDC
        ReleaseDC(System.IntPtr.Zero, hdc);
    }

    // Add a consolidated fingerprint template to database
    public int Enroll()
    {
        int id = 0;
        // Checks if template is valid.
        if (ConsolidatedTemplateIsValid())
        {
            // Adds template to database and returns template ID.
            _DB.addTemplate(_consolidatedTpt, ref id);
            return id;
        }
        else
        {
            return -1;
        }
    }

    // Extract a fingerprint template from current image
    public int ExtractTemplate()
    {
        int result;

        // set current buffer size for the extract template
        _tpt._size = (int)GRConstants.GR_MAX_SIZE_TEMPLATE;
        result = (int)_grfingerx.Extract(
            ref _raw.img, _raw.width, _raw.height, _raw.Res,
            ref _tpt._tpt, ref _tpt._size,
            (int)GRConstants.GR_DEFAULT_CONTEXT);
        // if error, set template size to 0
        if (result < 0)
        {
            // Result < 0 => extraction problem
            _tpt._size = 0;
        }
        return result;
    }

    dsDetalleHuellas dsDetalleHuellas = new dsDetalleHuellas();

    // Identify current fingerprint on our database
    public int Identify(ref int score)
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
        if (MantenimientoDeHuellas)
            dsDetalleHuellas = _DB.getTemplates();

        foreach (dsDetalleHuellas.HuellasRow huella in dsDetalleHuellas.Huellas.Rows)
        {
            // Getting current template from recordset.
            tptRef = _DB.getTemplate(huella);

            // Comparing current template.
            result = (GRConstants)_grfingerx.Identify(ref tptRef._tpt, ref score, (int)GRConstants.GR_DEFAULT_CONTEXT);

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

    // Check current fingerprint against another one in our database
    public int Verify(int id, ref int score)
    {
        TTemplate tptRef;

        // Checking if template is valid.
        if (!TemplateIsValid()) return ERR_INVALID_TEMPLATE;

        // Getting template with the supplied ID from database.
        tptRef = _DB.getTemplate(id);

        // Checking if ID was found.
        if ((tptRef._tpt == null) || (tptRef._size == 0))
        {
            return ERR_INVALID_ID;
        }

        // Comparing templates.
        return (int)_grfingerx.Verify(ref _tpt._tpt, ref tptRef._tpt,
            ref score, (int)GRConstants.GR_DEFAULT_CONTEXT);
    }

    // Show GrFinger version and type
    public void MessageVersion()
    {
        byte majorVersion = 0, minorVersion = 0;
        GRConstants result;
        string vStr = "";

        result = (GRConstants)_grfingerx.GetGrFingerVersion(ref majorVersion,
            ref minorVersion);
        if (result == GRConstants.GRFINGER_FULL)
            vStr = "Completa";
        else if (result == GRConstants.GRFINGER_LIGHT)
            vStr = "Liviana";
        MessageBox.Show("La versión del DLL GrFinger es " +
            majorVersion + "." + minorVersion + ". \n" +
            "El tipo de licencia es  '" + vStr + "'.", "GrFinger Version");
    }

    // start enroll
    public int StartEnroll()
    {
        int ret = _grfingerx.StartEnroll((int)GRConstants.GR_DEFAULT_CONTEXT);
        return ret;

    }

    // consolidate template
    public int Consolidate()
    {
        int result;
        int qual;

        // set current buffer size for the extract template
        _consolidatedTpt._size = (int)GRConstants.GR_MAX_SIZE_TEMPLATE;
        result = (int)_grfingerx.Enroll(
            ref _raw.img, _raw.width, _raw.height, _raw.Res,
            ref _consolidatedTpt._tpt, ref _consolidatedTpt._size, out qual, (int)GRConstants.GR_FORMAT_DEFAULT,
            (int)GRConstants.GR_DEFAULT_CONTEXT);
        // if error, set template size to 0
        if (result < 0)
        {
            // Result < 0 => enroll problem
            _consolidatedTpt._size = 0;
        }
        return result;
    }

    //Importing necessary HDC functions
    [DllImport("user32.dll", EntryPoint = "GetDC")]
    public static extern IntPtr GetDC(IntPtr ptr);

    [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
    public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

    // Database class.
    public DBClass _DB;
    // The last acquired image.
    public TRawImage _raw;
    // Reference to main form Image.
    public PictureBox _pbPic;
    // An enrollment process was started
    public bool _isEnrolling;
    // Number of consolidated templates
    public int _numberOfConsolidated;

    // The template extracted from last acquired image.
    private TTemplate _tpt;
    // The consolidated template.
    private TTemplate _consolidatedTpt;
    // Reference to main form log.
    private ListBox _lbLog;
    //references Main form Auto Extract Check Box
    private CheckBox _cbAutoExtract;
    //references Main form Auto Identify Check Box
    private CheckBox _cbAutoIdentify;
    //references Main form enroll button
    Button _btEnroll;
    //references Main form extract button
    Button _btExtract;
    //references Main form identify button
    Button _btIdentify;
    //references Main form verify button
    Button _btVerify;
    // GrFingerX component
    public AxGrFingerXCtrl _grfingerx;

    //Empleado empleado;
    //Mano mano;
    //Dedo dedo;

    ///// <summary>
    ///// Funcion para configurar los miembros
    ///// </summary>
    ///// <param name="pempleado">Objeto Empleado</param>
    ///// <param name="pmano">Objeto Mano</param>
    ///// <param name="pdedo">Objeto Dedo</param>
    //public void ConfigurarDatos(Empleado pempleado, Mano pmano, Dedo pdedo)
    //{
    //    empleado = pempleado;
    //    mano = pmano;
    //    dedo = pdedo;
    //    _DB.empleado = pempleado;
    //    _DB.mano = pmano;
    //    _DB.dedo = pdedo;
    //}
}
