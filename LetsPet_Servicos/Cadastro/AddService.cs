using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Cadastro
{
    public class AddService
    {
        public static int order = 1;
        public static string service;
        public static string especie;
        public static string size;
        public static string name;
        public static bool special;
        public static bool lotion;

        public static void Options()
        {
            Console.WriteLine("O que você deseja cadastrar?");
            foreach (Type service in Enum.GetValues(typeof(Type)))
            {
                Console.WriteLine($"{order} - {service}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            service = Enum.GetName(typeof(Type), order);

            Console.WriteLine("Para qual espécie é este serviço?");
            foreach (Especie especie in Enum.GetValues(typeof(Especie)))
            {
                Console.WriteLine($"{order} - {especie}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            especie = Enum.GetName(typeof(Especie), order);

            Console.WriteLine("Para qual porte é este serviço?");
            foreach (Porte especie in Enum.GetValues(typeof(Porte)))
            {
                Console.WriteLine($"{order} - {especie}");
                order++;
            }
            order = int.Parse(Console.ReadLine());
            size = Enum.GetName(typeof(Porte), order);

            Console.WriteLine("É um serviço especial?");
            special = bool.Parse(Console.ReadLine());

            Console.WriteLine("Esse serviço utilizará loção?");
            lotion = bool.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome desse serviço?");
            name = Console.ReadLine();

            Console.WriteLine($"'{name}' foi registrado. Informações do serviço:\nTipo: {service}\nEspécie: {especie}\nPorte: {size}\nServiço especial? {special}\nUtilizará loção? {lotion}");
        }

        //public static void ForeachEnum(Enum Choice)
        //{
        //    int order = 1;
        //    foreach (Enum especie in Enum.GetValues(typeof(Choice)))
        //    {
        //        Console.WriteLine($"{order} - {especie}");
        //        order++;
        //    }
        //}
    }
}
