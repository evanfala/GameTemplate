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
using System.Media;


namespace GameTemplate.Screens
{
    public partial class GameScreen : UserControl
    {
        public GameScreen()
        {
            InitializeComponent();
            // cubeImage = Properties.Resources.cube2;

            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            Font drawFont = new Font("Modern", 16, FontStyle.Bold);
            ship = Properties.Resources.Battle_ship;
            cube2 = Properties.Resources.cube2;
            left.Add(new Point(randNum.Next(20,200), 0));
            right.Add(new Point(randNum.Next(100, 150), 0));

            SoundPlayer player = new SoundPlayer(Properties.Resources.Kahoot_In_Game_Music_1);
            player.Play();


            scoreTimer.Enabled = true;
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
        
        string hit = "no hit";
        //initial starting points for black rectangle
        int drawX = 300;
        int drawY = 500;

        int monsterX = 0;
        int monsterY = 0;

        int bulletX = -10;
        int bulletY = -10;

       

        int newCube = 0;
        double elapsedTime = 0;

        int speed = 4;
    
        int cubesfall = 25;

        List<int> mX = new List<int>();

        Random randNum = new Random();


        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += 0.1;
        }

        List<int> mY = new List<int>();

        SolidBrush drawBrush = new SolidBrush(Color.Black);

        Font drawFont = new Font("Modern", 16, FontStyle.Bold);

        double distance = 0;
        double distance2 = 0;

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
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                
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
               
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
               
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


           
            


            if (elapsedTime > 15)
            {

                speed = 6;
                cubesfall = 20;

            }


            if (elapsedTime > 30)
            {

            speed = 8;
                cubesfall = 15;

            }

            if (elapsedTime > 45)
            {

                speed = 12;
                cubesfall = 12;

            }

            if (elapsedTime > 60)
            {

                speed = 16;
                cubesfall = 9;

            }

            if (elapsedTime > 80)
            {

                speed = 20;
                cubesfall = 6;

            }

            newCube++;

            if (newCube > cubesfall)
            {
                left.Add(new Point(randNum.Next(10, 399), 0));
                right.Add(new Point(randNum.Next(400, 750), 0));
              
                newCube = 0;
            }
            
           


            for (int i = 0; i < left.Count(); i++)
            {
                left[i] = new Point(left[i].X, left[i].Y + speed);

                right[i] = new Point(right[i].X, right[i].Y + speed);
            }
            #region main character movements

            // check distance between objects to determine if there is a collision 



            for (int i = 0; i < left.Count(); i++)
            {

                distance = Math.Sqrt(Math.Pow(left[i].X - drawX , 2) + Math.Pow(left[i].Y - drawY , 2));
                distance2 = Math.Sqrt(Math.Pow(right[i].X - drawX , 2) + Math.Pow(right[i].Y - drawY , 2));

                if (distance2 < 55 )
                {
                    hit = "hit";
                    gameTimer.Stop();
                   // Graphics.DrawString("Game Over", drawFont, drawBrush, 50, 40);


                }
                else
                {
                    hit = "no hit";
                }



                if (distance < 55 ) 
                {
                    hit = "hit";
                    gameTimer.Stop();

                }
                else
                {
                    hit = "no hit";
                }
            }





            if (leftArrowDown == true && drawX > 0)
            {
                drawX -= 10;
            }
            if (downArrowDown == true)
            {
                drawY += 10;
            }
            if (rightArrowDown == true && drawX < 740)
            {
                drawX += 10;
            }
            if (upArrowDown == true)
            {
                drawY -= 10;
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
            scoreTimer.Enabled = false;
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
            e.Graphics.DrawString("loop counter" + newCube, drawFont, drawBrush, 50, 40);
            e.Graphics.DrawString("Score: " + elapsedTime + " seconds", drawFont, drawBrush, this.Width - 200, 40);
            e.Graphics.DrawString(distance + "", drawFont, drawBrush, 50, 70);

            for (int i = 0; i < left.Count(); i++)
            {
                e.Graphics.DrawImage(cube2, left[i].X, left[i].Y, 60, 60);
                e.Graphics.DrawImage(cube2, right[i].X, right[i].Y, 60, 60);
            }

        }
    }
}
