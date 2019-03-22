using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingBalls
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            reactionTimer.Enabled = false;

            Form f = this.FindForm();
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
            f.Controls.Add(gs);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            titleLabel.ForeColor = Color.Red;
            titleLabel.Text = "Oh, that's unfortunate";
            subTitleLabel.Text = "It's okay, I understand. Thank you";
            Refresh();
            reactionTimer.Enabled = true;
        }

        private void reactionTimer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
