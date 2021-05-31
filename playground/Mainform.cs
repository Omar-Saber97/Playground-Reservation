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
            if (comboBox1.SelectedIndex == 0)
            {
                footballpic.Visible = true;
                BOX11.Visible = false;
                BOX12.Visible = false;
                pl11.Visible = false;
                pl12.Visible = false;


                about_label.Text = "Five-a-side football is a variation of association football, in which each team fields five players (four outfield players and a goalkeeper). Other differences from football include a smaller pitch, smaller goals, and a reduced game duration.";
            }
              if (comboBox1.SelectedIndex == 1)
            {
                tennispic.Visible = true;
                BOX11.Visible = false; pl11.Visible = false;
                BOX12.Visible = false; pl12.Visible = false;
                pl10.Visible = false; BOX10.Visible = false;
                pl9.Visible = false;  BOX9.Visible = false;
                pl8.Visible = false; BOX8.Visible = false;
                pl7.Visible = false; BOX7.Visible = false;
                pl6.Visible = false;  BOX6.Visible = false;
                pl5.Visible = false;  BOX5.Visible = false;
                pl4.Visible = false;  BOX4.Visible = false;
                pl3.Visible = false;  BOX3.Visible = false;
                about_label.Text = "Tennis is a racket sport that can be played individually against a single opponent or between two teams of two players each. Each player uses a tennis racket that is strung with cord to strike a hollow rubber ball covered with felt over or around a net and into the opponent's court";
            }
              if (comboBox1.SelectedIndex == 2)
            {
                tennispic.Visible = true;
                BOX12.Visible = false; pl12.Visible = false;
                BOX11.Visible = false; pl11.Visible = false;
                pl10.Visible = false; BOX10.Visible = false;
                pl9.Visible = false; BOX9.Visible = false;
                pl8.Visible = false; BOX8.Visible = false;
                pl7.Visible = false; BOX7.Visible = false;
                pl6.Visible = false; BOX6.Visible = false;
                pl5.Visible = false; BOX5.Visible = false;
                pl4.Visible = true; BOX4.Visible = true;
                pl3.Visible = true; BOX3.Visible = true;

                about_label.Text = "Tennis is a racket sport that can be played individually against a single opponent or between two teams of two players each. Each player uses a tennis racket that is strung with cord to strike a hollow rubber ball covered with felt over or around a net and into the opponent's court";

            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
