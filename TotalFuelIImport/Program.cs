using System;
using System.IO;
using System.Linq;
using TotalFuelImport.Models;
using Newtonsoft.Json;

namespace TotalFuelImport
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializer serial = new JsonSerializer();

            TotalFuel tf;
            using (var fr = File.OpenRead("C:\\Users\\JamesM\\OneDrive\\TotalFuelBackup.json"))
            using (var tr = new StreamReader(fr))
            using (var reader = new JsonTextReader(tr))
            {
                tf = serial.Deserialize<TotalFuel>(reader);
            }

            using (var fs = File.OpenWrite(@"C:\Temp\TotalFuelExport.csv"))
            using(var sw = new StreamWriter(fs))
            {
                sw.WriteLine("Vehicle,DateTime,Location,Odometer,EventType,EventDetail,TripDistance,FuelType,UnitPrice,Amount,TankLevelAfter,MissedPreviousRefuel,Total");
                foreach (var veh in tf.Vehicles)
                {
                    var name = veh.Name;


                    foreach (var entry in veh.FuelEntries)
                    {
                        var total = entry.UnitCost*  entry.Units;
                        sw.WriteLine(
                            $"\"{name}\",{entry.Date:s}, \"\",{entry.Odometer},\"Refuel\", \"\",,0,{entry.UnitCost}, {entry.Units},  {(entry.IsPartial?50:100)}, 0, {total}");

                    }
                }
            }
        }
    }
}