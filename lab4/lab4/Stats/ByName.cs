using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class ByName : Stats
    {
        public ByName(List<FileDetails> files) : base(files) { }

        public List<FileDetails> Find()
        { 
            return this.Files.OrderBy(x => x.Name).ToList();
        }
    }
}
