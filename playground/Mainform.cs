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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(comboBox1.Text== "FootBall")
            {
                footballpic.Visible = true;

                about_label.Text = "Five-a-side football is a variation of association football, in which each team fields five players (four outfield players and a goalkeeper). Other differences from football include a smaller pitch, smaller goals, and a reduced game duration.";
            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
