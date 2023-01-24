using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace GUI
{
    public partial class form1 : Form
    {

        public form1()
        {
            InitializeComponent();
            int range = 20;
            filesListBoxFirst.Width = Size.Width / 2 - 40;
            pathBoxFirst.Width = filesListBoxFirst.Width - range - goButtonFirst.Width;
            goButtonFirst.Left = pathBoxFirst.Right + range;
            backButtonFirst.Left = pathBoxFirst.Right + range;
        }

        private void backFirst(object sender, EventArgs e)
        {
            DirectoriesManager.Back(sender, e, filesListBoxFirst, pathBoxFirst);
        }

        private void backSecond(object sender, EventArgs e)
        {
            DirectoriesManager.Back(sender, e, filesListBoxSecond, pathBoxSecond);
        }


        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DirectoriesManager.DirectoriesMove(sender, e, filesListBoxFirst, pathBoxFirst);
        }

        private void GoClickFirst(object sender, EventArgs e)
        {
            DirectoriesManager.GoToWay(sender, e, pathBoxFirst, filesListBoxFirst);
        }

        private void GoClickSecond(object sender, EventArgs e)
        {
            DirectoriesManager.GoToWay(sender, e, pathBoxSecond, filesListBoxSecond);

        }

        private void listBox_MouseDoubleClickSecond(object sender, MouseEventArgs e)
        {
            DirectoriesManager.DirectoriesMove(sender, e, filesListBoxSecond, pathBoxSecond);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int range = 20;
            filesListBoxFirst.Width = Size.Width / 2 - range;
            filesListBoxFirst.Height = Size.Height - filesListBoxFirst.Top - 2 * range;
            pathBoxFirst.Width = filesListBoxFirst.Width - goButtonFirst.Width - range;
            goButtonFirst.Left = pathBoxFirst.Right + range;
            backButtonFirst.Left = pathBoxFirst.Right + range;

            filesListBoxSecond.Left = filesListBoxFirst.Right + range;
            filesListBoxSecond.Height = Size.Height - filesListBoxSecond.Top - 2 * range;
            filesListBoxSecond.Width = filesListBoxFirst.Width - range;
            pathBoxSecond.Left = filesListBoxFirst.Right + range;
            pathBoxSecond.Width = pathBoxFirst.Width - range;
            goButtonSecond.Left = filesListBoxFirst.Right + filesListBoxFirst.Width - goButtonSecond.Width;
            backButtonSecond.Left = filesListBoxFirst.Right + filesListBoxFirst.Width - backButtonSecond.Width;
        }
    }
}