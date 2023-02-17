using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEntity.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ITaskPersonRepository taskperson { get; }

        IAddressRepository address { get; }
        ICountryRepository country { get; }

        int Save();
    }
}
