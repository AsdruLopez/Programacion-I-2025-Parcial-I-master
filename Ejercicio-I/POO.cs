using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Ejercicios
{
    
    public class Persona
    {
        
        private string nombre;
        private int edad;

        
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { if (value > 0) edad = value; }
        }

       
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
        }
    }

   
    public class Estudiante : Persona
    {
        public int Matricula { get; set; }

        public Estudiante(string nombre, int edad, int matricula) : base(nombre, edad)
        {
            this.Matricula = matricula;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Matrícula: {Matricula}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Carlos", 30);
            persona.MostrarInfo();

            Estudiante estudiante = new Estudiante("Ana", 22, 12345);
            estudiante.MostrarInfo();
        }
    }
}



