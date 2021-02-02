using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableGenerator.Models
{
    public class TableViewModel
    {
        public Table myTable;
        public string RowGraphic { get; set; }


        public TableViewModel(bool Horizontal)
        {
            RowGraphic = "";
            myTable = new Table(Horizontal);
           
        }
    }
}
