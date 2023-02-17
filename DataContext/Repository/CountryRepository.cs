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
    public class CountryRepository: GenericRepository<RepoWithCountry>, ICountryRepository
    {
        public CountryRepository(DataAccessLayerContext dbContext): base(dbContext) 
        { 
        }

       
    }

   
}
