using Core;
using Core.Interfaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _578592_project_prg272.Forms
{
    public partial class Register : Form
    {
        private readonly IUserService _userService;
        public Register()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            String password = txtPassword.Text;
            String confirmPassword = txtConfirmPassword.Text;

            if(txtUsername.Text == "" )
            {
                lblError.Text += "Username is empty\n";
            }
            if(txtPassword.Text == "")
            {
                lblError.Text += "Password is empty\n";
                if(txtPassword.Text.Length < 8) 
                {
                    lblError.Text += "Password needs to be more then 8 characters\n";
                }
            }
            if(txtConfirmPassword.Text == "")
            {
                lblError.Text += "Confirm password is empty\n";
            }
            if(!password.Equals(confirmPassword))
            {
                lblError.Text += "Passwords do no match.\n";
            }

            if(lblError.Text == "")
            {
                User user = new User(txtUsername.Text, txtPassword.Text);
                String response = _userService.createUser(user);
                if(response == "User added successfully") 
                {
                    this.Close ();
                }
                else
                {
                    lblError.Text = response;
                }
            }
        }
    }
}
