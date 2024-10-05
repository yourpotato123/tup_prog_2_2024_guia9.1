using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class EvaluacionParametrica : Evaluacion
    {
        public double ValorMinimo { get; }
        public double ValorMaximo { get; }
        public string Unidad { get; }
        public double ValorTolerado { get; }
        public double ValorMedido { get; set; }

        public EvaluacionParametrica(string nombre, string descripcion, double minimo, double maximo, string unidad, double tolerado) : base(nombre, descripcion)
        {
            ValorMinimo = minimo;
            ValorMaximo = maximo;
            ValorTolerado = tolerado;
            Unidad = unidad;
        }

        public override TipoAprobacion Evaluar()
        {
            double toleradoMaximo = (ValorTolerado / 100) + 1;
            double toleradoMinimo = 1 - (ValorTolerado / 100);

            if (ValorMedido >= (ValorMinimo) && (ValorMedido <= (ValorMaximo)))
            { return TipoAprobacion.Aprobado; }

            else if ((ValorMedido >= toleradoMinimo) && (ValorMedido < ValorMinimo))
            { return TipoAprobacion.Parcial; }

            else if ((ValorMedido <= toleradoMaximo) && (ValorMedido > ValorMaximo))
            { return TipoAprobacion.Parcial;}

            else
            { return TipoAprobacion.NoAprobado; }
        }

        public override string ToString()
        {
            return base.ToString() + $" - {Evaluar()}";
        }
    }
}
