using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FedorenkoKS.Sprint0.Task4.V0.Lib;

namespace Tyuiu.FedorenkoKS.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Additional
            Console.WriteLine(DataService.Addition(1, 5));
            //Метод вычитания 
            Console.WriteLine(DataService.Subtraction(15, 5));
            //метод умножения
            Console.WriteLine(DataService.Multiplication(10, 10));
            //метод деления
            Console.WriteLine(DataService.Division(228, 12));

            Console.ReadKey();

        }
    }
}
