using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleCity
{
    public class GpsFahrt : AbstractFahrt
    {
        private List<Koordinate> _koordinaten;
        private DateTime _startZeit;
        private DateTime _endZeit;

        public GpsFahrt(DateTime startZeit, DateTime endZeit, List<Koordinate> koordinaten)
        {
            _koordinaten = koordinaten;
            _startZeit = startZeit;
            _endZeit = endZeit;
        }

        public override TimeSpan GetTimeSpan()
        {
            return _endZeit.Subtract(_startZeit);
        }

        public override double GetDistance()
        {
            double distance = 0;
            for (int i = 0; i < _koordinaten.Count - 1; i++)
            {
                distance += _koordinaten[i].DistanceTo(_koordinaten[i + 1]);
            }

            return distance;
        }
    }
}
