using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playground
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string name, password;
            name = textBox1.Text;
            password = textBox2.Text;
            if (name == "project" && password == "project")
            {
                Mainform come = new Mainform();
                come.Show();
            }
            else
            {
                MessageBox.Show(" Try again");
            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signup go = new signup();
            go.Show();


        }
    }
}
