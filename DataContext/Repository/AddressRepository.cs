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
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(DataAccessLayerContext dbContext) : base(dbContext)
        {

        }
    }
}
