using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using TableGenerator.Models;

namespace TableGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Models.TableViewModel _viewmodel;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _viewmodel = new TableViewModel();
            //_viewmodel.Orientations = new List<SelectListItem>();
            //_viewmodel.Orientations.Add(new SelectListItem() { Text = "Vertical", Value = "1", Selected = false });
            //_viewmodel.Orientations.Add(new SelectListItem() { Text = "Horizontal", Value = "2", Selected = false });

        }
        [HttpGet]
        public IActionResult Index()
        {
            //_viewmodel = new TableViewModel() ;
            //_viewmodel.Orientations = new List<SelectListItem>();
            //_viewmodel.Orientations.Add(new SelectListItem() { Text = "Vertical", Value = "1", Selected = false });
            //_viewmodel.Orientations.Add(new SelectListItem() { Text = "Horizontal", Value = "2", Selected = false });


            // assign other SelectListItem list values here

            return View(_viewmodel);
        }

        //[HttpGet]
        //public ActionResult ControllerName()
        //{
        //    var model = new TableViewModel();
        //    model.Orientations = new List<SelectListItem>();
        //    model.Orientations.Add(new SelectListItem() { Text = "Vertical", Value = "1", Selected = false });
        //    model.Orientations.Add(new SelectListItem() { Text = "Horizontal", Value = "2", Selected = false });


        //    // assign other SelectListItem list values here

        //    return View(model);
        //}
        //[HttpPost]
        public IActionResult Privacy(/*[Bind("SelectedOrientation")] TableViewModel model*/)
        {
        //    _viewmodel.SelectedOrientation= Request.Form()
            _viewmodel.myTable= new Table(/*placeholder number*/ 0);
            return View(_viewmodel);
            
        }

        public IActionResult HorizontalTable()
        {
            _viewmodel.myTable = new Table(/*placeholder number*/ 2);
            return View(_viewmodel);
        }

        public IActionResult VerticalTable()
        {

            _viewmodel.myTable = new Table(/*placeholder number*/ 1);
            return View(_viewmodel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
