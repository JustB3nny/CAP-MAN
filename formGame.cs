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
            if (multiplayer)
            {
                lbBanner.Text = "Local Multiplayer";
                lbPlayer2.Visible = true;
                tbPlayer2.Visible = true;
            }
            pbGame.Hide(); lblP1Score.Hide(); lblP2Score.Hide();
            cellSize = new SizeF((float)pbGame.Width / gridWidth, (float)pbGame.Height / gridHeight); //Works out the size of one cell. 
            pbGame.BackgroundImage = new Bitmap(pbGame.Width, pbGame.Height); //Creates a bitmap the size of the panel and sets it as the background.
            g = Graphics.FromImage(pbGame.BackgroundImage); //Sets g to new graphics on the background image bitmap.
            loadMaze(wall, ref walls); //Passes the wall array and the List of points (walls) to the proceedure.
            loadMaze(point, ref points); //Passes the point array and the List of points (points) to the proceedure.
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
                    pbGame.Show(); lblP1Score.Show(); //Shows the picturebox which the game will be displayed in.
                    draw(); //Calls the draw proceedure.
                    timerTick.Start(); //Starts the timer.
                }
                else
                {
                    MessageBox.Show("You need to have 3 characters for your alias.");
                }
            }
            if (tbPlayer1.TextLength == 3)
            {
                p1Name = tbPlayer1.Text.ToUpper();
                if (multiplayer)
                {
                    if (tbPlayer2.TextLength == 3)
                    {
                        p2Name = tbPlayer2.Text.ToUpper();
                    }
                    else
                    {
                        MessageBox.Show("You need to have 3 characters for your alias.");
                    }
                }
            }
        }
        private void start()
        {
            lbPlayer1.Hide(); lbPlayer1.Hide(); tbPlayer1.Hide(); tbPlayer2.Hide(); btnStart.Hide();
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
            p1Position = new Point(p1Position.X + p1XMove, p1Position.Y + p1YMove); //Update player 1 X & Y position based on what key has been pressed.
            if (multiplayer) //Only if multiplayer
            {
                p2Position = new Point(p2Position.X + p2XMove, p2Position.Y + p2YMove); //Update player 2 X & Y position based on what key has been pressed.
            }
            //Wall collision.
            foreach (Point i in walls)
            {
                if (i == p1Position)
                {
                    p1Position = new Point(p1Position.X - p1XMove, p1Position.Y - p1YMove);
                }
                if (multiplayer)
                {
                    if (i == p2Position)
                    {
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
            for (int i = 0; i < points.Count; i++)
            {
                //Draws a coin at specific x & y values obtained by the index of the wall and cell size.
                g.FillEllipse(Brushes.Orange, points[i].X * cellSize.Width + cellSize.Width / 2, points[i].Y * cellSize.Height + cellSize.Height / 2, 5, 5);
            }

            //g.DrawImage(Image, p1.X * cellSize.Width + cellSize.Width / 4, p1.Y * cellSize.Height, 20, 20);

            //Player rendering.
            //Player 1 rendering.
            g.FillEllipse(Brushes.Green, p1Position.X * cellSize.Width + cellSize.Width / 4, p1Position.Y * cellSize.Height, 20, 20); //Draws a green circle at the grid coordinates (x,y).
            //Player 2 rendering.
            if (multiplayer)
            {
               g.FillEllipse(Brushes.Red, p2Position.X * cellSize.Width + cellSize.Width / 4, p2Position.Y * cellSize.Height, 20, 20); //Draws a red circle at the grid coordinates (x,y).
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
