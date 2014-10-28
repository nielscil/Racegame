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
    public partial class World : Form
    {            
        bool leaved = true;
        bool eur, af, asi, nr_am, z_am, aust, ant = false;
        byte i = 0;

        public World()
        {
            InitializeComponent();
            continents.Controls.Add(europe);
            continents.Controls.Add(noordAmerika);
            continents.Controls.Add(zuidAmerika);
            continents.Controls.Add(australie);
            continents.Controls.Add(afrika);
            continents.Controls.Add(asia);
            continents.Controls.Add(antartica);
            this.MouseEnter += new EventHandler(deSelectAll);
            confirm.MouseEnter += new EventHandler(confirm_MouseEnter);
            confirm.MouseLeave += new EventHandler(confirm_MouseLeave);
            europe.MouseEnter += new EventHandler(europe_MouseEnter);
            afrika.MouseEnter += new EventHandler(afrika_MouseEnter);
            noordAmerika.MouseEnter += new EventHandler(noordAmerika_MouseEnter);
            zuidAmerika.MouseEnter += new EventHandler(zuidAmerika_MouseEnter);
            asia.MouseEnter += new EventHandler(asia_MouseEnter);
            australie.MouseEnter += new EventHandler(australie_MouseEnter);
            antartica.MouseEnter += new EventHandler(antartica_MouseEnter);
            europe.MouseLeave += new EventHandler(europe_MouseLeave);
            afrika.MouseLeave += new EventHandler(afrika_MouseLeave);
            noordAmerika.MouseLeave += new EventHandler(noordAmerika_MouseLeave);
            zuidAmerika.MouseLeave += new EventHandler(zuidAmerika_MouseLeave);
            asia.MouseLeave += new EventHandler(asia_MouseLeave);
            australie.MouseLeave += new EventHandler(australie_MouseLeave);
            antartica.MouseLeave += new EventHandler(antartica_MouseLeave);
        }

        private void deSelectAll(object sender, EventArgs e)
        {
            
        }

        private void confirm_MouseEnter(object sender, EventArgs e)
        {
            confirm.Image = new Bitmap(RaceGame.Properties.Resources.button_confirm_bright);
        }

        private void confirm_MouseLeave(object sender, EventArgs e)
        {
            confirm.Image = new Bitmap(RaceGame.Properties.Resources.button_confirm);
        }

        private void europe_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Image = new Bitmap(RaceGame.Properties.Resources.con_europe_bright);
                asia.Visible = false;
                afrika.Visible = false;
                noordAmerika.Visible = false;
                zuidAmerika.Visible = false;
                australie.Visible = false;
            }
        }

        private void afrika_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = false;
                asia.Visible = false;
                afrika.Image = new Bitmap(RaceGame.Properties.Resources.con_afrika_bright);
                noordAmerika.Visible = false;
                zuidAmerika.Visible = false;
                australie.Visible = false;
            }
        }

        private void noordAmerika_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = false;
                asia.Visible = false;
                afrika.Visible = false;
                noordAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_north_amerika_bright);
                zuidAmerika.Visible = false;
                australie.Visible = false;
            }
        }

        private void zuidAmerika_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = false;
                asia.Visible = false;
                afrika.Visible = false;
                noordAmerika.Visible = false;
                zuidAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_south_amerika_bright);
                australie.Visible = false;
            }
        }

        private void asia_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = false;
                asia.Image = new Bitmap(RaceGame.Properties.Resources.con_asia_bright);
                afrika.Visible = false;
                noordAmerika.Visible = false;
                zuidAmerika.Visible = false;
                australie.Visible = false;
            }
        }

        private void australie_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = false;
                afrika.Visible = false;
                noordAmerika.Visible = false;
                zuidAmerika.Visible = false;
                asia.Visible = false;
                australie.Image = new Bitmap(RaceGame.Properties.Resources.con_australia_bright);
            }
        }

        private void antartica_MouseEnter(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = false;
                afrika.Visible = false;
                noordAmerika.Visible = false;
                zuidAmerika.Visible = false;
                antartica.Image = new Bitmap(RaceGame.Properties.Resources.con_antartica_bright);
                australie.Visible = false;
            }
        }

        private void europe_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Image = new Bitmap(RaceGame.Properties.Resources.con_europe);
                asia.Visible = true;
                afrika.Visible = true;
                noordAmerika.Visible = true;
                zuidAmerika.Visible = true;
                antartica.Visible = true;
                australie.Visible = true;
            }
        }

        private void afrika_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                afrika.Image = new Bitmap(RaceGame.Properties.Resources.con_afrika);
                europe.Visible = true;
                asia.Visible = true;
                noordAmerika.Visible = true;
                zuidAmerika.Visible = true;
                antartica.Visible = true;
                australie.Visible = true;
            }
        }

        private void noordAmerika_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                europe.Visible = true;
                asia.Visible = true;
                afrika.Visible = true;
                noordAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_north_amerika);
                zuidAmerika.Visible = true;
                antartica.Visible = true;
                australie.Visible = true;
            }
        }

        private void zuidAmerika_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
                zuidAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_south_amerika);
                europe.Visible = true;
                asia.Visible = true;
                afrika.Visible = true;
                noordAmerika.Visible = true;
                antartica.Visible = true;
                australie.Visible = true;
            }
        }

        private void asia_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
            europe.Visible = true;
            asia.Image = new Bitmap(RaceGame.Properties.Resources.con_asia);
            afrika.Visible = true;
            noordAmerika.Visible = true;
            zuidAmerika.Visible = true;
            antartica.Visible = true;
            australie.Visible = true;
            }
        }

        private void australie_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
            europe.Visible = true;
            asia.Visible = true;
            afrika.Visible = true;
            noordAmerika.Visible = true;
            zuidAmerika.Visible = true;
            antartica.Visible = true;
            australie.Image = new Bitmap(RaceGame.Properties.Resources.con_australia);
            }
        }

        private void antartica_MouseLeave(object sender, EventArgs e)
        {
            if (leaved == true)
            {
            antartica.Image = new Bitmap(RaceGame.Properties.Resources.con_antartica);
            europe.Visible = true;
            asia.Visible = true;
            afrika.Visible = true;
            noordAmerika.Visible = true;
            zuidAmerika.Visible = true;
            australie.Visible = true;
            }
        }

        private void europe_Click(object sender, EventArgs e)
        {
            if (eur == false)
            {
                europe.Image = new Bitmap(RaceGame.Properties.Resources.con_europe_bright);
                leaved = false;
                eur = true;
                i = 1;
            }
            else if (eur == true)
            {
                europe.Image = new Bitmap(RaceGame.Properties.Resources.con_europe);
                leaved = true;
                eur = false;
                i = 0;
            }

        }

        private void afrika_Click(object sender, EventArgs e)
        {
            if (af == false)
            {
                afrika.Image = new Bitmap(RaceGame.Properties.Resources.con_afrika_bright);
                leaved = false;
                af = true;
                i = 2;
            }
            else if(af == true)
            {
                afrika.Image = new Bitmap(RaceGame.Properties.Resources.con_afrika);
                leaved = true;
                af = false;
                i = 0;
            }
        }

        private void noordAmerika_Click(object sender, EventArgs e)
        {
            if (nr_am == false)
            {
                noordAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_north_amerika_bright);
                leaved = false;
                nr_am = true;
                i = 3;
            }
            else if(nr_am == true)
            {
                noordAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_north_amerika);
                leaved = true;
                nr_am = false;
                i = 0;
            }
        }

        private void zuidAmerika_Click(object sender, EventArgs e)
        {
            if (z_am == false)
            {
                zuidAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_south_amerika_bright);
                leaved = false;
                z_am = true;
                i = 4;
            }
            else if(z_am == true)
            {
                zuidAmerika.Image = new Bitmap(RaceGame.Properties.Resources.con_south_amerika);
                leaved = true;
                z_am = false;
                i = 0;
            }

        }

        private void asia_Click(object sender, EventArgs e)
        {
            if (asi == false)
            {
                asia.Image = new Bitmap(RaceGame.Properties.Resources.con_asia_bright);
                leaved = false;
                asi = true;
                i = 5;
            }
            else if(asi == true)
            {
                asia.Image = new Bitmap(RaceGame.Properties.Resources.con_asia);
                leaved = true;
                asi = false;
                i = 0;
            }
        }

        private void australie_Click(object sender, EventArgs e)
        {
            if (aust == false)
            {
                australie.Image = new Bitmap(RaceGame.Properties.Resources.con_australia_bright);
                leaved = false;
                aust = true;
                i = 6;
            }
            else if (aust == true)
            {
                australie.Image = new Bitmap(RaceGame.Properties.Resources.con_australia);
                leaved = true;
                aust = false;
                i = 0;
            }
        }

        private void antartica_Click(object sender, EventArgs e)
        {
            if (ant == false)
            {
                antartica.Image = new Bitmap(RaceGame.Properties.Resources.con_antartica_bright);
                leaved = false;
                ant = true;
                i = 7;
            }
            else if (ant == true)
            {
                antartica.Image = new Bitmap(RaceGame.Properties.Resources.con_antartica);
                leaved = true;
                ant = false;
                i = 0;
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                Options options = (Options)this.Owner;
                options.TrackPick(i);
                this.Close();
            }
            else
            {
                MessageBox.Show("Geef een continent aan!");
            }
        }
    }
}
