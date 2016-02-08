using System;

namespace Demo3
{
    class Student
    {
        private String Name;
        private int Age;
        private String Sex;
        private int Motivation = 10;
        private int Psyche = 10;
        private int Alcoholism = 8;

        public Student(String name, int age, String sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public void DoHomework()
        {
            if (this.Motivation < 10) this.Motivation++;
            if (this.Alcoholism > 7) this.Alcoholism--;
        }

        public void DoHomeWorkLate()
        {
            if (this.Motivation > 5) this.Motivation--;
            if (this.Psyche > 3) this.Psyche--;
            if (this.Alcoholism > 0) this.Alcoholism--;
        }

        public void MakeMoney()
        {
            if (this.Alcoholism < 3)
            {
                if (this.Psyche > 0) this.Psyche--;
                if (this.Motivation < 7) this.Motivation--;
                if (this.Alcoholism > 0) this.Alcoholism--;
            }
            else if (this.Alcoholism < 7)
            {
                this.Alcoholism--;
                if (this.Psyche < 10) this.Psyche++;
                if (this.Motivation > 7 && this.Motivation < 10) this.Motivation++;
            }
            else
            {
                if (this.Psyche < 8) this.Psyche = 10;
                if (this.Motivation > 6 && this.Motivation < 10) this.Motivation++;
            }
        }

        public void MeetFriends()
        {
            if (this.Motivation > 5 && this.Motivation < 10) this.Motivation++;
            else
            {
                if (this.Alcoholism < 6 && this.Alcoholism > 0) this.Alcoholism--;
            }
           
        }

        public void PrintData()
        {
            Console.WriteLine("\nName: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Sex: " + this.Sex);
            Console.WriteLine("Motivation (0 bad <--> 10 good): " + this.Motivation);
            Console.WriteLine("Psyche (0 insane <--> 10 sane): " + this.Psyche);
            Console.WriteLine("Alcoholism (0 alcoholic <--> 10 sober)" + this.Alcoholism );
        }

    }
}
