using System;

namespace Eventos
{
    public class Horas: IRangoTiempo
    {
        public string ObtenerDiferenciaTiempo(TimeSpan dtDiferenciaFecha)
        {
            return Math.Abs(dtDiferenciaFecha.Hours) + " Horas";
        }
    }
}
