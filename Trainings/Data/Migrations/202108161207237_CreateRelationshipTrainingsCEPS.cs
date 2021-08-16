namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipTrainingsCEPS : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainings", "content_Id", c => c.Int());
            AddColumn("dbo.Trainings", "evaluation_Id", c => c.Int());
            AddColumn("dbo.Trainings", "profile_Id", c => c.Int());
            AddColumn("dbo.Trainings", "schedule_Id", c => c.Int());
            CreateIndex("dbo.Trainings", "content_Id");
            CreateIndex("dbo.Trainings", "evaluation_Id");
            CreateIndex("dbo.Trainings", "profile_Id");
            CreateIndex("dbo.Trainings", "schedule_Id");
            AddForeignKey("dbo.Trainings", "content_Id", "dbo.Contents", "Id");
            AddForeignKey("dbo.Trainings", "evaluation_Id", "dbo.Evaluations", "Id");
            AddForeignKey("dbo.Trainings", "profile_Id", "dbo.Profiles", "Id");
            AddForeignKey("dbo.Trainings", "schedule_Id", "dbo.Schedules", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trainings", "schedule_Id", "dbo.Schedules");
            DropForeignKey("dbo.Trainings", "profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.Trainings", "evaluation_Id", "dbo.Evaluations");
            DropForeignKey("dbo.Trainings", "content_Id", "dbo.Contents");
            DropIndex("dbo.Trainings", new[] { "schedule_Id" });
            DropIndex("dbo.Trainings", new[] { "profile_Id" });
            DropIndex("dbo.Trainings", new[] { "evaluation_Id" });
            DropIndex("dbo.Trainings", new[] { "content_Id" });
            DropColumn("dbo.Trainings", "schedule_Id");
            DropColumn("dbo.Trainings", "profile_Id");
            DropColumn("dbo.Trainings", "evaluation_Id");
            DropColumn("dbo.Trainings", "content_Id");
        }
    }
}
