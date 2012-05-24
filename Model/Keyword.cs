using System.Collections.Generic;
using Snippet2.DAL;

namespace Snippet2.Model
{
    public class Keyword
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Snippet> Snippets
        {
            get
            {
                return new List<Snippet>();
            }
        }
        public DBKeywordDataContext Context { set; private get; }
    }
}
