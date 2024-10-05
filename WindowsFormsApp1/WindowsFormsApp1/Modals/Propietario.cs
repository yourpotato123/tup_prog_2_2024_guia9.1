using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Propietario
    {
        public int DNI {  get; set; } 
        public string ApellidosyNombres { get; set;}

        public string Email { get; set;}

        public Propietario(int dni, string nombre, string mail)
        {
            DNI = dni;
            ApellidosyNombres = nombre;
            Email = mail;
        }

        public override string ToString()
        {
            return $"Propietario {ApellidosyNombres} - DNI {DNI} - Email {Email}";
        }


    }
}
