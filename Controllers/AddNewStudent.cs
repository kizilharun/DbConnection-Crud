using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbConnection_Crud.Models;

namespace DbConnection_Crud.Controllers
{
    public class AddNewStudent : Controller
    {
        private readonly ConnectionStringClass _con;

        public AddNewStudent(ConnectionStringClass con)
        {
            _con = con;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(Student student)
        {
            _con.Add(student);
            _con.SaveChanges();
            ViewBag.message = "The student who has name " + student.StudentFirstName + " is saved successfully..";
            return View();
        }
    }
}
