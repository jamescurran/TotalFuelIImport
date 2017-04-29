using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace TotalFuelImport.Models
{
    public class FuelEntry
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Decimal Odometer { get; set; }
        public Decimal Units { get; set; }
        public Decimal UnitCost { get; set; }
        public int  FuelUnit { get; set; }
        public bool IsPartial { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Days { get; set; }
        public string  Trip { get; set; }
    }
}
