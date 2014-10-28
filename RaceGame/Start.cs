using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    
    public partial class Start : Form
    {
            public Start()
            {
                InitializeComponent();
                starter.MouseEnter += new EventHandler(OnMouseEnterStart);
                pictureBox1.MouseEnter += new EventHandler(OnMouseEnterExit);
                this.MouseEnter += new EventHandler(start_MouseLeave);
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            private void OnMouseEnterExit(object sender,EventArgs e)
            {
                pictureBox2.Visible = true;
            }

            private void OnMouseEnterStart(object sender, System.EventArgs e)
            {
                startBright.Visible = true;
            }

            private void start_MouseLeave(object sender, EventArgs e)
            {
                startBright.Visible = false;
                pictureBox2.Visible = false;
            }

            private void pictureBox2_click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void startBright_Click(object sender, EventArgs e)
            {
                if (textBox1.Text != "Player 1" && textBox2.Text != "Player 2")
                {
                    Options optionScreen = new Options();
                    optionScreen.naam1 = textBox1.Text;
                    optionScreen.naam2 = textBox2.Text;
                    optionScreen.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Vul jullie namen in!");
            }       
    }
}
