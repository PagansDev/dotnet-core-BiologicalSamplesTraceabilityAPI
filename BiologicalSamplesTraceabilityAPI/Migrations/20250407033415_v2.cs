using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiologicalSamplesTraceability.API.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SampleIdentifierId",
                table: "SampleBatches");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SampleIdentifierId",
                table: "SampleBatches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
