using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Enemy : Units
    {
        private char _renderChar;
        private int _id;        

        public Enemy(int id, int x, int y, string name, char _renderChar) : base(x, y, name)
        {
            _id = id;            
        }
        public char RenderChar
        {
            get { return _renderChar; }
            set
            {
                _renderChar = value;
                Render();
            }
        }

        public void MoveDown()
        {            
            Y++;

        }        

        /*public void PrintInfo()
        {
            //Console.WriteLine($" Enemy {_name} is at {_x}x{_y}");
        }*/

        public int GetId()
        {
            return _id;
        }
        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(RenderChar);
        }
    }
}
