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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            LoginForm.users.Add(newUser);

        }
    }
}
