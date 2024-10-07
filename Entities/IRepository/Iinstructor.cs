using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IRepository
{
    public interface Iinstructor:IGenericRepository<Instructor>
    {
       void Update(Instructor instructor);

    }
}
