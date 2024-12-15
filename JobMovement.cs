using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public class JobMovement
    {
        public string MovementReason {  get; set; }
        
        public string OrderNumber { get; set; }
        public DateTime MovementDate { get; set; }
        

        public JobMovement() { }
        public JobMovement(string movementReason, DateTime movementDate, string orderNumber)
        {
            MovementReason = movementReason;
            OrderNumber = orderNumber;
            MovementDate = movementDate;
        }


        public override string ToString()
        {
            return $"{MovementReason} ({MovementDate.ToShortDateString()}) - Приказ №{OrderNumber}";
        }
    }
}
