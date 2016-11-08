using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleCity
{
    class DummyDataSource: IFahrradfahrerDataSource
    {
		readonly List<Fahrradfahrer> _fahrradfahrer = new List<Fahrradfahrer>() {
                new Fahrradfahrer("Paul", 1, true),
                new Fahrradfahrer("Paula", 2, false),
                new Fahrradfahrer("Pascal", 3, true)
            }; 
		
        public IEnumerable<Fahrradfahrer> AlleFahrradfahrer()
        {
            return _fahrradfahrer;
        }
		
		public void SpeichereFahrradfahrer(Fahrradfahrer fahrradfahrer)
        {
            _fahrradfahrer.Add(fahrradfahrer);
        }
    }
}
