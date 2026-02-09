using System;

namespace Unidad1_POO
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }

        public void Cumpleanos()
        {
            Edad++;
            Console.WriteLine($"¡Feliz cumpleaños {Nombre}! Ahora tienes {Edad} años.");
        }

        public void Despedirse()
        {
            Console.WriteLine($"Adiós, {Nombre}!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Anny", 20);
            persona1.Saludar();
            persona1.Cumpleanos();
            persona1.Despedirse();
        }
    }
}
