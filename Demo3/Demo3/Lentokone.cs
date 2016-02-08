/*
* Lentokone, liikkeelle aina tankki täynnä ja hyvin perus kontrollit, ei mitään hienompaa
* 
* Versio 1.0 8.2.2016
*/

using System;
using System.Timers;

namespace Demo3
{
    class Lentokone
    {
        private char start;
        private int x = 0;
        private int y = 0;
        private int z = 0;
        private int rpm = 0;
        private int fuel;
        private static Timer timer = new Timer(3000 * 1000);
        private double counter = timer.Interval;
        private bool loop = true;
        private char control;
        private EventArgs Event;

        public void Aeroplane()
        {
            Console.WriteLine("Very basic and quick game, that let's you fly a plane.\nControls:");
            Console.WriteLine("E: Up, Q: Down, W: Throttle on, D: Turn right,");
            Console.WriteLine("A: Turn left");
            Console.WriteLine("Start engine? y/n ");
            start = Console.ReadKey().KeyChar;

            while (loop == true)
            {

            
                switch (start)
                {
                    case 'y':
                        rpm = 200;
                        flight();
                        loop = false;
                        break;

                    case 'n':
                        Console.WriteLine("Take care now, bye bye then!");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Check your input.\n");
                        break;
                }
            }

        }

        private void flight()
        {
            timer.Start();                                  //Start timer
            timer.AutoReset = false;                        //So timer doesn't reset itself 
            while(counter > 0)                              //Flying while timer is greater then 0
            {
                timer1_Tick_1(timer, Event);                //Calling timer to lower value of counter
                fuel = Convert.ToInt32(counter) / 10000;    //Counting value of how much fuel plane has left using our timer counter

                if (counter % 20000 == 0)                   //Printing stats of plane regarding to timer 
                {
                    Console.WriteLine("\nRPM: " + this.rpm + "\nFuel: " + this.fuel);
                    Console.WriteLine("Location:\nX: " + this.x + " Y: " + this.y + " Z: " + this.z);
                }

                if (counter % 100000 == 0 && rpm > 1000) { x++; }   //If rpm of plane is greater then 1000, then plane moves forward on x-axel during some time

                while (Console.KeyAvailable)                        //If key is pressed, program reads input key value
                {
                    control = Console.ReadKey().KeyChar;

                    if (control == 'w') { rpm = 2000; }
                    if (control == 's') { rpm = 200; }
                    if (control == 'a' && rpm > 1000) { z--; }
                    if (control == 'd' && rpm > 1000) { z++; }
                    if (control == 'e' && rpm > 1000) { y++; }
                    if (control == 'q') { y--; }
                }

                if (y < 0)                                  //if plane goes lower then 0 at y-axel, it crashes
                {
                    break; 
                }
            }
            if (y > 0 || y < 0) { GameOver(); }
            else { Console.WriteLine("You have succesfully landed!"); }

        }

        private void GameOver()
        {
            Console.WriteLine("                      _/ (  (    )   )  ___                  ");
            Console.WriteLine("                  /( (  (  )   _    ))  )   )                ");
            Console.WriteLine("                ((     (   )(    )  )   (   )  )             ");                 //Awesome ascii art :D 
            Console.WriteLine("             ((/  ( _()   (   _) ) (  () )  ) |)             ");
            Console.WriteLine("           ( (  ( (_)   ((    (   )  .((_ ) .  )_            ");
            Console.WriteLine("            ( (  )    (      (  )    )   ) . ) (   )         ");
            Console.WriteLine("           (  (   (  (   ) (  _(_) ).  ) . ) ) ( )           ");
            Console.WriteLine("           ( (  (   ) (  )   (  ))     ) _)(   )  )  )       ");
            Console.WriteLine("           ( (  (  ) (    (_() ( )  )   ) )  )) ( )          ");
            Console.WriteLine("            (  (   (  (   (_() ( _    )  ) (  )  )   )       ");
            Console.WriteLine("            ( (  ( (  (  )     (_  )  ) )  _)   ) _( ( )     ");
            Console.WriteLine("            ((  (   )(    (     _    )   _) _(_ (  (_ )      ");
            Console.WriteLine("             (_((__(_(__(( ( ( |  ) ) ) )_))__))_)___)       ");
            Console.WriteLine("               (( __)      \\||lll|l||/ /    _))             ");
            Console.WriteLine("                    (    /(/ (  )  ) )   )                   ");
            Console.WriteLine("                     (  ( ( ( | | ) ) )  )                   ");
            Console.WriteLine("                      (  /(| / ( )) ) ) )) )                 ");
            Console.WriteLine("                        (   ( ((((_(|)_)))))  )              ");
            Console.WriteLine("                         (   ||(|(|)|/||   )                 ");
            Console.WriteLine("                          (   |(||(||)||||   )               ");
            Console.WriteLine("                         (     / /|/l|||)|\\  )              ");
            Console.WriteLine("                        (/ / / / /|/|/||||\\   _)            ");
            if (y > 0) { Console.WriteLine("\nYOU RUN OUT OF GAS!!!\nGAME OVER\n"); }
            else { Console.WriteLine("\nYOU CRASHED!!!\nGAME OVER\n"); }
        }

        private void timer1_Tick_1(object sender, EventArgs e)              //Counter value drops using timer
        {
            counter--;
        }



    }
}
