using System;

namespace CycleCity
{
    public abstract class AbstractFahrt
    {
        /// <summary>
        /// Liefert den Zeitraum der Fahrt zurück
        /// </summary>
        /// <returns></returns>
        public abstract TimeSpan GetTimeSpan();

        /// <summary>
        /// Liefert die Distanz in Kilometer zurück
        /// </summary>
        /// <returns></returns>
        public abstract double GetDistance();

        /// <summary>
        /// Gibt die Durchschnittsgeschwindigkeit (km/h) über die Fahrt zurück.
        /// </summary>
        /// <returns></returns>
        public virtual double GetAverageSpeed()
        {
            return GetDistance()/GetTimeSpan().TotalHours;
        }
    }
}