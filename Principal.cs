using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
   public class Principal
    {
        string Path = "Datos.txt";
        Registro r = new Registro();
        Usuario u = new Usuario();
        public void Menu()
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
      
        public  void Registrese(Usuario u)
        {
          
                    
            Console.WriteLine("Ingrese el nombre");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el usuario");
            u.Username = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña");
            u.Password = Console.ReadLine();
           
            r.RegistrarUsuario(u, Path);
        }

       
        
    }
}
