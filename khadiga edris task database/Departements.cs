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
    public partial class DepNameTb : Form
    {
        Funcation Con;
        public DepNameTb()
        {
            InitializeComponent();
            Con = new Funcation();
            ListerDepartment();
        }
        private void ListerDepartment()
        {
            string Qurey = "Select * from DepartmentTbl"
            DepList.DataSource = Con.GetData(Qurey);
        }

        private void Departements_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }else
                {
                    string Dep = DepNameTb.Text;
                    string Qurey = "insert into DepartmentTbl values(' {0} ')";
                    Qurey = string.Format(DepNameTb.Text);
                }
            }
        }
    }
}
