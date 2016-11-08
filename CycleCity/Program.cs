using System;
using System.Collections.Generic;

namespace CycleCity
{
    class Program
    {
        static void Main(string[] args)
        {
            FahrradfahrerServiceImpl fahrradfahrerServiceImpl = new FahrradfahrerServiceImpl(new DummyDataSource());

            Fahrradfahrer fahrer = fahrradfahrerServiceImpl.GetFahrradFahrerForName("Paul");
            List<Koordinate> koordinaten = new List<Koordinate>
            {
                new Koordinate(53.5735926, 10.0050694),
                new Koordinate(53.5726219, 10.0067387),
                new Koordinate(53.5714585, 10.0084191),
                new Koordinate(53.5710441, 10.0087984),
                new Koordinate(53.5704539, 10.0091474),
                new Koordinate(53.5693637, 10.0120378),
                new Koordinate(53.567967, 10.0149737),
                new Koordinate(53.5669668, 10.0154972),
                new Koordinate(53.5655431, 10.0159676),
                new Koordinate(53.5647276, 10.0164076),
                new Koordinate(53.5628081, 10.0143668),
            };

            GpsFahrt fahrt1 = new GpsFahrt(DateTime.Today.AddHours(10), DateTime.Today.AddHours(10).AddMinutes(10),
                koordinaten);
            fahrer.Fahrten.Add(fahrt1);

            double geschwindigkeit = fahrt1.GetDistance()/fahrt1.GetTimeSpan().TotalHours;
            Console.WriteLine(fahrt1.GetTimeSpan() + "; " + fahrt1.GetDistance() + " km; " + geschwindigkeit + "km/h");

            Console.Read();
        }
    }
}
//Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
//string name = Console.ReadLine();

//Console.WriteLine("Sind Sie Pendler? (j oder n)");
//string stringIsPendler = Console.ReadLine();

//if(stringIsPendler != "j" && stringIsPendler != "n")
//{
//    Console.WriteLine("Fehlerhafte Eingabe");
//    Console.Read();
//    Environment.Exit(0);
//}
//bool isPendler = stringIsPendler == "j";

//Console.WriteLine("Bitte geben Sie Ihre ID ein:");
//int id;
//if (!int.TryParse(Console.ReadLine(), out id))
//{
//    Console.WriteLine("Fehlerhafte Eingabe");
//    Console.Read();
//    Environment.Exit(0);
//};

//Fahrradfahrer fahrer = new Fahrradfahrer(name, id, isPendler);

//string eingabe;
//do
//{
//    Console.WriteLine("Geben Sie nochmal Ihren Namen ein:");
//    eingabe = Console.ReadLine();

//} while (eingabe != null && !eingabe.Equals(fahrer.Name));

//fahrer.Klingel();
//fahrer.Klingel();