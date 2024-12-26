using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingInterfaceIEnumerable
{
    public interface IAddRemoveDisplay<T>  // creating interface for typification input
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
    }
}
