using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameTemplate.Screens
{
    public partial class MenuScreen : UserControl
    {
        Color buttonBackColor = Color.White;
        Color buttonActiveColor = Color.Green;

        public MenuScreen()
        {
            InitializeComponent();

            //ScreenControl.setComponentValues(this);
            defaultOverride();

            SoundPlayer player = new SoundPlayer(Properties.Resources.Kahoot_In_Game_Music_1);
            player.Play();

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "GameScreen");
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "InstructionScreen");
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "ScoreScreen");
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "OptionScreen");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Change any control default values here
        /// </summary>
        public void defaultOverride()
        {
            foreach (Control c in this.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + 75);             
            }

            gameTitle.Visible = true;
            gameTitle.Font = new Font("Impact", 45);
            gameTitle.Location = new Point(233, 50);

            //Location of buttons an titles and such

            pictureBox1.Location = new Point(50, 20);
            pictureBox2.Location = new Point(625, 20);
            playButton.Location = new Point(ScreenControl.controlWidth/2 - playButton.Size.Width/2, 160);
            instructionButton.Location = new Point(ScreenControl.controlWidth / 2 - instructionButton.Size.Width / 2, 250);
            scoresButton.Location = new Point(ScreenControl.controlWidth / 2 - scoresButton.Size.Width / 2, 340);
            exitButton.Location = new Point(ScreenControl.controlWidth / 2 - exitButton.Size.Width / 2, 520);
            optionsButton.Location = new Point(ScreenControl.controlWidth / 2 - optionsButton.Size.Width / 2, 430);
        }


    }
}
