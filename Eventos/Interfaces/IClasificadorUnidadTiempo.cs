using Eventos.Entidades;
using System;
using System.Collections.Generic;

namespace Eventos
{
    public interface IClasificadorUnidadTiempo
    {
        string ClasificarTiempo(TimeSpan dtDiferenciaFechas, List<UnidadesTiempo> lstTiempo);
    }
}