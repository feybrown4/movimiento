using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovimientoBL;


namespace movimiento
{
    public partial class Text : Form
    {
        public Admin admin;
        public Text()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            //validate the various form text boxes using if statement
            
            string email = txtEmail.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string password = txtPassword.Text;
            if (txtEmail.ToString().Length <= 50 && email != "" && txtFirstName.ToString().Length <= 50 && firstName != "" && txtLastName.ToString().Length <= 50 && lastName != "" && txtPassword.ToString().Length <= 50 && password != "")

            {
               // create a new object
                admin = new Admin();
                admin.Firstname = txtFirstName.Text;
                admin.Lastname = txtLastName.Text;
                admin.Password = txtPassword.Text;
                admin.Email = txtEmail.Text;
                
                //handle exceptions from method call
                try
                {

                    //call insert method
                    
                    AdminDB.InsertAdmin(admin);
                    MessageBox.Show("Product added successfully.");
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
               
            }
           
            if (firstName == "")
            {
                MessageBox.Show("Please enter a first name");
                txtFirstName.Focus();
                return;
            }
            if (lastName == "")
            {
                MessageBox.Show("Please enter a last name");
                txtLastName.Focus();
                return;
            }
            if (email == "")
            {
                MessageBox.Show(" Please enter a email");
                txtEmail.Focus();
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Please enter a password");
                txtPassword.Focus();
                return;
            }

            txtEmail.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }
    }
}
