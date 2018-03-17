namespace Doctors.Migrations.patient
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreatePatient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ecgs",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        SerialNb = c.String(nullable: false, maxLength: 128),
                        File = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.PatientId, t.DoctorId, t.SerialNb });
            
            CreateTable(
                "dbo.InsuranceTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImagingResults",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        SerialNb = c.String(nullable: false, maxLength: 128),
                        File = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.PatientId, t.DoctorId, t.SerialNb });
            
            CreateTable(
                "dbo.LabResults",
                c => new
                    {
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        SerialNb = c.String(nullable: false, maxLength: 128),
                        File = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.PatientId, t.DoctorId, t.SerialNb });
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        DateOfBirth = c.DateTime(nullable: false),
                        ContactInfo = c.String(maxLength: 50),
                        InsuranceTypeIDs = c.String(maxLength: 50),
                        Referral = c.String(maxLength: 50),
                        Age = c.Int(nullable: false),
                        BloodType = c.String(maxLength: 2),
                        Allergies = c.String(maxLength: 500),
                        ChiefComplaint = c.String(maxLength: 500),
                        PastMedicalHistory = c.String(maxLength: 500),
                        PastSurgeryHistory = c.String(maxLength: 500),
                        MedicationIDs = c.String(maxLength: 500),
                        FamilyHisory = c.String(maxLength: 500),
                        SocialHistory = c.String(maxLength: 500),
                        Vitals = c.String(),
                        PhysicalExam = c.String(),
                        EcgIDs = c.String(maxLength: 500),
                        LabResultIDs = c.String(maxLength: 500),
                        ImagingResultIDs = c.String(maxLength: 500),
                        Assessment = c.String(),
                        Plan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.LabResults");
            DropTable("dbo.ImagingResults");
            DropTable("dbo.InsuranceTypes");
            DropTable("dbo.Ecgs");
            DropTable("dbo.Doctors");
        }
    }
}
