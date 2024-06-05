using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                string registeredUsername = textBox1.Text;
                string registeredPassword = textBox2.Text;

                
                if (IsValidUser(registeredUsername, registeredPassword))
                {
                    
                    string fullName = GetUserFullName(registeredUsername);
                    string department = GetUserDepartment(registeredUsername);
                    MessageBox.Show($"Welcome, {fullName} ({department})!");
               frmPurchaseDiscountedItem discounted = new frmPurchaseDiscountedItem();
                discounted.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }

            
            private bool IsValidUser(string username, string password)
            {
            return (username == "medusaka" && password == "212403");
        }

            
            private string GetUserFullName(string username)
            {
            if (username == "medusaka")
            {
                return "Jean Flores";
            }
            else
            {
               
                return "Unknown User";
            }
        }

            
            private string GetUserDepartment(string username)
            {
            if (username == "medusaka")
            {
                return "Finance";
            }
            else
            {
                
                return "Unknown Department";
            }
        }
        }
    }
    

