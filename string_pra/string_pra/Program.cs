using System;

namespace string_pra
{
    class Program
    {
        static void Main(string[] args)
        {
            

            information my_info=new information();
            Console.WriteLine("please enter your name!!");
            my_info.info=Console.ReadLine();
            Console.WriteLine(my_info.info);
            Console.WriteLine("please enter your birthdate !!");
            Console.WriteLine(my_info.birthdate());

            /*
            var info = (f_name:"chris",l_Name: "wondei",born:1992,graduation:2015,current_year:2013);
            string last_name = "my last name is wondeson";
            int age = 46;
            Console.WriteLine("my full name is {0} {1}",info.f_name,info.l_Name);
            Console.WriteLine("my brith date is {0}",info.born);
            Console.WriteLine("my actual age is {0}",info.current_year-info.born);
            Console.WriteLine("left days for graduation is {0}",info.graduation-info.current_year);
            var grade = (cgpa: 3.75, s_total: 3.68);
            grade.cgpa = 3.45;
            Console.WriteLine("your cumulative gpa is {0}\n" + "your semetor total is {1}", grade.cgpa, grade.s_total);
            if (grade.cgpa >= 3.75)

                Console.WriteLine("very great destination".ToUpper());
            else if (grade.cgpa == 3.75)
                Console.WriteLine("great destination".ToUpper());
            else if (grade.cgpa < 3.75)
                Console.WriteLine("work hard ".ToUpper());
           // this are string manipulations and grade calcualtor

            Console.WriteLine("please enter your name !!");
            name = Console.ReadLine();
            Console.WriteLine("your name is " + name);
            Console.WriteLine("your age is " + age);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(last_name.IndexOf("wondeson"));
            Console.WriteLine(name.Contains("babe"));
            Console.WriteLine(last_name.Contains("wondeson"));
            Console.WriteLine(last_name.Substring(16,4));
           // this are some of the vast string method used in c# */

        }

        class information 
        {
          public string info { get; set; }
         
          public DateTime days { get; set; }

          public int grade { get; set; }

            public bool birthdate ()
            { 
             days=DateTime.Now;
             Console.WriteLine("to day is :" + days.ToLongDateString());
             Console.WriteLine(" to day is :" +days.ToLongTimeString());
             TimeSpan age= DateTime.Now.Subtract(days);
             Console.WriteLine("your birthdate is :" +age.TotalDays);
             return true;
            }
        }
    }
}
