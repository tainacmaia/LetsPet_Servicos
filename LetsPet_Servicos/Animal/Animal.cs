﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet_Services.Animal
{
    public class Animal : DadosCadastro
    {
        public string Nome { get; set; } //******
        public Especie Especie { get; set; } //******
        public string Raca { get; set; }
        public List<string> DoencasAlergias { get; set; } = new(); //******
        public string Cor { get; set; }
        public Porte Porte { get; set; } //******
        public decimal Peso { get; set; }
        public int Idade { get { return IdadeCompleta(); } }
        public DateTime Nascimento { get; set; }

        public bool Agressivo { get; set; }
        public char Sexo { get; set; }
        public bool Castrado { get; set; }
        private int IdadeCompleta()
        {
            if (Nascimento.Month > DateTime.Now.Month)
            {
                return DateTime.Now.Year - Nascimento.Year - 1;
            }
            else if (Nascimento.Month < DateTime.Now.Month)
            {
                return DateTime.Now.Year - Nascimento.Year;
            }
            else
            {
                if (Nascimento.Day < DateTime.Now.Day)
                {
                    return DateTime.Now.Year - Nascimento.Year;
                }
                else
                {
                    return DateTime.Now.Year - Nascimento.Year - 1;
                }
            }
        }

        public bool NecessidadesEspeciais()
        {
            return DoencasAlergias.Any();
        }
        public void AdicionarDoencasAlergias(string doencaAlergia)
        {
            DoencasAlergias.Add(doencaAlergia);
        }
        public void ImprimirAnimal()
        {
            Console.WriteLine("Imprimindo Pet");
            Console.WriteLine(Nome);
            Console.WriteLine(Especie);
            Console.WriteLine(Raca);
            Console.WriteLine(Cor);
            Console.WriteLine(Porte);
            Console.WriteLine(Peso);
            Console.WriteLine(Nascimento);
            Console.WriteLine(NecessidadesEspeciais());

            if (NecessidadesEspeciais())
            {
                Console.WriteLine("Doenças e Alergias:");
                foreach (string doencaalergia in DoencasAlergias)
                {
                    Console.WriteLine(doencaalergia);
                }
            }
            Console.WriteLine(Agressivo);
            Console.WriteLine(Sexo);
            Console.WriteLine(Castrado);
            Console.WriteLine("");
        }
    }
}
