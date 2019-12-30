using System;

namespace Eventos
{
    public interface IEvento
    {
        string cEvento { get; set; }
        DateTime dtFechaEvento { get; set; }
    }
}