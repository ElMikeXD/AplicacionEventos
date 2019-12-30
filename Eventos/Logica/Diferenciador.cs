using System;

namespace Eventos
{
    public class Diferenciador : IDiferenciador
    {
        public TimeSpan Obtenerdiferecia(DateTime dtFechaEvento)
        {
            TimeSpan dtDiferenciaFechas = (DateTime.Now - dtFechaEvento);

            return dtDiferenciaFechas;
        }
    }
}
