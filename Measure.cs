using System;


namespace course_work
{
    public class Measure
    {
        public string Type { get; set; } 
        public string OrderNumber { get; set; } 
        public DateTime Date { get; set; } 

        public Measure() { }
        public Measure(string type, string orderNumber, DateTime date)
        {
            Type = type;
            OrderNumber = orderNumber;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Type} ({Date.ToShortDateString()}) - Приказ №{OrderNumber}";
        }
    }
}