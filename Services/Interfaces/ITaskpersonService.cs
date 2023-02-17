using InterfaceEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ITaskpersonService
    {
        Task<bool> CreatePerson(TaskPerson persondetails);

        Task<IEnumerable<TaskPerson>> GetAllpersons();

        Task<TaskPerson> GetPersonById(int personid);

        Task<bool> UpdatePerson(TaskPerson persondetails);

        Task<bool> DeletePerson(int personid);
    }
}
