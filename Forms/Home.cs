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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewAllStudents = new ViewAllStudents();
            viewAllStudents.Show();
            this.Close();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            ViewAllModules viewAllModules = new ViewAllModules();
            viewAllModules.Show();
            this.Close();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewAllStudents = new ViewAllStudents();
            viewAllStudents.Show();
            this.Close();
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAllModules viewAllModules = new ViewAllModules();
            viewAllModules.Show();
            this.Close();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudent createStudent = new CreateStudent();
            createStudent.Show();
            this.Close();
        }

        private void createNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateModule createModule = new CreateModule();
            createModule.Show();
            this.Close();
        }
    }
}
