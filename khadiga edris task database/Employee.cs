﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace khadiga_edris_task_database
{
    
    public partial class Employee : Form
    {
        Funcation Con;
        public Employee()
        {
            InitializeComponent();
            Con = new Funcation();
            ShowDep();

        }
        private void ShowDep()
        {
            string Qurey = "Select * from EmployeeTb1";
            EmpList.DataSource = Con.GetData(Qurey);
        }

        private void GetDepatement()
        {
            String Query = "Select * from Departement";
        }
        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
