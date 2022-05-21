using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class BySize : Stats
    {
        public BySize(List<FileDetails> files) : base(files) { }

        public List<FileDetails> Find()
        {
            return this.Files.OrderByDescending(x => x.Size).ToList();
        }
    }
}
