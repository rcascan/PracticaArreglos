using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nombre = { "Luis", "Maria", "Karla", "Juan " };
            string[] apellido = new string[3];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);

                //string parte = string.Join("-", nombre[i].ToCharArray());
                //Console.WriteLine(parte);
            }

            //Console.WriteLine(nombre.Length);
            Console.Read();

        }
    }
}
