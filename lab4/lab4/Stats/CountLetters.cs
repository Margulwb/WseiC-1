using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class CountLetters : Stats
    {
        public SortedDictionary<Char, int> Letters = new SortedDictionary<char, int> ();

        public CountLetters(List<FileDetails> files) : base(files)
        {
        }

        public SortedDictionary<Char, int> Find()
        {
            foreach (var c in this.Files.Select(x => Char.ToLower(x.FirstLetter)).ToList())
            {
                if (!Letters.ContainsKey(c))
                {
                    Letters.Add(c, 0);
                }

                Letters[c]++;
            }
            return this.Letters;
        }
    }
}
