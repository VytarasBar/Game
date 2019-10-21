using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameWindow : Window
    {
        private Button _startButton;
        private Button _creditsButton;
        private Button _quitButton;
        private TextBlock _titleTextBlock;
        private List<Button> menuItem = new List<Button>();
        
        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            menuItem.Add(_startButton = new Button(20, 13, 18, 5, "Start"));
            _startButton.SetActive();

            menuItem.Add(_creditsButton = new Button(50, 13, 18, 5, "Credits"));

            menuItem.Add(_quitButton = new Button(80, 13, 18, 5, "Quit"));

        }

        public override void Render()
        {
            bool needToRender = true;
            int index = 0;

            base.Render();
            menuItem[0].Render();
            menuItem[1].Render();
            menuItem[2].Render();
            _titleTextBlock.Render();
            Console.SetCursorPosition(0, 0);
            
            do
            {
                while (needToRender)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    int hashCode = pressedKey.Key.GetHashCode();
                    Console.SetCursorPosition(0, 0);

                    menuItem[0].SetInActive();
                    menuItem[0].Render();
                    menuItem[1].SetInActive();
                    menuItem[1].Render();
                    menuItem[2].SetInActive();
                    menuItem[2].Render();
                    
                    switch (pressedKey.Key)
                    {

                        case ConsoleKey.RightArrow:

                            index++;
                            if (index > 2)
                            {
                                index = 0;
                            }
                            menuItem[index].SetActive();
                            menuItem[index].Render();
                            break;
                        case ConsoleKey.LeftArrow:
                            index--;
                            if (index < 0)
                            {
                                index = 2;
                            }
                            menuItem[index].SetActive();
                            menuItem[index].Render();
                            break;
                        case ConsoleKey.Enter:
                            if (index == 0)
                            {
                                GameController gameController = new GameController();
                                gameController.StartGame();
                                base.Render();
                                menuItem[0].Render();
                                menuItem[1].Render();
                                menuItem[2].Render();
                                _titleTextBlock.Render();
                                Console.SetCursorPosition(0, 0);
                            }
                            if (index == 1)
                            {
                                CreditWindow creditWindow = new CreditWindow();
                                creditWindow.Render();
                                base.Render();
                                menuItem[0].Render();
                                menuItem[1].Render();
                                menuItem[2].Render();
                                _titleTextBlock.Render();
                                Console.SetCursorPosition(0, 0);
                            }
                            if (index == 2)
                            {
                                needToRender = false;
                            }
                            break;
                    }
                    if(pressedKey.Key != ConsoleKey.RightArrow || pressedKey.Key != ConsoleKey.LeftArrow ||
                       pressedKey.Key != ConsoleKey.Enter)
                    {
                        menuItem[index].SetActive();
                        menuItem[index].Render();
                    }

                } 
            }while (needToRender);
        }
    }
}
