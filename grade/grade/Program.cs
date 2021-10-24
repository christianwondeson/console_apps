using System;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
             double[] scale = { 4.0 , 3.7, 3.3 , 3.0 , 2.7 , 2.3 , 2.0 , 1.7 , 1.3 , 1.0 , 0.0};
            int year;
            int semestor;
            double[] result = new double[7];
            int[] credit_hour= new int[7];
            int courses;
            string comm,comm_1,comm_2,comm_3;
            double[] grade= new double[7];
            var comment = (comm:"very great destination",comm_1:"great destination",comm_2:"destination",comm_3:"bad destination");
            Restart:
              Console.WriteLine("please enter your full name");
              string full_name = Console.ReadLine();

              Console.WriteLine("please enter current year of study");
              year =Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("please enter current semestor of study");
              semestor =Convert.ToInt32(Console.ReadLine());
           private var info = (full_name,year,semestor);

              Console.WriteLine("you name is {0} and you're {1} year ,{2} semestor student", info.full_name, info.year, info.semestor);

            if (info.year == 1){
               Fresh_men();
            }
            else if (info.year == 2){
                Second_stud();
            }
            else if (info.year == 3)
                {
                Thrid_stud();
                }
             else if (info.year == 4)
                Console.WriteLine("welcome fourth year");
            else if (info.year == 5)
                Console.WriteLine("welcome graduating class year");
            else {
                
                Console.WriteLine("please enter your info again !!");
                 goto Restart;
              }

            }
           
             public static void Fresh_men(){
           Console.WriteLine("welcome first men");
        }
       public  static void Second_stud(){
          Console.WriteLine("welcome second year");
        }
        public static void Thrid_stud(){
          Console.WriteLine("welcome third year student !!");
                if (info.semestor == 1) {
                    Console.WriteLine("you have learnt this courses ");
                    Console.WriteLine("enter number of courses");
                    courses = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter grade for"+"vlsi :".ToUpper());
                    grade[0] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter credit hour of the course :");
                    credit_hour[0] = Convert.ToInt32(Console.ReadLine());
                    result[0] = credit_hour[0] * grade[0];
                    Console.WriteLine(result[0]);

                    Console.WriteLine("enter grade for" + "signal and system :".ToUpper());
                    grade[1] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter credit hour of the course :");
                    credit_hour[1] = Convert.ToInt32(Console.ReadLine());
                    result[1] = credit_hour[1] * grade[1];
                    Console.WriteLine(result[1]);

                    Console.WriteLine("enter grade for" + "discrete mathimatics :".ToUpper());
                    grade[2] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter credit hour of the course :");
                    credit_hour[2] = Convert.ToInt32(Console.ReadLine());
                    result[2] = credit_hour[2] * grade[2];
                    Console.WriteLine(result[2]);

                    Console.WriteLine("enter grade for" + "entrepernuership :".ToUpper());
                    grade[3] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter credit hour of the course :");
                    credit_hour[3] = Convert.ToInt32(Console.ReadLine());
                    result[3] = credit_hour[3] * grade[3];
                    Console.WriteLine(result[3]);

                    Console.WriteLine("enter grade for" + "database systems :".ToUpper());
                    grade[4] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter credit hour of the course :");
                    credit_hour[4] = Convert.ToInt32(Console.ReadLine());
                    result[4] = credit_hour[4] * grade[4];
                    Console.WriteLine(result[4]);

                    Console.WriteLine("enter grade for" + "computer arch. :".ToUpper());
                    grade[5] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter credit hour of the course :");
                    credit_hour[5] = Convert.ToInt32(Console.ReadLine());
                    result[5] = credit_hour[5] * grade[5];
                    Console.WriteLine(result[5]);

                    result[5] = result[0] + result[1] + result[2] + result[3] + result[4] + result[5];
                    Console.WriteLine("overall result :" + result[5]);
                    credit_hour[5] = credit_hour[0] + credit_hour[1] + credit_hour[2] + credit_hour[3] + credit_hour[4] + credit_hour[5];
                    Console.WriteLine("total credit hour learnt :" + credit_hour[5]);
                    result[6] = result[5] / credit_hour[5];
                    Console.WriteLine("cumulative" + "gpa :".ToUpper()+result[6]);

                    if (result[6] == scale[0])
                        Console.WriteLine("{0}", comment.comm);
                    else if (result[6] == scale[1])
                        Console.WriteLine("{0}", comment.comm_1);
                    else if (result[6] == scale[2])
                        Console.WriteLine("{0}", comment.comm_2);
                    else if (result[6] == scale[3])
                        Console.WriteLine("{0}", comment.comm_2);
                    else if (result[6] == scale[4])
                        Console.WriteLine("{0}", comment.comm_3);
        }
    }

        }

       
}
