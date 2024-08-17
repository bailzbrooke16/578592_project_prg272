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
    public partial class CreateModule : Form
    {
        private readonly IModuleService _moduleService;
        public CreateModule()
        {
            _moduleService = new ModuleService();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ViewAllModules viewAllModules = new ViewAllModules();
            viewAllModules.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string code, name, description, links;
            code = txtCode.Text;
            name = txtName.Text;
            description = rtbDescription.Text;
            links = rtbLinks.Text; 

            Module module = new Module();
            module.code = Convert.ToInt32(code);
            module.name = name;
            module.description = description;
            module.links = links;

            _moduleService.createModule(module);
            ViewAllModules viewAllModules = new ViewAllModules();
            viewAllModules.Show();
            this.Close();
        }
    }
}
