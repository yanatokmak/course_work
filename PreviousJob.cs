using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace course_work
{
    public class PreviousJob
    {
        public string PhoneNumber {  get; set; }
        public string LastJobTitle {  get; set; }
        
        public string DismissalReason {  get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public DateTime WorkingStartDate { get; set; }
        public DateTime WorkingEndDate { get; set; }

       
        public PreviousJob() { }
        public PreviousJob(string companyName, string address, string phoneNumber, string lastJobTitle, string dismissalReason, DateTime workingStartDate, DateTime workingEndDate)
        {
            CompanyName = companyName;
            Address = address;
            PhoneNumber = phoneNumber;
            LastJobTitle = lastJobTitle;
            DismissalReason = dismissalReason;
            WorkingStartDate = workingStartDate;
            WorkingEndDate = workingEndDate;
        }

        public override string ToString()
        {
            return $"{CompanyName} - {LastJobTitle} ({WorkingStartDate.ToShortDateString()} - {WorkingEndDate.ToShortDateString()})";
        }

    }
}
