using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class SizeTable : Table
    {
        public Dictionary<string, List<long>> ranges = new Dictionary<string, List<long>>() {
            { "     . <= 1KB ", new List<long> {0, 1024} },
            { "1KB < . <= 1MB", new List<long> {1024, 1048576 } },
            { "1MB < . <= 1GB", new List<long> {1048576, 1073741824 } },
            { "1GB < .       ", new List<long> {1073741824 }}
        };

        public SizeTable(string name, List<string> columns, IEnumerable<FileDetails> files) : base(name, columns, files) { }
        public new void Print()
        {
            CreateColumnHeader();
            Console.WriteLine($"\tBy {this.Name}");
            foreach (KeyValuePair<string, List<long>> range in ranges)
            {
                var values = new List<FileDetails>();
                if (range.Value.Count == 2)
                {
                    values = this.Files.Where(x => x.Size > range.Value[0] && x.Size <= range.Value[1]).ToList();
                }
                else {
                    values = this.Files.Where(x => x.Size > range.Value[0]).ToList();
                }

                var counts = values.Count();
                if (counts > 0)
                {
                    var size = values.Select(x => x.Size).Sum();
                    var value_avg_size = (counts != 0) ? (size / counts) : 0;
                    var value_min = values.Select(x => x.Size).Min();
                    var value_max = values.Select(x => x.Size).Max();
                    AddRow(range.Key, values.Count, size, value_avg_size, value_min, value_max);
                }
                else
                {
                    AddRow(range.Key, 0);
                }
            }
            Console.WriteLine(content);
        }
    }
}
