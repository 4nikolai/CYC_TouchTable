using System;

namespace CycleCity
{
    public class CoordinateUtils
    {
        public static double Distance(double lat1, double lon1, double lat2, double lon2)
        {
            double rlat1 = Math.PI * lat1 / 180;
            double rlat2 = Math.PI * lat2 / 180;
            double theta = lon1 - lon2;
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
















/*
new List<Koordinate>
            {
                new Koordinate(53.5735926,10.0050694),
                new Koordinate(53.5726219,10.0067387),
                new Koordinate(53.5714585,10.0084191),
                new Koordinate(53.5710441,10.0087984), 
                new Koordinate(53.5704539,10.0091474), 
                new Koordinate(53.5693637,10.0120378), 
                new Koordinate(53.567967,10.0149737), 
                new Koordinate(53.5669668,10.0154972), 
                new Koordinate(53.5655431,10.0159676), 
                new Koordinate(53.5647276,10.0164076), 
                new Koordinate(53.5628081,10.0143668), 
            }
*/
