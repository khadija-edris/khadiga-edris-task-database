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
    
    public partial class Employee : Form
    {
        Funcation Con;
        public Employee()
        {
            InitializeComponent();
            Con = new Funcation();
            ShowDep();
            GetDepatement();

        }
        private void ShowDep()
        {
            string Qurey = "Select * from EmployeeTb1";
            EmpList.DataSource = Con.GetData(Qurey);
        }

        private void GetDepatement()
        {
            String Query = "Select * from Departement";
            DepCb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            DepCb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            DepCb.DataSource = Con.SetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(GenCb.SelectedValue.ToString());
                    string Dop = DopTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int  Salary = Convert.ToInt32(DailySalTb.Text);

                    string Qurey = "insert into EmployeeTbl values(' {0} ','{1}','{2}','{3}','{4}','{5}')";
                    Qurey = string.Format(Qurey, Name, Gender, Dep, Dop, JDate, Salary);
                    Con.SetData(Qurey);
                    ShowDep();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
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
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    

                    string Qurey = "Delete from  EmployeeTbl where EmpId = '{0}'"; 
                    Qurey = string.Format(Qurey,Key);
                    Con.SetData(Qurey);
                    ShowDep();
                    MessageBox.Show("Employee Deleted!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(GenCb.SelectedValue.ToString());
                    string Dop = DopTb.Value.ToString();
                    string JDate = JDateTb.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    string Qurey = "UPdate EmployeeTbl Set EmpName = '{0}', EmpGen = '{1}',EmpDep = '{2}', EmpDop = '{3}', EmpJDate = '{4}', EmpSal = '{5}' where EmpId = '{6}'";
                    Qurey = string.Format(Qurey, Name, Gender, Dep, Dop, JDate, Salary, Key); 
                    Con.SetData(Qurey);
                    ShowDep();
                    MessageBox.Show("Employee Added!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }

    }
}
