/*****************************************************************************
* 
* Author: Tim Leslie
* Date: March 1, 2019.
* Course: CPRG 200 Rapid Application Development
* Assignment: Part 1: Lab Assignment 2
* Purpose: This is a Validation file which contains several methods to check
* for valid user input. Most of these methods were reviewed in CPRG200 class.
*
*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Test
{
    // A collection of methods to test for various data entry properties.
    public static class Validator
    {
        // Public method to check whether data has been entered in the TextBox.
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true;
            if (tb.Text == "")
            {
                result = false;
                MessageBox.Show("Please enter " + name + ".", "Input Error");
                tb.Focus();
            }
            return result;
        }

        // This method checks to see if the integer content of a textbox is
        // contained within the integer List provided.
        public static bool IsInRange(TextBox tb, string name, List<int> list)
        {
            bool result = true;
            int temp = Convert.ToInt32(tb.Text);
            foreach (int num in list)
                if (temp == num) return result;
                         
            result = false;
            MessageBox.Show(name + " is not in the database.", "Range Error");
            tb.Focus();
            return result;
        }

        // Public method to check whether data is a whole number (non-negative int).
        public static bool IsNonNegativeInt(TextBox tb, string name)
        {
            bool result = true;
            int val;
            if (!Int32.TryParse(tb.Text, out val))
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // Public method to check whether data is non-negative and of type Double.
        public static bool IsNonNegativeDouble(TextBox tb, string name)
        {
            bool result = true;
            double val;
            if (!Double.TryParse(tb.Text, out val))
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a whole number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // Public method to check whether data is non-negative and of type Decimal.
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, out val))
            {
                result = false;
                MessageBox.Show(name + " has to be a number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // Public method to check whether data is non-negative currency using local culture monetary symbols.
        public static bool IsNonNegativeCurrency(TextBox tb, string name)
        {
            bool result = true;
            decimal val;
            if (!Decimal.TryParse(tb.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out val))
            {
                result = false;
                MessageBox.Show(name + " has to be a currency number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            else if (val < 0)
            {
                result = false;
                MessageBox.Show(name + " has to be a non-negative currency number.", "Input Error");
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }
    }
}
