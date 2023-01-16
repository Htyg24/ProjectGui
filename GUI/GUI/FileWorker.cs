using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class FileWorker
    {
        public static string[] GetFiles(string path)
        {
            List<string> files = Directory.GetDirectories(path).ToList();
            files.AddRange(Directory.GetFiles(path).ToList());
            for (int i = 0; i < files.Count; i++)
            {
                files[i] = files[i].Substring(path.Length + 1);
            }
            return files.ToArray();
        }
    }
}
