using System;
using System.Collections.Generic;
using System.Globalization;

namespace Eventos
{
    public class LecturaTXT : ILector
    {
        public List<Evento> ExtraerEventos(string cRutaArchivo)
        {
            List<Evento> _lstEventos = new List<Evento>();

            string[] _cEventos = System.IO.File.ReadAllLines(cRutaArchivo);

            foreach (string evento in _cEventos)
            {
                _cEventos = evento.Split(',');

                DateTime _dtFechaIngles = DateTime.ParseExact(_cEventos[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                _lstEventos.Add(new Evento { cEvento = _cEventos[0], dtFechaEvento = _dtFechaIngles });

            }

            return _lstEventos;
        }
    }
}
