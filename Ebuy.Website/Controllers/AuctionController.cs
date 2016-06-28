using Ebuy.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebuy.Website.Controllers
{
    public class AuctionController : Controller
    {
        //
        // GET: /Auction/

        public ActionResult Index()
        {
            var db = new EbuyDataContext();
            List<Auction> list = db.Auctions.Where(o => true).ToList();
            return View(list);
        }

        //
        // GET: /Auction/Details/5

        public ActionResult Details(long id = 0)
        {
            Auction auction = new Auction()
            {
                Id = id,
                Title = "Brand new Widget 2.0",
                Description = "This is a brand new version 2.0 Widget",
                StartPrice = 1.00m,
                CurrentPrice = 13.40m,
                StartTime = DateTime.Parse("2016-06-28 11:06 AM"),
                EndTime = DateTime.Parse("2016-06-28 17:34 PM"),
            };
            return View(auction);
        }

        //
        // GET: /Auction/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Auction/Create

        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    var db = new EbuyDataContext();
                    db.Auctions.Add(auction);
                    db.SaveChanges();
                    return View(auction);
                }
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        //
        // GET: /Auction/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Auction/Edit/5

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

        //
        // GET: /Auction/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Auction/Delete/5

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
    }
}
