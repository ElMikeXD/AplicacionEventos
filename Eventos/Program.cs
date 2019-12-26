using System;
using System.Collections.Generic;

namespace Eventos
{
    class Program
    {
        static List<Evento> lstEventos = new List<Evento>();  

        public static void Lector()
        {
            string[] cEventos = System.IO.File.ReadAllLines(@"C:\Users\ELMike\Desktop\Enventos.txt");

            System.Console.WriteLine("Evento: ");

            string[] cadena;

            foreach (string evento in cEventos)
            {
                cadena = evento.Split(',');

                //DateTime dtFecha = Convert.ToDateTime(cadena[1]);

                string FormatoFecha = String.Format("{0:MM/dd/yyyy}", cadena[1]);

                lstEventos.Add( new Evento { cEvento = cadena[0], dtFechaEvento = Convert.ToDateTime(cadena[1])});
                
                Console.WriteLine("Evento: {0}  Fecha: {1}", cadena[0], cadena[1]);               
            }

            Console.WriteLine("\t-------------------");

            foreach (Evento e in lstEventos)
            {
                ObtenerTiempo(e.cEvento, e.dtFechaEvento);
                Console.WriteLine("\n----------------------");
            }

            Console.ReadKey();
        }

        public static string ObtenerTiempo(string cEvento, DateTime dtFechaEvento)
        {
            string cMensaje;

            string cResult;

            TimeSpan dtDiferenciaFechas = (DateTime.Now - dtFechaEvento);

            cResult = ValidarFecha(dtDiferenciaFechas);

            if (dtFechaEvento >= DateTime.Now)
            {
                cMensaje = "faltan";
            }
            else
            {
                cMensaje = "faltan";
            }

            return cMensaje;
        }

        public static string ValidarFecha(TimeSpan dtDiferenciaFechas)
        {
            string cMensaje;

            if (dtDiferenciaFechas.TotalSeconds >= 60)
            {
                cMensaje = dtDiferenciaFechas.Minutes + " Minutos";
            }
            if (dtDiferenciaFechas.TotalSeconds >= 3600)
            {
                cMensaje = dtDiferenciaFechas.Hours + " Horas";
            }
            if (dtDiferenciaFechas.TotalSeconds >= 86400)
            {
                cMensaje = dtDiferenciaFechas.Days + " Días";
            }
            if (dtDiferenciaFechas.TotalSeconds >= 2592000)
            {
                cMensaje = "1 Mes";
            }
            else
            {
                cMensaje = dtDiferenciaFechas.Seconds + " Segundos";
            }

            return cMensaje;
        }

        static void Main(string[] args)
        {
            Lector();
        }

    }
}
