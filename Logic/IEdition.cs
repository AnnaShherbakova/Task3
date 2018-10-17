using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IEdition
    {
        int AmountAuthor { get; }

        void AddAuthor(int n);
        void RemoveAuthor(int n);


    }
}
