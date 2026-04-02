using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Operation
    {
        public string UPPERCASE(string text)
        {
            return text.ToUpper();
        }

        public string CountSymbols(string text)
        {
            return $"Кількість символів = {text.Length}";
        }

        public string CountWords(string text)
        {
            return $"Кількість слів = {(text.Split(" ").Length)}";
        }
    }
}
