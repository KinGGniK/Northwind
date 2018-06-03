using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNorthwind1.Models
{
    public class Supplier
    {
        private int supplierID;
        private string companyName;
        private string contactName;
        private string contactTitle;
        private string address;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string phone;
        private string fax;
        private string homePage;


        public int SupplierID
        {
            get
            {
                return this.supplierID;
            }
            set
            {
                this.supplierID = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
            set
            {
                this.companyName = value;
            }
        }
        public string ContactName
        {
            get
            {
                return this.contactName;
            }
            set
            {
                this.contactName = value;
            }
        }
        public string ContactTitle
        {
            get
            {
                return this.contactTitle;
            }
            set
            {
                this.contactTitle = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                this.region = value;
            }
        }
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }
            set
            {
                this.postalCode = value;
            }
        }
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }
        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
        public string Fax
        {
            get
            {
                return this.fax;
            }
            set
            {
                this.fax = value;
            }
        }
        public string HomePage
        {
            get
            {
                return this.homePage;
            }
            set
            {
                this.homePage = value;
            }
        }


        public Supplier()
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string country, string phone, string fax, string index):this()
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string country, string phone, string fax) : this(id, comname, contname, addy, city, reg, post, country, phone, fax, "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string country, string phone) : this(id, comname, contname, addy, city, reg, post, country, phone, "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post, string country) : this(id, comname, contname, addy, city, reg, post, country, "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg, string post) : this(id, comname, contname, addy, city, reg, post, "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city, string reg) : this(id, comname, contname, addy, city, reg, "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy, string city) : this(id, comname, contname, addy, city, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname, string addy) : this(id, comname, contname, addy, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname, string contname) : this(id, comname, contname, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id, string comname) : this(id, comname, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }
        public Supplier(int id) : this(id, "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string aMessage = "";

            aMessage += aMessage + "Supplier ID  : " + SupplierID + "\n";
            aMessage += aMessage + "Comapny Name : " + CompanyName + "\n";
            aMessage += aMessage + "Contact Name : " + ContactName + "\n";
            aMessage += aMessage + "Contact Title: " + ContactTitle + "\n";
            aMessage += aMessage + "Address      : " + Address + "\n";
            aMessage += aMessage + "City         : " + City + "\n";
            aMessage += aMessage + "Region       : " + Region + "\n";
            aMessage += aMessage + "Postal Code  : " + PostalCode + "\n";
            aMessage += aMessage + "Country      : " + Country + "\n";
            aMessage += aMessage + "Phone        : " + Phone + "\n";
            aMessage += aMessage + "Fax          : " + Fax + "\n";
            aMessage += aMessage + "Home Page    : " + HomePage + "\n";

            return aMessage;
        }
    }
}