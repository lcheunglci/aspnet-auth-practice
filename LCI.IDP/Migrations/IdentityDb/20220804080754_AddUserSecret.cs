using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCI.IDP.Migrations.IdentityDb
{
    public partial class AddUserSecret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("053c13c3-64cf-40c0-be42-7a1af63fea7d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("056f02e8-dff3-4457-80b4-07c8521b2aef"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("09c07f0f-89a4-4862-bd36-51ba81f2171b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3bc76635-530e-4843-8069-0fb26fb2cafe"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("43e6cd75-f348-46a4-aeba-16b490ddf58f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6147bf6c-9435-460a-aab6-696b0705bac7"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("72b0a7e4-608c-4da9-bc58-b878dbb37528"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("85c8f48b-81cd-4e6d-be0f-c2c4759ad8c0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ae334846-d621-4e43-b48b-f121afe2ebf4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("aea0ebb1-6c5f-4ec0-be97-f4d66d253763"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ce8ff631-53c0-4f50-9f7b-30754068b659"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e43e6415-22f3-4ab8-976f-be8aa0acbaef"));

            migrationBuilder.CreateTable(
                name: "UserSecrets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecrets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecrets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("73fb625b-d1b4-4e61-a6f1-1d45bc3cc769"), "e3280c54-e1be-445f-9908-f6dc02d61c06", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("4f738929-30ef-429f-9f8c-a6f011f181eb"), "a2d43cef-ee2d-401b-8c52-7a3f322cd872", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("e212ad27-557d-4928-89c6-164580245146"), "222964ab-cb0d-4699-a593-770b263817af", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("034c7565-febc-45e5-a4cb-9d5d6433840e"), "adaeadf3-3b23-4c2c-ba1c-c5ab6be92c67", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("561cb72e-c11f-4fe3-bd27-a094371829ad"), "4731b791-5e87-4a5c-9ce1-5a7b162840f4", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("ddcf7286-e85a-4455-b309-6fd3bd4398bd"), "ace667e6-3358-441c-960e-aafda854a382", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("d1e65918-933c-405c-86ce-b2a90640b74d"), "9f00f8c6-4b27-4e21-952e-96c3bb391999", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("6650fbad-c689-4a83-b0d6-8b3337357dee"), "8d4dd8f6-30d5-4d48-b9fd-c385249191f6", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("943b4025-c748-40f9-bdb9-86196c6c8e59"), "6f11e3ff-343f-4fdf-ad3d-ef6bc312c854", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("4a4eec1f-baf4-478c-b463-4b5fd21194dd"), "5c2fe59c-8f4c-4546-ba34-ac7f5dbaec59", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("42fc2605-7dd2-4579-b95d-0128ad9bcb0a"), "e517fe53-05ab-45a7-986a-9a199a97c605", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("d4590fe8-3990-4f7e-a205-fb90e6415c89"), "a3a4f485-5ca1-4130-8490-70d78dd0a05c", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "8de15438-2010-4cb0-adae-ba595273049b");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "5fb54b2b-2098-4298-995b-3ae445e488ec");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecrets_UserId",
                table: "UserSecrets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecrets");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("034c7565-febc-45e5-a4cb-9d5d6433840e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("42fc2605-7dd2-4579-b95d-0128ad9bcb0a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4a4eec1f-baf4-478c-b463-4b5fd21194dd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4f738929-30ef-429f-9f8c-a6f011f181eb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("561cb72e-c11f-4fe3-bd27-a094371829ad"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6650fbad-c689-4a83-b0d6-8b3337357dee"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("73fb625b-d1b4-4e61-a6f1-1d45bc3cc769"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("943b4025-c748-40f9-bdb9-86196c6c8e59"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d1e65918-933c-405c-86ce-b2a90640b74d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d4590fe8-3990-4f7e-a205-fb90e6415c89"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ddcf7286-e85a-4455-b309-6fd3bd4398bd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("e212ad27-557d-4928-89c6-164580245146"));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("aea0ebb1-6c5f-4ec0-be97-f4d66d253763"), "31166816-45fd-4136-b332-c487100adde0", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("43e6cd75-f348-46a4-aeba-16b490ddf58f"), "b60aa1e9-dd7f-47f3-9fa9-4fe9a40675df", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("6147bf6c-9435-460a-aab6-696b0705bac7"), "2cfa7756-1244-4122-a4b8-87ffd443cfb3", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("056f02e8-dff3-4457-80b4-07c8521b2aef"), "ddae8fbb-e16f-4e56-8055-de6a04caf76a", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("3bc76635-530e-4843-8069-0fb26fb2cafe"), "eb26ccd1-7c61-40cf-add5-d3eab7470d58", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("ce8ff631-53c0-4f50-9f7b-30754068b659"), "37329520-cb4e-40f5-b8ae-456060940550", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("09c07f0f-89a4-4862-bd36-51ba81f2171b"), "15b458a3-447b-4576-990b-51ea2892bddd", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("85c8f48b-81cd-4e6d-be0f-c2c4759ad8c0"), "f16b7ce2-4ea5-427f-8237-4d16d2c758a3", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("72b0a7e4-608c-4da9-bc58-b878dbb37528"), "42c88455-7f62-4107-a06c-8d2b5b69eda7", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("e43e6415-22f3-4ab8-976f-be8aa0acbaef"), "02f16ce4-03b4-425a-9aa0-45fecc87d887", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("ae334846-d621-4e43-b48b-f121afe2ebf4"), "4d23a796-53b4-4683-87bb-40016239ad9a", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("053c13c3-64cf-40c0-be42-7a1af63fea7d"), "13903951-cd90-4c3c-b035-e8074f69e057", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "a6f3da1e-7973-452b-b9e0-72d7e1b9b2af");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "862e049c-d5cb-41e5-b9c8-93826e36641a");
        }
    }
}
