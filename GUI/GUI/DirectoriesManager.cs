using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{



    internal class DirectoriesManager
    {
        public static void DirectoriesMove(object sender, MouseEventArgs e, ListBox files, TextBox path)
        {
            if (Path.GetExtension(files.SelectedItem.ToString()) == "")
            {
                if (files.SelectedIndex != -1)
                {
                    path.Text = Path.Combine(path.Text, files.SelectedItem.ToString());
                }

                DirectoriesManager.Print(path, files);
            }
            else
            {
                Process.Start(new ProcessStartInfo(Path.Combine(path.Text, files.SelectedItem.ToString())) { UseShellExecute = true });
            }
        }
        public static void GoToWay(object sender, EventArgs e, TextBox path, ListBox files)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();

                DirectoriesManager.Print(path, files);
            }
            catch
            {
                Exeptions.Exeptionsss();
            };
        }
        public static void Back(object sender, EventArgs e, ListBox files, TextBox path)
        {
            if (path.Text[path.Text.Length - 1] == '\\')
            {
                path.Text = path.Text.Remove(path.Text.Length - 1, 1);
            }

            while (path.Text[path.Text.Length - 1] != '\\')
            {
                path.Text = path.Text.Remove(path.Text.Length - 1, 1);
            }

            DirectoriesManager.Print(path, files);
        }

        public static void Print(TextBox path, ListBox filesList)
        {
                filesList.Items.Clear();
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo crrDir in dirs)
                {
                    filesList.Items.Add(crrDir.Name);
                }

                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo crrFile in files)
                {
                    filesList.Items.Add(crrFile.Name);
                }
            }
            catch
            {
                Console.WriteLine("Is not directory!");
            };
        }
    }
}
