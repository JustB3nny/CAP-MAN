using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CAP_MAN
{
    public partial class formDesktop : Form
    {
        //Creates the home form that runs inside this form for the user to interact with.
        formHome formHome = new formHome() { TopLevel = false, AutoScroll = true, TopMost = true, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
        
        private Form activeForm = null; //This may be handy later depending on how I load the game form.

        public formDesktop()
        {
            InitializeComponent();

            //Enablas Frame Buffering.
            this.DoubleBuffered = true;

            //Add forms to panelDesktop.Controls.
            pDesktop.Controls.Add(formHome);
            
            //Set FormHome as activeForm.
            activeForm = formHome;
            formHome.Show();
        }

        //Re-enables application dragging functionality by hooking into the windows API.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Re-enables closing the application via the cross in the top right.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Closes application.
        }
    }
}
