using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str1;
                str1 = Console.ReadLine();
                char operation;
                operation = Convert.ToChar(Console.ReadLine());
                string str2;
                str2 = Console.ReadLine();
                
                

                if (Calculator.JudgeNumberOperation(str1) && Calculator.JudgeNumberOperation(str2))
                {
                    Console.Write("正在做数字运算：");
                    if (operation == '+')
                    {
                        Console.WriteLine(Calculator.Add(Convert.ToInt32(str1), Convert.ToInt32(str2)));
                    }
                    else if (operation == '-')
                    {
                        Console.WriteLine(Calculator.Reduce(Convert.ToInt32(str1), Convert.ToInt32(str2)));
                    }
                    else if (operation == '*')
                    {
                        Console.WriteLine(Calculator.Ride(Convert.ToInt32(str1), Convert.ToInt32(str2)));
                    }
                    else if (operation == '/')
                    {
                        Calculator.Except(Convert.ToInt32(str1), Convert.ToInt32(str2));
                    }
                    else
                    {
                        Console.WriteLine("运算错误！！！");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("正在做字符串运算：");
                    if (operation == '+')
                    {
                        Console.WriteLine(Calculator.Add(str1, str2));
                    }
                    else if (operation == '-')
                    {
                        Calculator.Reduce(str1, str2);
                    }
                    else
                    {
                        Console.WriteLine("运算错误!!!");
                        break;
                    }
                }
            }
        }
    }
}
