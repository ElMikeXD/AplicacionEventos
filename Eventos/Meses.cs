using System;

namespace Eventos
{
    class Meses : IRangoTiempo
    {
        public string ObtenerDiferenciaTiempo(TimeSpan dtDiferenciaFecha)
        {
            double _iMeses = Math.Abs(dtDiferenciaFecha.TotalSeconds) / 2592000;

            return Convert.ToInt32(_iMeses) + " Meses";
        }
    }
}
