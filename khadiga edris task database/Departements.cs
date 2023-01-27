using System;
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
    public partial class Department : Form
    {
        Funcation Con;
        public Department()
        {
            InitializeComponent();
            Con = new Funcation();
            ShowDepartment();
        }
        private void ShowDepartment()
        {
            string Qurey = "Select * from DepartmentTb1";
            Department.DataSource = Con.GetData(Qurey);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Qurey = "insert into DepartmentTbl values(' {0} ')";
                    Qurey = string.Format(Qurey, DepNameTb.Text);
                    Con.SetData(Qurey);
                    ShowDepartment();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private static DataTable DataSource;

        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DepNameTb.Text = Department.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(Department.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void FditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Qurey = "Update DepartmentTbl set DepName = '{0}' where DepId = {1}";
                    Qurey = string.Format(Qurey, DepNameTb.Text,Key);
                    Con.SetData(Qurey);
                    ShowDepartment();
                    MessageBox.Show("Department Updated!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void DeletBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Qurey = "Deleted from DepartmentTbl where DepId = {0}";
                    Qurey = string.Format(Qurey, Key);
                    Con.SetData(Qurey);
                    ShowDepartment();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
}