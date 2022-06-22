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
        public static Dictionary<string, List<string>> Package = new Dictionary<string, List<string>> { };
        public static List<string> Specification = new List<string>();
        public static Dictionary<string, double> Prices = new Dictionary<string, double> { };
        public static string Type { get; set; }//*
        public static string Species { get; set; }//*
        public static string Size { get; set; }//*
        public static string Name { get; set; }
        public static string Special { get; set; }
        public static string Lotion { get; set; }
        public static string GroomingType = "";
        //{
        //    get
        //    {
        //        return GroomingType;
        //    }

        //    set { GroomingType = null; }
        //}
        public static string ServiceTime = "1 ";
        public static double Price { get; set; }//*
        
        public static void DefaultMenu()
        {
            Console.WriteLine("1 - Cadastro de Serviços e Preços dos Serviços\n2 - Buscar serviço\n3 - Relatório de serviços prestados\n4 - Relatório de produtos por serviço prestado");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("1 - Cadastro de Serviços\n2 - Preços dos Serviços");
                    Cadastro.Registration.Select();
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
