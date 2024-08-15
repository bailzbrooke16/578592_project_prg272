using Core;
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
    public partial class CreateStudent : Form
    {
        private byte[] fileData;
        private readonly StudentService _studentService;

        public CreateStudent()
        {
            _studentService = new StudentService();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewAllStudents = new ViewAllStudents();
            viewAllStudents.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string first_name, last_name, gender, phone, address, number;
            number = txtStudentNumber.Text;
            first_name = txtFirstName.Text;
            last_name = txtLastName.Text;
            gender = txtGender.Text;
            phone = txtPhoneNumber.Text;
            address = rtbAddress.Text;

            DateTime dateOfBirth = dtpDateOfBirth.Value;

            if (string.IsNullOrWhiteSpace(first_name))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(last_name))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (dateOfBirth == DateTime.MinValue)
            {
                MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (fileData == null || fileData.Length == 0)
            {
                MessageBox.Show("File upload is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student student = new Student();
            student.number = Convert.ToInt32(number);
            student.gender = gender;
            student.phone = phone;
            student.address = address;
            student.DOB = DateOnly.FromDateTime(dateOfBirth);
            student.first_name = first_name;
            student.last_name = last_name;
            student.image = fileData;

            _studentService.createStudent(student);
            ViewAllStudents viewAllStudents = new ViewAllStudents();
            viewAllStudents.Show();
            this.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    fileData = File.ReadAllBytes(filePath);

                 }
            }
        }
    }
}
