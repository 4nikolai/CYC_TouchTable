using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleCity
{
    public class Koordinate
    {
        public double Lat { get; }
        public double Lon { get; }

        public Koordinate(double lat, double lon)
        {
            Lat = lat;
            Lon = lon;
        }

        public double DistanceTo(Koordinate other)
        {
            double rlat1 = Math.PI * Lat / 180;
            double rlat2 = Math.PI * other.Lat / 180;
            double theta = Lon - other.Lon;
            double rtheta = Math.PI * theta / 180;
            double dist =
                Math.Sin(rlat1) * Math.Sin(rlat2) + Math.Cos(rlat1) *
                Math.Cos(rlat2) * Math.Cos(rtheta);
            dist = Math.Acos(dist);
            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return dist * 1.609344;
        }
    }
}
