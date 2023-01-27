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
            if(UNameTb.Text == "" || passwordTb.Text == "") 
            {
                MessageBox.Show("Missing Date");
            }
        }
    }
}