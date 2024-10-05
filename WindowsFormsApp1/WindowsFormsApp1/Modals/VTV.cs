using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class VTV:IComparable
    {
        public string Patente { get; }
        public DateTime Fecha { get; }
        public DateTime FechaVencimiento 
        {
            get
            {
                switch (Aprobacion)
                {
                    case TipoAprobacion.Aprobado:
                        return Fecha.AddYears(1);
                    case TipoAprobacion.Parcial:
                        return Fecha.AddDays(20);
                    default:
                        return Fecha;
                }
            }
        }
        public int CantidadVerificaciones { get; }
        public Propietario Propietario { get; }
        private List <Evaluacion> verificaciones = new List<Evaluacion>();
        
        public Evaluacion this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < verificaciones.Count)
                {
                    return verificaciones[idx];
                }
                else return null;
            }
        }
     
        public TipoAprobacion Aprobacion 
        {
            get
            {
                if (verificaciones==null && verificaciones.Count > 0)
                {
                    return TipoAprobacion.NoAprobado;
                }

                TipoAprobacion menor = verificaciones[0].Evaluar(); 

                for (int i = 1; i < verificaciones.Count; i++)
                {
                    if (verificaciones[i].Evaluar() < menor)
                    {
                    menor = verificaciones[i].Evaluar();
                    }
                }
                return menor;
            }
        }

        public VTV(string patente, string propietario, DateTime dia)
        {
            if ((Regex.Match(patente, "^[A-Z]{2}[0-9]{3}[A-Z]{2}$").Success)
                || (Regex.Match(patente, "^[A-Z]{3}[0-9]{3}$").Success))
            { Patente = patente;
                Propietario.ApellidosyNombres = propietario;
                Fecha = dia;
            }
            else
            {
                throw new PatenteInvalidaExcepcion($"La patente {patente} no es valida");
            }

        }

        public string[] EmitirComprobante()//hacer bien
        {
            string[] Vtv = new string[10];
            return Vtv;
        }
        public override string ToString()
        {
            return base.ToString(); //modificar
        }

        public int CompareTo(object obj) //modificar para entender
        {
            throw new NotImplementedException();
        }
    }
}
