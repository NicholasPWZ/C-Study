using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Models
{
    public class Conta
    {
        public string Cpf { get; set; }
        public int Account { get; set; }
        public int Agency { get; set; } 
        public int Balance { get; set; } 
    }
}