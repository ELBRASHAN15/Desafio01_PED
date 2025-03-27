using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{

    public class Paciente
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string TipoSangre { get; set; }
        public string Presion { get; set; }

        public Paciente(string nombre, string genero, string tipoSangre, string presion)
        {
            Nombre = nombre;
            Genero = genero;
            TipoSangre = tipoSangre;
            Presion = presion;
        }
    }

    public class Arbol
    {
        public Dictionary<string, List<string>> Genero { get; set; }
        public Dictionary<string, List<string>> TipoSangre { get; set; }
        public Dictionary<string, List<string>> Presion { get; set; }

        public Arbol()
        {
            Genero = new Dictionary<string, List<string>>();
            TipoSangre = new Dictionary<string, List<string>>();
            Presion = new Dictionary<string, List<string>>();
        }
        public static class GestorPacientes
        {
            public static Arbol Arbol = new Arbol();
        }

        public void AgregarPaciente(Paciente paciente)
        {
            // Agregar al diccionario de Género
            if (!Genero.ContainsKey(paciente.Genero))
            {
                Genero[paciente.Genero] = new List<string>();
            }
            Genero[paciente.Genero].Add(paciente.Nombre);

            // Agregar al diccionario de Tipo de Sangre
            if (!TipoSangre.ContainsKey(paciente.TipoSangre))
            {
                TipoSangre[paciente.TipoSangre] = new List<string>();
            }
            TipoSangre[paciente.TipoSangre].Add(paciente.Nombre);

            // Agregar al diccionario de Presión
            if (!Presion.ContainsKey(paciente.Presion))
            {
                Presion[paciente.Presion] = new List<string>();
            }
            Presion[paciente.Presion].Add(paciente.Nombre);
        }

        public List<string> ObtenerPacientes(string genero = null, string tipoSangre = null, string presion = null)
        {
            // Listas de pacientes según cada filtro
            HashSet<string> pacientesGenero = (genero != null && Genero.ContainsKey(genero))
                                              ? new HashSet<string>(Genero[genero])
                                              : new HashSet<string>();

            HashSet<string> pacientesTipoSangre = (tipoSangre != null && TipoSangre.ContainsKey(tipoSangre))
                                                  ? new HashSet<string>(TipoSangre[tipoSangre])
                                                  : new HashSet<string>();

            HashSet<string> pacientesPresion = (presion != null && Presion.ContainsKey(presion))
                                               ? new HashSet<string>(Presion[presion])
                                               : new HashSet<string>();

            // Si ningún filtro se aplicó, devolver todos los pacientes disponibles
            if (genero == null && tipoSangre == null && presion == null)
            {
                return Genero.Values.SelectMany(x => x).Distinct().ToList();
            }

            // Si solo un filtro está definido, devolver la lista correspondiente
            if (genero != null && tipoSangre == null && presion == null) return pacientesGenero.ToList();
            if (genero == null && tipoSangre != null && presion == null) return pacientesTipoSangre.ToList();
            if (genero == null && tipoSangre == null && presion != null) return pacientesPresion.ToList();

            // Para múltiples filtros, calcular la intersección de los conjuntos disponibles
            HashSet<string> resultado = new HashSet<string>(pacientesGenero.Count > 0 ? pacientesGenero : pacientesTipoSangre.Count > 0 ? pacientesTipoSangre : pacientesPresion);

            if (pacientesGenero.Count > 0) resultado.IntersectWith(pacientesGenero);
            if (pacientesTipoSangre.Count > 0) resultado.IntersectWith(pacientesTipoSangre);
            if (pacientesPresion.Count > 0) resultado.IntersectWith(pacientesPresion);

            return resultado.ToList();
        }

    }
}
