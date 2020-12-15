using System.Net;
using System.IO;
using System.Web;
using System.Web.Mvc;
using TestT.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Threading.Tasks;

namespace TestT.Controllers
{
    private TestAspEntities db = new TestAspEntities();
   
  
    
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
        public ActionResult NewFile(HttpPostedFileBase[] upload, int idtable, int typetable)
        {
            try
            {
                string userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
                foreach (var file in upload)
                {
                    byte[] fileData;
                    using (Stream stream = file.InputStream)
                    {
                        fileData = new byte[stream.Length];
                        stream.Read(fileData, 0, fileData.Length);
                    }
                    try
                    {
                        string newid = Guid.NewGuid().ToString() + Guid.NewGuid().ToString() + Guid.NewGuid().ToString();
                        db.Files.Add(new Files() { id = newid, idtable = idtable, userid = userId, typetable = typetable, date = DateTime.Now, filename = file.FileName, filedata = fileData });
                        /* await*/
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        return Json(ex.ToString());
                    }
                }
            }
            catch { }
            return PartialView("TasksDisk", db.Tasks.Find(idtable));
        }
    }
}
