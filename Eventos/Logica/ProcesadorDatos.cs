using System;
using System.Collections.Generic;
using System.Globalization;

namespace Eventos.Logica
{
    public class ProcesadorDatos : IProcesador
    {
        public List<Evento> ProcesarDatos(string[] cEventos)
        {
            List<Evento> _lstEventos = new List<Evento>();

            foreach (string evento in cEventos)
            {
                cEventos = evento.Split(',');

                DateTime _dtFechaIngles = DateTime.ParseExact(cEventos[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                _lstEventos.Add(new Evento { cEvento = cEventos[0], dtFechaEvento = _dtFechaIngles });

            }

            return _lstEventos;
        }
    }
}
