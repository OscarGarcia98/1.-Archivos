using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autenticacion
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Principal p = new Principal();
            Login log = new Login();
            log.Log();
            // p.Menu();

           // string nombre = "Oscar Daniel";

           // string[] datos = nombre.Split(' ');

           // foreach(var item in datos)
            //{
           //     Console.WriteLine(item);
           // }
           // Console.ReadKey();


        }
       

    }
}

