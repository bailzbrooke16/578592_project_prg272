using Core;
using Core.Interfaces;
using Core.Models;
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
    public partial class Login : Form
    {
        private readonly IUserService _userService;
        public Login()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User(txtUsername.Text, txtPassword.Text);
            string response = _userService.loginUser(user);
            if(response == "Logged in successfully")
            {
                Home home = new Home(); 
                home.Show();
                this.Hide();
            }
            else
            {
                lblError.Text = response;
            }



        }
    }
}
