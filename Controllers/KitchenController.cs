using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleGitDemoApi.Controllers
{
    public class KitchenController : Controller
    {
        // GET: KitchenController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KitchenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KitchenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KitchenController/Create
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

        // GET: KitchenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KitchenController/Edit/5
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

        // GET: KitchenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KitchenController/Delete/5
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
