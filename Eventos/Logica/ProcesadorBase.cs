using Eventos.Entidades;
using System;
using System.Collections.Generic;

namespace Eventos.Logica
{
    class ProcesadorBase : IProcesadorBase
    {
        private readonly IClasificadorEvento clasificadorEvento;
        private readonly IClasificadorUnidadTiempo clasificadorUnidadTiempo;
        private readonly IDiferenciador diferenciador;
        private readonly IVisualizarMensajes visualizarMensajes;

        public ProcesadorBase(IClasificadorEvento clasificadorEvento, IClasificadorUnidadTiempo clasificadorUnidadTiempo , IDiferenciador diferenciador, IVisualizarMensajes visualizarMensajes)
        {
            this.clasificadorEvento = clasificadorEvento;
            this.clasificadorUnidadTiempo = clasificadorUnidadTiempo;
            this.diferenciador = diferenciador;
            this.visualizarMensajes = visualizarMensajes;
        }

        public void ProcesarFechaEventos(IEvento Evento, List<UnidadesTiempo> lstTiempo)
        {
            TimeSpan dtDiferenciaTiempo = diferenciador.Obtenerdiferecia(Evento.dtFechaEvento); //Diferencia de la fecha

            string cTipoTiempo = clasificadorEvento.ClasificarEventos(Evento.dtFechaEvento); //Tiempo Pasado o Futuro

            string cUnidadTiempo = clasificadorUnidadTiempo.ClasificarTiempo(dtDiferenciaTiempo, lstTiempo); //Unidad de tiempo Minutos, Horas, Días, etc.

            visualizarMensajes.VisualizarResultado(Evento.cEvento, cTipoTiempo, cUnidadTiempo);
        }
    }
}
