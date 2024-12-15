using System;
using System.Collections.Generic;
using System.Drawing;

namespace course_work
{
    public class Employee : GeneralInfo
    {
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public string Degree { get; set; }
        public string Title { get; set; }
        public List<Measure> Incentives { get; set; } = new List<Measure>();
        public List<Measure> DisciplinaryActions { get; set; } = new List<Measure>();
        public List<PreviousJob> PreviousJobs { get; set; } = new List<PreviousJob>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<JobMovement> JobMovements { get; set; } = new List<JobMovement>();


        public Employee(string photoPath, string surname, string name, string patronymic, string phoneNumber,
                string passportNumber, DateTime dateOfBirth, string placeOfBirth, string homeAddress,
                DateTime passportIssueDate, string passportIssuedBy,
                string gender, string department, string position, DateTime employmentStartDate,
                string degree, string title,
                List<Measure> incentives = null,
                List<Measure> disciplinaryActions = null,
                List<PreviousJob> previousJobs = null,
                List<Education> educations = null,
                List<JobMovement> jobMovements = null)
                : base(photoPath, surname, name, patronymic, phoneNumber, passportNumber, dateOfBirth, placeOfBirth, homeAddress,
                    passportIssueDate, passportIssuedBy, gender)
        {
            Department = department;
            Position = position;
            EmploymentStartDate = employmentStartDate;
            Degree = degree;
            Title = title;
            Incentives = incentives ?? new List<Measure>();
            DisciplinaryActions = disciplinaryActions ?? new List<Measure>();
            PreviousJobs = previousJobs ?? new List<PreviousJob>();
            Educations = educations ?? new List<Education>();
            JobMovements = jobMovements ?? new List<JobMovement>();
        }

        public string FullName
        {
            get
            {
                return $"{Surname} {Name} {Patronymic}";
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}