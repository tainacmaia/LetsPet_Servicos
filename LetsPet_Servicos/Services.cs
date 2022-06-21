using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPet_Services.Busca;

namespace LetsPet_Services
{
    public class Services
    {
        public int servicesTime { get; set; } //ver se DateTime é viável para ajudar o agendamento
        public static Dictionary<string, int> bathMenu = new Dictionary<string, int> { { "Banho Normal: Cachorro Grande", 1 }, { "Banho Especial: Cachorro Grande", 2 }, { "Banho Normal: Cachorro Pequeno", 3 }, { "Banho Especial: Cachorro Pequeno", 4 }, { "Banho Normal: Gato Grande", 5 }, { "Banho Especial: Gato Grande", 6 }, { "Banho Normal: Gato Pequeno", 7 }, { "Banho Especial: Gato Pequeno", 8 } };
        public static Dictionary<string, int> groomingMenu = new Dictionary<string, int> { { "Tosa Normal: Cachorro Grande", 1 }, { "Tosa Higiênica: Cachorro Grande", 2 }, { "Tosa Normal: Cachorro Pequeno", 3 }, { "Tosa Higiênica: Cachorro Pequeno", 4 }, { "Tosa Normal: Gato Grande", 5 }, { "Tosa Higiênica: Gato Grande", 6 }, { "Tosa Normal: Gato Pequeno", 7 }, { "Tosa Higiênica: Gato Pequeno", 8 } };
        public static Dictionary<string, List<string>> Package = new Dictionary<string, List<string>> {};
        public static Dictionary<string, int> Price = new Dictionary<string, int> { };
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
                    ServicesMenu();
                    //if (int.Parse(Console.ReadLine()) == 1)
                    //TipoServico.Bath.BathOptions();
                    break;
                case 2:
                    Research.Options();
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
    }
}
