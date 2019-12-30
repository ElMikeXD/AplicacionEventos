using Eventos;
using Eventos.Entidades;
using Eventos.Logica;
using System;
using System.Collections.Generic;

namespace Eventos
{
    class Program
    {
        public static void Eventos()
        {
            string _cRutaArchivo = "../../ArchivoEventos/Eventos.txt"; 

            List<UnidadesTiempo> _lstUnidadesTiempo = new List<UnidadesTiempo>
            {
                new UnidadesTiempo { cUnidad = "Minutos", iValorSegundos = 60 },
                new UnidadesTiempo { cUnidad = "Horas", iValorSegundos = 3600 },
                new UnidadesTiempo { cUnidad = "Días", iValorSegundos = 86400 },
                new UnidadesTiempo { cUnidad = "Semanas", iValorSegundos = 604800 },
                new UnidadesTiempo { cUnidad = "Meses", iValorSegundos = 2592000 },
                new UnidadesTiempo { cUnidad = "Años", iValorSegundos = 31556900 }
            };

            ILector _LecturaArchivo = new LecturaTXT();
            IProcesador _procesadorDatos = new ProcesadorDatos();

            String[] _arrayEventos = _LecturaArchivo.ExtraerEventos(_cRutaArchivo);

            List<Evento> _lstEventos = _procesadorDatos.ProcesarDatos(_arrayEventos);

            IProcesadorBase _procesadorBase = new ProcesadorBase(new ClasificadorEvento(), new ClasificadorUnidadTiempo(), new Diferenciador(), new Visualizador());

            foreach (Evento Evento in _lstEventos)
            {
                _procesadorBase.ProcesarFechaEventos(Evento, _lstUnidadesTiempo);
            }
        }

        static void Main(string[] args)
        {
            Eventos();
            Console.ReadKey();
        }

    }
}
