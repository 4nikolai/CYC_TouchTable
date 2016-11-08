using System;
using System.Collections.Generic;

namespace CycleCity
{
    public class Fahrradfahrer
    {

        private string _name;

        public string Name { get { return _name; } set { if (value.Length <= 20) { _name = value; } else { _name = "Fahradfahrer" + ID; } } }
        public int ID { get; }
        public bool IsPendler { get; set; }

        public List<GpsFahrt> Fahrten { get; set; }

        public Fahrradfahrer(string name, int id, bool isPendler)
        {
            Name = name;
            ID = id;
            IsPendler = isPendler;
            Fahrten = new List<GpsFahrt>();
        }

        public void Klingel()
        {
            Console.WriteLine("Ring!");
        }
    }
}
