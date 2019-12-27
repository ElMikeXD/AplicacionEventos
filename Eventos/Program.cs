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

        public static string ObtenerTiempo(DateTime dtFechaEvento)
        {
            string cMensaje;

            string cResult;

            TimeSpan dtDiferenciaFechas = (DateTime.Now - dtFechaEvento);

            cResult = ValidarFecha(dtDiferenciaFechas);

            if (dtFechaEvento >= DateTime.Now) //pasar a clase
            { 
                cMensaje = "Faltan ";
            }
            else
            {
                cMensaje = "Fue hace ";
            }

            return cMensaje + cResult;
        }

        public static string ValidarFecha(TimeSpan dtDiferenciaFechas)
        {
            string cMensaje = Math.Abs(dtDiferenciaFechas.Seconds) + " Segundos";

            if (Math.Abs(dtDiferenciaFechas.TotalSeconds) >= 60)
            {
                cMensaje = Math.Abs(dtDiferenciaFechas.Minutes) + " Minutos";
            }
            if (Math.Abs(dtDiferenciaFechas.TotalSeconds) >= 3600)
            {
                cMensaje = Math.Abs(dtDiferenciaFechas.Hours) + " Horas";
            }
            if (Math.Abs(dtDiferenciaFechas.TotalSeconds) >= 86400)
            {
                cMensaje = Math.Abs(dtDiferenciaFechas.Days) + " Días";
            }
            if (Math.Abs(dtDiferenciaFechas.TotalSeconds) >= 2592000)
            {
                double iMeses = Math.Abs(dtDiferenciaFechas.TotalSeconds) / 2592000;
                cMensaje = Convert.ToInt32(iMeses) + " Mes";
            }

            return cMensaje;
        }

        static void Main(string[] args)
        {
            Eventos();
            Console.ReadKey();
        }

    }
}
