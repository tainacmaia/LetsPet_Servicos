using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Busca
{
    internal class Research
    {
        public static void BathResearch(string variavelQueIremosLer)
        {
            string[] palavras = variavelQueIremosLer.Split(' ');

            if (palavras.Contains("large dog bath"))
            {
                Console.WriteLine("Existe!");
            }
            else
            {
                Console.WriteLine("Não existe!");
            }

            Console.ReadKey();
            //foreach (var item in Services.bathMenu)
            //{
            //    if (Services.bathMenu.ContainsKey(palavras))
            //    {
            //        Console.WriteLine(item.Key);
            //    }
            //}
        }
    }
}
