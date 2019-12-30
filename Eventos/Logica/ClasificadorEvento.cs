 using System;

namespace Eventos
{
    public class ClasificadorEvento : IClasificadorEvento
    {
        public string ClasificarEventos(DateTime dtFechaEvento)
        {
            return dtFechaEvento < DateTime.Now ? "ocurrió hace" : "ocurrirá dentro de";
        }
    }
}
