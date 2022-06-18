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

        public static void ServicesMenu()
        {
            //int option;
            List<(string, int)> BathList = BathMenu();
            List<(string, int)> GroomingList = GroomingMenu();
            bool want;
            //do
            //{
            //    Console.WriteLine("O que você deseja?");
            //    Console.WriteLine("1 - Banho\n2 - Tosa\n3 - Banho e Tosa");
            //} while (!int.TryParse(Console.ReadLine(), out option) || (option < 1 || option > 3));
            Console.WriteLine("Nossos serviços são banho e tosa.");
            do
            {
                Console.WriteLine("O pet realizará banho?");
            } while (!bool.TryParse(Console.ReadLine(), out want));

            if (want)
            {
                PrintBath(); //limitar de acordo com porte, especie, alergia
            }

            do
            {
                Console.WriteLine("O pet realizará tosa?");
            } while (!bool.TryParse(Console.ReadLine(), out want));

            if (want)
            {
                PrintGrooming(); //limitar de acordo com porte, especie, alergia
            }
            //do
            //{
            //    switch (option)
            //    {
            //        case 1:
            //            {
            //                Console.WriteLine("Banho:");
            //                PrintBath();
            //                 break;
            //            }
            //        case 2:
            //            {
            //                Console.WriteLine("Tosa:");
            //                PrintGrooming();
            //                break;
            //            }
            //            //case 3:
            //            //    {
            //            //        Console.WriteLine("Banho:");
            //            //        PrintBath();
            //            //        Console.WriteLine("Tosa:");
            //            //        PrintGrooming();
            //            //        break;
            //            //    }
            //    }
            //    Console.WriteLine("Deseja realizar outro serviço?");
            //} while (!bool.TryParse(Console.ReadLine(), out vai));

            static List<(string bathMenu, int key)> BathMenu()
            {
                var bathList = new List<(string bathMenu, int key)>();
                bathList.Add(("Normal large dog bath", 1));
                bathList.Add(("Special large dog bath", 2));
                bathList.Add(("Normal small dog bath", 3));
                bathList.Add(("Special small dog bath", 4));
                bathList.Add(("Normal large cat bath", 5));
                bathList.Add(("Special large cat bath", 6));
                bathList.Add(("Normal small cat bath", 7));
                bathList.Add(("Special small cat bath", 8));
                return bathList;
            }

            static List<(string groomingMenu, int key)> GroomingMenu()
            {
                var groomingList = new List<(string groomingMenu, int key)>();
                groomingList.Add(("Normal large dog grooming", 1));
                groomingList.Add(("Hygienic large dog grooming", 2));
                groomingList.Add(("Normal small dog grooming", 3));
                groomingList.Add(("Hygienic small dog grooming", 4));
                groomingList.Add(("Normal large cat grooming", 5));
                groomingList.Add(("Hygienic large cat grooming", 6));
                groomingList.Add(("Normal small cat grooming", 7));
                groomingList.Add(("Hygienic small cat grooming", 8));

                return groomingList;
            }

            void PrintBath()
            {
                foreach (var item in BathList)
                {
                    Console.WriteLine(item);
                }
            }

            void PrintGrooming()
            {
                foreach (var item in GroomingList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
