using InterfaceEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICountryServics
    {
        Task<bool> CreateCountry(RepoWithCountry countrydetails);

        Task<IEnumerable<RepoWithCountry>> GetAllCountry();

        Task<RepoWithCountry> GetCountryById(int countryid);

        Task<bool> UpdateCountry(RepoWithCountry countrydetails);

        Task<bool> DeleteCountry(int countryid);
    }
}
