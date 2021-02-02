using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableGenerator.Models
{
    public class Table
    {
        int counter = 1;
        int[] currentRow;
        public int[][] Rows;


        public Table(bool Horizontal)
        {   Rows = new int[10][];
            for (int r = 0; r < 10; r++) { Rows[r] = new int[10]; }

            if (Horizontal == true) { MakeHorizontal();}
            else { MakeVertical(); }
        }

        private void MakeHorizontal() 
        {
            for (int y = 0; y < 10; y++)
            {
                
                for (int x = 0; x < 10; x++)
                {
                    fillSpot(x, y, counter);
                    counter++;
                }
            }
            //reset counter after generating table.
            counter = 1;
        }

        private void MakeVertical() 
        {
            for (int x = 0; x < 10; x++)
            {
               
                for (int y = 0; y < 10; y++)
                {
                    fillSpot(x, y, counter);
                    counter++;
                }
            }
            //reset counter after generating table.
            counter = 1;
        }

        private void fillSpot(int x, int y, int value)
        {
            
            Rows[y][x] = value;
        }
        
    }
}
