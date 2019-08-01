using System.Collections.Generic;

namespace Tetris.Model
{
    public class Field
    {
        private int rows;
        private int cols;

        public List<string> FigCoordinates
        {
            get => figCoordinates;
            set => figCoordinates = value;
        }

        private List<string> figCoordinates;

        public int Rows
        {
            get => rows;
            set => rows = value;
        }

        public int Cols
        {
            get => cols;
            set => cols = value;
        }

        public Field()
        {
            figCoordinates = new List<string>();
            rows = 25;
            cols = 12;
        }
    }
}