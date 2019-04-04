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
    public static class TravelExpertsDB
    {
        public static SqlConnection GetConnection()
        {
            // define connection string using the string saved in NotePad from earlier SQL Server connections
            // the connection string provides information for accessing an SQL Server database
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TravelExperts;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
