using DataAccessLayer.DataContext;
using InterfaceEntity.Interface;
using InterfaceEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class TaskPersonRepository : GenericRepository<TaskPerson>, ITaskPersonRepository
    {
        public TaskPersonRepository(DataAccessLayerContext dbContext) : base(dbContext)
        {

        }
    }
}
