using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
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
            Task<bool> task = Task.Run(() =>
            {
                try
                {
                    DataOperations dp = new DataOperations();
                    string pass = "OPjSn10Z1U";
                    string user_op = "ftp_normac";
                    string ftpUrl = "ftp://10.50.13.89";

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
                CajaDialogo.Error($"Error de conexión FTP \nContacte a su Proveedor de Software");
                return false; // Se agotó el tiempo de espera
            }
        }

    }
}
