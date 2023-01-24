using System;
using System.Diagnostics;
using System.Windows.Forms;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();

                Output.Print(textBox1, listBox);
            }
            catch
            {
                Console.WriteLine("Is not directory!");
            };
        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[textBox1.Text.Length - 1] == '\\')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            while(textBox1.Text[textBox1.Text.Length - 1] != '\\')
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            Output.Print(textBox1, listBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Path.GetExtension(listBox.SelectedItem.ToString()) == "")
            {
                if (listBox.SelectedIndex != -1)
                    textBox1.Text = Path.Combine(textBox1.Text, listBox.SelectedItem.ToString());

                Output.Print(textBox1, listBox);
            }
            else
                Process.Start(Path.Combine(textBox1.Text, listBox.SelectedItem.ToString()));
        }
    }
}