using System;
using System.Collections;
using System.Collections.Generic;


namespace lab4
{
    public class Stats
    {
        public List<FileDetails> Files = new List<FileDetails>();

        public Stats(List<FileDetails> files)
        {
            this.Files = files;
        }

        public IEnumerable<FileDetails> Search()
        {
            return Files.ToArray();
        }
    }
}
