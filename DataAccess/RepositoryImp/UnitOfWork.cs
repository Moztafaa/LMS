using Entities.Models;
using Entities.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.RepositoryImp
{
    public class UnitOfWork : IunitOfWork
    {
        public Iinstructor instructorrepo { get; private set; }

        public Icourse Courserepo { get; private set; }

        // DB context;
        private readonly DB context;
        public UnitOfWork( DB context)
        {
            // context = new DB();
            this.context = context;
            instructorrepo=new InstructorRepo(context);
            Courserepo = new CourseRepo(context);
        }
        public async Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
           context.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await context.DisposeAsync();
        }
    }
}
