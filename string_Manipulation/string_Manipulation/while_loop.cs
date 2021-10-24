using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_Manipulation
{
    class while_loop
    {

        public static void main_M()
        {
            bool enter = true;
            var items = (op1:" option 1", op2:" option 2", op3:" exit 3");
            var choice = (num1: "1", num2: "2", num3: "3");
            //Console.Write("{0}\n{1}\n{2}", choice.num1, choice.num2, choice.num3);
            Console.Write("{0}\n{1}\n{2}",items.op1,items.op2,items.op3);
            Console.WriteLine("please enter options below");
            string input = Console.ReadLine();

            while (enter)
            {
                if (input == choice.num1)
                {
                    Console.WriteLine(items.op1);
                    games();

                }
                else if (input.SequenceEqual(items.op2))
                {
                    Console.WriteLine(items.op2);
                    print_number();
                }
                else
                {
                    Console.WriteLine("exit");
                    Console.WriteLine(items.op3);

                }

            }

        }
        public static void print_number()
        {
            string infor;
            infor= "printing sth";
            Console.WriteLine(infor);
        }
        public static void games()
        {
            string infors = "printing sth";
            Console.WriteLine(infors);
        }
    }
}
