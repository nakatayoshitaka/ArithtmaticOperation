using ArithmeticCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArithmeticCalculation.Controllers
{
    public class ArithmeticController : Controller
    {
        // GET: Arithmetic
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Default model,string Operater)
        {            
            if (Operater == "add") model.Result = model.Value1 + model.Value2;
            if (Operater == "sub") model.Result = model.Value1 - model.Value2;
            if (Operater == "mul") model.Result = model.Value1 * model.Value2;
            if (Operater == "div") model.Result = model.Value1 / model.Value2;
                        
            ModelState.Clear();
            return View(model);
        }
    }
}