using System;

namespace Eventos
{
    public static class Diferenciador
    {
        public static TimeSpan ObtenerdifereciaFechas(DateTime dtFechaEvento)
        {
            TimeSpan dtDiferenciaFechas = (DateTime.Now - dtFechaEvento);

            return dtDiferenciaFechas;
        }
    }
}
