using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Models
{
    public class Calculadora
    {
        public void Somar(double x, double y){
            double Resultado = x + y;
            Console.WriteLine($"Resultado final da equação: {Resultado}");
        }
        public void Subtrair(double x, double y){
            double Resultado = x - y;
            Console.WriteLine($"Resultado final da equação: {Resultado}");;
        }
        public void Multiplicar(double x, double y){
            double Resultado = x * y;
            Console.WriteLine($"Resultado final da equação: {Resultado}");
        }
        public void Dividir(double x, double y){
            double Resultado = x / y;
            Console.WriteLine($"Resultado final da equação: {Resultado}");
        }
    }
}