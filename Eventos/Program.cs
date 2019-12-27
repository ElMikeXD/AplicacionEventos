using System;
using System.Collections.Generic;

namespace Eventos
{
    class Program
    {
        public static void Eventos()
        {
            Minutos _oMinutos = new Minutos();
            Horas _oHoras = new Horas();
            Dias _oDias = new Dias();
            Meses _oMeses = new Meses();

            Diferenciador _oDiferenciador = new Diferenciador();

            Visualizador _oVisualizador = new Visualizador();

            LecturaTXT _oLectuta = new LecturaTXT();

            List<Evento> _lstEventos = _oLectuta.ExtraerEventos(@"C:\Users\ELMike\Desktop\Enventos.txt");

            foreach (Evento e in _lstEventos)
            {
                TimeSpan _dtDiferenciaFechas = _oDiferenciador.Obtenerdiferecia(e.dtFechaEvento);

                string _cClasificacionEvento = ClasificadorEvento.ClasificarEventos(e.dtFechaEvento);

                switch (ClasificadorTiempo.ClasificarTiempo(_dtDiferenciaFechas))
                {
                    case "Segundos":
                        break;

                    case "Minutos":
                        _oVisualizador.VisualizarResultado(e.cEvento, _cClasificacionEvento, _oMinutos.ObtenerDiferenciaTiempo(_dtDiferenciaFechas)); 
                        break;

                    case "Horas":
                        _oVisualizador.VisualizarResultado(e.cEvento, _cClasificacionEvento, _oHoras.ObtenerDiferenciaTiempo(_dtDiferenciaFechas));
                        break;

                    case "Días":
                        _oVisualizador.VisualizarResultado(e.cEvento, _cClasificacionEvento, _oDias.ObtenerDiferenciaTiempo(_dtDiferenciaFechas));
                        break;

                    case "Meses":
                        _oVisualizador.VisualizarResultado(e.cEvento, _cClasificacionEvento, _oMeses.ObtenerDiferenciaTiempo(_dtDiferenciaFechas));
                        break;

                    default:
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Eventos();
            Console.ReadKey();
        }

    }
}
