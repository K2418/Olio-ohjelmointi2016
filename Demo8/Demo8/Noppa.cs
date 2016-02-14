using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8
{
    class Noppa
    {
        int count1, count2, count3, count4, count5, count6, sum = 0;
        int value, x;
        double average;
        Random rand = new Random();

        public void Dice()
        {
            Console.WriteLine("Roll dice for how many times?");
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                if(x < 1) { Console.WriteLine("Please, give positive value"); }
                else if(x == 1)
                {
                    RollDice(x);
                    Console.WriteLine("Rolled once, throw value is: " + sum );
                }
                else
                {
                    Console.WriteLine("Dice will be rolled " + x + " times.\n");
                    RollDice(x);
                    average = Convert.ToDouble(sum) / x;
                    Console.WriteLine("Average of " + x + " rolls: " + average);
                    Console.WriteLine("1's: " + count1 + "\n2's: " + count2 + "\n3's: " + count3 + "\n4's: " + count4 + "\n5's: " + count5 + "\n6's: " + count6 + "\n");
                }
                
            }
            catch ( Exception  ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void RollDice(int times)
        {
            for(int i = 0; i < times; i++)
            {
                value = rand.Next(1, 7);

                if(value == 1)
                {
                    count1++;
                    sum += value;
                }
                else if(value == 2)
                {
                    count2++;
                    sum += value;
                }
                else if (value == 3)
                {
                    count3++;
                    sum += value;
                }
                else if (value == 4)
                {
                    count4++;
                    sum += value;
                }
                else if (value == 5)
                {
                    count5++;
                    sum += value;
                }
                else if (value == 6)
                {
                    count6++;
                    sum += value;
                }
                else
                {
                    Console.WriteLine("Something went wrong...");
                }


            }

        }

    }
}
