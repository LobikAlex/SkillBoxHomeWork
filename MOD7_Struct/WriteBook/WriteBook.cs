using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteBook
{
    struct WriteBook
    {
        public Worker[] Book;





        public WriteBook(params Worker[] value)
        {
            Book = value;
        }
    }
}
