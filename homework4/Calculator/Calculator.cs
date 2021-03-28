using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        /// <summary>
        /// 是否可以进行数字运算
        /// </summary>
        /// <returns></returns>
        static public bool JudgeNumberOperation(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i <= ch.Length - 1; i++)
            {
                if (48 <= Convert.ToInt32(ch[i]) && Convert.ToInt32(ch[i]) <= 57)
                {
                    continue;
                }
                else
                {
                    return false;       //不可进行数字运算
                }
            }
            return true;
        }
        static public int Add(int x,int y)
        {
            return x + y;
        }
        static public string Add(string str1,string str2)
        {
            return str1 + str2;
        }
        static public int Reduce(int x, int y)
        {
            return x - y;
        }
        static public void Reduce(string str1,string str2)
        {
            if (str1.Contains(str2))
            {
                string str=str1.Replace(str2, "");
                Console.WriteLine(str); 
            }
            else
            {
                Console.WriteLine("计算错误！");
            }
        }
        static public int Ride(int x,int y)
        {
            return x * y;
        }
        static public void Except(int x,int y)
        {
            try
            {
                Console.WriteLine("{0}", x / y);
            }
            catch
            {
                Console.WriteLine("计算错误！");
            }
        }
    }
}
