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
        public void RegistrarUsuario(Usuario u, string Path)
        {
            string data = u.Nombre + " " + u.Username + " " + u.Password;
            var datos = ObtenerLineas(Path);

            if (datos != null)
            {
                datos.Add(data);
                File.WriteAllLines(Path, datos);
            }
            else
            {

                File.WriteAllText(Path, data);
            }


        }
        public List<string> ObtenerLineas(string ruta)
        {
            string[] data = null;

            if (File.Exists(ruta))
            {
                data = File.ReadAllLines(ruta);
            }

            List<string> datos = new List<string>();

            foreach (var item in data)
            {
                datos.Add(item);
            }

            return datos;
        }
    }
}
