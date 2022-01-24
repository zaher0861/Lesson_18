using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку, состоящую из скобок трех видов (круглые,\nквадратные и фигурные) и любых других символов, а программа\nпроверит на корректность расставления скобок");
            string symbolsString = Console.ReadLine();
            Console.WriteLine(Result(symbolsString));
            Console.ReadKey();
        }
        static bool Result(string symbolsString)
        {
            Dictionary<char, char> symbolsDictionary = new Dictionary<char, char>
            {
                { '[',']' },
                { '{','}' },
                { '(',')' }
            };
            Stack<char> symbolsStack = new Stack<char>();
            foreach (char s in symbolsString)
            {
                if (s == '(' || s == '{' || s == '[')
                {
                    symbolsStack.Push(symbolsDictionary[s]);
                }
                if (s == ')' || s == '}' || s == ']')
                {
                    if (symbolsStack.Count == 0 || s != symbolsStack.Pop())
                    {
                        return false;
                    }
                }
            }
            if (symbolsStack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
              
                     
            
    }
}
