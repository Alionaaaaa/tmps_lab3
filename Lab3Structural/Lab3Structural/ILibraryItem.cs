using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Structural
{
    public interface ILibraryItem
    {
        string Title { get; }
        int NumberOfCopies { get; set; }
        void Display();
    }
}
