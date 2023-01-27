namespace khadiga_edris_task_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void resetbl_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            passwordTb.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Missing Date");
            }
            else if (UNameTb.Text == "Admin" && passwordTb.Text == "Password")
            {
                Employee Obj = new Employee();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or password");
                UNameTb.Text = "";
                passwordTb.Text = "";
            }
        }
        

    }
}