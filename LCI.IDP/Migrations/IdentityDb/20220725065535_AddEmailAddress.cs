using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LCI.IDP.Migrations.IdentityDb
{
    public partial class AddEmailAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0d0d1946-b04f-40a9-ab26-01b9348e2e65"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0d8cab17-6882-48ba-9f05-e8af4f3fa21a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("209d3f7a-f1a7-4f31-bc7e-39cb2ec360cd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("396d5d5c-c1e7-497f-b38d-527f7171b59a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("3b7ef136-9eb4-41ea-b9cd-fa49a34a2fb4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6c4bdca4-536c-4c3f-b925-9e1a5744c249"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7007543d-308a-463d-87fe-b6e7b49b20f0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7217bb4d-26a7-44b9-8f5f-cc309d1ebcc4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7dee54d5-70d0-4747-8519-48116e054dbe"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("de761efe-dd62-4323-a934-398bf624935e"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "datetime2",
                maxLength: 200,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("7007543d-308a-463d-87fe-b6e7b49b20f0"), "b3971d55-a2a5-4b8b-b86d-764fd3fc9c1d", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Frank" },
                    { new Guid("de761efe-dd62-4323-a934-398bf624935e"), "c98aa5e4-333f-4a61-8eb5-10e76917a979", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Underwood" },
                    { new Guid("396d5d5c-c1e7-497f-b38d-527f7171b59a"), "99fa348f-6a1e-4ba5-9b20-97ba603cd0d3", "address", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Main Road 1" },
                    { new Guid("6c4bdca4-536c-4c3f-b925-9e1a5744c249"), "44d35261-79d0-45f3-b7b6-a9e3bd3db2dc", "subscriptionlevel", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("0d8cab17-6882-48ba-9f05-e8af4f3fa21a"), "5b8509e4-4ed0-4a1d-8229-40760e9adcd8", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("209d3f7a-f1a7-4f31-bc7e-39cb2ec360cd"), "2f688db6-bf1e-4262-a099-67b2741467cf", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Claire" },
                    { new Guid("0d0d1946-b04f-40a9-ab26-01b9348e2e65"), "fd10d18f-a0de-49ad-aeaf-4429f7bbf24b", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Underwood" },
                    { new Guid("7dee54d5-70d0-4747-8519-48116e054dbe"), "e75de716-c697-40c1-b7e7-6d6d00117780", "address", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Big Street 2" },
                    { new Guid("3b7ef136-9eb4-41ea-b9cd-fa49a34a2fb4"), "31245aae-f068-4d98-9240-7fe0ae3443de", "subscriptionlevel", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("7217bb4d-26a7-44b9-8f5f-cc309d1ebcc4"), "b5b80b08-3891-48b0-a639-10da02ebbd56", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "ae2531c3-7bd8-419d-b228-2504a915c246");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "f44e94e7-ad7e-4b01-9e21-c4214b303acd");
        }
    }
}
