using DataAccessLayer.DataContext;
using InterfaceEntity.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly DataAccessLayerContext _dbContext;
       
        public IAddressRepository address { get; }

        public ITaskPersonRepository taskperson { get; }       

        public ICountryRepository country { get; }


        public UnitOfWork(DataAccessLayerContext dbContext,
                            ITaskPersonRepository personRepository , IAddressRepository Address )
        {
            _dbContext = dbContext;
            taskperson = personRepository;
            address = Address;
           // country = Country;
        }
        public int Save()
        {


        
            return   _dbContext.SaveChanges();
                   
        }
    //public int Save()
    //{
    //    using (var transaction = _dbContext.Database.BeginTransaction())
    //    {
    //        try
    //        {
    //            _dbContext.SaveChanges();
    //            transaction.Commit();
    //        }
    //        catch (Exception ex)
    //        {
    //            transaction.Rollback();
    //        }
    //    }
    //    return 0;
    //}

    public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
