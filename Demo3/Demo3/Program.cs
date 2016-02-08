using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            bool jatko = true;



            while (jatko == true)
            {
                Console.WriteLine("\nChoose assignment: ");
                Console.WriteLine("1. Tehtävä 4");
                Console.WriteLine("2. Tehtävä 5");
                Console.WriteLine("3. Tehtävä 6");
                Console.WriteLine("4. Lopeta");
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {

                    case 1:
                        Vehicle vehicle1 = new Vehicle("Kottikärry", 10, 1);
                        vehicle1.PrintData();
                        vehicle1 = new Vehicle("Polkupyörä", 55, 2);
                        vehicle1.PrintData();
                        break;

                    case 2:
                        Student[] students = new Student[5];
                        students[0] = new Student("Martti", 30, "Mies");
                        students[1] = new Student("Pertti", 20, "Mies");
                        students[2] = new Student("Minna", 22, "Nainen");
                        students[3] = new Student("Seppo-Aliisa", 58, "Hermafrodiitti");
                        students[4] = new Student("Jorma", 7, "Mies");

                        foreach (Student student in students)
                        {
                            student.PrintData();
                        }

                        foreach (Student student in students)
                        {
                            for (int i = 0; i < 5; i++) student.DoHomeWorkLate();

                        }

                        Console.WriteLine("\n\n\nPari kertaa kaikilla läksyt ei maistu..\n\n");

                        foreach (Student student in students)
                        {
                            student.PrintData();
                        }

                        break;

                    case 3:
                        Lentokone plane = new Lentokone();
                        plane.Aeroplane();
                        break;

                    case 4:
                        jatko = false;
                        break;

                    default:
                        Console.WriteLine("Check your input");
                        break;
                }
            }
        }
    }
}
