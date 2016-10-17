using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrange arr = new Arrange(new[] { '7', '8', '9','a', 'b', 'c', 'd'

            });
            Arrange.PwdCount = 4;
            var dd = arr.GetAllArrangements();
        }
    }

    class Arrange
    {
        public static int PwdCount { get; set; }
        public static char[] _chars;
        String newS = string.Empty;
        public int Count = 0;
        public Arrange(char[] chars)
        {
            if (chars == null || chars.Length == 0)
            {
                throw new Exception("传入的字符数组不能为空");
            }
            _chars = chars.Distinct().ToArray();
        }
        public List<String> GetAllArrangements()
        {
            List<String> returnValue = new List<string>();
            for (int i = 0; i < _chars.Length; i++)
            {
                returnValue.AddRange(GetArrangements("", PwdCount / 2));
            }
            return returnValue;
        }
        private List<String> GetArrangements(String s, int length)
        {
            if (length == 0)
            {
                return new List<string> { s };
            }
            List<String> returnValue = new List<String>();
            for (int i = 0; i < _chars.Length; i++)
            {
                newS = s + _chars[i];
                List<String> nextArray = GetArrangements(newS, length - 1);
                returnValue.AddRange(nextArray);
            }
            return returnValue;
        }
    }
}
