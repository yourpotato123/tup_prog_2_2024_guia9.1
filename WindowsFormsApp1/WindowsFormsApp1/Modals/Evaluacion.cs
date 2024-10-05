using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract public class Evaluacion
    {
        public string Nombre { get; }
        public string Descripcion { get; }
        public Evaluacion(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public abstract TipoAprobacion Evaluar();

        public override string ToString()
        {
            return $"{Nombre} - {Descripcion}";
        }
    }
}
