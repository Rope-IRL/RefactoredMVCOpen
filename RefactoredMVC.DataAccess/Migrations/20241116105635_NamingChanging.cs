using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RefactoredMVC.DataAccess.MsSql.Migrations
{
    /// <inheritdoc />
    public partial class NamingChanging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlatContracts_LandLords_LandlordId",
                table: "FlatContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_LandLords_LlId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_LandLords_LlId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseContracts_LandLords_LandlordId",
                table: "HouseContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_LandLords_LlId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_LandLordAdditionalInfos_LandLords_LandlordId",
                table: "LandLordAdditionalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomContracts_LandLords_LandlordId",
                table: "RoomContracts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandLords",
                table: "LandLords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandLordAdditionalInfos",
                table: "LandLordAdditionalInfos");

            migrationBuilder.RenameTable(
                name: "LandLords",
                newName: "Landlords");

            migrationBuilder.RenameTable(
                name: "LandLordAdditionalInfos",
                newName: "LandlordAdditionalInfos");

            migrationBuilder.RenameIndex(
                name: "IX_LandLords_Email",
                table: "Landlords",
                newName: "IX_Landlords_Email");

            migrationBuilder.RenameIndex(
                name: "IX_LandLordAdditionalInfos_LandlordId",
                table: "LandlordAdditionalInfos",
                newName: "IX_LandlordAdditionalInfos_LandlordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Landlords",
                table: "Landlords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandlordAdditionalInfos",
                table: "LandlordAdditionalInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlatContracts_Landlords_LandlordId",
                table: "FlatContracts",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_Landlords_LlId",
                table: "Flats",
                column: "LlId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Landlords_LlId",
                table: "Hotels",
                column: "LlId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseContracts_Landlords_LandlordId",
                table: "HouseContracts",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Landlords_LlId",
                table: "Houses",
                column: "LlId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandlordAdditionalInfos_Landlords_LandlordId",
                table: "LandlordAdditionalInfos",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomContracts_Landlords_LandlordId",
                table: "RoomContracts",
                column: "LandlordId",
                principalTable: "Landlords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlatContracts_Landlords_LandlordId",
                table: "FlatContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Flats_Landlords_LlId",
                table: "Flats");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Landlords_LlId",
                table: "Hotels");

            migrationBuilder.DropForeignKey(
                name: "FK_HouseContracts_Landlords_LandlordId",
                table: "HouseContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Landlords_LlId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_LandlordAdditionalInfos_Landlords_LandlordId",
                table: "LandlordAdditionalInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomContracts_Landlords_LandlordId",
                table: "RoomContracts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Landlords",
                table: "Landlords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LandlordAdditionalInfos",
                table: "LandlordAdditionalInfos");

            migrationBuilder.RenameTable(
                name: "Landlords",
                newName: "LandLords");

            migrationBuilder.RenameTable(
                name: "LandlordAdditionalInfos",
                newName: "LandLordAdditionalInfos");

            migrationBuilder.RenameIndex(
                name: "IX_Landlords_Email",
                table: "LandLords",
                newName: "IX_LandLords_Email");

            migrationBuilder.RenameIndex(
                name: "IX_LandlordAdditionalInfos_LandlordId",
                table: "LandLordAdditionalInfos",
                newName: "IX_LandLordAdditionalInfos_LandlordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandLords",
                table: "LandLords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LandLordAdditionalInfos",
                table: "LandLordAdditionalInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlatContracts_LandLords_LandlordId",
                table: "FlatContracts",
                column: "LandlordId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flats_LandLords_LlId",
                table: "Flats",
                column: "LlId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_LandLords_LlId",
                table: "Hotels",
                column: "LlId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HouseContracts_LandLords_LandlordId",
                table: "HouseContracts",
                column: "LandlordId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_LandLords_LlId",
                table: "Houses",
                column: "LlId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandLordAdditionalInfos_LandLords_LandlordId",
                table: "LandLordAdditionalInfos",
                column: "LandlordId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomContracts_LandLords_LandlordId",
                table: "RoomContracts",
                column: "LandlordId",
                principalTable: "LandLords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
