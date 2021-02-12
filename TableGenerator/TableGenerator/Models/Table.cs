using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableGenerator.Models
{
    public class Table
    {
        int counter = 1;
        public int[][] Rows;


        public Table(int orientation, int lenght, int width)
        {
            #region set lenght/width to 10, if not set
            if (lenght == 0) {lenght = 10;}
            if (width == 0) { width = 10; }
            #endregion

            #region Initialize matrix with 0 in every spot to avoid null-refferences , when filling out array
            Rows = new int[lenght][];
            for (int r = 0; r < lenght; r++) { Rows[r] = new int[width]; }
            #endregion

            if (orientation==2) { MakeHorizontal(lenght,width);}
            else if(orientation==1) { MakeVertical(lenght,width); }

            //reset counter after making table
            counter = 1;
        }

        private void MakeHorizontal(int lenght, int width) 
        {
            for (int y = 0; y < lenght; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    fillSpot(x, y, counter);
                }
            }  
        }

        private void MakeVertical(int lenght, int width) 
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < lenght; y++)
                {
                    fillSpot(x, y, counter);
                }
            }
        }

        private void fillSpot(int x, int y, int value)
        {
            Rows[y][x] = value;
            counter++;
        }
        
    }
}
