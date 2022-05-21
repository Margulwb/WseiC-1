namespace lab4
{
    public class FileDetails
    {
        public string Name { get; }
        public string Extension { get; }
        public string Category { get; }
        public string Path { get; }
        public long Size { get; }
        public char FirstLetter { get; }

        public FileDetails(string name, string extension, string category, string path, long size)
        { 
            this.Name = name;
            this.Extension = extension.Trim('.');
            this.Category = category;
            this.Path = path;
            this.Size = size;
            this.FirstLetter = name[0];
        }

        public string FileHumanSize()
        {
            return Utils.GetFileSize(this.Size);
        }
    }

}
