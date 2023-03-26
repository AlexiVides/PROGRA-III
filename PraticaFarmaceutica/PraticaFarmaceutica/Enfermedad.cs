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
        double miligramos;
        double gramos;
        string fechaVence;

        int x;
        int opc;

        public void Enfermedades()
        {
            Console.WriteLine("\nQue Enfermedad presenta?");
            Console.WriteLine("1-Hipertencion");
            Console.WriteLine("2-Artritis");
            Console.WriteLine("3-Covid-19");
            Console.WriteLine("4-Tiroide");
            x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Medicamentos para la Hipertencion");

                Console.WriteLine("1-Aspirina");
                Console.WriteLine("2-paracetamol");
                Console.WriteLine("3-Kawasaki");
                opc = Convert.ToInt32(Console.ReadLine());

                if(opc == 1)
                {
                    Console.WriteLine("\nDatos de la aspirina");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Unidades:");
                    unidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();

                }
                else if (opc == 2)
                {
                    Console.WriteLine("\nDatos de paracetamol");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("miligramos:");
                    miligramos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if(opc == 3)
                {
                    Console.WriteLine("\nDatos de Kawasaki");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("miligramos:");
                    miligramos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No existe ese medicamento");
                }
            }
            else if(x == 2)
            {
                Console.WriteLine("Medicamentos para Artristis");
                Console.WriteLine("1-Hidroxicloroquina");
                Console.WriteLine("2-Anakinra");
                Console.WriteLine("3-Rituximab");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("\nDatos de la Hidroxicloroquina");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Unidades:");
                    unidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if (opc == 2)
                {
                    Console.WriteLine("\nDatos de la Anakinra");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("miligramos:");
                    miligramos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if (opc == 3)
                {
                    Console.WriteLine("\nDatos de la Rituximab");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("gramos:");
                    gramos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No existe ese medicamento");
                }

            }
            else if(x == 3)
            {
                Console.WriteLine("Medicamentos para Covid-19");
                Console.WriteLine("1-Paxlovid");
                Console.WriteLine("2-Remdesivir");
                Console.WriteLine("3-Vacuna-Moderna");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("\nDatos de la Paxlovid");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Unidades:");
                    unidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if (opc == 2)
                {
                    Console.WriteLine("\nDatos de la Remdesivir");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("miligramos:");
                    miligramos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if (opc == 3)
                {
                    Console.WriteLine("\nDatos de la Vacuna-Moderna");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("miligramos:");
                    miligramos = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No existe ese medicamento");
                }

            }
            else if (x == 4)
            {
                Console.WriteLine("Medicamentos para Tiroide");
                Console.WriteLine("1-Unithroid");
                Console.WriteLine("2-L-Thyroxin");
                Console.WriteLine("3-Novothyrox");
                opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    Console.WriteLine("\nDatos de la Unithroid");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Unidades:");
                    unidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if (opc == 2)
                {
                    Console.WriteLine("\nDatos de la L-Thyroxin");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Unidades:");
                    unidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else if (opc == 3)
                {
                    Console.WriteLine("\nDatos de la Novothyrox");
                    Console.WriteLine("nombre: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Unidades:");
                    unidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fecha de vencimiento:");
                    fechaVence = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("No existe ese medicamento");
                }
            }
            else
            {
                Console.WriteLine("La enferdad selecionada no esta en la lista");
            }
        }

        public void MostrarDatosEnfer()
        {
            Console.WriteLine("Datos del medicamento");

            if (x == 1)
            {
                Console.WriteLine("\nDatos de medicamentos para Hipertencion");
                if(opc == 1)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Unidades: " + unidad);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if(opc == 2)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Miligramos: " + miligramos);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Miligramos: " + miligramos);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("\nDatos de medicamentos para Artritis");
                if (opc == 1)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Unidades: " + unidad);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Miligramos: " + miligramos);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Gramos: " + gramos);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
            }
            else if (x == 3)
            {
                Console.WriteLine("\nDatos de medicamentos para Covid-19");
                if (opc == 1)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Unidades: " + unidad);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Miligramos: " + miligramos);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Miligramos: " + miligramos);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
            }
            else if (x == 4)
            {
                Console.WriteLine("\nDatos de medicamentos para Tiroide");
                if (opc == 1)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Unidades: " + unidad);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 2)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Unidades: " + unidad);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
                else if (opc == 3)
                {
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Unidades: " + unidad);
                    Console.WriteLine("Fecha de vencimiento: " + fechaVence);
                }
            }
        }
    }
}
