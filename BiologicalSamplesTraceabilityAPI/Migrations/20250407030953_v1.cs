using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BiologicalSamplesTraceability.API.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SampleIdentifierId",
                table: "SampleBatches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SampleIdentifierId",
                table: "SampleBatches");
        }
    }
}
