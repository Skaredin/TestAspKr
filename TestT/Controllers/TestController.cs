﻿using System.Net;
using System.IO;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;
using TestT.Models;
using System;

namespace TestT.Controllers
{
    //private TestAspEntities db = new TestAspEntities();
   
  
    
    public class TestController : Controller
    {
        
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //public ActionResult Loader()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Loader(Test tblimage)
        //{
        //    string name = Path.GetFileNameWithoutExtension(tblimage.ImageFile.FileName);
        //    string Kartinka = Path.GetExtension(tblimage.ImageFile.FileName);
        //    tblimage.Kartinka = "TestKartinki/" + name;
        //    name = Path.Combine(Server.MapPath("TestKartinki/"), name);
        //    tblimage.ImageFile.SaveAs(name);
        //    using (DBmodel dBmodel = new DBmodel())
        //    {
        //        dBmodel.Test.Add(tblimage);
        //        dBmodel.SaveChanges();
        //    }
        //    ModelState.Clear();
        //    return View();
        //}


    }
}
