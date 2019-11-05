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
            // Entero
            int a = 800;
            // Flotante
            float b = 5.46f;
            // Flotante doble precision
            double c = 10.202;
            // Caracter
            char d = 'D';
            // Cadena
            string e = "Hola gente";
            // Booleano
            bool voto = true;

            /* Máximos valores númericos */
            a = int.MaxValue; // 2147483647
            b = float.MaxValue; // 3.402823E+38
            c = double.MaxValue; // 1.79769313486232E+308
            // Entero largo
            long maximoLong = long.MaxValue; // 9223372036854775807
            // Gran entero
            decimal maximoDecimal = decimal.MaxValue; // 79228162514264337593543950335

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(maximoLong);
            Console.WriteLine(maximoDecimal);


            /* Escritura en consola y lectura de teclado */
            // Escribe en consola sin salto de linea
            Console.Write("Hola");
            // Se intoduce un salto de linea
            Console.Write("\n");

            Console.WriteLine("Escribe un número");
            // Como la lectura del teclado es en cadena para tener un numero le indicamos al compilador que lo convierta a un entero
            a = Convert.ToInt16(Console.ReadLine());
            // Misma operación pero con otra función
            string linea; // Esta variable leera la entrada.
            Console.WriteLine("Escribe un entero");
            linea = Console.ReadLine();
            a = int.Parse(linea); // Convierte la cadena a un entero corto.
            b = float.Parse(linea); // Convierte la cadena en un flotante.

            Console.WriteLine("Escribe un nombre");
            // Declara cadena y la lee desde el teclado
            string nombre = Console.ReadLine();
            // Imprime una variable con cadena
            Console.WriteLine("Hola " + nombre);

            
            /* Clases y objetos */
            // Se crea un objeto tambien llamada instancia de la clase Clase ubicado en Clase.cs
            Clase objeto = new Clase();
            // Inicializa el setter
            objeto.setNombre(nombre);
            // Llamada del objeto a su metodo.
            objeto.Saludo();




            // Espera una tecla
            Console.ReadKey();
        }
    }
}
