using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Cadastro
{
    public class Registration
    {
        public static string Type;
        public static string Species;
        public static string Size;
        public static string Name;
        public static bool Special;
        public static bool Lotion;
        public static string GroomingType = "";
        public static int ServiceTime = 1;
        public static double Price;
        public static int option;
        public static int order = 1;
        public static List<Service> ServicesList = new();

        public static void AddService()
        {
            Console.WriteLine("O que você deseja cadastrar?");
            foreach (Type service in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine($"{order} - {service}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            Type = Enum.GetName(typeof(Type), order);

            if (order == 2)
            {
                order = 1;
                Console.WriteLine("Qual o tipo de tosa a ser realizado?");
                foreach (GroomingType service in Enum.GetValues(typeof(GroomingType)))
                {
                    Console.WriteLine($"{order} - {service}");
                    order++;
                }
                order = int.Parse(Console.ReadLine());
                GroomingType = Enum.GetName(typeof(GroomingType), order);
            }
            else
            {
                GroomingType = null;
            }
            order = 1;

            Console.WriteLine("Para qual espécie é este serviço?");
            foreach (Species especie in Enum.GetValues(typeof(Species)))
            {
                Console.WriteLine($"{order} - {especie}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            Species = Enum.GetName(typeof(Species), order);

            order = 1;

            Console.WriteLine("Para qual porte é este serviço?");
            foreach (Size especie in Enum.GetValues(typeof(Size)))
            {
                Console.WriteLine($"{order} - {especie}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            Size = Enum.GetName(typeof(Size), order);
            order = 1;

            Console.WriteLine("É um serviço especial?");
            Special = bool.Parse(Console.ReadLine());

            Console.WriteLine("Esse serviço utilizará loção?");
            Lotion = bool.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome deste serviço?");
            Name = Console.ReadLine();

            Console.WriteLine("Qual o valor deste serviço?");
            Price = double.Parse(Console.ReadLine());

            Service newService = new Service (Type, Species, Size, Name, Special, Lotion, GroomingType, ServiceTime, Price);
            ServicesList.Add(newService);
            Console.WriteLine("Cadastro Realizado!\n");
        }
    }
}
