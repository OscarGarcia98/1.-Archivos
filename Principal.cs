using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
   public class Principal
    {
        string Path = "Datos.txt";     //Esta variable guarda el nombre de la ruta del archivo de texto donde se guardará la informacion de los usuarios
        Registro r = new Registro();      //Instancias de la clase para trabajar con sus metodos y atributos
        Usuario u = new Usuario();
        public void Menu()    //Método menú que se despliega al usuario para elegir la opción de ingresar usuario
        {
           
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1.-Registrarse\n");
            switch (Console.ReadLine())
            {
                case "1":
                    Registrese(u);     
                    break;
                
            }
            Menu();
        }
      
        public  void Registrese(Usuario u)      //Método que pide los datos al usuario 
        {
          
                    
            Console.WriteLine("Ingrese el nombre");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el usuario");
            u.Username = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            u.Password = Console.ReadLine();
           
            r.RegistrarUsuario(u, Path);     //Estos datos se mandan junto al directorio al método que ingresar esta informacion al archivo 
        }

       
        
    }
}
