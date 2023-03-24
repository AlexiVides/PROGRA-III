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
                Console.WriteLine("Nombre:");
                persona.DatosCliente();

                while (true)
                {

                    Enfermedad farmacos = new Enfermedad();
                    int x;

                    Console.WriteLine("\nSeleccione la enfermedad");
                    Console.WriteLine("1-Fiebre");
                    Console.WriteLine("2-Dolores musculares");
                    Console.WriteLine("3-Infecciones");
                    Console.WriteLine("4-Pulmonia");
                    x = Convert.ToInt32(Console.ReadLine());

                    if(x == 1)
                    {
                        farmacos.Medicamentos();
                    }
                }
            }

            

            Console.ReadKey();
        }
    }
}
