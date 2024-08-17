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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace _578592_project_prg272.Forms
{
    public partial class LinkModules : Form
    {
        private Student selectedStudent;
        private ILinkModuleService _linkModuleService;
        private LinkModule selectedLinked;
        private LinkModule selectedAvailable;
        public LinkModules(Student student)
        {
            _linkModuleService = new LinkModuleService();
            selectedStudent = student;


            InitializeComponent();
            dgvLinked.DataSource = _linkModuleService.getLinkedModules(selectedStudent.number);
            dgvAvailable.DataSource = _linkModuleService.getAvailableModules(selectedStudent.number);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewAllStudents = new ViewAllStudents();
            viewAllStudents.Show();
            this.Close();
        }

        private void dgvLinked_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLinked.SelectedRows.Count > 0)
            {
                this.selectedLinked = (LinkModule)dgvLinked.SelectedRows[0].DataBoundItem;
            }
        }

        private void dgvAvailable_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAvailable.SelectedRows.Count > 0)
            {
                this.selectedAvailable = (LinkModule)dgvAvailable.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if(this.selectedAvailable != null)
            {
                _linkModuleService.addLinkModule(this.selectedAvailable);
                dgvLinked.DataSource = _linkModuleService.getLinkedModules(selectedStudent.number);
                dgvAvailable.DataSource = _linkModuleService.getAvailableModules(selectedStudent.number);
                this.selectedAvailable = null;
            }
        }

        private void btnDelink_Click(object sender, EventArgs e)
        {
            if (this.selectedLinked != null)
            {
                _linkModuleService.removeLinkModule(this.selectedLinked);
                dgvLinked.DataSource = _linkModuleService.getLinkedModules(selectedStudent.number);
                dgvAvailable.DataSource = _linkModuleService.getAvailableModules(selectedStudent.number);
                this.selectedLinked = null;
            }
        }
    }
}
