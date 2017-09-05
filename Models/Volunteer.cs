using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.BuilderProperties;

namespace VolunteerTracking.Models
{
    public class Volunteer
    {
        public int VolunteerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(35)]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        [StringLength(35)]
        public string LastName { get; set; }


        [Display(Name = "Availability")]
        public DayAvailable AvailableDay { get; set; }


        [Display(Name = "Preferred Center")]
        public Center CenterPreferred { get; set; }


        [Display(Name = "Education")]
        public EducationLevel HighestEducation { get; set; }


        [Display(Name = "Skill")]
        public Skill Skill { get; set; }


        [Display(Name = "License")]
        public License CurrentLicense { get; set; }


        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }


        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6)]
        public string Password { get; set; }


        [Display(Name = "Address")]
        public string Address { get; set; }


        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        public string HomeNumber { get; set; }


        [Display(Name = "Cell Phone")]
        [DataType(DataType.PhoneNumber)]
        public string CellNumber { get; set; }


        [Display(Name = "Work Phone")]
        [DataType(DataType.PhoneNumber)]
        public string WorkNumber { get; set; }


        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }


        [Display(Name = "Emergency Contact")]
        public string EmergencyContact { get; set; }


        [Display(Name = "Driver's License")]
        public bool HasDriversLicense { get; set; }


        [Display(Name = "Social Security Card")]
        public bool HasSsCard { get; set; }


        [Required]
        [Display(Name = "Status")]
        public Status Status { get; set; }

    }


    public enum DayAvailable
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Center
    {
        [Display(Name = "Florida State College at Jacksonville")] FSCJ = 1,
        [Display(Name = "Jacksonville University")] JU,
        [Display(Name = "University of North Florida")] UNF,
        [Display(Name = "University of Florida")] UF,
        [Display(Name = "Florida Institute of Technology")] FIT

    }

    public enum EducationLevel
    {
        [Display(Name = "High school")] Highschool = 1,
        [Display(Name = "Associate's degree")] Associates,
        [Display(Name = "Bachelor's degree")] Bachelors,
        [Display(Name = "Master's degree")] Masters,
        [Display(Name = "Doctorate or professional degree")] Doctorate
    }

    public enum Skill
    {
        Analysis = 1,
        Communication,
        [Display(Name = "Programming knowledge")] ProgrammingKnowledge,
        Planning,
        [Display(Name = "Problem solving")] ProblemSolving,
        Teaching,
        Writing
    }


    public enum License
    {
        Architecture = 1,
        Construction,
        Engineering,
        [Display(Name = "Health Care")] HealthCare,
        [Display(Name = "Real Estate")] RealEstate
    }

    public enum Status
    {
        Approved = 1,
        Pending,
        Disapproved,
        Inactive
    }
}
