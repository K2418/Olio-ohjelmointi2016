using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Radio
    {
        private int volume = 0;
        private readonly int MaxVolume = 9;
        private double channel = 2000.0;
        private readonly double MaxChannel = 26000.0;
        private readonly double MinChannel = 2000.0;
        public bool power = false;
        private String PowerText;

        public int Volume
        {
            get
            {
                if (power == false)
                {
                    Console.WriteLine("Radio is off");
                    return volume;
                }
                else { return volume; }
            }

            set
            {
                if (power == false) { Console.WriteLine("Radio is off"); }
                else
                {
                    if (value <= MaxVolume && value >= 0) { volume = value; }
                    else { Console.WriteLine("Check your input, volume must be between 0 & 9."); }
                }
            }
        }

        public double Channel
        {
            get
            {
                if (power == false)
                {
                    Console.WriteLine("Radio is off");
                    return channel;
                }
                else { return channel; }
            }

            set
            {
                if (power == false) { Console.WriteLine("Radio is off"); }
                else
                {
                    if (value <= MaxChannel && value >= MinChannel) { channel = value; }
                    else { Console.WriteLine("Check your input, channel range 2000.0 - 26000.0."); }
                }
            }
        }


        public void PrintSettings()
        {
            if (power == true) { PowerText = "On"; }
            else { PowerText = "Off"; }
            Console.WriteLine("\nPower: " + PowerText);
            if (power == true)
            {
                Console.WriteLine("Volume: " + volume);
                Console.WriteLine("Channel: " + channel);
            }
        }
    }
}
