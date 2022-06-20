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
        public static void Options()
        {
            Console.WriteLine("Qual o tipo de pesquisa que deseja realizar?");
            Console.WriteLine("1 - Tipo de Serviços\n2 - Porte ou Espécie");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Opções de serviço são:\n1 - Banho\n2 - Tosa");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Research.BathResearch("Banho");
                }
                else if (input == 2)//*
                {
                    Research.GroomingResearch("Tosa");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Digite um porte ou espécie");
                string arroz = Console.ReadLine();
                Research.BathResearch(arroz);
                Research.GroomingResearch(arroz);
            }
        }
    }
}
