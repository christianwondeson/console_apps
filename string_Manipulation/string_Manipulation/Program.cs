using System;

namespace string_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {

            while_loop.main_M();
            
            string[] name = new string[3];
            string info;
            info = "please enter your first Name".ToUpper();
            Console.WriteLine(info);
            name[0] = Console.ReadLine();
            info = "please enter your last Name".ToUpper();
            Console.WriteLine(info);
            name[1] = Console.ReadLine();
            info = "please enter your city Name".ToLower();
            Console.WriteLine(info);
            name[2] = Console.ReadLine();
            info = "your name is :";
            Console.WriteLine(info + name[0] + " " + name[1]);

            Console.WriteLine("your city is :" + name[2]);
            Console.WriteLine("your information is reversed:");
            string frs = string_man(name[0]);
            string las = string_man(name[1]);
            string cy =  string_man(name[2]);
            disp(string_man(name[0]), string_man(name[1]), string_man(name[2])); //this will display the string which is return
            Console.Write("your information is reversed:");
            Console.WriteLine();
            //overloading the same function with different parameter
            disp(string_man(name[0]), string_man(name[1])+" ", string_man(name[2]));
        }
        private static string string_man(string message)
        { 
            //this will reverse the string after changing it into string
            char[] ss = message.ToCharArray();
            Array.Reverse(ss);
            return string.Concat(ss);
        }
        private static void disp(string frs,string las,string cy)
        {
            //this method will display the sting by using the return info from the string _man method
            Console.Write(string.Format("{0} {1} {2}", frs, las, cy));
            Console.ReadLine();
        }
        private static void disp(string message) //using for overloading
        {
            Console.Write(message);
            Console.WriteLine();
        }
    }
}

