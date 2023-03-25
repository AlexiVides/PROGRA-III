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

            while (true)
            {
                Console.WriteLine("Bienvenido a la clinica 'Tetrabé'");
                Console.WriteLine("Digite los datos del cliente");
                persona.DatosCliente();

                while (true)
                {

                    Enfermedad farmacos = new Enfermedad();

                    farmacos.Enfermedades();
                    farmacos.MostrarDatosEnfer();
                }
            }

            

            Console.ReadKey();
        }
    }
}
