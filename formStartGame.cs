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
    public partial class formStartGame : Form
    {
        public bool multiplayer; //
        public string p1Name, p2Name; //Stores player's inputed alias.
        public int p1Score, p2Score; //Stores player's score.
        public Point p1 = new Point(1, 28);
        public Point p2 = new Point(26, 28);
        public int p1XMove, p1YMove, p2XMove, p2YMove; //Stores the direction in which the player wants to move.
        public int gridWidth = 28, gridHeight = 30; //Defines the grid sizes.
        string[] wall = File.ReadAllText(@"..\..\..\Files\walls.capman").Split(' ').ToArray(); //Reads the walls.capman file splitting it by the ' ' into each index.
        public List<Point> walls = new List<Point>();
        string[] point = File.ReadAllText(@"..\..\..\Files\points.capman").Split(' ').ToArray(); //Reads the points.capman file splitting it by the ' ' into each index.
        public List<Point> points = new List<Point>();
        Graphics g;
        SizeF cellSize;

        Image Image = Image.FromFile(@"..\..\..\Images\BLUE_right.png");

        public formStartGame()
        {
            InitializeComponent();
        }
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            start();
            //KeyPreview = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Player 1 movement
            if (keyData == Keys.A)
            {
                p1XMove = -1;
                p1YMove = 0;
            }
            if (keyData == Keys.D)
            {
                p1XMove = 1;
                p1YMove = 0;
            }
            if (keyData == Keys.W)
            {
                p1XMove = 0;
                p1YMove = -1;
            }
            if (keyData == Keys.S)
            {
                p1XMove = 0;
                p1YMove = 1;
            }

            //Player 2 movement
            if (keyData == Keys.Left)
            {
                p2XMove = -1;
                p2YMove = 0;
            }
            if (keyData == Keys.Right)
            {
                p2XMove = 1;
                p2YMove = 0;
            }
            if (keyData == Keys.Up)
            {
                p2XMove = 0;
                p2YMove = -1;
            }
            if (keyData == Keys.Down)
            {
                p2XMove = 0;
                p2YMove = 1;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void start()
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
                    lbPlayer1.Hide(); lbPlayer1.Hide(); tbPlayer1.Hide(); tbPlayer2.Hide(); btnStart.Hide(); //Hides the user interface elements asking for the user's alias etc.
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
        private void timerTick_Tick(object sender, EventArgs e)
        {
            p1 = new Point(p1.X + p1XMove, p1.Y + p1YMove); //Update player 1 X & Y position based on what key has been pressed.
            if (multiplayer) //Only if multiplayer
            {
                p2 = new Point(p2.X + p2XMove, p2.Y + p2YMove); //Update player 2 X & Y position based on what key has been pressed.
            }
            foreach (Point i in walls)
            {
                if (i == p1)
                {
                    p1 = new Point(p1.X - p1XMove, p1.Y - p1YMove);
                }
                if (multiplayer)
                {
                    if (i == p2)
                    {
                        p2 = new Point(p2.X - p2XMove, p2.Y - p2YMove);
                    }
                }
            }
            for (int i = 0; i < points.Count; i++) //Loops through each index in the list of points.
            {
                if (points[i] == p1) //If the point and the index == to player 1's point.
                {
                    points.Remove(points[i]); //Removes the point from the list at the index i.
                    p1Score++; //Increases the player's score by 1.
                }
            }

            if (multiplayer) //Only if multiplayer.
            {
                for (int i = 0; i < points.Count; i++) //Loops through each index in the list of points.
                {
                    if (points[i] == p2) //If the point and the index == to player 2's point.
                    {
                        points.RemoveAt(i); //Removes the point from the list at the index i.
                        p2Score++; //Increases the player's score by 1.
                    }
                }
            }

            if (points.Count == 0) //If the list of points is empty.
            {
                loadMaze(point, ref points); //Refil the list with the points read from the file.
            }

            lblP1Score.Text = p1Name + "'s Score: " + Convert.ToString(p1Score);
            lblP2Score.Text = p2Name + "'s Score: " + Convert.ToString(p2Score);


            draw(); //Calls the draw proceedure.
        }

        private void draw()
        {
            g.Clear(Color.Black); //Sets the bitmap to black removing all drawn graphics.

            for (int i = 0; i < walls.Count; i++) //Loops through each index in the list of points till i == the total number of indexes in the list.
            {
                g.FillRectangle(Brushes.Blue, walls[i].X * cellSize.Width, walls[i].Y * cellSize.Height, cellSize.Width, cellSize.Height); //Draws a rectangle on the bitmap using the point at that index's x & y values.
            }
            for (int i = 0; i < points.Count; i++) //Loops through each index in the list of points till i == the total number of indexes in the list.
            {
                g.FillEllipse(Brushes.Orange, points[i].X * cellSize.Width + cellSize.Width / 2, points[i].Y * cellSize.Height + cellSize.Height / 2, 5, 5); //Draws a circle on the bitmap using the point at that index's x & y values.
            }


           // g.FillEllipse(Brushes.Green, p1.X * cellSize.Width + cellSize.Width / 4, p1.Y * cellSize.Height, 20, 20); //Draws a green circle at the grid coordinates (x,y).

            g.DrawImage(Image, p1.X * cellSize.Width + cellSize.Width / 4, p1.Y * cellSize.Height, 20, 20);

            if (multiplayer)
            {
               g.FillEllipse(Brushes.Red, p2.X * cellSize.Width + cellSize.Width / 4, p2.Y * cellSize.Height, 20, 20); //Draws a red circle at the grid coordinates (x,y).
            }

            Refresh(); //Refreshes background image with the newly drawn bitmap.
        }
        private void loadMaze(string[] data, ref List<Point> list)
        {
            int pointx, pointy;
            for (int i = 0; i < data.Length; i++) //Loops through each index till i == the total number of indexes in the array.
            {
                pointx = Convert.ToInt32(data[i].Substring(0, data[i].IndexOf(","))); //Splits and removes everything after the comma including thje comma. Stores it as an int.
                pointy = Convert.ToInt32(data[i].Substring(data[i].IndexOf(",") + 1)); //Splits and removes everything before the comma including thje comma. Stores it as an int.
                list.Add(new Point(pointx, pointy)); //Adds a new point to the list of points.
            }
        }

    }
}
