using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestWebApplicationNetCoreMVC.Controllers
{
    public class PortalController : Controller
    {
        // GET: PortalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PortalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PortalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PortalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PortalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PortalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PortalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
