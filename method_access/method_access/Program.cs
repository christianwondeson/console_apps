using System;

namespace method_access
{
    class Program
    {
        static void Main(string[] args)
        {
            Info();
            
        }

         static void Info()
        {
            string F_name,L_name;

            Console.WriteLine("please enter your first name !!");
            F_name = Console.ReadLine();
            Console.WriteLine("please enter your last name !!");
            L_name = Console.ReadLine();

            Console.WriteLine("hello "+ F_name.ToUpper() +" " + L_name.ToUpper());
            Console.WriteLine(F_name.Contains("christian"));
            Console.WriteLine(L_name.IndexOf("d"));
            Console.WriteLine(F_name.Substring(3,6));
        }
    }
}
