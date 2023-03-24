using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PraticaFarmaceutica
{
    class Enfermedad
    {
        string nombre;
        int unidad;
        double miligramosI;
        double miligramosJ;
        double gramos;
        string fechaVence;

        public void Enfermedades()
        {
            int x;

            Console.WriteLine("Enfermedades");
            Console.WriteLine("1-Hipertencion");
            Console.WriteLine("2-Artritis");
            Console.WriteLine("3-Covid-19");
            Console.WriteLine("4-Tiroide");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Medicamentos para Hipertencion");

                Console.WriteLine("1-Aspirina");
                Console.WriteLine("2-paracetamol");
                Console.WriteLine("3-Kawasaki");

                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Unidades:");
                unidad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha de vencimiento:");
                fechaVence = Console.ReadLine();
            }
            else if(x == 2)
            {
                Console.WriteLine("Medicamentos para Artristis");
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Gramos:");
                gramos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha de vencimiento:");
                fechaVence = Console.ReadLine();
            }
            else if(x == 3)
            {
                Console.WriteLine("Medicamentos para Covid-19");
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Miligramos:");
                miligramosI = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha de vencimiento:");
                fechaVence = Console.ReadLine();
            }
            else if (x == 4)
            {
                Console.WriteLine("Medicamentos para Tiroide");
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Miligramos:");
                miligramosJ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fecha de vencimiento:");
                fechaVence = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No existe ese medicamento");
            }
        }
    }
}
