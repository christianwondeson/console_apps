using System;

namespace string__bob
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string []main=new string[4];
            Console.WriteLine("please enter your name as in \"sophonias deribssa\"");
            main[0] = Console.ReadLine();
            main[1] = "is your drive c:\\drive ?"; //string manipulation by adding \ on c:\drive 
            main[2]= @"is your drive c:\drive ?"; //adding @ and also adding new line 
            Console.WriteLine("{0}\n{1}\n{2}\n", main[0],main[1],main[2]);
            main[3] = string.Format("{0:C}",498.32);
            Console.WriteLine(main[3]) ;
            main[3] = string.Format("{0:N}",329045344);
            Console.WriteLine(main[3]);
            main[2] = string.Format("{0:P}",.342);
            Console.WriteLine(main[2]);
            main[1] = string.Format("{0:####-###-### +}", 3818897690);
            char[] chinv;
            chinv= main[1].ToCharArray();
            Array.Reverse(chinv);
            Console.WriteLine(main[1]);
            Console.WriteLine(chinv);
            Console.ReadLine();
             */

            /*string name;
            string zodiac;
           
            Console.WriteLine("hello !!");
            Console.Write("please enter your name :");
            name = Console.ReadLine();
            Console.Write("enter zodiac :");
            zodiac = Console.ReadLine();
            Console.WriteLine("enter date !!");
            string day = Console.ReadLine();

            Console.WriteLine("hello" +" " +name + " " 
                +"\n" +"your zodiac is :" + zodiac);
            Console.WriteLine("today is :" +" " +day);
            
            Console.WriteLine(" play game");
            Console.Write("enter number 1 for calling \n" +" enter number 2 for checking balance \n");
            string input = Console.ReadLine();

            string info = (input == "1") ? "your are calling" : "your balance is 23.5 birr";

            Console.WriteLine("you entered {0}\n therefore {1}",input,info);
            
            Console.WriteLine("welcome to easy calculator !!");

            string[] arithmetcs=new string[4];

            arithmetcs[0]="addition";
            arithmetcs[1]="subtraction";
            arithmetcs[2]="multiplication";
            arithmetcs[3]="division";

            foreach (var calcultation in arithmetcs)
	{
                Console.WriteLine(calcultation);
	}
          /*  Console.Write("enter 1 for adding \n" +
                          "enter 2 for subtracting \n" +
                          "enter 3 for comparing\n");
            string value = Console.ReadLine();
            string result = "reult is :";
            string last = "the smallerst is :";
            string most = "the largest is :";
            string output = "please enter any number !";
            if (value == "1")
            {
                 Console.WriteLine(output);
                 x = Console.Read();
                Console.ReadLine();
                Console.WriteLine(output);
                 y = Console.Read();
                Console.ReadLine();
                z = x + y;
                 Console.WriteLine(result,+z);
                
                Console.ReadLine();
            }
            else if (value == "2")
            {
                 Console.WriteLine(output);
                x = Console.Read();
                Console.ReadLine();
                Console.WriteLine(output);
                 y = Console.Read();
                Console.ReadLine();
                z = x - y;
                 Console.WriteLine(result,+z);

                Console.ReadLine();

            }
            else if (value == "3")
                Console.WriteLine(output);
                x = Console.Read();
                Console.ReadLine();
                Console.WriteLine(output);
                y = Console.Read();
                Console.ReadLine();
                Console.WriteLine(output);
                z = Console.Read();
                Console.ReadLine();
           
                  int phase_1 = (x < y) ? x : y;
                  int phase_2 = (phase_1 < z) ? phase_1 : z;
                 Console.WriteLine(last,+phase_2);
       */
            DateTime days=DateTime.Now;
            DateTime dd = DateTime.UtcNow;
            DateTime bday;
            TimeSpan dayss;

            Console.WriteLine(days.ToString());
            Console.WriteLine(dd.ToString());
            Console.WriteLine(days.ToShortDateString());
            Console.WriteLine(days.ToShortTimeString());
            Console.WriteLine(days.ToLongDateString());
            Console.WriteLine(days.ToLongTimeString());
            Console.WriteLine(dd.ToLongTimeString());
            Console.WriteLine(dd.ToLongDateString());
            Console.WriteLine(days.AddDays(30).ToLongDateString());
            Console.WriteLine(dd.Month);
            bday = DateTime.Parse("23/06/1999");
            Console.WriteLine(bday.ToLongDateString());
            dayss= DateTime.Now.Subtract(bday);
            Console.WriteLine(dayss.TotalDays);
            Console.ReadLine();



             
        }
    }
}
