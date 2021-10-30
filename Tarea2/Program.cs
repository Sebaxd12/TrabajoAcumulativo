using System;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {


            bool confirmacion = true;

            if (confirmacion = true) {

                Console.WriteLine("                           FORMULARIO DE CONTACTO");
                Console.WriteLine("Ingrese la cantidad de persona que quiere registrar:");

                int numerodedatos = Convert.ToInt32(Console.ReadLine());
                Persona[] ListaPersona = new Persona[numerodedatos];

                Persona p4 = new Persona();

                ListaPersona[0] = p4;

              

                for (int i=0; i< numerodedatos; i++)

                {
                    Console.WriteLine("Ingrese su Rut:");
                    p4.Rut = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese su Nombre:");
                    p4.Nombre = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese su Apellido Paterno:");
                    p4.Apellido_pa = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese su Apellido Materno:");
                    p4.Apellido_ma = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese su Edad:");
                    p4.Edad = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese su Correo:");
                    p4.Correo = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ingrese su Fono:");
                    p4.Fono = Convert.ToString(Console.ReadLine());

                    
                    ListaPersona[i] = p4;
                }
                foreach (Persona datoss in ListaPersona)
                {
                    Console.WriteLine("LOS DATOS DE LAS PERSONAS INGRESADAS SON:");
                    Console.WriteLine("                " + p4.Rut);
                    Console.WriteLine("                " + p4.Nombre);
                    Console.WriteLine("                " + p4.Apellido_pa);
                    Console.WriteLine("                " + p4.Apellido_ma);
                    Console.WriteLine("                " + p4.Edad);
                    Console.WriteLine("                " + p4.Correo);
                    Console.WriteLine("                " + p4.Fono);

                }



            }

        }
    }
}
