using System.IO;

namespace task1
{
    internal class Program
    {
        delegate string TextOperation(string text);

        static void ProcessFile(string file, TextOperation op)
        {
            string End_file = "resultPD24.txt";
            string content;
            using (StreamReader sr = new StreamReader(file))
            {
                content = sr.ReadToEnd();
            }
            string End_content = "";
            foreach (string line in content.Split("\n"))
            {
                if (File.Exists(End_file))
            {
                using (StreamReader sr = new StreamReader(End_file))
                {
                    End_content = sr.ReadToEnd();
                }
            }
            
                using (StreamWriter sw = new StreamWriter(End_file)) { sw.WriteLine(End_content + op(line)); }
            }
        }
        static void Main(string[] args)
        {
            string Base_file = "textPD24.txt";
            TextOperation oper;
            Operation OPS = new Operation();
            oper = OPS.UPPERCASE;
            ProcessFile(Base_file, oper);
            oper = OPS.CountSymbols;
            ProcessFile(Base_file, oper);
            oper = OPS.CountWords;
            ProcessFile(Base_file, oper);

        }
    }
}
