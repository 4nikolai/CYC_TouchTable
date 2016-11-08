using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleCity
{
    class FahrradfahrerServiceImpl : IFahrradfahrerService
    {
        private readonly IFahrradfahrerDataSource _fahrradfahrerDataSource;

        public IEnumerable<Fahrradfahrer> GetAllFahrradfahrer()
        {
            try
            {
                return _fahrradfahrerDataSource.AlleFahrradfahrer();
            }
            catch (DataException e)
            {
                throw new ApplicationException("Data Access Failure", e);
            }
        }

        public Fahrradfahrer GetFahrradfahrerForId(int id)
        {
            return GetAllFahrradfahrer().FirstOrDefault(fahrradfahrer => fahrradfahrer.ID == id);
        }

        public Fahrradfahrer GetFahrradFahrerForName(string name)
        {
                return GetAllFahrradfahrer().FirstOrDefault(fahrradfahrer => fahrradfahrer.Name == name);
        }

        public FahrradfahrerServiceImpl(IFahrradfahrerDataSource dataSource)
        {
            _fahrradfahrerDataSource = dataSource;
        }
    }
}
