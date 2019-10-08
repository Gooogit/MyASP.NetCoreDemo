using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyASP.NetCoreDemo.Models;

namespace MyASP.NetCoreDemo.Controllers
{
        public class HomeController : Controller
        {

                private readonly IStudentRepository _studentRepository;
                public HomeController(IStudentRepository studentRepository)
                {
                        _studentRepository = studentRepository;
                }
                //public IActionResult Index()
                //{
                //        return View();
                //}
                public string Index()
                {
                        return _studentRepository.GetStudent(1).Name;
                        //return Json(new { id=1,name="Penciihi"});
                }
        }
}