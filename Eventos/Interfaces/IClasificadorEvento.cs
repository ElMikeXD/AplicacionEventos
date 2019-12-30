using System;

namespace Eventos
{
    public interface IClasificadorEvento
    {
        string ClasificarEventos(DateTime dtFechaEvento);
    }
}