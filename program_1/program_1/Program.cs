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
// El namespace puede usarse como una libreria en otro proyecto con using
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
            String cadena = "Hola C#";
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
            // Se introduce un salto de linea
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

            /* Operaciones númericas */
            Console.WriteLine("Suma = {0}", a + a);
            Console.WriteLine("Resta = {0}", a - a);
            Console.WriteLine("Multiplicación = {0}", a * a);
            Console.WriteLine("División = {0}", a / a);
            Console.WriteLine("Resto = {0}", a % a);

            /* Clases y objetos */
            // Se crea un objeto tambien llamada instancia de la clase Clase ubicado en Clase.cs
            Clase objeto = new Clase();
            // Inicializa el setter
            objeto.SetNombre(nombre);
            // Llamada del objeto a su metodo.
            objeto.Saludo();

            /* Ciclo For */
            // Una forma de recorrer un arreglo de variables del mismo tipo es usar un ciclo
            // El ciclo for primero declara una variable que itera sobre el arreglo los cuales todos comienzan desde el 0
            // Despues se tiene una condición la cual al momento que no se cumpla dejara de ejcutarse el codigo entre los corchetes
            // Por ultimo se actualiza variable inicial para que se mueva por el arreglo y cambie el válor.
            for(int i = 0; i < args.Length; i++){
                // El arreglo args contiene la propiedad Length la cual almacena el tamaño del arreglo.
                // al poner una variable con ++ es igual a hacer incrementos en uno
                Console.WriteLine("El contenido del arreglo args es {0} = {1}", i, args[i]);
                // Otra forma de poner variables en una cadena es por medio de llaves iniciando del 0 y pasando la variable a tomar como parametro
                // Para acceder al contenido de una variable utilizamos los corchetes y el número de elemento.
            }

            /* Obtener argumentos de la aplicación */
            // Declaramos un arreglo de cadenas para almacenar los argumentos de la línea de comandos.
            string[] argumentos = Environment.GetCommandLineArgs();
            // La siguiente línea usara la función join para unir todos los agumentos de la línea de comandos uniendolos por el primer argumentos que en este caso es " - " resultando una cadena
            Console.WriteLine(string.Join(" - ", argumentos));



            // Espera una tecla
            Console.ReadKey();
        }
    }
}
