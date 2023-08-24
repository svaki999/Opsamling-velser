using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsamlingØvelser.WordCount
{
    public class WordCount
    {
        public static int Count(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int typeCount = 0;
            foreach (string word in words)
            {
                if (word.Equals("type", StringComparison.OrdinalIgnoreCase) || word.Equals("types", StringComparison.OrdinalIgnoreCase))
                {
                    typeCount++;
                }
            }

            return typeCount;
        }

    }

}
