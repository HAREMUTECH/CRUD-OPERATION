using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Decloud_CRUD.Migrations
{
    public partial class cities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Cities (NAME) VALUES('Lagos')");
            migrationBuilder.Sql("INSERT INTO Cities (NAME) VALUES('Ibadan')");
            migrationBuilder.Sql("INSERT INTO Cities (NAME) VALUES('Lokoja')");
            migrationBuilder.Sql("INSERT INTO Cities (NAME) VALUES('Abeokuta')");
            migrationBuilder.Sql("INSERT INTO Cities (NAME) VALUES('Anambra')");
            migrationBuilder.Sql("INSERT INTO Cities (NAME) VALUES('Kaduna')");
           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("DELETE * FROM Cities");
        }
    }
}
