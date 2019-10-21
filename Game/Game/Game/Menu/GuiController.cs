using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GuiController
    {
        private GameWindow gameWindow = new GameWindow();

        public void ShowMenu()
        {            
            InitMenu();
        }

        private void InitMenu()
        {
            gameWindow.Render();
            
        }
    }
}
