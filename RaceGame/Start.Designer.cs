namespace RaceGame
{
    partial class Start
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
            this.starter = new System.Windows.Forms.PictureBox();
            this.startBright = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.starter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // starter
            // 
            this.starter.BackColor = System.Drawing.Color.Transparent;
            this.starter.Image = global::RaceGame.Properties.Resources.button_start;
            this.starter.Location = new System.Drawing.Point(644, 600);
            this.starter.Name = "starter";
            this.starter.Size = new System.Drawing.Size(327, 97);
            this.starter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starter.TabIndex = 0;
            this.starter.TabStop = false;
            // 
            // startBright
            // 
            this.startBright.BackColor = System.Drawing.Color.Transparent;
            this.startBright.Image = global::RaceGame.Properties.Resources.button_start_bright;
            this.startBright.Location = new System.Drawing.Point(644, 600);
            this.startBright.Name = "startBright";
            this.startBright.Size = new System.Drawing.Size(327, 97);
            this.startBright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startBright.TabIndex = 1;
            this.startBright.TabStop = false;
            this.startBright.Visible = false;
            this.startBright.Click += new System.EventHandler(this.startBright_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Player 1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Player 2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RaceGame.Properties.Resources.button_exit;
            this.pictureBox1.Location = new System.Drawing.Point(33, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RaceGame.Properties.Resources.button_exit_bright;
            this.pictureBox2.Location = new System.Drawing.Point(33, 600);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RaceGame.Properties.Resources.screen_title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startBright);
            this.Controls.Add(this.starter);
            this.Name = "Start";
            this.Text = "Terror Nerds Race Game";
            ((System.ComponentModel.ISupportInitialize)(this.starter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void start_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox starter;
        private System.Windows.Forms.PictureBox startBright;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}