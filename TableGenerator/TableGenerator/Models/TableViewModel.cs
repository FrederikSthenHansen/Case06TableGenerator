using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        //public enum Orientation {Vertical, Horizontal}

        //public Orientation TableOrientation { get {return Enum.GetValues}; set; 
        [BindProperty]
        public int SelectedOrientation { get; set; }
        public List<SelectListItem> Orientations { get; set; }

        private static bool orientationsDone = false;

       
        public TableViewModel(/*bool buildTable*/)
        {
            if (orientationsDone == false)
            {
                Orientations = new List<SelectListItem>();
                Orientations.Add(new SelectListItem() { Text = "Vertical", Value = "1", Selected = false });
                Orientations.Add(new SelectListItem() { Text = "Horizontal", Value = "2", Selected = false });
                orientationsDone = true;
            }

            RowGraphic = "";
           
            if (SelectedOrientation == 2)
            { myTable = new Table(2); }
            if (SelectedOrientation == 1)
            { myTable = new Table(1); }
            //else { myTable = new Table(3); }
        }
    }
}
