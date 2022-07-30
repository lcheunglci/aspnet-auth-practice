using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCI.IDP.Migrations.IdentityDb
{
    public partial class AddUserLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3e40e822-d4dc-49f2-aeb3-69dd649bbfe8"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("543bc5c2-8835-42eb-9b25-678491cbbd9b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("68589884-db29-4d86-a329-41839b9b2de4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("821615cc-b4b7-47b5-b994-a4f60c8ec1bd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("87570941-6a26-47dd-876f-79bd22239a59"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8f363e62-6d10-4dcc-a4c6-2075a857476a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9f358c54-1673-47d9-b668-58561d57a84b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ae90a133-a549-4c12-9dc3-2bb9c18a153a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ca786da0-dbe3-4624-8e9c-f2a9325cbfac"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("edeab107-0329-496f-92d6-75a107e5c980"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f2db616c-20f3-4e5e-81d6-11e5b9d524f0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f52d760e-71f2-4d67-abbd-6c8884790283"));

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Provider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
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

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

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

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("821615cc-b4b7-47b5-b994-a4f60c8ec1bd"), "eef1aa36-0a3d-4c41-9965-98fc6e2c2a9e", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("68589884-db29-4d86-a329-41839b9b2de4"), "a8135fa4-8d04-4a6e-8303-eba595b7cb69", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("ae90a133-a549-4c12-9dc3-2bb9c18a153a"), "05f636fb-15d1-4be4-a141-f66526e80d22", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("87570941-6a26-47dd-876f-79bd22239a59"), "6d635492-4dd4-476d-8d0b-d18b03dd5fdc", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("ca786da0-dbe3-4624-8e9c-f2a9325cbfac"), "ccda7817-a2bf-4314-9262-3b1eb8a7dfff", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("543bc5c2-8835-42eb-9b25-678491cbbd9b"), "80762117-37f4-40b0-b262-578bbbb05324", "email", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "frank@someprovider.com" },
                    { new Guid("3e40e822-d4dc-49f2-aeb3-69dd649bbfe8"), "7f3dc21c-efe2-4d5d-bc1b-35b3a44fc6a7", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("f2db616c-20f3-4e5e-81d6-11e5b9d524f0"), "3fc92abb-2d1a-4bb8-942a-593528d89d64", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("edeab107-0329-496f-92d6-75a107e5c980"), "6d433450-d2b4-42a0-a9ed-17258cd18555", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("8f363e62-6d10-4dcc-a4c6-2075a857476a"), "839b9a6f-3835-4925-a055-3b0e7be7b2ee", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("f52d760e-71f2-4d67-abbd-6c8884790283"), "c7a94446-ee28-4bf9-afed-df8e7a448bb5", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("9f358c54-1673-47d9-b668-58561d57a84b"), "4b8f0d92-f2e7-4e9a-be36-4f07ec259591", "email", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "claire@someprovider.com" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "2dde4399-0c55-40cc-a521-00c2b4d07f32");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "a27ecb20-d0a1-4e9c-8a50-b704d17b775e");
        }
    }
}
