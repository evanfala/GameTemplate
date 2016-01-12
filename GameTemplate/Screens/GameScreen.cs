using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameTemplate.Dialogs;


namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            // cubeImage = Properties.Resources.cube2;
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Graphics formGraphics = this.CreateGraphics();

            Font drawFont = new Font("Modern", 16, FontStyle.Bold);
            ship = Properties.Resources.Battle_ship;
            cube2 = Properties.Resources.cube2;
            left.Add(new Point(400, 0));
            right.Add(new Point(600, 0));
        }

        #region required global values - DO NOT CHANGE

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //player2 button control keys - DO NOT CHANGE
        Boolean aDown, sDown, dDown, wDown, cDown, vDown, xDown, zDown;

        #endregion

        //TODO - Place game global variables here
        //---------------------------------------
        Image ship;
        Image cube2;

        //initial starting points for black rectangle
        int drawX = 300;
        int drawY = 500;

        int monsterX = 0;
        int monsterY = 0;

        int bulletX = -10;
        int bulletY = -10;

        List<int> mX = new List<int>();
        List<int> mY = new List<int>();
       
        //Graphics objects
        SolidBrush heroBrush = new SolidBrush(Color.White);
        SolidBrush monsterBrush = new SolidBrush(Color.White);

        List<Point> left = new List<Point>();
        List<Point> right = new List<Point>();
        //----------------------------------------

        // PreviewKeyDown required for UserControl instead of KeyDown as on a form
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                pauseGame();
            }

            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }

            //player 2 button presses
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.C:
                    cDown = true;
                    break;
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.X:
                    xDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;
                default:
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }

            //player 2 button releases
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// All game update logic must be placed in this event method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < left.Count(); i++)
            {
                left[i] = new Point(left[i].X, left[i].Y + 4);

                right[i] = new Point(right[i].X, right[i].Y + 4);
            }
            #region main character movements
            
            {  // check distance between objects to determine if there is a collision 
                 double distance = Math.Sqrt(Math.Pow(monsterX - shipX, 2) + Math.Pow(monsterY - shipY, 2));

                if (distance < 20)
                {
                    hit = "hit";
                }
                else
                {
                    hit = "no hit";
                }

            }




            if (leftArrowDown == true && drawX > 0)
            {
                drawX-=10;
            }
            if (downArrowDown == true)
            {
                drawY+=10;
            }
            if (rightArrowDown == true && drawX < 740)
            {
                drawX+=10;
            }
            if (upArrowDown == true)
            {
                drawY-=10;
            }

            #endregion

            #region monster movements - TO BE COMPLETED

            if (monsterX > drawX)
            {
                monsterX--;

            }
            else
            {
                monsterX++;

            }
            if (monsterY > drawY)
            {
                monsterY--;

            }
            else
            {
                monsterY++;

            }



            #endregion

            #region collision detection - TO BE COMPLETED


            #endregion


            //refresh the screen, which causes the GameScreen_Paint method to run
            Refresh();
        }

        /// <summary>
        /// Open the pause dialog box and gets Cancel or Abort result from it
        /// </summary>
        private void pauseGame()
        {
            gameTimer.Enabled = false;
            rightArrowDown = leftArrowDown = upArrowDown = downArrowDown = false;

            DialogResult result = PauseDialog.Show();

            if (result == DialogResult.Cancel)
            {
                gameTimer.Enabled = true;
            }
            if (result == DialogResult.Abort)
            {
                ScreenControl.changeScreen(this, "MenuScreen");
            }
        }

        /// <summary>
        /// All drawing, (and only drawing), to be done here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw rectangle to screen
            e.Graphics.DrawImage(ship, drawX, drawY, 60, 60);

            for (int i = 0; i < left.Count(); i++)
            {
                e.Graphics.DrawImage(cube2, left[i].X, left[i].Y, 20, 20);
                e.Graphics.DrawImage(cube2, right[i].X, right[i].Y, 20, 20);
                formGraphics.DrawString("No hit", Font, , 50, 40);

            }

        }
    }
}
