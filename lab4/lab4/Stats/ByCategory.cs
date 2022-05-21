using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class ByCategory : Stats
    {
        public ByCategory(List<FileDetails> files) : base(files) { }

        public List<string> Find()
        {
            return Files.Select(x => x.Category).Distinct().ToList();
        }
    }
}
