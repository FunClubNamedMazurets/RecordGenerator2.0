namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableDodatoc4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dodatoc4",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfOrganAndAddress = c.String(),
                        DateAndTime = c.String(),
                        NameOfOrganAndOwner = c.String(),
                        Place = c.String(),
                        Initials = c.String(),
                        TypeInjuries = c.String(),
                        CausesAccident = c.String(),
                        DateAndSurname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dodatoc4");
        }
    }
}
