using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class FiscalizadorVTV
    {
        public int CantidadVTV { get; }
        public List<VTV> verificaciones = new List<VTV>();
        VTV TeVeoBenito;

        public VTV this[int idx]
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
        public VTV AgregarPatente(string patente, string propietario, DateTime dia)
        {
                TeVeoBenito = new VTV(patente, propietario, dia);
                verificaciones.Add(TeVeoBenito);
                return TeVeoBenito;
        }
        public List<VTV> VerVTVPorPatente(string patente) //ver por patente
        {
            int i = 0;
            List<VTV> TeVi=new List<VTV> ();

            while (i < verificaciones.Count)
            {
                if (verificaciones[i].Patente == patente)
                {
                    TeVi.Add(verificaciones[i]);
                }
                i++;
            }
            return TeVi;
        }
    }
}
