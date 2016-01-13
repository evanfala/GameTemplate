using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTemplate.Screens
{
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ScreenControl.changeScreen(this, "MenuScreen");
            
            
           


        }

        private void InstructionScreen_Load(object sender, EventArgs e)
        {
            this.Size = new Size(ScreenControl.controlWidth, ScreenControl.controlHeight);
            //location
            exitButton.Location = new Point(ScreenControl.controlWidth / 2 - exitButton.Size.Width / 2, 500);
            exitButton.Text = "Exit";
            pictureBox1.Location = new Point(0, 20);
            pictureBox2.Location = new Point(0, 200);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
