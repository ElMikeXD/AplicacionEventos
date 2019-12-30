using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    interface IProcesador
    {
        List<Evento> ProcesarDatos(string[] cEventos);
    }
}
