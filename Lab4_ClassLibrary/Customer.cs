/********************************************************************************
* 
* Author: Tim Leslie
* Date: April 3, 2019.
* Course: CPRG 2017 Rapid Application Development
* Assignment: Workshop 4
* Purpose: This is a Windows Form Application which adds two columns,
* UserId and Password to the TravelExperts database.
* Ultimately, the Password cells should be hashed but that will be
* dealt with in a subsequent release.
*
*********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ClassLibrary
{
    // Public Order class definition whose property values will be used to store Order
    // information from the latest database SELECT query.
    public class Customer
    {
        // use default constructor
        public Customer() { } // default constructor

        // Constructor used to instantiate the object with passed values. DateTime
        // properties have been declared nullable to be able to handle null cases in
        // the database and through user-selection.
        public Customer(int id, string fn, string ln)
        {
            CustomerID = id;
            CustFirstName = fn;
            CustLastName = ln;
        }

        // Public properties
        public int CustomerID { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }

        public override string ToString()
        {
            return "CustomerID: " + CustomerID.ToString() + ", " + "Name: " + CustFirstName + " " + CustLastName;
        }
    }
}
