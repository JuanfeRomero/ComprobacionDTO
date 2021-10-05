using System;
using System.Globalization;

namespace ComprobacionDTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre ="Juan Federico";
            persona.Apellido = "Romero";
            persona.Edad = 26;
            persona.FechaNacimiento = Convert.ToDateTime("09/02/1995", new CultureInfo("es-ES"));

            Console.WriteLine("Nombre: " + persona.Nombre);
            Console.WriteLine("Apellido: " + persona.Apellido);
            Console.WriteLine("Edad: " + persona.Edad);
            Console.WriteLine("Fecha de Nacimiento: " + persona.FechaNacimiento.ToString("dd-MM-yyyy"));

            Console.WriteLine("Presione cualquier boton para terminar...");
            Console.ReadKey();
        }
    }
}
