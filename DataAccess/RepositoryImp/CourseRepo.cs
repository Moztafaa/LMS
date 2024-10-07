using Entities.Models;
using Entities.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RepositoryImp
{
    public class CourseRepo : GenericRepository<Course>, Icourse
    {

        readonly DB context;
        public CourseRepo(DB context) : base(context)
        {
            this.context = context;
        }
        public void Update(Course course)
        {
            context.Update(course);   
        }
    }
}
