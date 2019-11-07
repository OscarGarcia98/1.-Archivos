using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Autenticacion
{
    public class Registro
    {
        public void RegistrarUsuario(Usuario u, string Path)            //Método que permite registrar el usuario en el archivo de texto utilizando los valores ingresados por el usuario
        {
            string data = u.Nombre + " " + u.Username + " " + u.Password;       //cadena de texto que concatenan los datos de un usuario
            var datos = ObtenerLineas(Path);        //en esta variable datos se guarda la lista obtenida del método ObtenerLineas la cual pertenece al archivo de texto

            if (datos != null)      //Esta condición determina si la lista esta vacía o no
            {
                datos.Add(data);                    //Si no esta vacía se agrega el nuevo usuario
                File.WriteAllLines(Path, datos);        //Se sobreescribe el archivo
            }
            else
            {

                File.WriteAllText(Path, data);      //Caso contrario solo se sobreescribre
            }


        }
        public List<string> ObtenerLineas(string ruta)      //Método que retorna la lista de datos guardados en el archivo de texto
        {
            string[] data = null;

            if (File.Exists(ruta))      //Si el archivo con al ruta especificada existe...
            {
                data = File.ReadAllLines(ruta);         //...Entonces el array de string tomará el valor de todas las lineas guardadas en el archivo 
            }

            List<string> datos = new List<string>();        //Se crea la lista que incluirá los datos

            foreach (var item in data)
            {
                datos.Add(item);    //Para cada "objeto" en la variable data se agregará ese objeto en la lista de datos
            }

            return datos;       //Retorna esta lista llamada datos
        }
    }
}
