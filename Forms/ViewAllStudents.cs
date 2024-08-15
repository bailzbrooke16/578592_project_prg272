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
    public partial class ViewAllStudents : Form
    {
        private readonly IStudentService _studentService;
        private Student selectedStudent;
        public ViewAllStudents()
        {
            _studentService = new StudentService();
            InitializeComponent();
            dgvStudents.DataSource = _studentService.getAllStudents();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudent createStudent = new CreateStudent();
            createStudent.Show();
            this.Close();
        }

        private void viewAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAllModules viewAllModules = new ViewAllModules();
            viewAllModules.Show();
            this.Close();
        }

        private void createNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateModule createModule = new CreateModule();
            createModule.Show();
            this.Close();
        }

        private void btnLinkModules_Click(object sender, EventArgs e)
        {
            if (this.selectedStudent != null)
            {
                LinkModules linkModules = new LinkModules(this.selectedStudent);
                linkModules.Show();
                this.Close();
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                this.selectedStudent = (Student)dgvStudents.SelectedRows[0].DataBoundItem;

                txtFirstName.Text = this.selectedStudent.first_name;
                txtLastName.Text = this.selectedStudent.last_name;
                txtNumber.Text = this.selectedStudent.number.ToString();
                txtGender.Text = this.selectedStudent.gender;
                txtPhone.Text = this.selectedStudent.phone;
                rtbAddress.Text = this.selectedStudent.address;
                using (MemoryStream ms = new MemoryStream(this.selectedStudent.image))
                {
                    Image image = Image.FromStream(ms);
                    pbImage.Image = image;
                }
                dtpDOB.Value = new DateTime(selectedStudent.DOB.Year, selectedStudent.DOB.Month, selectedStudent.DOB.Day);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.selectedStudent != null)
            {
                _studentService.deleteStudent(this.selectedStudent.number);
                dgvStudents.DataSource = _studentService.getAllStudents();
                this.clearFields();
            }

        }


        private void clearFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNumber.Text = "";
            txtGender.Text = "";
            txtPhone.Text = "";
            rtbAddress.Text = "";
            pbImage.Image = null;
            dtpDOB.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.selectedStudent.first_name = txtFirstName.Text;
            this.selectedStudent.last_name = txtLastName.Text;
            this.selectedStudent.number = Convert.ToInt32(txtNumber.Text);
            this.selectedStudent.gender = txtGender.Text;
            this.selectedStudent.phone = txtPhone.Text;
            this.selectedStudent.address = rtbAddress.Text;
            this.selectedStudent.DOB = DateOnly.FromDateTime(dtpDOB.Value);

            _studentService.updateStudent(this.selectedStudent);
            dgvStudents.DataSource = _studentService.getAllStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Student> students = _studentService.getAllStudents();
            string searchcode = txtSearch.Text;

            List<Student> filteredStudents = students
                .Where(student => student.number.ToString().Contains(searchcode))
                .ToList();

            dgvStudents.DataSource = filteredStudents;
        }
    }
}
