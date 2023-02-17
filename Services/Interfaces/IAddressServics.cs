using InterfaceEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAddressServics
    {
        Task<bool> CreateAddress(Address addressdeatils);

        Task<IEnumerable<Address>> GetAllAddress();

        Task<Address> GetAddressById(int addressid);

        Task<bool> UpdateAddress(Address addressdetail);

        Task<bool> DeleteAddress(int addressid);
    }
}
