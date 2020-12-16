using TestT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Microsoft.Owin.Security;
using System.Configuration;

namespace TestT.Controllers
{
    public class MenuController : Controller
    {
        private TestAspEntities1 db = new TestAspEntities1();
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        // GET: Menu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menu/Create
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

        // GET: Menu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Menu/Edit/5
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

        // GET: Menu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Menu/Delete/5
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

        public ActionResult _MainMenu()
        {

            menuMain M = new menuMain();
            Dictionary<int, string> projects = new Dictionary<int, string>();
            Dictionary<long, string> accounts = new Dictionary<long, string>();

            var uid = User.Identity.GetUserId();

            var acc = db.Accounts.Where(a => a.Accounts_Users.Select(u => u.AspNetUsers.Id).Contains(uid));

            List<ItemMenuProfile> itemMenuProfile = db.Projects
                .Where(p => p.Accounts.Accounts_Users
                .Select(u => u.AspNetUsers.Id)
                .Contains(uid))
                .Select(i => new ItemMenuProfile { id = i.id, name = i.name, guid = i.guid }).ToList();

            foreach (var item in db.Projects.Where(p => acc.Select(a => a.Id).Contains(p.accountId)))
            {
                projects.Add(item.id, item.name);
            }

            foreach (var item in acc)
            {
                accounts.Add(item.Id, item.ShortLegalName);
            }

            M.menuProject = projects;
            M.menuAccaunts = accounts;
            M.menuProfile = itemMenuProfile;
            return PartialView("_MainMenu", M);
        }

    }
}
