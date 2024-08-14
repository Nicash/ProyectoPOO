using AccesoDatos;
using Entidades;

namespace Negocio
{
    public class Logica
    {
        public static List<Equipo> ListaEquipos = new List<Equipo>();
        public static List<Jugador> ListaJugadores = new List<Jugador>();
        public static List<DirectorTecnico> ListaDT = new List<DirectorTecnico>();
        public static List<Arbitro> ListaArbitros = new List<Arbitro>();

        public static void Iniciar()
        {
            CargarDatos();
        }

        public static void CargarDatos()
        {
            CargarJSON cargarJSON = new CargarJSON();

            ListaEquipos = cargarJSON.Cargar<List<Equipo>>("equipos");
            ListaJugadores = cargarJSON.Cargar<List<Jugador>>("jugadores");
            ListaDT = cargarJSON.Cargar<List<DirectorTecnico>>("dts");
            ListaArbitros = cargarJSON.Cargar<List<Arbitro>>("arbitros");
        }

        public static void GuardarDatos()
        {
            EscribirJSON escribirJSON = new EscribirJSON();

            escribirJSON.Guardar("equipos", ListaEquipos);
            escribirJSON.Guardar("jugadores", ListaJugadores);
            escribirJSON.Guardar("dts", ListaDT);
            escribirJSON.Guardar("arbitros", ListaArbitros);

        }

        public static string ObtenerNombreDT (int dni)
                    {
            foreach (DirectorTecnico dt in ListaDT)
            {
                if (dt.DNI == dni)
                {
                    return dt.Nombre + " " + dt.Apellido;
                }
            }
            return "No encontrado";
        }
    }
}
