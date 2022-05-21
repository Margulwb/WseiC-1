using System;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    public class Table
    {
        public string Name = string.Empty;
        public List<string> Idx = new List<string>();
        public List<string> Columns = new List<string>();
        public IEnumerable<FileDetails> Files;

        public System.Text.StringBuilder content = new System.Text.StringBuilder();

        public Table(string name, List<string> idx, List<string> columns, IEnumerable<FileDetails> files)
        { 
            this.Name = name;
            this.Idx = idx;
            this.Columns = columns;
            this.Files = files;
        }

        public Table(string name, List<string> columns)
        {
            this.Name = name;
            this.Columns = columns;
        }

        public Table(string name, List<string> columns, IEnumerable<FileDetails> files)
        { 
            this.Name=name;
            this.Columns=columns;
            this.Files = files;
        }

        public Table() { }
        public void CreateColumnHeader()
        {
            int i = 0;
            foreach (var columnName in Columns)
            {
                if (i == 0)
                    content.Append(String.Format("{0, 38}", $"[{columnName}]"));
                else
                    content.Append(String.Format("{0, 15}", $"[{columnName}]"));
                i++;
            }
            content.Append(String.Format("\n"));
        }

        public void AddRow(string index, int counts = 0, long size = 0, long avg_size = 0, long min_size = 0, long max_size = 0)
        {
            content.Append(String.Format("{0,20} {1,15} {2,15} {3,15} {4,15} {5,15}\n", 
                $"{index}",
                $"{counts}",
                $"{Utils.GetFileSize(size)}",
                $"{Utils.GetFileSize(avg_size)}",
                $"{Utils.GetFileSize(min_size)}",
                $"{Utils.GetFileSize(max_size)}"));
        }

        public void Print()
        {
            CreateColumnHeader();
            Console.WriteLine($"\tBy {this.Name}");
            foreach (var index in Idx)
            {
                var sorted = Files.Where(x => x.Category == index).ToList();

                if (Name == "extensions")
                {
                    sorted = Files.Where(x => x.Extension == index).ToList();
                }

                var counts = sorted.Count();
                if (counts > 0)
                {
                    var size = sorted.Select(x => x.Size).Sum();
                    var value_avg_size = (counts != 0) ? (size / counts) : 0;
                    var value_min = sorted.Select(x => x.Size).Min();
                    var value_max = sorted.Select(x => x.Size).Max();
                    AddRow(index, sorted.Count, size, value_avg_size, value_min, value_max);
                }
                else
                {
                    AddRow(index, 0);
                }
            }
            Console.WriteLine(content);
        }
    }
}
