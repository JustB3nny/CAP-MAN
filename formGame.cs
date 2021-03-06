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
        //Player class.
        class Player
        {
            //Declares all the variables that will be used for each player.
            //Stores the grid location of the player.
            public Point location;
            //Stores the direction which the player is traveling.
            public int xDirection;
            public int yDirection;
            //Stores the players alias that was entered into the textbox.
            public string playerName;
            //Holds the player score that is updated every player tick.
            public int playerScore;
            //Stores the sprite images for the player and their directions.
            public Image playerUp;
            public Image playerDown;
            public Image playerLeft;
            public Image playerRight;
            public Image playerSprite;
            //Player constructor.
            public Player(Point spawnLocation, Image up, Image down, Image left, Image right, Image sprite)
            {
                //Player location is set.
                location = spawnLocation;
                //Sprites are loaded and set.
                playerUp = up;
                playerDown = down;
                playerLeft = left;
                playerRight = right;
                playerSprite = sprite;
                //Direction is set to 0.
                xDirection = 0;
                yDirection = 0;
            }
            //Movement method.
            public void movement(string direction)
            {
                //Checks the direction that is sent to the method.
                switch (direction)
                {
                    //If the string is "up".
                    case "up":
                        //Sets the current sprite to player up image.
                        playerSprite = playerUp;
                        //Sets X value to 0 and Y value to -1 (up).
                        xDirection = 0;
                        yDirection = -1;
                        break;
                    //If the string is "down".
                    case "down":
                        //Sets the current sprite to player down image.
                        playerSprite = playerDown;
                        //Sets X value to 0 and Y value to 1 (down).
                        xDirection = 0;
                        yDirection = 1;
                        break;
                    //If the string is "left".
                    case "left":
                        //Sets the current sprite to player left image.
                        playerSprite = playerLeft;
                        //Sets Y value to 0 and X value to -1 (left).
                        xDirection = -1;
                        yDirection = 0;
                        break;
                    //If the string is "right".
                    case "right":
                        //Sets the current sprite to player right image.
                        playerSprite = playerRight;
                        //Sets Y value to 0 and X value to 1 (right).
                        xDirection = 1;
                        yDirection = 0;
                        break;
                }
            }
            //Collision method.
            public void wallCollision(List<Point> data)
            {
                //Loops through all the indexes in the data list.
                foreach (Point i in data)
                {
                    //Checks to see if the player's location is the same as the point at the index.
                    if (i == location)
                    {
                        //Moves the player back 1 grid position in the direction they're traveling.
                        location = new Point(location.X - xDirection, location.Y - yDirection);
                    }
                }
            }
            //Point collection method.
            public void pointCollection(ref List<Point> data)
            {
                //Loops through all the indexes in the data list.
                for (int i = 0; i < data.Count; i++)
                {
                    //Checks to see if the player's location is the same as the point at the index.
                    if (data[i] == location)
                    {
                        //Removes the point from the list at the index.
                        data.RemoveAt(i);
                        //Increases the player's score.
                        playerScore++;
                    }
                }
            }
            //Update method.
            public void update()
            {
                //Updates the player's location with the next place the player will move to.
                location = new Point(location.X + xDirection, location.Y + yDirection);
            }
        }
        //Create's the player's using the constructor.
        Player playerOne = new Player(new Point(1, 28), Image.FromFile(@"..\..\..\Images\BLUE_up.png"), Image.FromFile(@"..\..\..\Images\BLUE_down.png"), Image.FromFile(@"..\..\..\Images\BLUE_left.png"), Image.FromFile(@"..\..\..\Images\BLUE_right.png"), Image.FromFile(@"..\..\..\Images\BLUE_right.png"));
        Player playerTwo = new Player(new Point(26, 28), Image.FromFile(@"..\..\..\Images\YELLOW_up.png"), Image.FromFile(@"..\..\..\Images\YELLOW_down.png"), Image.FromFile(@"..\..\..\Images\YELLOW_left.png"), Image.FromFile(@"..\..\..\Images\YELLOW_right.png"), Image.FromFile(@"..\..\..\Images\YELLOW_left.png"));
        //Ghost class
        class Ghost
        {
            //Stores the location of the ghost's.
            public Point location;
            //Stores the direction the ghost is moving.
            public int xDirection;
            public int yDirection;
            //Stores the sprite images for the ghosts and their directions.
            public Image ghostUp;
            public Image ghostDown;
            public Image ghostLeft;
            public Image ghostRight;
            public Image ghostSprite;
            //Ghost constructor.
            public Ghost(Point spawnLocation, Image up, Image down, Image left, Image right, Image sprite)
            {
                //Ghost location is set.
                location = spawnLocation;
                //Sprites are loaded and set.
                ghostUp = up;
                ghostDown = down;
                ghostLeft = left;
                ghostRight = right;
                ghostSprite = sprite;
                //Direction is set to 0.
                xDirection = 0;
                yDirection = 0;
            }
            //Movement method.
            public void movement(string direction)
            {
                switch (direction)
                {
                    case "up":
                        //Sets the current sprite to ghost up image.
                        ghostSprite = ghostUp;
                        //Sets X value to 0 and Y value to -1 (up).
                        xDirection = 0;
                        yDirection = -1;
                        break;
                    case "down":
                        //Sets the current sprite to ghost down image.
                        ghostSprite = ghostDown;
                        //Sets X value to 0 and Y value to 1 (down).
                        xDirection = 0;
                        yDirection = 1;
                        break;
                    case "left":
                        //Sets the current sprite to ghost left image.
                        ghostSprite = ghostLeft;
                        //Sets Y value to 0 and X value to -1 (left).
                        xDirection = -1;
                        yDirection = 0;
                        break;
                    case "right":
                        //Sets the current sprite to ghost right image.
                        ghostSprite = ghostRight;
                        //Sets Y value to 0 and X value to 1 (right).
                        xDirection = 1;
                        yDirection = 0;
                        break;
                }
            }
            //Update method.
            public void update()
            {
                //Updates the ghost's location with the next place the ghost will move to.
                location = new Point(location.X + xDirection, location.Y + yDirection);
            }
        }
        //Creates the ghost's using the contructor.
        Ghost purple = new Ghost(new Point(1, 1), Image.FromFile(@"..\..\..\Images\ghost_porple_up.png"), Image.FromFile(@"..\..\..\Images\ghost_porple_down.png"), Image.FromFile(@"..\..\..\Images\ghost_porple_left.png"), Image.FromFile(@"..\..\..\Images\ghost_porple_right.png"), Image.FromFile(@"..\..\..\Images\ghost_porple_right.png"));
        Ghost pink = new Ghost(new Point(26, 1), Image.FromFile(@"..\..\..\Images\ghost_pink_up.png"), Image.FromFile(@"..\..\..\Images\ghost_pink_down.png"), Image.FromFile(@"..\..\..\Images\ghost_pink_left.png"), Image.FromFile(@"..\..\..\Images\ghost_pink_right.png"), Image.FromFile(@"..\..\..\Images\ghost_pink_left.png"));
        Ghost blue = new Ghost(new Point(9, 11), Image.FromFile(@"..\..\..\Images\ghost_blue_up.png"), Image.FromFile(@"..\..\..\Images\ghost_blue_down.png"), Image.FromFile(@"..\..\..\Images\ghost_blue_left.png"), Image.FromFile(@"..\..\..\Images\ghost_blue_right.png"), Image.FromFile(@"..\..\..\Images\ghost_blue_right.png"));
        Ghost green = new Ghost(new Point(6, 19), Image.FromFile(@"..\..\..\Images\ghost_green_up.png"), Image.FromFile(@"..\..\..\Images\ghost_green_down.png"), Image.FromFile(@"..\..\..\Images\ghost_green_left.png"), Image.FromFile(@"..\..\..\Images\ghost_green_right.png"), Image.FromFile(@"..\..\..\Images\ghost_green_right.png"));


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
            //Checks if the multiplayer bool is true.
            if (multiplayer)
            {
                //Checks to see if both user inputs are 3 characters long.
                if (tbPlayer1.TextLength == 3 && tbPlayer2.TextLength == 3)
                {
                    //Checks to make sure that the user inputs are not the same.
                    if (tbPlayer1.Text != tbPlayer2.Text)
                    {
                        //Calls the start proceedure.
                        start();
                    }
                    else
                    {
                        //Displays a message saying that they can't have the same alias.
                        MessageBox.Show("Player 1 & player 2 cannot have the same alias.");
                    }
                }
                else
                {
                    //Displays a message saying that the users alias must be 3 characters long.
                    MessageBox.Show("Your alias must be 3 characters long.");
                }
            }
            else
            {
                //Checks to see if the user input is 3 characters long.
                if (tbPlayer1.TextLength == 3)
                {
                    //Calls the start proceedure.
                    start();
                }
                else
                {
                    MessageBox.Show("Your alias must be 3 characters long.");
                }
            }
        }
        //Start proceedure for when the start button is pressed.
        private void start()
        {
            if (multiplayer)
            {
                //Hides UI elements.
                lbPlayer2.Hide();
                tbPlayer2.Hide();
                //Stores player 1 alias.
                playerTwo.playerName = tbPlayer2.Text.ToUpper();
                //Shows player 1 score lable.
                lblP2Score.Show();
            }
            //Hides UI elements.
            lbPlayer1.Hide();
            tbPlayer1.Hide();
            btnStart.Hide();
            //Stores player 1 alias.
            playerOne.playerName = tbPlayer1.Text.ToUpper();
            //Shows player 1 score lable.
            lblP1Score.Show();
            //Shows picturebox the game is rendered to.
            pbGame.Show();
            //Calls the draw proceedure.
            draw();
            //Starts the game timer.
            playerTick.Start();
            renderTick.Start();
            ghostTick.Start();
        }

        //Textbox Key Validation
        private void textboxKeyPress(object sender, KeyPressEventArgs e)
        {
            //Checks to see if the key pressed is a letter or backspace.
            if(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                //Allows the character to be entered into the textbox.
                e.Handled = false;
            }
            else
            {
                //Ignores the key.
                e.Handled = true;
            }
        }

        //Key press movement.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (playerTick.Enabled)
            {
                //Player 1 movement.
                //If key pressed is A move player 1 to the left.
                if (keyData == Keys.A)
                {
                    playerOne.movement("left");
                }
                //If key pressed is D move player 1 to the right.
                if (keyData == Keys.D)
                {
                    playerOne.movement("right");
                }
                //If key pressed is W move player 1 up.
                if (keyData == Keys.W)
                {
                    playerOne.movement("up");
                }
                //If key pressed is W move player 1 down.
                if (keyData == Keys.S)
                {
                    playerOne.movement("down");
                }
                //Player 2 movement
                if (multiplayer)
                {
                    //If key pressed is left arrow move player 2 to the left.
                    if (keyData == Keys.Left)
                    {
                        playerTwo.movement("left");
                    }
                    //If key pressed is right arrow move player 2 to the right.
                    if (keyData == Keys.Right)
                    {
                        playerTwo.movement("right");
                    }
                    //If key pressed is up arrow move player 2 up.
                    if (keyData == Keys.Up)
                    {
                        playerTwo.movement("up");
                    }
                    //If key pressed is down arrow move player 2 down.
                    if (keyData == Keys.Down)
                    {
                        playerTwo.movement("down");
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Player timer.
        private void playerTick_Tick(object sender, EventArgs e)
        {
            if (purple.location == playerOne.location || pink.location == playerOne.location || blue.location == playerOne.location || green.location == playerOne.location || purple.location == playerTwo.location || pink.location == playerTwo.location || blue.location == playerTwo.location || green.location == playerTwo.location)
            {
                gameOver();
            }
            playerOne.update();
            playerOne.wallCollision(walls);
            playerOne.pointCollection(ref points);
            lblP1Score.Text = playerOne.playerName + "'s Score: " + Convert.ToString(playerOne.playerScore);

            if (multiplayer)
            {
                playerTwo.update();
                playerTwo.wallCollision(walls);
                playerTwo.pointCollection(ref points);
                lblP2Score.Text = playerTwo.playerName + "'s Score: " + Convert.ToString(playerTwo.playerScore);
            }
            //Point respawn.
            if (points.Count == 0) //If the list of points is empty.
            {
                loadMaze(point, ref points); //Refil the list with the points read from the file.
                if (ghostTick.Interval > 150)
                {
                    ghostTick.Interval = ghostTick.Interval - 5;
                }
            }
        }
        //Ghost timer.
        private void ghostTick_Tick(object sender, EventArgs e)
        {
            //Movement logic.
            //Purple ghost
            if (purple.location == new Point(1, 1))
            {
                purple.movement("right");
            }
            else if (purple.location == new Point(12, 1))
            {
                purple.movement("down");
            }
            else if (purple.location == new Point(12, 5))
            {
                purple.movement("left");
            }
            else if (purple.location == new Point(6, 5))
            {
                purple.movement("down");
            }
            else if (purple.location == new Point(6, 8))
            {
                purple.movement("left");
            }
            else if (purple.location == new Point(1, 8))
            {
                purple.movement("up");
            }
            //Pink ghost
            if (pink.location == new Point(26, 1))
            {
                pink.movement("left");
            }
            else if (pink.location == new Point(15, 1))
            {
                pink.movement("down");
            }
            else if (pink.location == new Point(15, 5))
            {
                pink.movement("right");
            }
            else if (pink.location == new Point(21, 5))
            {
                pink.movement("down");
            }
            else if (pink.location == new Point(21, 8))
            {
                pink.movement("right");
            }
            else if (pink.location == new Point(26, 8))
            {
                pink.movement("up");
            }
            //Blue ghost
            if (blue.location == new Point(9, 11))
            {
                blue.movement("right");
            }
            else if (blue.location == new Point(18, 11))
            {
                blue.movement("down");
            }
            else if (blue.location == new Point(18, 17))
            {
                blue.movement("left");
            }
            else if (blue.location == new Point(9, 17))
            {
                blue.movement("up");
            }
            //Green ghost
            if (green.location == new Point(6, 19))
            {
                green.movement("right");
            }
            else if (green.location == new Point(12, 19))
            {
                green.movement("down");
            }
            else if (green.location == new Point(12, 22))
            {
                green.movement("right");
            }
            else if (green.location == new Point(15, 22))
            {
                green.movement("up");
            }
            else if (green.location == new Point(15, 19))
            {
                green.movement("right");
            }
            else if (green.location == new Point(21, 19))
            {
                green.movement("down");
            }
            else if (green.location == new Point(21, 22))
            {
                green.movement("left");
            }
            else if (green.location == new Point(18, 22))
            {
                green.movement("down");
            }
            else if (green.location == new Point(18, 25))
            {
                green.movement("left");
            }
            else if (green.location == new Point(15, 25))
            {
                green.movement("down");
            }
            else if (green.location == new Point(15, 28))
            {
                green.movement("left");
            }
            else if (green.location == new Point(12, 28))
            {
                green.movement("up");
            }
            else if (green.location == new Point(12, 25))
            {
                green.movement("left");
            }
            else if (green.location == new Point(9, 25))
            {
                green.movement("up");
            }
            else if (green.location == new Point(9, 22))
            {
                green.movement("left");
            }
            else if (green.location == new Point(6, 22))
            {
                green.movement("up");
            }
            if (purple.location == playerOne.location || pink.location == playerOne.location || blue.location == playerOne.location || green.location == playerOne.location || purple.location == playerTwo.location || pink.location == playerTwo.location || blue.location == playerTwo.location || green.location == playerTwo.location)
            {
                gameOver();
            }
            purple.update();
            pink.update();
            blue.update();
            green.update();
        }

        //Rendering timer.
        private void renderTick_Tick(object sender, EventArgs e)
        {
            //Draw graphics.
            //Calls the draw proceedure.
            draw();
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

            //Player rendering

            //Player 1 rendering.
            //Draws the player sprite using the player position points multiplied by the width and height of one cell to create a bitmap coordinate. 
            g.DrawImage(playerOne.playerSprite, playerOne.location.X * cellSize.Width + cellSize.Width / 4, playerOne.location.Y * cellSize.Height, 20, 20);
            //Player 2 rendering.
            //Draws the player sprite using the player position points multiplied by the width and height of one cell to create a bitmap coordinate. 
            if (multiplayer)
            {
                g.DrawImage(playerTwo.playerSprite, playerTwo.location.X * cellSize.Width + cellSize.Width / 4, playerTwo.location.Y * cellSize.Height, 20, 20);
            }

            //Ghost rendering.
            g.DrawImage(purple.ghostSprite, purple.location.X * cellSize.Width + cellSize.Width / 4, purple.location.Y * cellSize.Height, 20, 20);
            g.DrawImage(pink.ghostSprite, pink.location.X * cellSize.Width + cellSize.Width / 4, pink.location.Y * cellSize.Height, 20, 20);
            g.DrawImage(blue.ghostSprite, blue.location.X * cellSize.Width + cellSize.Width / 4, blue.location.Y * cellSize.Height, 20, 20);
            g.DrawImage(green.ghostSprite, green.location.X * cellSize.Width + cellSize.Width / 4, green.location.Y * cellSize.Height, 20, 20);


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

        public void gameOver()
        {
            playerTick.Stop();
            ghostTick.Stop();
            renderTick.Stop();
            List<string> scoreboard = new List<string>();
            bool playerOneFound = false;
            bool playerTwoFound = false;
            var scores = File.ReadAllLines(@"..\..\..\Files\scoreboard.capman").Select(x => x.Split(":")).Select(x => new { Name = x[0], Score = int.Parse(x[1]) }).OrderByDescending(x => x.Score);
            foreach (var score in scores)
            {
                if (playerOne.playerName == score.Name)
                {
                    playerOneFound = true;
                    if (playerOne.playerScore > score.Score)
                    {
                        MessageBox.Show("Congratulations " + playerOne.playerName + " you have reached a new high score");
                        scoreboard.Add(score.Name + ":" + playerOne.playerScore);
                    }
                    else
                    {
                        scoreboard.Add(score.Name + ":" + score.Score);
                    }
                }
                else if (playerTwo.playerName == score.Name && multiplayer)
                {
                    playerOneFound = true;
                    if (playerTwo.playerScore > score.Score)
                    {
                        MessageBox.Show("Congratulations " + playerTwo.playerName + " you have reached a new high score");
                        scoreboard.Add(score.Name + ":" + playerTwo.playerScore);
                    }
                    else
                    {
                        scoreboard.Add(score.Name + ":" + score.Score);
                    }
                }
                else
                {
                    scoreboard.Add(score.Name + ":" + score.Score);
                }
            }
            if (!playerOneFound)
            {
                scoreboard.Add(playerOne.playerName + ":" + playerOne.playerScore);
            }
            if (!playerTwoFound && multiplayer)
            {
                scoreboard.Add(playerTwo.playerName + ":" + playerTwo.playerScore);
            }
            File.WriteAllLines(@"..\..\..\Files\scoreboard.capman", scoreboard);
            MessageBox.Show("Game Over!");
        }
    }
}
