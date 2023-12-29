using Projeto_Apoo.Context;
using Projeto_Apoo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Apoo.Controllers
{
    public class ItemController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Item
        public ActionResult Index()
        {
            return View(context.Items.OrderBy(i => i.Nome));
        }

        // GET: Item/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Item/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                context.Entry(item).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Item/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(long id)
        {
            Item item = context.Items.Find(id);
            context.Items.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
