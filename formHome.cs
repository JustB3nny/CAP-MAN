using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAP_MAN
{
    public partial class formHome : Form
    {
        private Form activeForm = null;

        public formHome()
        {
            InitializeComponent();

            //Enablas Frame Buffering
            this.DoubleBuffered = true;

        }



        private void btnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender; //Gets the name of the button that has been pressed.
            switch (b.Name) //Changes the output based on what button has been pressed.
            {
                case "btnSingleplayer":
                    formSwap(b.Name); //passes the button name to a proceedure that changes the form displayed in the pDesktop panel.
                    break;
                case "btnLocalMultiplayer":
                    formSwap(b.Name); //passes the button name to a proceedure that changes the form displayed in the pDesktop panel.
                    break;
                case "btnLeaderboard":
                    formSwap(b.Name); //passes the button name to a proceedure that changes the form displayed in the pDesktop panel.
                    break;
                case "btnOptions":
                    formSwap(b.Name); //passes the button name to a proceedure that changes the form displayed in the pDesktop panel.
                    break;
                case "btnControls":
                    formSwap(b.Name); //passes the button name to a proceedure that changes the form displayed in the pDesktop panel.
                    break;
                case "btnQuit":
                    Application.Exit(); //Closes the application when pressed.
                    break;
            }
        }

        private void formSwap(string btnName)
        {
            if (activeForm != null)
            {
                activeForm.Close(); //Completely closes the form so that it isn't running in background.
                pDesktop.Controls.Remove(activeForm); //Removes the form from pDesktop.Controls to prevent duplicates being added as well as errors.
            }
            switch (btnName)
            {
                case "btnSingleplayer":
                    formGame formSingleplayer = new formGame() { TopLevel = false, AutoScroll = true, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill }; //Declares new form.
                    pDesktop.Controls.Add(formSingleplayer); //Adds it to pDesktop.Controls so that it can be displayed inside the panel.
                    activeForm = formSingleplayer; //Sets the active form to the newly created form.
                    formSingleplayer.multiplayer = false; //Passes the value of false to the form so that only one textbox is displayed.
                    break;
                case "btnLocalMultiplayer":
                    formGame formMultiplayer = new formGame() { TopLevel = false, AutoScroll = true, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill }; //Declares new form.
                    pDesktop.Controls.Add(formMultiplayer); //Adds it to pDesktop.Controls so that it can be displayed inside the panel.
                    activeForm = formMultiplayer; //Sets the active form to the newly created form.
                    formMultiplayer.multiplayer = true; //Passes the value of true to the form so that both textboxes are displayed.
                    break;
                case "btnLeaderboard":
                    formLeaderboard formLeaderboard = new formLeaderboard() { TopLevel = false, AutoScroll = true, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill }; //Declares new form.
                    pDesktop.Controls.Add(formLeaderboard); //Adds it to pDesktop.Controls so that it can be displayed inside the panel.
                    activeForm = formLeaderboard; //Sets the active form to the newly created form.
                    break;
                case "btnOptions":
                    formOptions formOptions = new formOptions() { TopLevel = false, AutoScroll = true, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill }; //Declares new form.
                    pDesktop.Controls.Add(formOptions); //Adds it to pDesktop.Controls so that it can be displayed inside the panel.
                    activeForm = formOptions; //Sets the active form to the newly created form.
                    break;
                case "btnControls":
                    formControls formControls = new formControls() { TopLevel = false, AutoScroll = true, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill }; //Declares new form.
                    pDesktop.Controls.Add(formControls); //Adds it to pDesktop.Controls so that it can be displayed inside the panel.
                    activeForm = formControls; //Sets the active form to the newly created form.
                    break;
            }
            try {
                if (activeForm != null)
                {
                    activeForm.Show(); //Shows the newly created form in the panel.
                    pbLogo.Hide(); //Hides the ghost.
                    pbBanner.Hide(); //Hides the extended banner.
                }
            }
            catch
            {
                pbLogo.Show();
                pbBanner.Show();
            }
        }
    }
}
