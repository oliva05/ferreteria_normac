using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO
{
    public class GrupoUser
    {
        /// <summary>
        /// Enumerador de los grupos disponibles para el usuario.
        /// </summary>
        public enum GrupoUsuario
        {
            //Montacarga = 0,
            Logistica = 1,
            Administradores = 2,
            RRHH = 3,
            Contabilidad = 4,
            Facturacion_Admin = 5,
            Facturacion_EndUser = 6
        }

        public GrupoUsuario GrupoUsuarioActivo;

        /// <summary>
        /// Constructor
        /// </summary>
        public GrupoUser()
        {
            GrupoUsuarioActivo = GrupoUsuario.Administradores;
        }
    }
}
