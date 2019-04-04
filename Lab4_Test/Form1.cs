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

using Lab4_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        // Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Customer> customers = new List<Customer>();
            customers = CustomerDB.GetCustomers();

            foreach (Customer cust in customers)
            {
                listBox1.Items.Add(cust);
                cmbCustomers.Items.Add(cust);
            }
            listBox1.DataSource = customers;
            cmbCustomers.DataSource = customers;
        }


        // Exit application on Exit button click.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<Customer> customers = new List<Customer>();
            customers = CustomerDB.GetCustomers();

            bool success = CustomerDB.UpdateUsers(customers);
        }
    }
}
