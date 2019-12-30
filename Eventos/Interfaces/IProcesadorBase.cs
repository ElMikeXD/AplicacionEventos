using Eventos.Entidades;
using System;
using System.Collections.Generic;

namespace Eventos.Logica
{
    interface IProcesadorBase
    {
       void ProcesarFechaEventos(IEvento Evento, List<UnidadesTiempo> lstTiempo);
    } 
}