using System;

namespace TotalFuelImport.Models
{
    public class TotalFuel
    {
        public Guid VehicleId { get; set; }
        public Guid Id { get; set; }
        public Vehicle[] Vehicles { get; set; }

    }
}