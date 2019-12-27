using System;
using System.Collections.Generic;

namespace Eventos
{
    public static class ClasificadorTiempo
    {
        public static string ClasificarTiempo(TimeSpan dtDiferenciaFechas)
        {
            string _cTiempo = "Segundos";

            List<Tiempo> _lstTiempo = new List<Tiempo>();

            _lstTiempo.Add(new Tiempo { cNombre = "Minutos", iValorSegundos = 60 });
            _lstTiempo.Add(new Tiempo { cNombre = "Horas", iValorSegundos = 3600 });
            _lstTiempo.Add(new Tiempo { cNombre = "Días", iValorSegundos = 86400 });
            _lstTiempo.Add(new Tiempo { cNombre = "Meses", iValorSegundos = 2592000 });

            foreach (Tiempo t in _lstTiempo)
            {
                if (dtDiferenciaFechas.TotalSeconds > t.iValorSegundos)
                {
                    _cTiempo = t.cNombre;
                }
            }

            return _cTiempo;
        }
    }
}
