using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Gui.Infrastructure.SqLite
{
    public class TaskRepository : ITaskRepository
    {
        public System.Threading.Tasks.Task<int> Add(Task entity)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<int> Delete(Task entity)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<List<Task>> Get()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<Task> Get(string key)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<int> Update(Task entity)
        {
            throw new NotImplementedException();
        }
    }
}
