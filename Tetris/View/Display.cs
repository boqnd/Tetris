using System;
using Tetris.Model;

namespace Tetris.View
{
    public class Display
    {              
        public void VisualiseField(Field f,Figures fig)
        {
            for (int r = 0; r < f.Rows; r++)
            {
                
                Console.Write("     . ");
                for (int c = 0; c < f.Cols; c++)
                {
                    string currCoo = r + " " + c;

                    if (fig.Coordinates.Contains(currCoo) || f.FigCoordinates.Contains(currCoo))
                    {
                        Console.Write("▒ ");
                    }
                    else if (r == 2)
                    {
                        Console.Write("~~");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                }
                Console.Write(". ");
                Console.WriteLine();
            }
            Console.Write("     ");
            for (int c = 0; c < f.Cols + 2; c++)
            {
                Console.Write("--");
            }
        }

        public void GameOver(int tetrises)
        {
            Console.WriteLine(" _____   ___  ___  ___ _____   _____  _   _ ___________");
            Console.WriteLine("|  __ \\ / _ \\ |  \\/  ||  ___| |  _  || | | |  ___| ___ \\");
            Console.WriteLine("| |  \\// /_\\ \\| .  . || |__   | | | || | | | |__ | |_/ /");
            Console.WriteLine("| | __ |  _  || |\\/| ||  __|  | | | || | | |  __||    /");
            Console.WriteLine("| |_\\ \\| | | || |  | || |___  \\ \\_/ /\\ \\_/ / |___| |\\ \\");
            Console.WriteLine(" \\____/\\_| |_/\\_|  |_/\\____/   \\___/  \\___/\\____/\\_| \\_|");
            Console.WriteLine(" _       _        _               ");
            Console.WriteLine("| |     | |      (_)                _  ");
            Console.WriteLine("| |_ ___| |_ _ __ _ ___  ___  ___  (_) ");
            Console.WriteLine("| __/ _ \\ __| '__| / __|/ _ \\/ __|        "   + tetrises);
            Console.WriteLine("| ||  __/ |_| |  | \\__ \\  __/\\__ \\  _ ");
            Console.WriteLine(" \\__\\___|\\__|_|  |_|___/\\___||___/ (_)");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("                     _        _           ");
            Console.WriteLine("                    | |      | |          ");
            Console.WriteLine(" _ __ ___   __ _  __| | ___  | |__  _   _ ");
            Console.WriteLine("| '_ ` _ \\ / _` |/ _` |/ _ \\ | '_ \\| | | |");
            Console.WriteLine("| | | | | | (_| | (_| |  __/ | |_) | |_| |");
            Console.WriteLine("|_| |_| |_|\\__,_|\\__,_|\\___| |_.__/ \\__, |");
            Console.WriteLine("                                     __/ |");
            Console.WriteLine("                                    |___/ ");
            Console.WriteLine("______                          ______ ");
            Console.WriteLine("| ___ \\                         |  _  \\");
            Console.WriteLine("| |_/ / ___  _   _  __ _ _ __   | | | |");
            Console.WriteLine("| ___ \\/ _ \\| | | |/ _` | '_ \\  | | | |");
            Console.WriteLine("| |_/ / (_) | |_| | (_| | | | | | |/ / ");
            Console.WriteLine("\\____/ \\___/ \\__, |\\__,_|_| |_| |___(_)");
            Console.WriteLine("              __/ |                    ");
            Console.WriteLine("             |___/                     ");
        }
        
    }
}