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
        public CreateStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewAllStudents = new ViewAllStudents();
            viewAllStudents.Show();
            this.Close();
        }
    }
}
