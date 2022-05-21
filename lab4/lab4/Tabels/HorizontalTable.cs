using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class HorizontalTable : Table
    {
        public new SortedDictionary<char, int> Files = new SortedDictionary<char, int>();    

        public HorizontalTable(string name, SortedDictionary<char, int> files)
        {
            this.Name = name;
            this.Files = files;
        }
        public new void Print()
        {
            Console.WriteLine($"\tBy {this.Name}");
            content.Append(String.Format("\t"));
            foreach (var c in this.Files.Keys)
            {
                if (Char.IsLetter(c))
                {
                    content.Append(String.Format("{0,5}", $"{c}"));
                }
            }
            content.Append(String.Format("\n\t"));

            foreach (var c in this.Files.Keys)
            {
                if (Char.IsLetter(c))
                {
                    content.Append(String.Format("{0,5}", $"{this.Files[c]}"));
                }
            }
            Console.WriteLine(content);
        }
    }
}
