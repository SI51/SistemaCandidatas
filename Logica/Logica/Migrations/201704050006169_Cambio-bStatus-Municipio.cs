namespace Logica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiobStatusMunicipio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Municipios", "bStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Municipios", "bStatus");
        }
    }
}
