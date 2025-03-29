using ACS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    internal class Marcas
    {
        public class PT_Marca
        {
            public int IdMarca { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string PaisOrigen { get; set; }
            public string SitioWeb { get; set; }
            public bool Estado { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaActualizacion { get; set; }
            public string UserCreate { get; set; }
            public string UserModi { get; set; }
        }

        public bool RecuperarRegistros(int pIdMarca)
        {
            bool Recuperar = false;


            try
            {

            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }
    }
}
