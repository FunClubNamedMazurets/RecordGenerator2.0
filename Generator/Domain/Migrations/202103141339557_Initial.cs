namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dodatoc2",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfOrgan = c.String(),
                        Initials = c.String(),
                        EducationInstitution = c.String(),
                        ClassAndGroup = c.String(),
                        ActNumber = c.String(),
                        ActDate = c.String(),
                        Сonsequences_Column1 = c.String(),
                        Сonsequences_Column2 = c.String(),
                        Сonsequences_Column3 = c.String(),
                        BossOfInstitution_Column1 = c.String(),
                        BossOfInstitution_Column2 = c.String(),
                        BossOfInstitution_Column3 = c.String(),
                        DateOfDocument = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dodatoc4",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Input_1_Education_Management = c.String(),
                        Input_2_Date_Of_Accident = c.String(),
                        Input_3_Name_Of_School_And_Creator = c.String(),
                        Input_4_Place_Of_Accident = c.String(),
                        Input_5_Poor_Ones = c.String(),
                        Input_6_Trauma = c.String(),
                        Input_7_Reasons_Of_Accident = c.String(),
                        Input_8_Date_And_Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dodatoc4");
            DropTable("dbo.Dodatoc2");
        }
    }
}
