using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CAP_MAN
{
    public partial class formGame : Form
    {
        //Multiplayer flag to determine gamemode.
        public bool multiplayer;
        //Global player variables for name, score, position and movement.
        public string p1Name, p2Name; //Name.
        public int p1Score, p2Score; //Score.
        public Point p1Position = new Point(1, 28); //Player 1 position.
        public Point p2Position = new Point(26, 28); //Player 2 position.
        public int p1XMove, p1YMove, p2XMove, p2YMove; //Movement/direction.
        
        //Global maze variables for grid size, cell size, wall data and coin data.
        //Defines the width and height of the grid.
        public int gridWidth = 28, gridHeight = 30;
        //Reads the wall data from a file.
        string[] wall = File.ReadAllText(@"..\..\..\Files\walls.capman").Split(' ').ToArray();
        //Stores the points from the loaded wall data.
        public List<Point> walls = new List<Point>();
        //Reads the coin data from a file.
        string[] point = File.ReadAllText(@"..\..\..\Files\points.capman").Split(' ').ToArray();
        //Stores the points from the loaded coin data.
        public List<Point> points = new List<Point>();
        //Stores the width and height of once grid cell.
        SizeF cellSize;

        //Global rendering variables.
        Graphics g;

        Image Image = Image.FromFile(@"..\..\..\Images\BLUE_right.png");

        public formGame()
        {
            InitializeComponent();
        }

        //Form load
        private void formStartGame_Load(object sender, EventArgs e)
        {
            //Shows player 2 ui elements if the multiplayer flag is true.
            if (multiplayer)
            {
                //Changes the top banner to state that the gamemode is multiplayer.
                lbBanner.Text = "Local Multiplayer";
                //Displays the "player 2:" lable.
                lbPlayer2.Visible = true;
                //Displays the textbox for player 2 to enter their alias.
                tbPlayer2.Visible = true;
            }
            //Hides certain elements from showing till the game has started.
            //Hides the picturebox which the game is rendered to.
            pbGame.Hide(); 
            //Hides the lable that displays player 1's score.
            lblP1Score.Hide(); 
            //Hides the lable that displays player 2's score.
            lblP2Score.Hide();
            //Calculates the size of one grid cell by dividing the width and height of the picturebox by the gridWidth and gridHeight variables.
            cellSize = new SizeF((float)pbGame.Width / gridWidth, (float)pbGame.Height / gridHeight);
            //Creates a new bitmap on the background of the picturebox that is the same size and width of it.
            pbGame.BackgroundImage = new Bitmap(pbGame.Width, pbGame.Height);
            //Sets g to draw new graphics to the background image of the picturebox. 
            g = Graphics.FromImage(pbGame.BackgroundImage);
            //Calls the loadMaze proceedure to populate the list of points for the walls and coins by passing the list and data(by reference).
            //Walls
            loadMaze(wall, ref walls);
            //Coins
            loadMaze(point, ref points);
        }
        //Start game button
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (multiplayer)
            {
                if (tbPlayer1.TextLength == 3 && tbPlayer2.TextLength == 3)
                {
                    p1Name = tbPlayer1.Text.ToUpper();
                    p2Name = tbPlayer2.Text.ToUpper();
                    lbPlayer1.Hide(); lbPlayer1.Hide(); tbPlayer1.Hide(); tbPlayer2.Hide(); btnStart.Hide(); //Hides the user interface elements asking for the user's alias etc.
                    pbGame.Show(); lblP1Score.Show(); lblP2Score.Show(); //Shows the picturebox which the game will be displayed in.
                    draw(); //Calls the draw proceedure.
                    timerTick.Start(); //Starts the timer.
                }
                else
                {
                    MessageBox.Show("You need to have 3 characters for your alias.");
                }
            }
            else
            {
                if (tbPlayer1.TextLength == 3)
                {
                    p1Name = tbPlayer1.Text.ToUpper();
                    lbPlayer1.Hide(); lbPlayer1.Hide(); tbPlayer1.Hide(); tbPlayer2.Hide(); btnStart.Hide();
                    pbGame.Show(); lblP1Score.Show(); //Shows the picturebox which the game will be displayed in.
                    draw(); //Calls the draw proceedure.
                    timerTick.Start(); //Starts the timer.
                }
                else
                {
                    MessageBox.Show("You need to have 3 characters for your alias.");
                }
            }
        }

        //Key press movement.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Player 1 movement.
            //If key pressed is A move player 1 to the left.
            if (keyData == Keys.A)
            {
                p1XMove = -1;
                p1YMove = 0;
            }
            //If key pressed is D move player 1 to the right.
            if (keyData == Keys.D)
            {
                p1XMove = 1;
                p1YMove = 0;
            }
            //If key pressed is W move player 1 up.
            if (keyData == Keys.W)
            {
                p1XMove = 0;
                p1YMove = -1;
            }
            //If key pressed is W move player 1 down.
            if (keyData == Keys.S)
            {
                p1XMove = 0;
                p1YMove = 1;
            }
            //Player 2 movement
            //If key pressed is left arrow move player 2 to the left.
            if (keyData == Keys.Left)
            {
                p2XMove = -1;
                p2YMove = 0;
            }
            //If key pressed is right arrow move player 2 to the right.
            if (keyData == Keys.Right)
            {
                p2XMove = 1;
                p2YMove = 0;
            }
            //If key pressed is up arrow move player 2 up.
            if (keyData == Keys.Up)
            {
                p2XMove = 0;
                p2YMove = -1;
            }
            //If key pressed is down arrow move player 2 down.
            if (keyData == Keys.Down)
            {
                p2XMove = 0;
                p2YMove = 1;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Game tick.
        private void timerTick_Tick(object sender, EventArgs e)
        {
            //Player movement update.
            //Updates player 1's X & Y position with the direction the user wishes to move in.
            p1Position = new Point(p1Position.X + p1XMove, p1Position.Y + p1YMove);
            //Only if the multiplayer flag is true.
            if (multiplayer)
            {
                //Updates player 2's X & Y position with the direction the user wishes to move in.
                p2Position = new Point(p2Position.X + p2XMove, p2Position.Y + p2YMove);
            }
            //Wall collision.
            //Loops through every index in the list of points called walls.
            foreach (Point i in walls)
            {
                //Compares the point at each index to the player's position.
                if (i == p1Position)
                {
                    //If the player's position is the same as a wall position, it sets the players position back one movement value.
                    p1Position = new Point(p1Position.X - p1XMove, p1Position.Y - p1YMove);
                }
                //Only if the multiplayer flag is true.
                if (multiplayer)
                {
                    //Compares the point at each index to the player's position.
                    if (i == p2Position)
                    {
                        //If the player's position is the same as a wall position, it sets the players position back one movement value.
                        p2Position = new Point(p2Position.X - p2XMove, p2Position.Y - p2YMove);
                    }
                }
            }

            //Point collision.
            for (int i = 0; i < points.Count; i++) //Loops through each index in the list of points.
            {
                if (points[i] == p1Position) //If the point and the index == to player 1's point.
                {
                    points.Remove(points[i]); //Removes the point from the list at the index i.
                    p1Score++; //Increases the player's score by 1.
                }
            }
            if (multiplayer) //Only if multiplayer.
            {
                for (int i = 0; i < points.Count; i++) //Loops through each index in the list of points.
                {
                    if (points[i] == p2Position) //If the point and the index == to player 2's point.
                    {
                        points.RemoveAt(i); //Removes the point from the list at the index i.
                        p2Score++; //Increases the player's score by 1.
                    }
                }
            }
            //Point respawn.
            if (points.Count == 0) //If the list of points is empty.
            {
                loadMaze(point, ref points); //Refil the list with the points read from the file.
            }
            //Player score update
            lblP1Score.Text = p1Name + "'s Score: " + Convert.ToString(p1Score);
            lblP2Score.Text = p2Name + "'s Score: " + Convert.ToString(p2Score);

            //Draw graphics.
            draw(); //Calls the draw proceedure.
        }

        //Graphics rendering.
        private void draw()
        {
            //Clearing the bitmap for a blank canvas.
            g.Clear(Color.Black);

            //Maze rendering.
            //Draws the maze walls by looping through every index.
            for (int i = 0; i < walls.Count; i++)
            {
                //Draws a wall at specific x & y values obtained by the index of the wall and cell size.
                g.FillRectangle(Brushes.Blue, walls[i].X * cellSize.Width, walls[i].Y * cellSize.Height, cellSize.Width, cellSize.Height);
            }
            //Draws the maze coins by looping through every index.
            /*for (int i = 0; i < points.Count; i++)
            {
                //Draws a coin at specific x & y values obtained by the index of the wall and cell size.
                g.FillEllipse(Brushes.Orange, points[i].X * cellSize.Width + cellSize.Width / 2, points[i].Y * cellSize.Height + cellSize.Height / 2, 5, 5);
            }*/

            //g.DrawImage(Image, p1.X * cellSize.Width + cellSize.Width / 4, p1.Y * cellSize.Height, 20, 20);

            //Player 1 rendering.
            //Draws a green circle using the player position points multiplied by the width and height of one cell to create a bitmap coordinate. 
            g.FillEllipse(Brushes.Green, p1Position.X * cellSize.Width + cellSize.Width / 4, p1Position.Y * cellSize.Height, 20, 20);
            //Player 2 rendering.
            //Draws a red circle using the player position points multiplied by the width and height of one cell to create a bitmap coordinate. 
            if (multiplayer)
            {
               g.FillEllipse(Brushes.Red, p2Position.X * cellSize.Width + cellSize.Width / 4, p2Position.Y * cellSize.Height, 20, 20);
            }

            //Refreshing the picturebox background with the updated graphics/info.
            Refresh();
        }

        //Maze loader/generator/regenerator
        private void loadMaze(string[] data, ref List<Point> list)
        {
            int pointx, pointy;
            //Loops through the entirety of the data array passed to the proceedure.
            for (int i = 0; i < data.Length; i++)
            {
                //Splits the string at each index into to seperate parts and converts it to an integer.
                pointx = Convert.ToInt32(data[i].Substring(0, data[i].IndexOf(",")));
                pointy = Convert.ToInt32(data[i].Substring(data[i].IndexOf(",") + 1));
                //Uses the two integers obtained from splitting the string to add a new point to the list.
                list.Add(new Point(pointx, pointy));
            }
        }

    }
}
