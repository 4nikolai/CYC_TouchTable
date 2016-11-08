using System.Collections.Generic;

namespace CycleCity
{
    public interface IFahrradfahrerDataSource
    {
        /// <summary>
        /// Gibt alle Fahrradfahrer aus der Datenquelle
        /// </summary>
        /// <returns>Alle Fahrradfahrer</returns>
        IEnumerable<Fahrradfahrer> AlleFahrradfahrer();
		
		/// <summary>
        /// Speichert einen Fahrradfahrer
        /// </summary>
        /// <param name="fahrradfahrer"></param>
        void SpeichereFahrradfahrer(Fahrradfahrer fahrradfahrer);
    }
}