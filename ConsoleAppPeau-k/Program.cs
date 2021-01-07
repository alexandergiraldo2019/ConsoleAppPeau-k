using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPeau_k
{
    class Program
    {
        static void Main(string[] args)
        {
            string prueba = "Able was I ere I saw Elba";
            Acciones obj = new Acciones();
            bool resultado = obj.Palindrome(prueba);
        }


    }

    public class Acciones
    {
        public bool Palindrome(string cadena)
        {
            char[] data = cadena.ToArray();
            int n = data.Length-1;
            int lim = n / 2;

            for (int i = 0; i <= n; i++)
            {
                if (data[i].ToString().ToUpper() != data[n].ToString().ToUpper())
                {
                    return false;
                }

                n--;
            }

            return true;
        }
    }
}
