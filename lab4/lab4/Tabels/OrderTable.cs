using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class OrderTable : Table
    {
        public bool Path = false;
        public List<FileDetails> FileList = new List<FileDetails>();
        public OrderTable(string name, List<FileDetails> fileList, List<string> columns, bool path) : base(name, columns) 
        {
            this.Path = path;
            this.FileList = fileList;
        }
        
        public void AddRow(string index, long size, string path = null)
        {
            if (path != null)
                content.Append(String.Format("{0, 20} {1, 20} {2, 20} \n", $"{index}", $"{Utils.GetFileSize(size)}", $"\t{path}"));

            else
                content.Append(String.Format("{0, 20} {1, 15} \n", $"{index}", $"{Utils.GetFileSize(size)}"));

        }

        public new void Print()
        {
            CreateColumnHeader();
            Console.WriteLine($"\tBy {this.Name}");
            foreach (var file in FileList)
            {
                if (Path)
                    AddRow(file.Name, file.Size, file.Path);
                else
                    AddRow(file.Name, file.Size);
            }
            Console.WriteLine(content);
        }
    }
}
