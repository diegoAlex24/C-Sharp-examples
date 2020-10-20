using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar clase clic derecho en el nombre proyecto -> agregar -> clase
namespace program_1 {
    class Clase {
        // Atributos
        // Se crea un atributo privado lo cual significa que no puede ser afectado o cambiado fuera de la clase.
        private String nombre;

        // Constructor se ejecuta automaticamente al crear un nuevo objeto de la clase.
        public Clase() {
            Console.WriteLine("Este es el constructor");
        }

        // Metodo sin parametros, ni regresa nada, se ejecuta desde llamada del objeto.
        public void Saludo(){
            // Se llama a una funcion de la propia clase, al usar this se refiere al objeto que la llama
            Console.WriteLine("Que tal " + this.GetNombre());
        }

        // Setter para definir un atributo de la clase.
        public void SetNombre(String name){
            nombre = name;
        }

        // Getter devuelve el valor de un atributo de la clase.
        public String GetNombre(){
            return nombre;
        }
    }
}
