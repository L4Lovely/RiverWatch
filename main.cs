using System;
using System.Collections.Generic;
using System.Threading;

namespace RiverObserver{
    internal class Program{
        static void Main(string[] args){
            
            // Ships act autonomously. 
            // If a river is at capacity a ship will either WAIT, or turn
            // around and select another river which is connected.

            Console.Clear();
            Console.CursorVisible = false;
            
            
            Box MainFrame = new Box(Console.WindowWidth,Console.WindowHeight,0,0);
            int boxwidth = 22;
            int offset_x = 6;

            RiverBox RB0 = new RiverBox(boxwidth,15,(offset_x * 1)                 ,6, "Rhine");
            RiverBox RB1 = new RiverBox(boxwidth,15,(offset_x * 2) + (boxwidth * 1),6, "Neckar");
            RiverBox RB2 = new RiverBox(boxwidth,15,(offset_x * 3) + (boxwidth * 2),6, "Mosel");
            RiverBox RB3 = new RiverBox(boxwidth,15,(offset_x * 4) + (boxwidth * 3),6, "Krassel");
            RiverBox RB4 = new RiverBox(boxwidth,15,(offset_x * 5) + (boxwidth * 4),6, "Hang-Over");
            RiverBox RB5 = new RiverBox(boxwidth,15,(offset_x * 6) + (boxwidth * 5),6, "Herbar");
            RiverBox RB6 = new RiverBox(boxwidth,15,(offset_x * 7) + (boxwidth * 6),6, "(/$§)0");
            RiverBox RB7 = new RiverBox(boxwidth,15,(offset_x * 8) + (boxwidth * 7),6, "Programmsel");
            
            Console.SetCursorPosition(1,1);
            
        }
    }
}
