using System;

namespace Eventos
{
    public static class ClasificadorEvento
    {
        public  static string ClasificarEventos(DateTime dtFechaEvento)
        {
            return dtFechaEvento <= DateTime.Now ? "ocurrió hace" : "ocurrirá dentro de";
        }
    }
}
