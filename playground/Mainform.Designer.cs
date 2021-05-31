
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
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
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
    }
}