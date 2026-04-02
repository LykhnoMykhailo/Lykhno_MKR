using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class FileLogger
    {
       
        public void Logger(string msg)
        {
            string Content = "";
            string End_file = "logPD24.txt";
            if (File.Exists(End_file))
            {
                using (StreamReader sr = new StreamReader(End_file))
                {
                    Content = Content + sr.ReadToEnd();
                }
            }
            Content = Content + $"[{DateTime.Now}] {msg}";
            using (StreamWriter stream = new StreamWriter(End_file))
            {
                stream.WriteLine(Content);
            }
        }
    }
}
