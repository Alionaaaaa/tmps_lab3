using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public interface ILibraryAdapter
    {
        void Add(ILibraryItem item);
        void Remove(ILibraryItem item);
    }
}
