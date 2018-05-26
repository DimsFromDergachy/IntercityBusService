using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public enum RepeatDaysPattern
    {
        EveryDay,
        Evens,
        Odds,
    }

    public class Schedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public RepeatDaysPattern DaysPattern { get; set; }
        public DateTime Time { get; set; } // TODO: Extend for many times on a single day
    }
}