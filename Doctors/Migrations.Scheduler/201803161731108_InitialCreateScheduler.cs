namespace Doctors.Migrations.Scheduler
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateScheduler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EFAppointments",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AllDay = c.Boolean(nullable: false),
                        Subject = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        Label = c.Int(nullable: false),
                        ResourceIDs = c.String(),
                        ReminderInfo = c.String(),
                        RecurrenceInfo = c.String(),
                    })
                .PrimaryKey(t => t.UniqueID);
            
            CreateTable(
                "dbo.EFResources",
                c => new
                    {
                        UniqueID = c.Int(nullable: false, identity: true),
                        ResourceID = c.Int(nullable: false),
                        ResourceName = c.String(),
                        Image = c.Binary(),
                        ColorEx_A = c.Byte(nullable: false),
                        ColorEx_R = c.Byte(nullable: false),
                        ColorEx_G = c.Byte(nullable: false),
                        ColorEx_B = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.UniqueID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EFResources");
            DropTable("dbo.EFAppointments");
        }
    }
}
