using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class PatenteInvalidaExcepcion:Exception 
    {
        public PatenteInvalidaExcepcion(string message) : base(message) { }



    }
}
