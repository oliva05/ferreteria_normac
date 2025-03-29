using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAGUAR_PRO.Clases;
using DevExpress.XtraBars.Ribbon;
using System.IO;

namespace JAGUAR_PRO.Mantenimientos.ProductoTerminado
{
    public partial class frmPT_VisorImagenes : DevExpress.XtraEditors.XtraForm
    {
        int IdPt = 0;
        DataTable dtImagenes = new DataTable();
        private GalleryItemGroup galleryGroup;
        public frmPT_VisorImagenes(int idPT)
        {
            InitializeComponent();
            IdPt = idPT;

            if (IdPt != 0) 
            {
                JAGUAR_PRO.Clases.ProductoTerminado pt = new Clases.ProductoTerminado();

                dtImagenes = pt.GetImagenesPT(IdPt);
                FTP_Class ftp = new FTP_Class();
                
                foreach (DataRow row in dtImagenes.Rows) 
                {
                    imageSlider.Images.Add(ftp.ShowImageFromFtp(row["path"].ToString()));
                }

                ////GALLERY CONTROL
                //foreach (DataRow row in dtImagenes.Rows)
                //{
                //    GalleryItem item = new GalleryItem
                //    {
                //        Image = ftp.ShowImageFromFtp(row["path"].ToString()),
                //        Caption = row["path"].ToString()
                //    };

                //    galleryControl.Gallery.Groups[0].Items.Add(item);

                //}




            }
        }
    }
}