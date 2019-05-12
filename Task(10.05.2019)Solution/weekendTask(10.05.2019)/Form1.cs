using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weekendTask_10._05._2019_
{
    public partial class LoginForm : Form
    {

        public static List<User> users = new List<User>();

        

        public LoginForm()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //users.Find();
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
