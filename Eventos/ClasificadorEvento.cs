using System;

namespace Eventos
{
    public static class ClasificadorEvento
    {
        public  static bool ClasificarEventos(DateTime dtFechaEvento)
        {
            TimeSpan dtDiferenciaFechas = (DateTime.Now - dtFechaEvento);

            return dtFechaEvento > DateTime.Now ? true : false;
        }
    }
}
