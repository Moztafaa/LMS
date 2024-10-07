using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IRepository
{
    public interface IunitOfWork:IDisposable,IAsyncDisposable
    {
        Task<int> Complete();
        Iinstructor instructorrepo { get;}
        Icourse Courserepo{ get;}
    }
}
