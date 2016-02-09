using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Map game1 = new Map();
            game1.CreateGame();
            game1.PrintMap();
            game1.StartGame();  
        }
    }
}
