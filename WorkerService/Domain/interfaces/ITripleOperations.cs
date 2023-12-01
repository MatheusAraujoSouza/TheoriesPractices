using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerService.Domain.interfaces
{
    public interface ITripleOperations<T1, T2, T3>
    {
        void PrintTriple(Triple<T1, T2, T3> triple);
        Triple<T3, T2, T1> Reverse(Triple<T1, T2, T3> triple);
    }
}
