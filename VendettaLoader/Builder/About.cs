using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace VendettaLoader
{
    public partial class About : Form
    {
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public About()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void authorGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }
    }
}
