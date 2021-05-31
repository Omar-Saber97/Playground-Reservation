
namespace playground
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.footballpic = new System.Windows.Forms.PictureBox();
            this.basketpic = new System.Windows.Forms.PictureBox();
            this.vollypic = new System.Windows.Forms.PictureBox();
            this.tennispic = new System.Windows.Forms.PictureBox();
            this.about_label = new System.Windows.Forms.Label();
            this.BOX1 = new System.Windows.Forms.TextBox();
            this.BOX2 = new System.Windows.Forms.TextBox();
            this.BOX3 = new System.Windows.Forms.TextBox();
            this.BOX4 = new System.Windows.Forms.TextBox();
            this.BOX5 = new System.Windows.Forms.TextBox();
            this.BOX6 = new System.Windows.Forms.TextBox();
            this.BOX7 = new System.Windows.Forms.TextBox();
            this.BOX8 = new System.Windows.Forms.TextBox();
            this.BOX9 = new System.Windows.Forms.TextBox();
            this.BOX10 = new System.Windows.Forms.TextBox();
            this.BOX11 = new System.Windows.Forms.TextBox();
            this.BOX12 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pl2_label = new System.Windows.Forms.Label();
            this.pl3 = new System.Windows.Forms.Label();
            this.pl5 = new System.Windows.Forms.Label();
            this.pl7 = new System.Windows.Forms.Label();
            this.pl9 = new System.Windows.Forms.Label();
            this.pl11 = new System.Windows.Forms.Label();
            this.pl4 = new System.Windows.Forms.Label();
            this.pl6 = new System.Windows.Forms.Label();
            this.pl8 = new System.Windows.Forms.Label();
            this.pl10 = new System.Windows.Forms.Label();
            this.pl12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.footballpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vollypic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennispic)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FootBall",
            "Tennis(1vs1)",
            "Tennis(2vs2)",
            "VollyBall",
            "BasketBall"});
            this.comboBox1.Location = new System.Drawing.Point(171, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "choose your Game";
            // 
            // footballpic
            // 
            this.footballpic.Image = global::playground.Properties.Resources.football;
            this.footballpic.Location = new System.Drawing.Point(620, 54);
            this.footballpic.Name = "footballpic";
            this.footballpic.Size = new System.Drawing.Size(261, 252);
            this.footballpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footballpic.TabIndex = 2;
            this.footballpic.TabStop = false;
            this.footballpic.Visible = false;
            // 
            // basketpic
            // 
            this.basketpic.Image = global::playground.Properties.Resources.basket;
            this.basketpic.Location = new System.Drawing.Point(620, 56);
            this.basketpic.Name = "basketpic";
            this.basketpic.Size = new System.Drawing.Size(261, 251);
            this.basketpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basketpic.TabIndex = 3;
            this.basketpic.TabStop = false;
            this.basketpic.Visible = false;
            // 
            // vollypic
            // 
            this.vollypic.Image = global::playground.Properties.Resources.volly;
            this.vollypic.Location = new System.Drawing.Point(620, 56);
            this.vollypic.Name = "vollypic";
            this.vollypic.Size = new System.Drawing.Size(261, 251);
            this.vollypic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vollypic.TabIndex = 4;
            this.vollypic.TabStop = false;
            this.vollypic.Visible = false;
            // 
            // tennispic
            // 
            this.tennispic.Image = global::playground.Properties.Resources.tennis;
            this.tennispic.Location = new System.Drawing.Point(620, 54);
            this.tennispic.Name = "tennispic";
            this.tennispic.Size = new System.Drawing.Size(261, 252);
            this.tennispic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tennispic.TabIndex = 5;
            this.tennispic.TabStop = false;
            this.tennispic.Visible = false;
            // 
            // about_label
            // 
            this.about_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.about_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.about_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_label.Location = new System.Drawing.Point(620, 310);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(261, 110);
            this.about_label.TabIndex = 6;
            // 
            // BOX1
            // 
            this.BOX1.Location = new System.Drawing.Point(124, 114);
            this.BOX1.Multiline = true;
            this.BOX1.Name = "BOX1";
            this.BOX1.Size = new System.Drawing.Size(129, 31);
            this.BOX1.TabIndex = 7;
            // 
            // BOX2
            // 
            this.BOX2.Location = new System.Drawing.Point(385, 114);
            this.BOX2.Multiline = true;
            this.BOX2.Name = "BOX2";
            this.BOX2.Size = new System.Drawing.Size(128, 31);
            this.BOX2.TabIndex = 8;
            // 
            // BOX3
            // 
            this.BOX3.Location = new System.Drawing.Point(124, 151);
            this.BOX3.Multiline = true;
            this.BOX3.Name = "BOX3";
            this.BOX3.Size = new System.Drawing.Size(129, 33);
            this.BOX3.TabIndex = 9;
            // 
            // BOX4
            // 
            this.BOX4.Location = new System.Drawing.Point(385, 151);
            this.BOX4.Multiline = true;
            this.BOX4.Name = "BOX4";
            this.BOX4.Size = new System.Drawing.Size(128, 33);
            this.BOX4.TabIndex = 10;
            // 
            // BOX5
            // 
            this.BOX5.Location = new System.Drawing.Point(124, 190);
            this.BOX5.Multiline = true;
            this.BOX5.Name = "BOX5";
            this.BOX5.Size = new System.Drawing.Size(129, 30);
            this.BOX5.TabIndex = 11;
            // 
            // BOX6
            // 
            this.BOX6.Location = new System.Drawing.Point(385, 190);
            this.BOX6.Multiline = true;
            this.BOX6.Name = "BOX6";
            this.BOX6.Size = new System.Drawing.Size(128, 30);
            this.BOX6.TabIndex = 12;
            // 
            // BOX7
            // 
            this.BOX7.Location = new System.Drawing.Point(124, 226);
            this.BOX7.Multiline = true;
            this.BOX7.Name = "BOX7";
            this.BOX7.Size = new System.Drawing.Size(129, 29);
            this.BOX7.TabIndex = 13;
            // 
            // BOX8
            // 
            this.BOX8.Location = new System.Drawing.Point(385, 226);
            this.BOX8.Multiline = true;
            this.BOX8.Name = "BOX8";
            this.BOX8.Size = new System.Drawing.Size(128, 29);
            this.BOX8.TabIndex = 14;
            // 
            // BOX9
            // 
            this.BOX9.Location = new System.Drawing.Point(124, 261);
            this.BOX9.Multiline = true;
            this.BOX9.Name = "BOX9";
            this.BOX9.Size = new System.Drawing.Size(129, 27);
            this.BOX9.TabIndex = 15;
            // 
            // BOX10
            // 
            this.BOX10.Location = new System.Drawing.Point(385, 261);
            this.BOX10.Multiline = true;
            this.BOX10.Name = "BOX10";
            this.BOX10.Size = new System.Drawing.Size(128, 27);
            this.BOX10.TabIndex = 16;
            // 
            // BOX11
            // 
            this.BOX11.Location = new System.Drawing.Point(124, 294);
            this.BOX11.Multiline = true;
            this.BOX11.Name = "BOX11";
            this.BOX11.Size = new System.Drawing.Size(129, 30);
            this.BOX11.TabIndex = 17;
            // 
            // BOX12
            // 
            this.BOX12.Location = new System.Drawing.Point(385, 294);
            this.BOX12.Multiline = true;
            this.BOX12.Name = "BOX12";
            this.BOX12.Size = new System.Drawing.Size(128, 30);
            this.BOX12.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Player 1:";
            // 
            // pl2_label
            // 
            this.pl2_label.AutoSize = true;
            this.pl2_label.Location = new System.Drawing.Point(332, 117);
            this.pl2_label.Name = "pl2_label";
            this.pl2_label.Size = new System.Drawing.Size(47, 13);
            this.pl2_label.TabIndex = 20;
            this.pl2_label.Text = "player 2:";
            // 
            // pl3
            // 
            this.pl3.AutoSize = true;
            this.pl3.Location = new System.Drawing.Point(70, 154);
            this.pl3.Name = "pl3";
            this.pl3.Size = new System.Drawing.Size(48, 13);
            this.pl3.TabIndex = 21;
            this.pl3.Text = "Player 3:";
            // 
            // pl5
            // 
            this.pl5.AutoSize = true;
            this.pl5.Location = new System.Drawing.Point(70, 190);
            this.pl5.Name = "pl5";
            this.pl5.Size = new System.Drawing.Size(48, 13);
            this.pl5.TabIndex = 22;
            this.pl5.Text = "Player 5:";
            // 
            // pl7
            // 
            this.pl7.AutoSize = true;
            this.pl7.Location = new System.Drawing.Point(70, 226);
            this.pl7.Name = "pl7";
            this.pl7.Size = new System.Drawing.Size(48, 13);
            this.pl7.TabIndex = 23;
            this.pl7.Text = "Player 7:";
            // 
            // pl9
            // 
            this.pl9.AutoSize = true;
            this.pl9.Location = new System.Drawing.Point(70, 264);
            this.pl9.Name = "pl9";
            this.pl9.Size = new System.Drawing.Size(48, 13);
            this.pl9.TabIndex = 24;
            this.pl9.Text = "Player 9:";
            // 
            // pl11
            // 
            this.pl11.AutoSize = true;
            this.pl11.Location = new System.Drawing.Point(64, 297);
            this.pl11.Name = "pl11";
            this.pl11.Size = new System.Drawing.Size(54, 13);
            this.pl11.TabIndex = 25;
            this.pl11.Text = "Player 11:";
            // 
            // pl4
            // 
            this.pl4.AutoSize = true;
            this.pl4.Location = new System.Drawing.Point(332, 151);
            this.pl4.Name = "pl4";
            this.pl4.Size = new System.Drawing.Size(48, 13);
            this.pl4.TabIndex = 26;
            this.pl4.Text = "Player 4:";
            // 
            // pl6
            // 
            this.pl6.AutoSize = true;
            this.pl6.Location = new System.Drawing.Point(331, 193);
            this.pl6.Name = "pl6";
            this.pl6.Size = new System.Drawing.Size(48, 13);
            this.pl6.TabIndex = 27;
            this.pl6.Text = "Player 6:";
            // 
            // pl8
            // 
            this.pl8.AutoSize = true;
            this.pl8.Location = new System.Drawing.Point(331, 229);
            this.pl8.Name = "pl8";
            this.pl8.Size = new System.Drawing.Size(48, 13);
            this.pl8.TabIndex = 28;
            this.pl8.Text = "Player 8:";
            // 
            // pl10
            // 
            this.pl10.AutoSize = true;
            this.pl10.Location = new System.Drawing.Point(325, 264);
            this.pl10.Name = "pl10";
            this.pl10.Size = new System.Drawing.Size(54, 13);
            this.pl10.TabIndex = 29;
            this.pl10.Text = "Player 10:";
            // 
            // pl12
            // 
            this.pl12.AutoSize = true;
            this.pl12.Location = new System.Drawing.Point(326, 297);
            this.pl12.Name = "pl12";
            this.pl12.Size = new System.Drawing.Size(54, 13);
            this.pl12.TabIndex = 30;
            this.pl12.Text = "Player 12:";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.pl12);
            this.Controls.Add(this.pl10);
            this.Controls.Add(this.pl8);
            this.Controls.Add(this.pl6);
            this.Controls.Add(this.pl4);
            this.Controls.Add(this.pl11);
            this.Controls.Add(this.pl9);
            this.Controls.Add(this.pl7);
            this.Controls.Add(this.pl5);
            this.Controls.Add(this.pl3);
            this.Controls.Add(this.pl2_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BOX12);
            this.Controls.Add(this.BOX11);
            this.Controls.Add(this.BOX10);
            this.Controls.Add(this.BOX9);
            this.Controls.Add(this.BOX8);
            this.Controls.Add(this.BOX7);
            this.Controls.Add(this.BOX6);
            this.Controls.Add(this.BOX5);
            this.Controls.Add(this.BOX4);
            this.Controls.Add(this.BOX3);
            this.Controls.Add(this.BOX2);
            this.Controls.Add(this.BOX1);
            this.Controls.Add(this.about_label);
            this.Controls.Add(this.tennispic);
            this.Controls.Add(this.vollypic);
            this.Controls.Add(this.basketpic);
            this.Controls.Add(this.footballpic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vollypic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennispic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox footballpic;
        private System.Windows.Forms.PictureBox basketpic;
        private System.Windows.Forms.PictureBox vollypic;
        private System.Windows.Forms.PictureBox tennispic;
        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.TextBox BOX1;
        private System.Windows.Forms.TextBox BOX2;
        private System.Windows.Forms.TextBox BOX3;
        private System.Windows.Forms.TextBox BOX4;
        private System.Windows.Forms.TextBox BOX5;
        private System.Windows.Forms.TextBox BOX6;
        private System.Windows.Forms.TextBox BOX7;
        private System.Windows.Forms.TextBox BOX8;
        private System.Windows.Forms.TextBox BOX9;
        private System.Windows.Forms.TextBox BOX10;
        private System.Windows.Forms.TextBox BOX11;
        private System.Windows.Forms.TextBox BOX12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pl2_label;
        private System.Windows.Forms.Label pl3;
        private System.Windows.Forms.Label pl5;
        private System.Windows.Forms.Label pl7;
        private System.Windows.Forms.Label pl9;
        private System.Windows.Forms.Label pl11;
        private System.Windows.Forms.Label pl4;
        private System.Windows.Forms.Label pl6;
        private System.Windows.Forms.Label pl8;
        private System.Windows.Forms.Label pl10;
        private System.Windows.Forms.Label pl12;
    }
}