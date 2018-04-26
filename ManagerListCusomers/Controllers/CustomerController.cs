using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManagerListCusomers.Models;

namespace ManagerListCusomers.Controllers
{
    public class CustomerController : Controller
    {
        private dbCustomerEntities de = new dbCustomerEntities();
        public int idedit;
        public ActionResult Index()
        {
            ViewData["lstCustomer"] = de.Customers.ToList();
            return View();
        }
        public ActionResult Add()
        {
            return View("Add");
        }
        public ActionResult Edit(string id)
        {
            Customer ct = de.Customers.Single(x => x.CustomerNo.Equals(id));
            ViewData["ct"] = ct;
            return View("Edit");
        }
        public ActionResult ActionAdd(FormCollection fc)
        {
            Customer ct = new Customer();
            ct.CustomerNo = fc["txtCode"];
            ct.CustomerName = fc["txtName"];
            ct.CustomerAddress = fc["txtAddress"];
            ct.CustomerPhone = fc["txtPhone"];
            ct.CustomerEmail = fc["txtEmail"];
            de.Customers.Add(ct);
            de.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ActionDelete(int id)
        {
            Customer ct = de.Customers.Single(x => x.CustomerID.Equals(id));
            de.Customers.Remove(ct);
            de.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ActionEdit(FormCollection fc)
        {
            string No = fc["txtCode"];
            Customer ct = de.Customers.Single(x => x.CustomerNo.Equals(No));
            ct.CustomerNo = fc["txtCode"];
            ct.CustomerName = fc["txtName"];
            ct.CustomerAddress = fc["txtAddress"];
            ct.CustomerPhone = fc["txtPhone"];
            ct.CustomerEmail = fc["txtEmail"];
            de.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
