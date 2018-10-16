using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterHistoryApp.Models
{
    /// <summary>
    /// Модель класса History
    /// Поля: int HistoryId, string Name, string Season, string NumberEmployees,  
    /// string DayWeek, string PreviouDay, string TimeDelivery, string NumberPumps,
    /// string NumberRepeir, string Vending, string WorkingHours, string UncertainReasons,
    ///  string TemperatureConditions,  int Quantity, DateTime DateTime
    /// </summary>
    public class History
    {
        public int HistoryId { get; set; }
        public string Season { get; set; }
        public string NumberEmployees { get; set; }
        public string DayWeek { get; set; }
        public string PreviouDay { get; set; }
        public string TimeDelivery { get; set; }
        public string NumberPumps { get; set; }
        public string NumberRepeir { get; set; }
        public string Vending { get; set; }
        public string WorkingHours { get; set; }
        public string UncertainReasons { get; set; }
        public string TemperatureConditions { get; set; }
        public int Quantity { get; set; }
        public DateTime DateTime { get; set; }


    }
}
