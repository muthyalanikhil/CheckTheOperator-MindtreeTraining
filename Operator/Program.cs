using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            String ch;
            Console.WriteLine("enter a operator: ");
            ch = Console.ReadLine();
            switch (ch)
            {

                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                case "++":
                case "--":

                    Console.WriteLine("{0} is Arithmetic Operator. ", ch);
                    break;
                case "=":
                case "+=":
                case "-=":
                case "*=":
                case "/=":
                case "%=":
                case "<<=":
                case ">>=":
                case "&=":
                case "^=":
                case "|=":
                    Console.WriteLine("{0} is Assignment Operator. ",ch);
                    break;

                case "&":
                case "|":
                case "^":
                case "~":
                case "<<":
                case ">>":
                    {
                        Console.WriteLine("{0} is bitwise operator.",ch);
                        break;
                    }

                case "==":
                case "!=":
                case ">":
                case "<":
                case ">=":
                case "&&":
                case "||":
                case "!":
                    {
                        Console.WriteLine("{0} is Logical Operator. ",ch);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Charecter you entered is not an operator.\nEnter an operator.");
                    }
                    break;
            }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine( );
            }
        }
    }
}


        
