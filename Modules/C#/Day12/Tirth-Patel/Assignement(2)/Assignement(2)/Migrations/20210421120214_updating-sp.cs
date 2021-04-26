﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignement_2_.Migrations
{
    public partial class updatingsp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp1 = @"Create Procedure GetAllproducts
                AS BEGIN
                        SET NOCOUNT ON
                            Select t.ToyID,t.Name,c.Name,t.Price  FROM Toys t LEFT OUTER Join Categories c on t.CategoryID = c.CategoryID ;
                    END;";
            var sp2 = @"Create Procedure SerachCategoryWise
            @CategoryName nvarchar(max)
                AS 
                Begin
                    SET NOCOUNT ON
                        Select t.ToyID,t.Name,c.Name,t.Price  From Toys t LEFT OUTER join Categories c on t.CategoryID = c.CategoryID
                                Where c.Name = @CategoryName;
                  END;";
            migrationBuilder.Sql(sp1);
            migrationBuilder.Sql(sp2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
