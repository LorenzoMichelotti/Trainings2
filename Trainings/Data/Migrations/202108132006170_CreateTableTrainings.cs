﻿namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableTrainings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        content_Id = c.Int(),
                        evaluation_Id = c.Int(),
                        profile_Id = c.Int(),
                        schedule_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contents", t => t.content_Id)
                .ForeignKey("dbo.Evaluations", t => t.evaluation_Id)
                .ForeignKey("dbo.Profiles", t => t.profile_Id)
                .ForeignKey("dbo.Schedules", t => t.schedule_Id)
                .Index(t => t.content_Id)
                .Index(t => t.evaluation_Id)
                .Index(t => t.profile_Id)
                .Index(t => t.schedule_Id);
            
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
            DropTable("dbo.Trainings");
        }
    }
}