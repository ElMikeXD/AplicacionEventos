using System;
using System.Collections.Generic;
using System.Globalization;

namespace Eventos
{
    class Program
    {
        static List<Evento> lstEventos = new List<Evento>();  

        public static void Lector()
        {
            string[] cEventos = System.IO.File.ReadAllLines(@"C:\Users\ELMike\Desktop\Enventos.txt");

            string[] cadena;

            foreach (string evento in cEventos)
            {
                cadena = evento.Split(',');

                //string cFechaConvertida = DateTime.ParseExact(cadena[1], "dd-MM-yyyy", CultureInfo.InvariantCulture)
                //      .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);

                lstEventos.Add( new Evento { cEvento = cadena[0], dtFechaEvento = Convert.ToDateTime(cadena[1]) });
                
                Console.WriteLine("Evento: {0}  Fecha: {1}", cadena[0], cadena[1]);               
            }

            Console.WriteLine("-----------------------");

            foreach (Evento e in lstEventos)
            {
                Console.WriteLine(ObtenerTiempo(e.dtFechaEvento) + "\n----------------------");
            }

            Console.ReadKey();
        }

        public static string ObtenerTiempo(DateTime dtFechaEvento)
        {
            string cMensaje;

            string cResult;

            TimeSpan dtDiferenciaFechas = (DateTime.Now - dtFechaEvento);

            cResult = ValidarFecha(dtDiferenciaFechas);

            if (dtFechaEvento >= DateTime.Now)
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
            Lector();
        }

    }
}
