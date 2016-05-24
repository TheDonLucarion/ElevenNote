namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterNoteAddSummaryColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "Summary", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "Summary");
        }
    }
}
