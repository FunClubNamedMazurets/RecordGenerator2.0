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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dodatoc2");
        }
    }
}
