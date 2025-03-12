using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data.SqlClient;

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=.\\SQLEXPRESS;Database=Escuela;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    Console.Write("Ingrese el nombre del estudiante: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese la edad del estudiante: ");
                    if (!int.TryParse(Console.ReadLine(), out int edad))
                    {
                        Console.WriteLine("Error: La edad debe ser un número válido.");
                        return;
                    }

                    
                    string query = "INSERT INTO Estudiantes (Nombre, Edad) VALUES (@nombre, @edad)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@edad", edad);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        Console.WriteLine("Filas insertadas: " + filasAfectadas);
                    }
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


