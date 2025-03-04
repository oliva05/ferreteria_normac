using ACS.Classes;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    CajaDialogo.Information("Conexión exitosa: " + response.StatusDescription);
                }

                //using (Stream fileStream = File.OpenRead(pathFile))
                //using (Stream ftpStream = request.GetRequestStream())
                //{
                //    fileStream.CopyTo(ftpStream);
                //    Guardado = true;
                //}
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
                using (Stream fileStream = File.Create(pathDestination))
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
            }

        }

    }
}
