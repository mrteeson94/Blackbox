﻿namespace blackBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateAddedColToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
