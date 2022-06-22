using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Busca
{
    internal class Research
    {
        public static void ServicesResearch(string search)
        {
            var internalSearch = Cadastro.Registration.ServicesList.Where(s => s.Type == search);

            foreach (var service in internalSearch)
            {
                Console.WriteLine(service.Name);
            }
        }

        public static void Options()
        {
            string search;
            int input;
            Console.WriteLine("Qual o tipo de pesquisa que deseja realizar?");
            Console.WriteLine("1 - Tipo de Serviços\n2 - Por porte ou espécie");
            input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.WriteLine("Opções de serviço são:\n1 - Banho\n2 - Tosa");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    ServicesResearch("Banho");
                }
                else if (input == 2)//*
                {
                    ServicesResearch("Tosa");
                }
            }
            else if (input == 2)
            {
                Console.WriteLine("Digite um porte ou espécie");
                search = Console.ReadLine();
                ServicesResearch(search);
            }
        }
    }
}
