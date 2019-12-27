using System;

namespace Eventos
{
    public class Dias : IRangoTiempo
    {
        public string ObtenerDiferenciaTiempo(TimeSpan dtDiferenciaFecha)
        {
            return Math.Abs(dtDiferenciaFecha.Days) + " Días";
        }
    }
}
