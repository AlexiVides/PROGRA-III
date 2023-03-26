using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaFarmaceutica
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Console.WriteLine("---------------Bienvenido a la clinica--------------");
            while (true)
            {
                
                Console.WriteLine("\nDigite los datos del paciente");
                persona.DatosCliente();

                Enfermedad farmacos = new Enfermedad();
                farmacos.Enfermedades();
                persona.MostrarDatosCliente();
                farmacos.MostrarDatosEnfer();
            }

            Console.ReadKey();
        }
    }
}
