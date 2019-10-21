using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Units
    {
        protected int X;
        protected int Y;
        private string Name;
        //protected char RenderChar;
        public Units(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
            //RenderChar = renderChar;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Unit {Name} is at {X}x{Y}");
        }
        /*public void Render()
        {
            Console.SetCursorPosition(X,Y);
            Console.Write(X);
        }*/
    }
}