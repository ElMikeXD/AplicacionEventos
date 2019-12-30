using System;

namespace Eventos
{
    public interface IDiferenciador
    {
        TimeSpan Obtenerdiferecia(DateTime dtFechaEvento);
    }
}