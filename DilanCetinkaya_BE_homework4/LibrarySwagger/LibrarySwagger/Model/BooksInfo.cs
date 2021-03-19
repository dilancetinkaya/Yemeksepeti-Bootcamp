using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySwagger.Model
{
    public class BooksInfo
    {
        public int Id { get; set; }
        public int Page { get; set; }
        public string Name { get; set; }

        public string Writer { get; set; }
    }
}
