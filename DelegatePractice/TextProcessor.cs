using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class TextProcessor
    {
        public string ProcessText(string filePath)
        {
			try
			{
				return File.ReadAllText(filePath);
			}
			catch (FileNotFoundException ex)
			{
                Console.WriteLine(".txt not found");
                throw;
			}
        }

        public int CountWords(string text)
        {

            // var words = text.Split(new char[] { '\n', ' ' });
            // return words.Length;
            return text.Split(new char[] { '\n', ' ' }).Length;
        }

        public Dictionary<char, int> CalculateFrecuency(string text)
        {
            return text.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }

        public string FindLongestWord(string text)
        {
            // Implementation using LINQ
            return text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                       .OrderByDescending(word => word.Length)
                       .FirstOrDefault();
        }
    }
}
