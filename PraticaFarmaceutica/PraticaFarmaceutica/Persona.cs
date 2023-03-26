using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaFarmaceutica
{
    class Persona
    {
        string nombre;
        string genero;
        int edad;

        public void DatosCliente()
        {
            Console.WriteLine("Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Genero:");
            genero = Console.ReadLine();
            Console.WriteLine("Edad:");
            edad = int.Parse(Console.ReadLine());
        }

        public void MostrarDatosCliente()
        {
            Console.WriteLine("\nDatos del paciente");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Genero: {genero}");
            Console.WriteLine($"Edad: {edad}");
        }
    }
}
