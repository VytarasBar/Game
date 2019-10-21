using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Game

{
    class Hero : Units
    {
        private char _renderChar;

        public Hero(int x, int y, string name, char _renderChar) : base(x, y, name)
        {
            RenderChar = _renderChar; 
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
        public void MoveRight()
        {
            X++;
        }
        public void MoveLeft()
        {
            X--;
        }

        public int GetX()
        {
            return X;
        }
        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(RenderChar);
        }
    }
}
