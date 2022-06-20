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
            foreach (var item in Services.bathMenu)
            {
                if (item.Key.Contains(variavelQueIremosLer))
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        public static void GroomingResearch(string variavelQueIremosLer)
        {
            foreach (var item in Services.groomingMenu)
            {
                if (item.Key.Contains(variavelQueIremosLer))
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
