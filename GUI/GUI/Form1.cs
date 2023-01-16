namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string startPath = "D:\\GB";
            string[] filesList = FileWorker.GetFiles(startPath);
            foreach (string file in filesList)
            {
                leftFilesList.Items.Add(file);
            }
        }
    }
}