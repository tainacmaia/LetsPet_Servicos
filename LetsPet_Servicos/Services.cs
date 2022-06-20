using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services
{
    public class Services
    {
        public double Price { get; set; }
        public int servicesTime { get; set; } //ver se DateTime é viável para ajudar o agendamento
        public static Dictionary<string, int> bathMenu = new Dictionary<string, int> { { "Normal large dog bath", 1 }, { "Special large dog bath", 2 }, { "Normal small dog bath", 3 }, { "Special small dog bath", 4 }, { "Normal large cat bath", 5 }, { "Special large cat bath", 6 }, { "Normal small cat bath", 7 }, { "Special small cat bath", 8 } };
        public static Dictionary<string, int> groomingMenu = new Dictionary<string, int> { { "Normal large dog grooming", 1 }, { "Hygienic large dog grooming", 2 }, { "Normal small dog grooming", 3 }, { "Hygienic small dog grooming", 4 }, { "Normal large cat grooming", 5 }, { "Hygienic large cat grooming", 6 }, { "Normal small cat grooming", 7 }, { "Hygienic small cat grooming", 8 } };
        //public static Dictionary<string, int> GeneralMenu = new Dictionary<string, int> { { "Cadastro de Serviços e Preços dos Serviços", 1 }, { "Buscar serviço", 2 }, { "Relatório de serviços prestados", 3 }, { "Relatório de produtos por serviço prestado", 4 } };

        public static void ServicesMenu()
        {
            //int option;
             bool want;
            Console.WriteLine("Nossos serviços são banho e tosa.");
            do
            {
                Console.WriteLine("O pet realizará banho?");

            } while (!bool.TryParse(Console.ReadLine(), out want));

            if (want)
                PrintBath(); //limitar de acordo com porte, especie, alergia

            do
            {
                Console.WriteLine("O pet realizará tosa?");
            } while (!bool.TryParse(Console.ReadLine(), out want));

            if (want)
                PrintGrooming(); //limitar de acordo com porte, especie, alergia

            void PrintBath()
            {
                foreach (var item in bathMenu)
                {
                    Console.WriteLine(item);
                }
            }

            void PrintGrooming()
            {
                foreach (var item in groomingMenu)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void DefaultMenu()
        {
            //foreach (var key in GeneralMenu)
            //{
            //    Console.WriteLine($"{key.Value} - {key.Key}");
            //}
            Console.WriteLine("1 - Cadastro de Serviços e Preços dos Serviços\n2 - Buscar serviço\n3 - Relatório de serviços prestados\n4 - Relatório de produtos por serviço prestado");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("1 - Cadastro de Serviços\n2 - Preços dos Serviços");
                    //if (int.Parse(Console.ReadLine()) == 1)
                        //TipoServico.Bath.BathOptions();
                    break;
                case 2:
                    Services.ServicesMenu();
                    break;
                case 3:
                    break;
                case 4:
                    break;

            }
        }
    }
}
