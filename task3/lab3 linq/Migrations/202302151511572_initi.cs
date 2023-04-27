namespace lab3_linq.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Crs_name = c.String(),
                        Crs_Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stud_Course",
                c => new
                    {
                        Crs_ID = c.Int(nullable: false),
                        Stud_ID = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Crs_ID, t.Stud_ID })
                .ForeignKey("dbo.courses", t => t.Crs_ID, cascadeDelete: true)
                .ForeignKey("dbo.students", t => t.Stud_ID, cascadeDelete: true)
                .Index(t => t.Crs_ID)
                .Index(t => t.Stud_ID);
            
            CreateTable(
                "dbo.students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                        Address = c.String(),
                        Age = c.Int(nullable: false),
                        Dept_ID = c.Int(nullable: false),
                        st_Super = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.departments", t => t.Dept_ID, cascadeDelete: true)
                .ForeignKey("dbo.students", t => t.st_Super)
                .Index(t => t.Dept_ID)
                .Index(t => t.st_Super);
            
            CreateTable(
                "dbo.departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                        DeptDesc = c.String(),
                        Location = c.String(),
                        DeptManager = c.Int(nullable: false),
                        hireDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stud_Course", "Stud_ID", "dbo.students");
            DropForeignKey("dbo.students", "st_Super", "dbo.students");
            DropForeignKey("dbo.students", "Dept_ID", "dbo.departments");
            DropForeignKey("dbo.Stud_Course", "Crs_ID", "dbo.courses");
            DropIndex("dbo.students", new[] { "st_Super" });
            DropIndex("dbo.students", new[] { "Dept_ID" });
            DropIndex("dbo.Stud_Course", new[] { "Stud_ID" });
            DropIndex("dbo.Stud_Course", new[] { "Crs_ID" });
            DropTable("dbo.departments");
            DropTable("dbo.students");
            DropTable("dbo.Stud_Course");
            DropTable("dbo.courses");
        }
    }
}
