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
        private void EmpNameTb_TextChanged(object sender, EventArgs e)
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
                    string Dep = GenCb.SelectedValue.ToString();
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
    }
}
