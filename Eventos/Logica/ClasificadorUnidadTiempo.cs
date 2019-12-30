using Eventos.Entidades;
using System;
using System.Collections.Generic;

namespace Eventos
{
    public class ClasificadorUnidadTiempo : IClasificadorUnidadTiempo
    {
        public string ClasificarTiempo(TimeSpan dtDiferenciaFechas, List<UnidadesTiempo> lstTiempo)
        {
            string _cTiempo = "Segundos";

            foreach (UnidadesTiempo t in lstTiempo)
            {
                if (Math.Abs(dtDiferenciaFechas.TotalSeconds) > t.iValorSegundos)
                {                    
                    _cTiempo = Convert.ToInt32(Math.Abs(dtDiferenciaFechas.TotalSeconds) / t.iValorSegundos) + " " + t.cUnidad;
                }
            }

            return _cTiempo;
        }
    }
}
