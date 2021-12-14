using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Hard_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string phrase = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();
            for (int i = 0; i < phrase.Length; i++)
            {
                switch (phrase[i])
                {
                    case '(': 
                        {
                            brackets.Push(')');
                            check = true;
                            break;               
                        }
                    case '{':
                        {
                            brackets.Push('}');
                            check = true;
                            break;
                        }
                    case '[':
                        {
                            brackets.Push(']');
                            check = true;
                            break;
                        }
                }
                if (brackets.Count() != 0)
                    if (phrase[i] == brackets.Peek())
                        brackets.Pop();
            }
            if (brackets.Count() == 0 && check)
                Console.WriteLine("Cкобки расставлены корректно");
            else
                Console.WriteLine("Скобки расставлены некорректно");
            Console.ReadKey();
        }
    }
}
