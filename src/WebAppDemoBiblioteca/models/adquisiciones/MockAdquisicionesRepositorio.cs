using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDemoBiblioteca.models.adquisiciones
{
    public class MockAdquisicionesRepositorio : IAdquisionesRepositorio
    {
        private readonly IDonacionesRepositorio _DonacionesRepositorio = new MockDonacionesRepositorio();

        public IEnumerable<Adquisiciones> Adquisiciones
        {
            get
            {
                return new List<Adquisiciones>
                {
                    new Adquisiciones {CodigoAdquisicion = 1, CodigoProveedor = 1, CodigoUsuario = 1, TipoAdquisicion = "compra", Cantidad = 50, Costo = 250, PagoTotal = 250, FechaLimitePago = 09/09/2018, Estado = "pendiente",  FechaAdquisicion = 09/04/2018, Comprobante = 1, Observacion = "ninguna"},
                    new Adquisiciones {CodigoAdquisicion = 2, CodigoProveedor = 2, CodigoUsuario = 2, TipoAdquisicion = "compra", Cantidad = 25, Costo = 150, PagoTotal = 25, FechaLimitePago = 09/09/2018, Estado = "pendiente", FechaAdquisicion = 09/04/2018, Comprobante = 2, Observacion = "ninguna"},
                    new Adquisiciones {CodigoAdquisicion = 3, CodigoProveedor = 3, CodigoUsuario = 3, TipoAdquisicion = "compra", Cantidad = 40, Costo = 90, PagoTotal = 40, FechaLimitePago = 09/09/2018, Estado = "pendiente", FechaAdquisicion = 09/04/2018, Comprobante = 3, Observacion = "ninguna"},
                    new Adquisiciones {CodigoAdquisicion = 4, CodigoProveedor = 4, CodigoUsuario = 4, TipoAdquisicion = "compra", Cantidad = 5, Costo = 85, PagoTotal = 85, FechaLimitePago = 09/09/2018, Estado = "pendiente", FechaAdquisicion = 09/04/2018, Comprobante = 4, Observacion = "ninguna"},
                    new Adquisiciones {CodigoAdquisicion = 5, CodigoProveedor = 5, CodigoUsuario = 5, TipoAdquisicion = "compra", Cantidad = 9, Costo = 90, PagoTotal = 90, FechaLimitePago = 09/09/2018, Estado = "pendiente", FechaAdquisicion = 09/04/2018, Comprobante = 5, Observacion = "ninguna" }
                   
                };
            }//fin del get
        }//fin de IEnumerable Libros

        public IEnumerable<Adquisiciones> AdquisicionesRecientes { get; }

        public IEnumerable<Adquisiciones> AdquisicionesReciente
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public Adquisiciones GetAdquisicionesPorCodigo(int CodigoAdquisicion)
        {
            throw new System.NotImplementedException();
        }
    }//fin del public class
}