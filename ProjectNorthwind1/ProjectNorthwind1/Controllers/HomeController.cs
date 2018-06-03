using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectNorthwind1.Models;
using System.Data.OleDb;
using System.Data.Odbc;

namespace ProjectNorthwind1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }


        //Listing All The Tables Into a View
        public ActionResult ListCategories()
        {
            DbConnection aConnection = new DbConnection();

            List<Category> aListofCategories = new List<Category>();
            aListofCategories = aConnection.ListCategories();

            ViewBag.AListofCategories = aListofCategories;

            return View();
        }
        public ActionResult ListCustomers()
        {
            DbConnection aConnection = new DbConnection();

            List<Customers> aListofCustomers = new List<Customers>();
            aListofCustomers = aConnection.ListCustomers();

            ViewBag.AListofCustomers = aListofCustomers;

            return View();
        }
        public ActionResult ListEmployees()
        {
            DbConnection aConnection = new DbConnection();

            List<Employees> aListofEmployees = new List<Employees>();
            aListofEmployees = aConnection.ListEmployees();

            ViewBag.AListofEmployees = aListofEmployees;

            return View();
        }
        public ActionResult ListOrderDetails()
        {
            DbConnection aConnection = new DbConnection();

            List<OrderDetail> aListofOrderDetails = new List<OrderDetail>();
            aListofOrderDetails = aConnection.ListOrderDetails();

            ViewBag.AListofOrderDetails = aListofOrderDetails;

            return View();
        }
        public ActionResult ListProducts()
        {
            DbConnection aConnection = new DbConnection();

            List<Products> aListofProducts = new List<Products>();
            aListofProducts = aConnection.ListProducts();

            ViewBag.AListofProducts = aListofProducts;

            return View();
        }
        public ActionResult ListShippers()
        {
            DbConnection aConnection = new DbConnection();

            List<Shippers> aListofShippers = new List<Shippers>();
            aListofShippers = aConnection.ListShippers();

            ViewBag.AListofShippers = aListofShippers;

            return View();
        }
        public ActionResult ListOrders()
        {
            DbConnection aConnection = new DbConnection();

            List<Orders> aListofOrders = new List<Orders>();
            aListofOrders = aConnection.ListOrders();

            ViewBag.AListofOrders = aListofOrders;

            return View();
        }
        public ActionResult ListSuppliers()
        {
            DbConnection aConnection = new DbConnection();

            List<Supplier> aListofSuppliers = new List<Supplier>();
            aListofSuppliers = aConnection.ListSuppliers();

            ViewBag.AListofSuppliers = aListofSuppliers;

            return View();
        }

        //Table Listing Pages
        public ActionResult ListPage()
        {

            return View();
        }
        public ActionResult InsertPage()
        {

            return View();
        }
        public ActionResult EditPage()
        {

            return View();
        }
        public ActionResult DeletePage()
        {

            return View();
        }

        //To Select Appropriate Corresponding Table in Relation to Other Tables in a View
        public ActionResult GetaCategory(int id)
        {
           
            DbConnection aConnection = new Models.DbConnection();
            Category aCategory = new Models.Category();
            List<Products> aListofProducts = null;

            aListofProducts = aConnection.ListProducts();
            aCategory = aConnection.GetaCategory(id);

            var whatWeWant = from p in aListofProducts where p.CategoryID == id orderby p.ProductID select p;

            ViewBag.Category = aCategory;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }
        public ActionResult GetaShipper(int id)
        {

            DbConnection aConnection = new Models.DbConnection();
            Shippers aShipper = new Models.Shippers();
            List<Orders> aListofOrders = null;

            aListofOrders = aConnection.ListOrders();
            aShipper = aConnection.GetaShipper(id);

            var whatWeWant = from o in aListofOrders where o.ShipVia == id orderby o.ShipVia select o;

            ViewBag.Shipper = aShipper;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }
        public ActionResult GetanEmployee(int id)
        {

            DbConnection aConnection = new Models.DbConnection();
            Employees anEmployee = new Models.Employees();
            List<Orders> aListofOrders = null;

            aListofOrders = aConnection.ListOrders();
            anEmployee = aConnection.GetanEmployee(id);

            var whatWeWant = from o in aListofOrders where o.EmployeeID == id orderby o.EmployeeID select o;

            ViewBag.Employee = anEmployee;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }
        public ActionResult GetaCustomer(string id)
        {

            DbConnection aConnection = new Models.DbConnection();
            Customers aCustomer = new Models.Customers();
            List<Orders> aListofOrders = null;

            aListofOrders = aConnection.ListOrders();
            aCustomer = aConnection.GetaCustomer(id);

            var whatWeWant = from o in aListofOrders where o.CustomerID == id orderby o.CustomerID select o;

            ViewBag.Customer = aCustomer;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }
        public ActionResult GetaProduct(int id)
        {

            DbConnection aConnection = new Models.DbConnection();
            Products aProduct = new Models.Products();
            List<OrderDetail> aListofOrderDetails = null;

            aListofOrderDetails = aConnection.ListOrderDetails();
            aProduct = aConnection.GetaProduct(id);

            var whatWeWant = from od in aListofOrderDetails where od.ProductID == id orderby od.ProductID select od;

            ViewBag.Product = aProduct;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }
        public ActionResult GetanOrder(int id)
        {

            DbConnection aConnection = new Models.DbConnection();
            Orders anOrder = new Models.Orders();
            List<OrderDetail> aListofOrderDetails = null;

            aListofOrderDetails = aConnection.ListOrderDetails();
            anOrder = aConnection.GetanOrder(id);

            var whatWeWant = from od in aListofOrderDetails where od.OrderID == id orderby od.OrderID select od;

            ViewBag.Order = anOrder;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }
        public ActionResult GetaSupplier(int id)
        {

            DbConnection aConnection = new Models.DbConnection();
            Supplier aSupplier = new Models.Supplier();
            List<Products> aListofProducts = null;

            aListofProducts = aConnection.ListProducts();
            aSupplier = aConnection.GetaSupplier(id);

            var whatWeWant = from p in aListofProducts where p.SupplierID == id orderby p.SupplierID select p;

            ViewBag.Supplier = aSupplier;
            ViewBag.WhatWeWant = whatWeWant;

            return View();
        }

        //Method to connect Edit Tables Methods to Forms
        public ActionResult EditCategory(int catid, string name, string desc)
        {
            DbConnection aConnection = new DbConnection();

            ViewBag.CatID = catid;
            ViewBag.Name = name;
            ViewBag.Desc = desc;

            aConnection.EditCategory(catid, name, desc);

            return View();
        }
        public ActionResult EditCategoryForm(int id)
        {
            DbConnection aConnection = new Models.DbConnection();

            Category aCategory = new Models.Category();
            aCategory = aConnection.GetaCategory(id);

            ViewBag.Category = aCategory;

            return View();
        }
        public ActionResult EditCategoryPage()
        {
            DbConnection aConnection = new DbConnection();

            List<Category> aListofCategories = new List<Category>();
            aListofCategories = aConnection.ListCategories();

            var OrderList = from p in aListofCategories orderby p.CategoryName select p;

            ViewBag.AListofCategories = OrderList;

            return View();
        }

        public ActionResult EditEmployees(int empid, string lname, string fname, string title, string titofcourt, DateTime bdate, DateTime hdate, string addy, string city, string region, string postal, string country, string hphone, string exten, string photo, string notes, int repto)
        {
            DbConnection aConnection = new DbConnection();

            ViewBag.EmpID = empid;
            ViewBag.LName = lname;
            ViewBag.FName = fname;
            ViewBag.Title = title;
            ViewBag.Titofcourt = titofcourt;
            ViewBag.BDate = bdate;
            ViewBag.HDate = hdate;
            ViewBag.Addy = addy;
            ViewBag.City = city;
            ViewBag.Region = region;
            ViewBag.Postal = postal;
            ViewBag.Country = country;
            ViewBag.HPhone = hphone;
            ViewBag.Exten = exten;
            ViewBag.Photo = photo;
            ViewBag.Notes = notes;
            ViewBag.Repto = repto;

            aConnection.EditEmployees(empid, lname, fname, title, titofcourt, bdate, hdate, addy, city, region, postal, country, hphone, exten, photo, notes, repto);

            return View();
        }
        public ActionResult EditEmployeesForm(int id)
        {
            DbConnection aConnection = new Models.DbConnection();

            Employees anEmployee = new Models.Employees();
            anEmployee = aConnection.GetanEmployee(id);

            ViewBag.Employee = anEmployee;
            
            return View();
        }
        public ActionResult EditEmployeesPage()
        {
            DbConnection aConnection = new DbConnection();

            List<Employees> aListofEmployees = new List<Employees>();
            aListofEmployees = aConnection.ListEmployees();

            var OrderList = from p in aListofEmployees orderby p.LastName select p;

            ViewBag.AListofEmployees = OrderList;

            return View();
        }

        public ActionResult EditShippers(int id, string compname, string phone)
        {
            DbConnection aConnection = new DbConnection();

            ViewBag.ID = id;
            ViewBag.CompName = compname;
            ViewBag.Phone = phone;

            aConnection.EditShippers(id, compname, phone);
            return View();
        }
        public ActionResult EditShippersForm(int id)
        {
            DbConnection aConnection = new Models.DbConnection();

            Shippers aShipper = new Shippers();
            aShipper = aConnection.GetaShipper(id);

            ViewBag.Shipper = aShipper;

            return View();
        }
        public ActionResult EditShippersPage()
        {
            DbConnection aConnection = new DbConnection();

            List<Shippers> aListofShippers = new List<Shippers>();
            aListofShippers = aConnection.ListShippers();

            var OrderList = from p in aListofShippers orderby p.CompanyName select p;

            ViewBag.AListofShippers = OrderList;

            return View();
        }

        public ActionResult EditCustomer(string id, string compname, string name, string title, string addy, string city, string reg, string post, string country, string phone, string fax)
        {
            ViewBag.ID = id;
            ViewBag.CompanyName = compname;
            ViewBag.Name = name;
            ViewBag.Title = title;
            ViewBag.Address = addy;
            ViewBag.City = city;
            ViewBag.Region = reg;
            ViewBag.Postal = post;
            ViewBag.Country = country;
            ViewBag.Phone = phone;
            ViewBag.Fax = fax;

            EditCustomer(id, compname, name, title, addy, city, reg, post, country, phone, fax);
            return View();
        }
        public ActionResult EditCustomerForm(string id)
        {

            DbConnection aConnection = new Models.DbConnection();

            Customers aCustomer = new Models.Customers();
            aCustomer = aConnection.GetaCustomer(id);

            ViewBag.Customer = aCustomer;

            return View();
        }
        public ActionResult EditCustomersPage()
        {
            DbConnection aConnection = new DbConnection();

            List<Customers> aListofCustomers = new List<Customers>();
            aListofCustomers = aConnection.ListCustomers();

            var OrderList = from p in aListofCustomers orderby p.ContactName select p;

            ViewBag.AListofCustomers = OrderList;

            return View();
        }

        //Method to connect Insert Method to Forms
        public ActionResult InsertCategory(string name, string desc)
        {
            DbConnection aConnection = new DbConnection();

            ViewBag.Name = name;
            ViewBag.Desc = desc;

            aConnection.InsertCategory(name, desc);

            return View();
        }
        public ActionResult InsertCategoryForm()
        {
            return View();
        }

        public ActionResult InsertEmployees(string lname, string fname, string title, string titofcourt, DateTime bdate, DateTime hdate, string addy, string city, string region, string postal, string country, string hphone, string exten, string photo, string notes, int repto)
        {
            DbConnection aConnection = new DbConnection();

            ViewBag.LName = lname;
            ViewBag.FName = fname;
            ViewBag.Title = title;
            ViewBag.Titofcourt = titofcourt;
            ViewBag.BDate = bdate;
            ViewBag.HDate = hdate;
            ViewBag.Addy = addy;
            ViewBag.City = city;
            ViewBag.Region = region;
            ViewBag.Postal = postal;
            ViewBag.Country = country;
            ViewBag.HPhone = hphone;
            ViewBag.Exten = exten;
            ViewBag.Photo = photo;
            ViewBag.Notes = notes;
            ViewBag.Repto = repto;

            aConnection.InsertEmployees(lname, fname, title, titofcourt, bdate, hdate, addy, city, region, postal, country, hphone, exten, photo, notes, repto);

            return View();
        }
        public ActionResult InsertEmployeesForm()
        {

            return View();
        }

        //Method to connect Delete Forms to Tables
        public ActionResult DeleteCategory(int catid, string name)
        {
            DbConnection aConnection = new DbConnection();

            ViewBag.Name = name;

            aConnection.DeleteCategory(catid);

            return View();
        }
        public ActionResult DeleteCategoryPage()
        {
            DbConnection aConnection = new DbConnection();

            List<Category> aListofCategories = new List<Category>();
            aListofCategories = aConnection.ListCategories();

            ViewBag.AListofCategories = aListofCategories;

            return View();
        }

        //JSON Select Stored Procedure
        public ActionResult JSONListCategories()
        {
            DbConnection aConnection = new DbConnection();

            List<Category> aListofCategories = new List<Category>();
            aListofCategories = aConnection.JSONListCategories();

            return View();
        }

        //XML Select Stored Procedure
        public ActionResult XMLListCategories()
        {
            DbConnection aConnection = new DbConnection();

            List<Category> aListofCategories = new List<Category>();
            aListofCategories = aConnection.XMLListCategories();

            return View();
        }



        //public ActionResult GetProductsLINQ()
        //{
        //    DbConnection aConnection = new Models.DbConnection();
        //    List<Products> aListofProducts = null;
        //    List<Category> aListofCategories = null;

        //    //Downloading records we want to search and then using LINQ to search/sort it
        //    aListofProducts = aConnection.ListProducts();
        //    aListofCategories = aConnection.ListCategories();

        //    var whatWeWant = from p in aListofProducts from c in aListofCategories where c.CategoryID == p.CategoryID orderby p.ProductName descending select p;

        //    ViewBag.WhatWeWant = whatWeWant;

        //    return View();
        //}
    }
}