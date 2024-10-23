using System;
using System.Collections.Generic;   
using System.Linq;  
using System.Threading.Tasks;       

namespace Códigos.Models{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            if (x >= 10 && y >= 10){
                Console.WriteLine("Test 1");
            }else{
                Console.WriteLine("Test 2");
            }
        }
         public void Subtração(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void Divisão(int x, int y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
         public void Multiplicação(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
         public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
        }
         public void Seno(double angulo){
            double radiano = angulo * Math.PI/ 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"seno de {angulo}° = {Math.Round(seno,2)}");
         }
         public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double conseno = Math.Cos(radiano);
            Console.WriteLine($"o conseno de {angulo}° = {Math.Round(conseno,2)}"); 
         }
         public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A tangente de {angulo}° = {Math.Round(tangente, 2)}");
         }

        public void Raizquadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz é de valor {x} = {Math.Round(raiz, 2)} ");
        }
    }
}