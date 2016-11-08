using System.Collections.Generic;
using System.Data;

namespace CycleCity
{
    public class ThrowingDummyDataSource:IFahrradfahrerDataSource
    {
        public IEnumerable<Fahrradfahrer> AlleFahrradfahrer()
        {
            throw new DataException("Data Source has failed because of reasons.");
        }
		
		public void SpeichereFahrradfahrer(Fahrradfahrer fahrradfahrer)
        {
            throw new System.NotImplementedException();
        }
    }
}