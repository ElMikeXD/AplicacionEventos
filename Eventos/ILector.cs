using System.Collections.Generic;

namespace Eventos
{
    interface ILector
    {
        List<Evento> ExtraerEventos(string cRutaArchivo); 
    }
}
