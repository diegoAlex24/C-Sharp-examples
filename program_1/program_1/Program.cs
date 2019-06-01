// Aplicacion de consola
// Comentarios de una línea
/* Comentarios
 Multilneas
*/
// Librerias
using System; // Ahorra el escribir
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para todos los nombres identificadores no usar palabras reservadas ("if, else, class, int, long, double, etc") 
// Proyecto
namespace program_1 {
    // Clase
    class Program { // Orientado a objetos
        /* Main */
        // Metodo static = global no necesita instancias
        // Para pasar argumentos al main hay que dar clic derecho en nuestro proyecto -> propiedades -> depurar y escribirlos en la linea de comandos separados por espacios.
        static void Main(string[] args) {
            // Escribe en consola el mensaje
            Console.WriteLine("Hola mundo");

            /* Variables */
            int a = 800;
            float b = 5.46f;
            double c = 10.202;
            char d = 'D';
            string e = "Hola gente";

            /* Escritura en consola y lectura de teclado */
            // Escribe en consola sin salto de linea
            Console.Write("Hola");
            // Se intoduce un salto de linea
            Console.Write("\n");

            Console.WriteLine("Escribe un número");
            // Como la lectura del teclado es en cadena para tener un numero le indicamos al compilador que lo caste a un entero
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escribe un nombre");
            // Declara cadena y la lee desde el teclado
            string nombre = Console.ReadLine();
            // Imprime una variable con cadena
            Console.WriteLine("Hola " + nombre);

            // Espera una tecla
            Console.ReadKey();
        }
    }
}
