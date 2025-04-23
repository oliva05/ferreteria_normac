using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace JAGUAR_PRO.Clases
{
    public class FTP_Class
    {
    
        public FTP_Class()
        {
            
        }

        public bool DownloadFileV2(string pathSource, string pathDestination, UserLogin pUsuarioLogeado, string file_name)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string localFilePath = Path.Combine(pathDestination, file_name);

                string pass = "Tempo1234";
                string user_op = "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // Obtener la respuesta del servidor FTP
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(localFilePath, FileMode.Create))
                {
                    // Copiar el archivo desde el stream de respuesta al archivo local
                    responseStream.CopyTo(fileStream);
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                CajaDialogo.Error("No se tiene acceso al archivo o carpeta: " + ex.Message);
                return false;

            }

            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
                return false;
            }
        }

        public void OpenFile(string pathSource, string pathDestination, UserLogin pUsuarioLogeado)
        {
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                string password = "";
                string puser = "";

                if (string.IsNullOrEmpty(pUsuarioLogeado.Password))
                {
                    
                    puser = dp.Password_UserFTPServer;//"Tempo1234";
                    password = dp.User_FTP_Server;//= "operador";
                }
                else
                {
                    puser = pUsuarioLogeado.AD_User;
                    password = pUsuarioLogeado.Password;
                }

                request.Credentials = new NetworkCredential(puser, password, "AQUAFEEDHN.COM");
                //request.Credentials = new NetworkCredential(UsuarioLogueado.AD_User, UsuarioLogueado.Password);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = System.IO.File.Create(pathDestination))
                {

                    ftpStream.CopyTo(fileStream);

                    Process.Start(pathDestination);

                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool GuardarArchivoRRHHExpediente(UserLogin pUsuarioLogeado, string pFileName, string pathFile)
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Normac_RRHH_Expedientes + pFileName);
                string pass = dp.Password_UserFTPServer;//"Tempo1234";
                string user_op = dp.User_FTP_Server;//= "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (Stream fileStream = System.IO.File.OpenRead(pathFile))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                    Guardado = true;
                }
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }

            return Guardado;
        }

        public bool GuardarArchivoRRHHEmpleado(UserLogin pUsuarioLogeado, string pFileName, string pathFile)
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();


                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Normac_Empleados + pFileName);
                string pass = dp.Password_UserFTPServer;//"Tempo1234";
                string user_op = dp.User_FTP_Server;//= "operador";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                request.Method = WebRequestMethods.Ftp.UploadFile;

                using (Stream fileStream = System.IO.File.OpenRead(pathFile))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                    Guardado = true;
                }
            }
            catch (Exception ec)
            {
                throw new Exception(ec.Message);
            }

            return Guardado;
        }

        public bool GuardarArchivo(UserLogin pUsuarioLogeado, string pFileName, string pathFile)
        {
            bool Guardado = false;
            try
            {
                DataOperations dp = new DataOperations();

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(dp.FTP_Normac_PT + pFileName);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                string pass =  "OPjSn10Z1U";
                string user_op = "ftp_normac";


                request.Credentials = new NetworkCredential(user_op, pass);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                //request.EnableSsl = false;
                request.UsePassive = false;  // Prueba cambiar a false si sigue fallando
                request.UseBinary = true;
                request.KeepAlive = false;

                using (Stream fileStream = System.IO.File.OpenRead(pathFile))
                using (Stream ftpStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(ftpStream);
                    Guardado = true;
                }
            }
            catch(Exception ec)
            {
                CajaDialogo.Error("Error de conexión FTP: " + ec.Message);
                //throw new Exception(ec.Message);
            }

            return Guardado;
        }

        public void DownloadFile(string pathSource, string pathDestination, UserLogin pUsuarioLogeado)
        {
            try
            {
                DataOperations dp = new DataOperations();
                string pass = "OPjSn10Z1U";
                string user_op = "ftp_normac";
                if (pUsuarioLogeado != null)
                {
                    if (!string.IsNullOrEmpty(pUsuarioLogeado.Pass))
                    {
                        user_op = pUsuarioLogeado.ADuser1;
                        pass = pUsuarioLogeado.Pass;
                    }
                }

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(pathSource);
                request.Credentials = new NetworkCredential(user_op, pass, "AQUAFEEDHN.COM");
                //request.Credentials = new NetworkCredential(user_op, pass);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = System.IO.File.Create(pathDestination))
                {
                    ftpStream.CopyTo(fileStream);
                }

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        public bool RemoveFile(string path_file)
        {
            string ftpServer = path_file;
            string pass = "OPjSn10Z1U";
            string user_op = "ftp_normac";

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpServer);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = new NetworkCredential(user_op, pass);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Console.WriteLine($"Archivo eliminado, status: {response.StatusDescription}");
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                CajaDialogo.Error(ex.Message);
            }

        }

        public Image ShowImageFromFtp(string url_ftp)
        {
            Image image = null;
            try
            {
                DataOperations dp = new DataOperations();
                string pass = "OPjSn10Z1U";
                string user_op = "ftp_normac";

                // Crear la solicitud FTP
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url_ftp);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // Especificar credenciales FTP
                request.Credentials = new NetworkCredential(user_op, pass);

                // Obtener la respuesta como un flujo (stream)
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                {
                    // Cargar la imagen en un PictureBox desde el stream
                    if (responseStream != null)
                    {
                        image = System.Drawing.Image.FromStream(responseStream);
                    }
                    Console.WriteLine("Imagen cargada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }

            return image;
        }

        public bool ValidateConnection()
        {
            bool Recuperado = false;
            Task<bool> task = Task.Run(() =>
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    string pass = "OPjSn10Z1U";
                    string user_op = "ftp_normac";
                    string ftpUrl = "ftp://192.168.21.50";

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpUrl);
                    request.Credentials = new NetworkCredential(user_op, pass);
                    request.Method = WebRequestMethods.Ftp.ListDirectory; // Comprobar si podemos listar archivos
                    //request.Timeout = 2000; // Timeout en milisegundos

                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        return response.StatusCode == FtpStatusCode.OpeningData // Si abre la conexión, es válida
                        || response.StatusCode == FtpStatusCode.DataAlreadyOpen
                        || response.StatusCode == FtpStatusCode.CommandOK;
                        
                    }
                    Recuperado = true;

                }
                catch (WebException ex)
                {
                    //CajaDialogo.Error($"Error de conexión FTP: {ex.Message}\nContacte a su Proveedor de Software");
                    return false; // Si hay error, la conexión no es válida
                }

                
            }
            );

            if (Task.WaitAny(task, Task.Delay(3000)) == 0) 
            {
                return task.Result;// La tarea terminó a tiempo
            }
            else
            {
                //CajaDialogo.Error($"Error de conexión FTP \nContacte a su Proveedor de Software");
                Recuperado = false; // Se agotó el tiempo de espera
            }

            return Recuperado;
        }

    }
}
