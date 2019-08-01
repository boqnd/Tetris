using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Tetris.Model;
using Tetris.View;

namespace Tetris.Controler
{
    public class Service
    {
        private Figures fig;
        private Field f;
        private Display _display;
        private int tetrises = 0;
        private int currFormNum = 0;

        public int Tetrises
        {
            get => tetrises;
            set => tetrises = value;
        }

        char input = ' ';

        private int speed = 400; 
        private int fast = 400;

        public Service()
        {
            fig = new Figures();
            f = new Field();
            _display = new Display();
        }

        public void GetInput()
        {
            input = Console.ReadKey().KeyChar;

        }

        public void MakeFast()
        {
            fast = 100;
            Thread.Sleep(250);
            fast = speed;
        }
        public void Start()
        {
            fig.Coordinates.Add(fig.Figures1[0][0]);
            fig.Coordinates.Add(fig.Figures1[0][1]);
            fig.Coordinates.Add(fig.Figures1[0][2]);
            fig.Coordinates.Add(fig.Figures1[0][3]);

            while (true)
            {
                Console.WriteLine();
                input = ' ';
                Thread getInput = new Thread(GetInput);

                getInput.Start();
                Thread.Sleep(fast);

                List<string> currCoo = new List<string>();
                currCoo.Add(fig.Coordinates[0]);
                currCoo.Add(fig.Coordinates[1]);
                currCoo.Add(fig.Coordinates[2]);
                currCoo.Add(fig.Coordinates[3]);




                for (int i = 0; i < fig.Coordinates.Count; i++)
                {
                    string curr = fig.Coordinates[i];
                    int s = curr.Split(" ").Select(int.Parse).ToList()[0];
                    s++;
                    string newC = s + " " + curr.Split(" ").Select(int.Parse).ToList()[1];
                    fig.Coordinates[i] = newC;
                }
                if (input != ' ')
                {
                    if (input == 'd')
                    {
                        for (int i = 0; i < fig.Coordinates.Count; i++)
                        {
                            string curr = fig.Coordinates[i];
                            int s = curr.Split(" ").Select(int.Parse).ToList()[1];
                            s++;
                            string newC = curr.Split(" ").Select(int.Parse).ToList()[0] + " " + s;
                            fig.Coordinates[i] = newC;
                        }
                        for (int i = 0; i < fig.Coordinates.Count; i++)
                        {
                            if (f.FigCoordinates.Contains(fig.Coordinates[i]))
                            {
                                fig.Coordinates.Clear();

                                fig.Coordinates.Add(currCoo[0]);
                                fig.Coordinates.Add(currCoo[1]);
                                fig.Coordinates.Add(currCoo[2]);
                                fig.Coordinates.Add(currCoo[3]);
                            }
                        }
                    }else if (input == 'a')
                    {
                        for (int i = 0; i < fig.Coordinates.Count; i++)
                        {
                            string curr = fig.Coordinates[i];
                            int s = curr.Split(" ").Select(int.Parse).ToList()[1];
                            s--;
                            string newC = curr.Split(" ").Select(int.Parse).ToList()[0] + " " + s;
                            fig.Coordinates[i] = newC; 
                        }
                        for (int i = 0; i < fig.Coordinates.Count; i++)
                        {
                            if (f.FigCoordinates.Contains(fig.Coordinates[i]))
                            {
                                fig.Coordinates.Clear();

                                fig.Coordinates.Add(currCoo[0]);
                                fig.Coordinates.Add(currCoo[1]);
                                fig.Coordinates.Add(currCoo[2]);
                                fig.Coordinates.Add(currCoo[3]);
                            }
                        }
                        
                    }else if (input == 's')
                    {
                        Thread makeFast = new Thread(MakeFast);
                        makeFast.Start();
                    }
                }

                Random r = new Random();

                int rand = r.Next(1, 8);
                rand = rand * 4 - 3;

                for (int i = 0; i < fig.Coordinates.Count; i++)
                {
                    if (fig.Coordinates[i].Split(" ").Select(int.Parse).ToList()[0] > f.Rows - 1 ||
                        f.FigCoordinates.Contains(fig.Coordinates[i]))   
                    {   
                        f.FigCoordinates.Add(currCoo[0]);
                        f.FigCoordinates.Add(currCoo[1]);
                        f.FigCoordinates.Add(currCoo[2]);
                        f.FigCoordinates.Add(currCoo[3]);

                        currFormNum = rand;


                        fig.Coordinates.Clear();

                        fig.Coordinates.Add(fig.Figures1[currFormNum][0]);
                        fig.Coordinates.Add(fig.Figures1[currFormNum][1]);
                        fig.Coordinates.Add(fig.Figures1[currFormNum][2]);
                        fig.Coordinates.Add(fig.Figures1[currFormNum][3]);

                    }

                    if (fig.Coordinates[i].Split(" ").Select(int.Parse).ToList()[1] < 0 ||
                        fig.Coordinates[i].Split(" ").Select(int.Parse).ToList()[1] > f.Cols -1)
                    {
                        fig.Coordinates.Clear();
                        
                        fig.Coordinates.Add(currCoo[0]);
                        fig.Coordinates.Add(currCoo[1]);
                        fig.Coordinates.Add(currCoo[2]);
                        fig.Coordinates.Add(currCoo[3]);
                    }
                }

                if (input == 'w')
                {
                    int orgRow = fig.Figures1[currFormNum][0].Split(" ").Select(int.Parse).ToList()[0];
                    int orgCol = fig.Figures1[currFormNum][0].Split(" ").Select(int.Parse).ToList()[1];
  
                    int row = fig.Coordinates[0].Split(" ").Select(int.Parse).ToList()[0];
                    int col = fig.Coordinates[0].Split(" ").Select(int.Parse).ToList()[1];

                    int rowDiff = row - orgRow;
                    int colDiff = col - orgCol;

                    currFormNum++;

                    if (currFormNum%4 == 0)
                    {
                        currFormNum -= 4;
                    }
             
                    fig.Coordinates.Clear();

                    fig.Coordinates.Add((fig.Figures1[currFormNum][0].Split(" ").Select(int.Parse).ToList()[0]+rowDiff) + " " + (fig.Figures1[currFormNum][0].Split(" ").Select(int.Parse).ToList()[1]+ colDiff));
                    fig.Coordinates.Add((fig.Figures1[currFormNum][1].Split(" ").Select(int.Parse).ToList()[0]+rowDiff) + " " + (fig.Figures1[currFormNum][1].Split(" ").Select(int.Parse).ToList()[1]+ colDiff));
                    fig.Coordinates.Add((fig.Figures1[currFormNum][2].Split(" ").Select(int.Parse).ToList()[0]+rowDiff) + " " + (fig.Figures1[currFormNum][2].Split(" ").Select(int.Parse).ToList()[1]+ colDiff));
                    fig.Coordinates.Add((fig.Figures1[currFormNum][3].Split(" ").Select(int.Parse).ToList()[0]+rowDiff) + " " + (fig.Figures1[currFormNum][3].Split(" ").Select(int.Parse).ToList()[1]+ colDiff));
                }

                for (int ro = 0; ro < f.Rows; ro++)
                {
                    List<string> coordin = new List<string>();
                    for (int fo = 0; fo < f.FigCoordinates.Count; fo++)
                    {
                        int row = f.FigCoordinates[fo].Split(" ").Select(int.Parse).ToList()[0];
                        if (row == 2)
                        {
                            Console.Clear();
                            _display.GameOver(tetrises);
                            Environment.Exit(0);
                        }
                        if (row == ro)
                        {
                            coordin.Add(f.FigCoordinates[fo]);
                        }
                    }

                    if (coordin.Count == f.Cols)
                    {
                        tetrises++;
                        if (tetrises>=3)
                        {
                            speed = 350;
                        }else if (tetrises >= 6)
                        {
                            speed = 300;
                        }else if (tetrises >= 10)
                        {
                            speed = 250;
                        }
                        
                        int removedRow = coordin[0].Split(" ").Select(int.Parse).ToList()[0];
                        for (int i = 0; i < coordin.Count; i++)
                        {
                            f.FigCoordinates.Remove(coordin[i]);
                        }
                        
                        for (int fo = 0; fo < f.FigCoordinates.Count; fo++)
                        {
                            int row = f.FigCoordinates[fo].Split(" ").Select(int.Parse).ToList()[0];
                            if (row < removedRow)
                            {
                                row++;
                                f.FigCoordinates[fo] = row + " " +f.FigCoordinates[fo].Split(" ").Select(int.Parse).ToList()[1];
                            }
                        }
                    }
                    
                    
                    
                }
                
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine(" _____ _____ ___________ _____ _____ ");
                Console.WriteLine("|_   _|  ___|_   _| ___ \\_   _/  ___|");
                Console.WriteLine("  | | | |__   | | | |_/ / | | \\ `--. ");
                Console.WriteLine("  | | |  __|  | | |    /  | |  `--. \\");
                Console.WriteLine("  | | | |___  | | | |\\ \\ _| |_/\\__/ /");
                Console.WriteLine("  \\_/ \\____/  \\_/ \\_| \\_|\\___/\\____/ ");
                _display.VisualiseField(f, fig);
                Console.WriteLine();
                Console.WriteLine("tetrises: " + tetrises);


            }



        }


    }


}