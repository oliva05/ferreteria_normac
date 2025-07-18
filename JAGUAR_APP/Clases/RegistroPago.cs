using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAGUAR_PRO.Clases
{
    public class RegistroPago
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Valor { get; set; }
        public int IdTipo { get; set; }
        public string TipoName { get; set; }
        public string Referencia { get; set; }
        public string NumeroCheque { get; set; }
        public string EmisorCheque { get; set; }
        public int id_banco { get; set; }
        public int id_cuenta { get; set; }
        public string CuentaBanco { get; set; }
        public RegistroPago() { }


    }
}
