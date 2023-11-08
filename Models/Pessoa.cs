using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Models
{
    public class Pessoa
    {
       public string Nome { get; set; }
       public int Idade { get; set; }

       public string Cpf { get; set; }

       public void apresentar(){
        Console.WriteLine($"Me chamo {Nome} e minha idade é {Idade}");
       }
    }
}