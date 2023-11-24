using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.net1.Models1
{
    public class Pessoa
    {
        public  string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; } 

        public void Apresentar()
        {
            Console.WriteLine($"olá, Meu nome é {Nome},e tenho {Idade} anos. e meu Email é{Email}");
        }
    }
}