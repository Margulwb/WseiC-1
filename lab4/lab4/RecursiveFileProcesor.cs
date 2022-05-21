using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace lab4
{
    public class RecursiveFileProcessor
    {
        private static int dirsCount = 0;
        private static int filesCount = 0;
        private static long filesSize = 0;


        public static Dictionary<string, string> extensions_values = new Dictionary<string, string> {
            {".png", "image" },
            {".webp", "image"},
            {".jpg", "image"},
            {".gif", "image" },
            {".tiff", "image" },
            {".ogg", "audio" },
            {".mp3", "audio" },
            {".mkv", "video" },
            {".mp4", "video" },
            {".webm", "video" },
            {".txt", "document" },
            {".doc", "document" },
            {".docx", "document"},
            {".xml", "document" },
            {".xlmx", "document" },
            {"other", "other" }

        };

        public static List<FileDetails> files = new List<FileDetails>();


        public void Run(string path)
        {
            if (File.Exists(path))
            {
                ProcessFile(path);
            }
            else if (Directory.Exists(path))
            {
                ProcessDirectory(path);
            }
            else
            {
                Console.WriteLine("{0} is not a valid file or directory.", path);
            }

        }

        public static void ProcessDirectory(string targetDirectory)
        {
            dirsCount += 1;

            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                ProcessFile(fileName);
            }

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory);
            }
        }

        public static void ProcessFile(string path)
        {
            FileInfo fi = new FileInfo(path);

            filesCount += 1;
            filesSize += fi.Length;

            var category = extensions_values.ContainsKey(fi.Extension) ? extensions_values[fi.Extension] : "other";
            var extension = extensions_values.ContainsKey(fi.Extension) ? fi.Extension : "other";

            FileDetails fileDetail = new FileDetails(fi.Name, extension, category, fi.FullName, fi.Length);
            files.Add(fileDetail);
        }

        public void Log()
        {
            List<string> COLUMNS = new List<string> { "count", "total size", "avg size", "min size", "max size" };

            List<string> byCategory = new ByCategory(files).Find();
            List<string> byExtension = new ByExtension(files).Find();
            List<FileDetails> orderByName = new ByName(files).Find();
            List<FileDetails> orderBySize = new BySize(files).Find();
            SortedDictionary<char, int> countsFirstLetter = new CountLetters(files).Find();

            Table categories = new Table("types", byCategory, COLUMNS, files);
            Table extensions = new Table("extensions", byExtension , COLUMNS, files);
            SizeTable sizes = new SizeTable("sizes", COLUMNS, files);
            OrderTable orderName = new OrderTable("Order by name: ", orderByName, new List<string> { "size", "path" }, true);
            OrderTable orderSizes = new OrderTable("Order by sizes: ", orderBySize, new List<string> { "size" }, false);

            Table[] tables = { categories, extensions };
            OrderTable[] orderTables = { orderName, orderSizes };

            
            HorizontalTable countLetters = new HorizontalTable("Counts by first leter:", countsFirstLetter);

            System.Text.StringBuilder log = new System.Text.StringBuilder();
            log.Append(String.Format("Nodes:\n"));
            log.Append(String.Format("{0, 38} {1, 15}\n", $"[count]", $"[total size]"));
            log.Append(String.Format("{0, 20} {1, 15} {2, 15}\n", "Directories:", $"{dirsCount}", $"{Utils.GetFileSize(filesSize)}"));
            log.Append(String.Format("{0, 20} {1, 15} {2, 15}\n", "Files:", $"{filesCount}", $"{Utils.GetFileSize(filesSize)}"));
            Console.WriteLine(log.ToString());
            Console.WriteLine("Files: ");
            foreach (var table in tables)
            {
                table.Print();
            }
            sizes.Print();
            countLetters.Print();
            foreach (var table in orderTables)
            {
                table.Print();
            }
        }
    }
}
