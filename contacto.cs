using System;
using System.Collections.Generic;
using System.Text;

namespace classe2
{
    class contacto
    {
        public void saludar()
        {
            Console.WriteLine("hola, soy");

        }
        public string nombe;
        public string apellido;
        public string telefono;
        public string direccion;


        public static void SetContacto(string pnombre, string papellido, string ptelefono, string pDireccion)
        {
            string nombre = pnombre;
            string apellido = papellido;
            int telefono = Int32.Parse(ptelefono);
            string Direccion = pDireccion;
        }

    }
}
