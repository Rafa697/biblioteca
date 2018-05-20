using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.adquisiciones
{
    public class Adquisiciones
    {
        public int CodigoAdquisicion { get; set; }

        public int CodigoProveedor { get; set; }

        public int CodigoUsuario { get; set; }

        public string TipoAdquisicion { get; set; }

        public int Cantidad { get; set; }

        public double Costo { get; set; }

        public double PagoTotal { get; set; }

        public DateTimeKind FechaLimitePago { get; set; }

        public string Estado { get; set; }

        public DateTimeKind FechaAdquisicion { get; set; }

        public int Comprobante { get; set; }

        public string Observacion { get; set; }


        public virtual Donacion Donacion { get; set; }

    }
}
