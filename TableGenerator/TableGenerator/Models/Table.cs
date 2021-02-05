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


        public Table(int orientation)
        {   
            Rows = new int[10][];
            for (int r = 0; r < 10; r++) { Rows[r] = new int[10]; }

            if (orientation==2) { MakeHorizontal();}
            else if(orientation==1) { MakeVertical(); }

            //reset counter after making table
            counter = 1;
        }
        //public Table()
        //{
        //    Rows = new int[10][];
        //    for (int r = 0; r < 10; r++) { Rows[r] = new int[10]; }
        //}

        private void MakeHorizontal() 
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    fillSpot(x, y, counter);
                }
            }  
        }

        private void MakeVertical() 
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
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
