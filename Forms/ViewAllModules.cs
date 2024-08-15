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
    public partial class ViewAllModules : Form
    {
        private readonly IModuleService _moduleService;
        private Module selectedModule;
        public ViewAllModules()
        {
            _moduleService = new ModuleService();
            InitializeComponent();
            dgvModules.DataSource = _moduleService.getAllModules();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllStudents students = new ViewAllStudents();
            students.Show();
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

        private void ViewAllModules_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void dgvModules_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModules.SelectedRows.Count > 0)
            {
                this.selectedModule = (Module)dgvModules.SelectedRows[0].DataBoundItem;
                txtCode.Text = this.selectedModule.code.ToString();
                txtName.Text = this.selectedModule.name;
                rtbDescription.Text = this.selectedModule.description;
                rtbLinks.Text = this.selectedModule.links;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedModule != null)
            {
                _moduleService.deleteModule(this.selectedModule.code);
                clearFields();
                dgvModules.DataSource = _moduleService.getAllModules();
            }

        }

        private void clearFields()
        {
            txtCode.Text = "";
            txtName.Text = "";
            rtbDescription.Text = "";
            rtbLinks.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.selectedModule != null)
            {
                _moduleService.updateModule(this.selectedModule);
            }
        }
    }
}
