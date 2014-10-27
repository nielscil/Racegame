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
    public partial class Options : Form
    {
        byte carSelect1, selectedCar1, trk = 0;
        byte carSelect2, selectedCar2 = 1;
        public string naam1, naam2;
        public Options()
        {
            InitializeComponent();
            track.Image = new Bitmap(RaceGame.Properties.Resources.con_afrika, 126, 150);
            this.MouseEnter += new EventHandler(deSelectAll);
            exit.MouseEnter += new System.EventHandler(exit_MouseEnter);
            startGame.MouseEnter += new System.EventHandler(startGame_MouseEnter);
            selectWorld.MouseEnter += new System.EventHandler(selectWorld_MouseEnter);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void TrackPick(byte i)
        {
            switch (i)
            {
                case 1:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_europe,150,104);
                    trk = 4;
                    break;
                case 2:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_afrika,126,150);
                    trk = 0;
                    break;
                case 3:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_north_amerika,150,91);
                    trk = 5;
                    break;
                case 4:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_south_amerika,93,150);
                    trk = 6;
                    break;
                case 5:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_asia,150,123);
                    trk = 3;
                    break;
                case 6:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_australia,127,150);
                    trk = 2;
                    break;
                case 7:
                    track.Image = new Bitmap(RaceGame.Properties.Resources.con_antartica,150,31);
                    trk = 1;
                    break;
            }
        }

        private void exit_MouseEnter(object sender, System.EventArgs e)
        {
            exitBright.Visible = true;
        }

        private void deSelectAll(object sender, EventArgs e)
        {
            exitBright.Visible = false;
            startGameBright.Visible = false;
            selectWorldBright.Visible = false;
        }

        private void exitBright_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startGame_MouseEnter(object sender, EventArgs e)
        {
            startGameBright.Visible = true;
        }

        private void selectWorld_MouseEnter(object sender, EventArgs e)
        {
            selectWorldBright.Visible = true;
        }

        private void startGameBright_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Starten ja");
            //laadscherm openen met game daarachter
        }

        private void VehicleSelect1()
        {
            List<byte> selectableCars1 = new List<byte>();
            for (byte i = 0; i < 5; i++)
                selectableCars1.Add(i);
            selectableCars1.Remove(selectedCar2);

            selectedCar1 = selectableCars1[carSelect1];
            switch (selectedCar1)
            {
                case 0:
                    car1.Image = new Bitmap(RaceGame.Properties.Resources.carMenuRed);
                    break;
                case 1:
                    car1.Image = new Bitmap(RaceGame.Properties.Resources.carMenuGreen);
                    break;
                case 2:
                    car1.Image = new Bitmap(RaceGame.Properties.Resources.carMenuBlue);
                    break;
                case 3:
                    car1.Image = new Bitmap(RaceGame.Properties.Resources.carMenuGrey);
                    break;
                case 4:
                    car1.Image = new Bitmap(RaceGame.Properties.Resources.carMenuRainbow);
                    break;
            }

        }

        private void vehicleLeft1_Click(object sender, EventArgs e)
        {
            if (carSelect1 > 0)
            {
                carSelect1--;
            }
            else
            {
                carSelect1 = 3;
            }
            VehicleSelect1();
        }

        private void vehicleRight1_Click(object sender, EventArgs e)
        {
            if (carSelect1 < 3)
            {
                carSelect1++;
            }
            else
            {
                carSelect1 = 0;
            }
            VehicleSelect1();
        }

        private void VehicleSelect2()
        {
            List<byte> selectableCars2 = new List<byte>();
            for (byte i = 0; i < 5; i++)
                selectableCars2.Add(i);
            selectableCars2.Remove(selectedCar1);

            selectedCar2 = selectableCars2[carSelect2];
            switch (selectedCar2)
            {
                case 0:
                    car2.Image = new Bitmap(RaceGame.Properties.Resources.carMenuRed);
                    break;
                case 1:
                    car2.Image = new Bitmap(RaceGame.Properties.Resources.carMenuGreen);
                    break;
                case 2:
                    car2.Image = new Bitmap(RaceGame.Properties.Resources.carMenuBlue);
                    break;
                case 3:
                    car2.Image = new Bitmap(RaceGame.Properties.Resources.carMenuGrey);
                    break;
                case 4:
                    car2.Image = new Bitmap(RaceGame.Properties.Resources.carMenuRainbow);
                    break;
            }

        }

        private void vehicleLeft2_Click(object sender, EventArgs e)
        {
            if (carSelect2 > 0)
            {
                carSelect2--;
            }
            else
            {
                carSelect2 = 3;
            }
            VehicleSelect2();
        }

        private void vehicleRight2_Click(object sender, EventArgs e)
        {
            if (carSelect2 < 3)
            {
                carSelect2++;
            }
            else
            {
                carSelect2 = 0;
            }
            VehicleSelect2();
        }

        private void selectWorldBright_Click(object sender, EventArgs e)
        {
            World world = new World();
            world.Show(this);
        }

        private void startGameBright_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Start start = new Start();
            form1.trk = this.trk;
            form1.car1 = this.selectedCar1;
            form1.car2 = this.selectedCar2;
            form1.naam1 = naam1;
            form1.naam2 = naam2;
            form1.Show();
            this.Close();
            
        }
    }
}
