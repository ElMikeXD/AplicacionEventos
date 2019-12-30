namespace Eventos
{
    public class LecturaTXT : ILector
    {
        public string[] ExtraerEventos(string cRutaArchivo)
        {
            string[] _cEventos = System.IO.File.ReadAllLines(cRutaArchivo);

            return _cEventos;
        }
    }
}
