using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class Output
    {
        public static void Print(TextBox textBox1, ListBox listBox)
        {
                listBox.Items.Clear();
            try
            {
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo crrDir in dirs)
                {
                    listBox.Items.Add(crrDir.Name);
                }

                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo crrFile in files)
                {
                    listBox.Items.Add(crrFile.Name);
                }
            }
            catch
            {
                Console.WriteLine("Is not directory!");
            };
        }
    }
}
