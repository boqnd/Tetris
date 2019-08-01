using System.Collections.Generic;

namespace Tetris.Model
{
    public class Figures
    {
        public List<List<string>> Figures1
        {
            get => figures;
            set => figures = value;
        }

        public List<string> Coordinates
        {
            get => coordinates;
            set => coordinates = value;
        }

        private List<List<string>> figures;
        private List<string> coordinates;
        
        public Figures()
        {
            figures = new List<List<string>>();
            coordinates = new List<string>();
            
            figures.Add(new List<string>(){"0 3","0 4","0 5","0 6"});
            figures.Add(new List<string>(){"0 5","1 5","2 5","3 5"});
            figures.Add(new List<string>(){"0 3","0 4","0 5","0 6"});
            figures.Add(new List<string>(){"0 5","1 5","2 5","3 5"});

            figures.Add(new List<string>(){"0 4","0 5","1 4","1 5"});
            figures.Add(new List<string>(){"0 4","0 5","1 4","1 5"});
            figures.Add(new List<string>(){"0 4","0 5","1 4","1 5"});
            figures.Add(new List<string>(){"0 4","0 5","1 4","1 5"});
            
            figures.Add(new List<string>(){"0 5","1 5","2 5","2 6"});
            figures.Add(new List<string>(){"0 4","0 5","0 6","1 4"});
            figures.Add(new List<string>(){"0 5","1 5","2 5","0 4"});
            figures.Add(new List<string>(){"1 4","1 5","1 6","0 6"});

            figures.Add(new List<string>(){"0 5","1 5","2 5","2 4"});
            figures.Add(new List<string>(){"1 4","1 5","1 6","0 4"});
            figures.Add(new List<string>(){"0 5","1 5","2 5","0 6"});
            figures.Add(new List<string>(){"0 4","0 5","0 6","1 6"});
          
            figures.Add(new List<string>(){"0 4","1 4","1 5","2 5"});
            figures.Add(new List<string>(){"1 4","1 5","0 5","0 6"});
            figures.Add(new List<string>(){"0 4","1 4","1 5","2 5"});
            figures.Add(new List<string>(){"1 4","1 5","0 5","0 6"});
            
            figures.Add(new List<string>(){"0 5","1 5","1 4","2 4"});
            figures.Add(new List<string>(){"0 4","0 5","1 5","1 6"});
            figures.Add(new List<string>(){"0 5","1 5","1 4","2 4"});
            figures.Add(new List<string>(){"0 4","0 5","1 5","1 6"});

            figures.Add(new List<string>(){"0 4","1 4","2 4","1 5"});
            figures.Add(new List<string>(){"0 4","0 5","0 6","1 5"});
            figures.Add(new List<string>(){"0 5","1 5","2 5","1 4"});
            figures.Add(new List<string>(){"1 4","1 5","1 6","0 5"});

        }
    }
}