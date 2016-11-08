using System.Collections.Generic;

namespace CycleCity
{
    public interface IFahrradfahrerService
    {
        /// <summary>
        /// Liefert alle Fahrradfahrer zurück
        /// </summary>
        /// <returns>Alle Fahrradfahrer</returns>
        IEnumerable<Fahrradfahrer> GetAllFahrradfahrer();

        /// <summary>
        /// Gibt den Fahrradfahrer für die entsprechende Id zurück
        /// </summary>
        /// <param name="id">Die Id des Fahrradfahrers</param>
        /// <returns>Der Fahrradfahrer oder <code>null</code> wenn nicht vorhanden</returns>
        Fahrradfahrer GetFahrradfahrerForId(int id);

        /// <summary>
        /// Liefert den Fahrradfahrer mit dem entsprechenden Namen zurück.
        /// </summary>
        /// <param name="name">Der Name des Fahrradfahrers</param>
        /// <returns>Der Fahrradfahrer oder <code>null</code> wenn nicht vorhanden</returns>
        Fahrradfahrer GetFahrradFahrerForName(string name);
    }
}