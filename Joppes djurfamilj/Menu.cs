using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JoppesDjurFamilj
{
    public class Menu
    {
        private int SelectedIndex = 0;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
        }

        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for(int i = 0; i < Options.Length; i++)
            {
                if(i == SelectedIndex)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"<< {Options[i]} >>");
            }
            ResetColor();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                keyPressed = ReadKey(true).Key;
                if(keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if(SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }else if(keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if(SelectedIndex > Options.Length - 1)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);
            Clear();
            return SelectedIndex;
        }
    }
}
