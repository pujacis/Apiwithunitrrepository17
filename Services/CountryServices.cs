using InterfaceEntity.Interface;
using InterfaceEntity.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CountryServices : ICountryServics
    {
        public IUnitOfWork _unitOfWork;

        public CountryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<bool> CreateCountry(RepoWithCountry countrydetails)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCountry(int countryid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RepoWithCountry>> GetAllCountry()
        {
            var countrylist = await _unitOfWork.country.GetAll();
            return countrylist;
        }

        public Task<RepoWithCountry> GetCountryById(int countryid)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCountry(RepoWithCountry countrydetails)
        {
            throw new NotImplementedException();
        }
    }
}
