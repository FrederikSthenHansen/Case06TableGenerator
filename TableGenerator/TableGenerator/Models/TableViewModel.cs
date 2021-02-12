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
        
        //private int options = 15;

        [BindProperty]
        public string SelectedOrientation { get; set ; }
        public List<SelectListItem> Orientations { get; set; }
        public int SelectedWidth { get; set; }
        public List<SelectListItem> Width { get; set; }
        public int SelectedLenght { get; set; }
        public List<SelectListItem> Lenght { get; set; }


        //private static bool orientationsDone = false;

       
       public TableViewModel()
        {
            //if (orientationsDone == false)
            //{
            //    Orientations = new List<SelectListItem>();
            //    Orientations.Add(new SelectListItem() { Text = "Vertical", Value = "1", Selected = false });
            //    Orientations.Add(new SelectListItem() { Text = "Horizontal", Value = "2", Selected = false });
            //    Lenght = new List<SelectListItem>();
            //    Width = new List<SelectListItem>();
            //    for(int i=1; i <= options; i++)
            //    {
            //        Width.Add(new SelectListItem() { Text = $"{i}", Value = $"{i}", Selected = false });
            //        Lenght.Add(new SelectListItem() { Text = $"{i}", Value = $"{i}", Selected = false });
            //    }
                


            //    SelectedOrientation = "";
            //    orientationsDone = true;

            //}

            //RowGraphic = "";
           
            //if (SelectedOrientation == "2")
            //{ myTable = new Table(2, SelectedLenght,SelectedWidth); }
            //if (SelectedOrientation == "1")
            //{ myTable = new Table(1, SelectedLenght, SelectedWidth); }
            //else { myTable = new Table(3); }
        }
    }
}
