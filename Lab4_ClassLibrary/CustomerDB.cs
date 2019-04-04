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
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ClassLibrary
{
    public static class CustomerDB
    {
        // This method returns a List of OrderDetail objects that correspond
        // to a passed OrderID.
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>(); // create an empty list

            SqlConnection connection = TravelExpertsDB.GetConnection(); // db connection

            string selectStatement = // prepare SQL statement
                "SELECT CustomerId, CustFirstName, CustLastName " +
                "FROM Customers";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

//            selectCommand.Parameters.AddWithValue("@OrderID", orderID);

            // in this case should be a multiline read for all the detail rows corresponding to a given OrderID
            try
            {
                // open the database connection
                connection.Open();

                // execute the SELECT query and build a List of order details for a given OrderID
                SqlDataReader cust = selectCommand.ExecuteReader();

                while (cust.Read())
                {   // set order OrderDet object properties according to the current reader line
                    Customer customer = new Customer();
                    customer.CustomerID = (int)cust["CustomerID"];
                    customer.CustFirstName = (string)cust["CustFirstName"];
                    customer.CustLastName  = (string)cust["CustLastName"];
                    customers.Add(customer);
                }
                cust.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return customers;
        }

        public static bool UpdateUsers(List<Customer> customers)
        {
            bool success = true;
 
            SqlConnection connection = TravelExpertsDB.GetConnection(); // db connection

            // open the database connection
            connection.Open();

            string updateStatement = "UPDATE Customers SET " +
                "UserId = @UserId, Password = @PassWord " +
                "WHERE CustomerId = @CustomerId";  // to identify record to update

            using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
            {
                foreach (Customer cust in customers)
                {
                    // execute the SELECT query and build a List of order details for a given OrderID
                    updateCommand.Parameters.Clear();
                    updateCommand.Parameters.AddWithValue("@CustomerId", cust.CustomerID);
                    updateCommand.Parameters.AddWithValue("@UserId", (cust.CustFirstName[0] + cust.CustLastName).ToLower());
                    updateCommand.Parameters.AddWithValue("@Password", "test");
                    updateCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            return success;
        }
    }
}
