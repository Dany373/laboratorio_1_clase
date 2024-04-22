using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.EjemploEncapsulamiento
{
    internal class Persona
    {
        // Campos privados
        private string nombre;
        private int edad;

        // Constructor
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        // Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        //ejemplo de propiedad con validación
        // la edad no puede ser negativa
        // si se intenta asignar un valor negativo, se mostrará un mensaje
        public int Edad
        {
            get { return edad; }
            set
            {
                // Validación para asegurarse de que la edad es válida
                if (value >= 0)
                {
                    edad = value;
                }
                else
                {
                    Console.WriteLine("La edad no puede ser negativa.");
                }
            }
        }

        // Método
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }

       
        // ejemplo de método estático
        // se puede llamar sin instanciar la clase
        public static void listaDePersonas()
        {
            Console.WriteLine("Lista de Personas");
            Console.WriteLine("1. Nombre: Juan, Edad: 25");
            Console.WriteLine("2. Nombre: Maria, Edad: 30");
            Console.WriteLine("3. Nombre: Pedro, Edad: 20");
        }

    }
}
