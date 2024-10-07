using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.IRepository
{
    public interface Icourse:IGenericRepository<Course>
    {
        void Update(Course course); 
    }
}
