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
    public partial class formLeaderboard : Form
    {
        ListBox listBox = new ListBox();
        public formLeaderboard()
        {
            InitializeComponent();
        }

        private void formLeaderboard_Load(object sender, EventArgs e)
        {
            var scores = File.ReadAllLines(@"..\..\..\Files\scoreboard.capman").Select(x => x.Split(":")).Select(x => new { Name = x[0], Score = int.Parse(x[1]) }).OrderByDescending(x => x.Score).Take(10);

            foreach (var score in scores)
            {
                lstbScore.Items.Add(score.Score);
                lstbName.Items.Add(score.Name);
            }
 
        }

        void listTypes_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }
    }
}
