using LetsPet_Services.Animal;
using LetsPet_Services.Busca;
using System;

namespace LetsPet_Services
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem-vindo à LetsPet");
            Cadastro.AddService.Options();
            //Services.DefaultMenu();

            //primeiro menu
            //• Cadastro de Serviços e Preços dos Serviços
            //• Buscar serviço
            //• Relatório de serviços prestados
            //• Relatório de produtos por serviço prestado

            //que puxa o menu abaixo em uma das opções
            //Animal.Animal pet = new Animal.Animal();
            //pet.Nome = "Yuki";
            //pet.Especie = Especie.Cachorro;
            //pet.Raca = "Akita";
            //pet.Cor = "Laranja";
            //pet.Porte = Porte.Grande;
            //pet.Peso = 32;
            //pet.Nascimento = new DateTime(2017, 10, 21);
            //pet.Agressivo = false;
            //pet.Sexo = 'F';
            //pet.Castrado = true;
            //TipoServico.Grooming.GroomingOptions(pet);
            //TipoServico.Bath.BathOptions(pet);

            //Animal.Animal animaldaThayssa = new Animal.Animal();
            //Console.WriteLine();
            //animaldaThayssa.Nome = "Lajotinha";
            //animaldaThayssa.Especie = Especie.Cachorro;
            //animaldaThayssa.Raca = "SRD";
            //animaldaThayssa.Cor = "Marrom";
            //animaldaThayssa.Porte = Porte.Grande;
            //animaldaThayssa.Peso = 23;
            //animaldaThayssa.Nascimento = new DateTime(2013, 10, 1);
            //animaldaThayssa.AdicionarDoencasAlergias("Cegueira Total");
            //animaldaThayssa.Agressivo = false;
            //animaldaThayssa.Sexo = 'M';
            //animaldaThayssa.Castrado = true;
            //TipoServico.Grooming.GroomingOptions(animaldaThayssa);
            //TipoServico.Bath.BathOptions(animaldaThayssa);

            //animaldaThayssa.ImprimirAnimal();
            //Grooming.GroomingOptions(animaldaThayssa);
            //Console.WriteLine("Digite algo para busca:");
            //string arroz = Console.ReadLine();
            //Research.BathResearch(arroz);

            //Services.ServicesMenu();
        }
    }
}