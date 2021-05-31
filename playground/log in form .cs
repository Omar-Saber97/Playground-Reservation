using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (name == "abc" && password == "123")
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح");
            }
            else
            {
                MessageBox.Show(" حاول مرة اخرى");
            }
        }
    }
}
