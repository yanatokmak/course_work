using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace course_work
{
    public class Education
    {
        public string GraduatedInstitution { get; set; }
        public int GraduationYear {  get; set; }
        public string Speciality {  get; set; }
        public string EducationLevel { get; set; }
        public string EducationDocumentData{get; set;}
        public Education(string educationLevel, string graduatedInstitution, int graduationYear, string speciality, string educationDocumentData)
        {
            EducationLevel = educationLevel;
            GraduatedInstitution = graduatedInstitution;
            GraduationYear = graduationYear;
            Speciality = speciality;
            EducationDocumentData = educationDocumentData;
        }

        public Education()
        {
        }

        public override string ToString()
        {
            return $"{EducationLevel} - {GraduatedInstitution} ({GraduationYear})";
        }
    }
}
