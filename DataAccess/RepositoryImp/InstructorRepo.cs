using Entities.Models;
using Entities.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RepositoryImp
{
    public class InstructorRepo : GenericRepository<Instructor>, Iinstructor
    {
        readonly DB context;
        public InstructorRepo(DB context):base(context)
        {
           this.context = context;
        }
        public void Update(Instructor instructor)
        {
            context.Update(instructor);  
        }

    }
}
