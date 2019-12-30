using System;

namespace Eventos
{
    public class Evento : IEvento
    {
        public string cEvento { get; set; }
        public DateTime dtFechaEvento { get; set; }
    }
}
