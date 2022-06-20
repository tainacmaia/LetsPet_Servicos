using LetsPet_Services.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.TipoServico
{
    public class Bath : Services
    {
        //preço base
        //preço shampoo mais caro (if alergia)
        public static void BathOptions(Animal.Animal animal)
        {
 
            if (animal.Especie == Especie.Cachorro)
            {
                if (animal.Porte == Porte.Grande)
                {
                    if (animal.NecessidadesEspeciais())
                    {
                        Console.WriteLine("Special large dog bath");
                    }
                    else
                    {
                        Console.WriteLine("Normal large dog bath");
                    }
                }
                else
                {
                    if (animal.NecessidadesEspeciais())
                    {
                        Console.WriteLine("Special small dog bath");
                    }
                    else
                    {
                        Console.WriteLine("Normal small dog bath");
                    }
                }
            }
            else
            {
                if (animal.Porte == Porte.Grande)
                {
                    if (animal.NecessidadesEspeciais())
                    {
                        Console.WriteLine("Special large cat bath");
                    }
                    else
                    {
                        Console.WriteLine("Normal large cat bath");
                    }
                }
                else
                {
                    if (animal.NecessidadesEspeciais())
                    {
                        Console.WriteLine("Special small cat bath");
                    }
                    else
                    {
                        Console.WriteLine("Normal small cat bath");
                    }
                }
            }

                //void Discount()
                //{
                //  if (count == 4)
                //  {
                //      Price = Price / 2;
                //      count = 0;
                //  }
                //}
        }
    }
}
