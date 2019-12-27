using System;

namespace Eventos
{
    public class Minutos : IRangoTiempo
    {
        public string ObtenerDiferenciaTiempo(TimeSpan dtDiferenciaFecha)
        {
           return Math.Abs(dtDiferenciaFecha.Minutes) + " Minutos";
        }
    }
}
