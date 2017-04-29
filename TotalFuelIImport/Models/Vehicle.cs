using System;

namespace TotalFuelImport.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public FuelEntry[] FuelEntries { get; set; }
        public Settings Settings { get; set; }


    }
}