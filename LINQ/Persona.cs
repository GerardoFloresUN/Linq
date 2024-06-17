using System.Diagnostics;

namespace LINQ
{

    [DebuggerDisplay("{Nombre}")]
    public class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public bool Soltero { get; set; }

        public DateTime FechaIngresoALAEmpresa { get; set; }
        public List<string> Telefonos = new List<string>();

        public int EmpresaId { get; set; }
    }
}