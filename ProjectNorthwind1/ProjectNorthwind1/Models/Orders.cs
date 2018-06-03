using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Orders
    {
        private int orderID;
        private string customerID;
        private int employeeID;
        private DateTime orderDate;
        private DateTime requiredDate;
        private DateTime shippedDate;
        private int shipVia;
        private int freight;
        private string shipName;
        private string shipAddress;
        private string shipCity;
        private string shipRegion;
        private string shipPostalCode;
        private string shipCountry;

        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                this.orderID = value;
            }
        }
        public string CustomerID
        {
            get
            {
                return this.customerID;
            }
            set
            {
                this.customerID = value;
            }
        }
        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }            
            set
            {
                this.employeeID = value;
            }            
        }
        public DateTime OrderDate
        {
            get
            {
                return this.orderDate;
            }
            set
            {
                this.orderDate = value;
            }
        }
        public DateTime RequiredDate
        {
            get
            {
                return this.requiredDate;
            }
            set
            {
                this.requiredDate = value;
            }
        }
        public DateTime ShippedDate
        {
            get
            {
                return this.shippedDate;
            }
            set
            {
                this.shippedDate = value;
            }
        }
        public int ShipVia
        {
            get
            {
                return shipVia;
            }
            set
            {
                this.shipVia = value;
            }
        }
        public int Freight
        {
            get
            {
                return freight;
            }
            set
            {
                this.freight = value;
            }
        }
        public string ShipName
        {
            get
            {
                return this.shipName;
            }
            set
            {
                this.shipName = value;
            }
        }
        public string ShipAddress
        {
            get
            {
                return this.shipAddress;
            }
            set
            {
                this.shipAddress = value;
            }
        }
        public string ShipCity
        {
            get
            {
                return this.shipCity;
            }
            set
            {
                this.shipCity = value;
            }
        }
        public string ShipRegion
        {
            get
            {
                return this.shipRegion;
            }
            set
            {
                this.shipRegion = value;
            }
        }
        public string ShipPostalCode
        {
            get
            {
                return this.shipPostalCode;
            }
            set
            {
                this.shipPostalCode = value;
            }
        }
        public string ShipCountry
        {
            get
            {
                return this.shipCountry;
            }
            set
            {
                this.shipCountry = value;
            }
        }

        public Orders()
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre, string sname, string saddy, string scity, string sreg, string spost, string scountry):this()
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre, string sname, string saddy, string scity, string sreg, string spost) : this(id, custid, empid, odate, redate, shdate, via, fre, sname, saddy, scity, sreg, spost, "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre, string sname, string saddy, string scity, string sreg) : this(id, custid, empid, odate, redate, shdate, via, fre, sname, saddy, scity, sreg, "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre, string sname, string saddy, string scity) : this(id, custid, empid, odate, redate, shdate, via, fre, sname, saddy, scity, "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre, string sname, string saddy) : this(id, custid, empid, odate, redate, shdate, via, fre, sname, saddy, "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre, string sname) : this(id, custid, empid, odate, redate, shdate, via, fre, sname, "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via, int fre) : this(id, custid, empid, odate, redate, shdate, via, fre, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate, int via) : this(id, custid, empid, odate, redate, shdate, via, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate, DateTime shdate) : this(id, custid, empid, odate, redate, shdate, -1, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate, DateTime redate) : this(id, custid, empid, odate, redate, default(DateTime), -1, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid, DateTime odate) : this(id, custid, empid, odate, default(DateTime), default(DateTime), -1, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid, int empid) : this(id, custid, empid, default(DateTime), default(DateTime), default(DateTime), -1, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id, string custid) : this(id, custid, -1, default(DateTime), default(DateTime), default(DateTime), -1, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Orders(int id) : this(id, "N/A", -1, default(DateTime), default(DateTime), default(DateTime), -1, -1, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Order ID:         " + OrderID + "\n";
            aMessage += aMessage + "Customer ID:      " + CustomerID + "\n";
            aMessage += aMessage + "Employee ID:      " + EmployeeID + "\n";
            aMessage += aMessage + "Order Date:       " + OrderDate + "\n";
            aMessage += aMessage + "Required Date:    " + RequiredDate + "\n";
            aMessage += aMessage + "Shipped Date:     " + ShippedDate + "\n";
            aMessage += aMessage + "Ship Via:         " + ShipVia + "\n";
            aMessage += aMessage + "Freight:          " + Freight + "\n";
            aMessage += aMessage + "Ship Name:        " + ShipName + "\n";
            aMessage += aMessage + "Ship Address:     " + ShipAddress + "\n";
            aMessage += aMessage + "Ship City:        " + ShipCity + "\n";
            aMessage += aMessage + "Ship Region:      " + ShipRegion + "\n";
            aMessage += aMessage + "Ship Postal Code: " + ShipPostalCode + "\n";
            aMessage += aMessage + "Ship Country:     " + ShipCountry + "\n";

            return aMessage;
        }

    }
}