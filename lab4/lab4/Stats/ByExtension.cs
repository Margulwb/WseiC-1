using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class ByExtension : Stats
    {
        public ByExtension(List<FileDetails> files) : base(files) { }

        public List<string> Find()
        {
            return this.Files.Select(x => x.Extension).Distinct().ToList();
        }
    }
}
