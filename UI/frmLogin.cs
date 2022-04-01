
using Core;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            logincheks log = new();

            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }

            else if (log.LoginCheck(txt_Password.Text, txt_UserName.Text) ==false)
            {
                MessageBox.Show("Pease enter right password and username");
            }
            else if(log.LoginCheck(txt_Password.Text,txt_UserName.Text)==true)
            {
                bool test = true;
            }

        }
    }
}