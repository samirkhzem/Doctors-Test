using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Patient
    {
        [Key()]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }
        [StringLength(50)]
        public string ContactInfo { get; set; }
        [StringLength(50)]
        //Multiple Insurance Types, Multiple IDs
        public string InsuranceTypeIDs { get; set; }
        [StringLength(50)]
        public string Referral { get; set; }
        public int Age { get; set; }
        [StringLength(2)]
        public string BloodType { get; set; }
        [StringLength(500)]
        public string Allergies { get; set; }
        [StringLength(500)]
        public string ChiefComplaint { get; set; }
        [StringLength(500)]
        public string PastMedicalHistory { get; set; }
        [StringLength(500)]
        public string PastSurgeryHistory { get; set; }
        [StringLength(500)]
        //Multiple medications ex: 1,2,3 (Serial) 
        //Should be able to see old rows too
        public string MedicationIDs { get; set; }
        [StringLength(500)]
        public string FamilyHisory { get; set; }
        [StringLength(500)]
        public string SocialHistory { get; set; }
        [StringLength(5000)]
        public string Vitals { get; set; }
        [StringLength(5000)]
        public string PhysicalExam { get; set; }
        [StringLength(500)]
        //Multiple ECGs ex: 1,2,3 (Serial) 
        public string EcgIDs { get; set; }
        [StringLength(500)]
        //Multiple Lab Results ex: 1,2,3 (Serial) 
        public string LabResultIDs { get; set; }
        [StringLength(500)]
        //Multiple Lab Results ex: 1,2,3 (Serial) 
        public string ImagingResultIDs { get; set; }
        [StringLength(5000)]
        public string Assessment { get; set; }
        [StringLength(5000)]
        public string Plan { get; set; }
    }
}