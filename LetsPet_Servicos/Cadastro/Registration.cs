using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Cadastro
{
    public class Registration : Services
    {
        public static int order = 1;

        public static void Select()
        {
            Console.WriteLine("O que você deseja cadastrar?");
            foreach (Type service in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine($"{order} - {service}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            Type = Enum.GetName(typeof(Type), order);
            Specification.Add(Type);
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
            order = 1;

            Console.WriteLine("Para qual espécie é este serviço?");
            foreach (Especie especie in Enum.GetValues(typeof(Especie)))
            {
                Console.WriteLine($"{order} - {especie}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            Species = Enum.GetName(typeof(Especie), order);
            Specification.Add(Species);
            order = 1;

            Console.WriteLine("Para qual porte é este serviço?");
            foreach (Porte especie in Enum.GetValues(typeof(Size)))
            {
                Console.WriteLine($"{order} - {especie}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            Size = Enum.GetName(typeof(Porte), order);
            Specification.Add(Size);
            order = 1;

            Console.WriteLine("É um serviço especial?");
            Special = Console.ReadLine();
            Specification.Add(Special);

            Console.WriteLine("Esse serviço utilizará loção?");
            Lotion = Console.ReadLine();
            Specification.Add(Lotion);

            Console.WriteLine("Qual o nome deste serviço?");
            Name = Console.ReadLine();

            Specification.Add(GroomingType);

            Package.Add(Name, Specification);
            foreach (var item in Package)
            {
                Console.WriteLine("Serviço adicionado com sucesso!");
                Console.WriteLine("Serviço: ");
                Console.WriteLine(item.Key);
                Console.WriteLine("Informações do serviço: ");
                for (int i = 0; i < Specification.Count; i++)
                {
                    Console.WriteLine(Specification[i]);
                };
            }

            Console.WriteLine("Qual o valor deste serviço?");
            Price = double.Parse(Console.ReadLine());
            Prices.Add(Name, Math.Round(Price, 2));
            foreach (var item in Prices)
            {
                Console.WriteLine("Serviço e valor determinado: ");
                Console.WriteLine($"{item.Key} - R${item.Value}");
                
            }
        }
    }
}
