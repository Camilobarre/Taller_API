using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taller.Migrations
{
    /// <inheritdoc />
    public partial class CrearFakers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "propietarios",
                columns: new[] { "Id", "Apellido", "Correo", "Direccion", "FotoPerfil", "Nombre", "NumeroIdentificaion", "Telefono" },
                values: new object[,]
                {
                    { 1, "Zemlak", "Luella15@yahoo.com", "6586 Ethelyn Springs, East Addie, Lithuania", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/317.jpg", "Cara", "vi6inbbujw", "(526) 203-8157 x19449" },
                    { 2, "Beahan", "Victor_Runte@hotmail.com", "2704 Nienow Garden, Wizaburgh, Costa Rica", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/645.jpg", "Maiya", "g0nr5ec37g", "(684) 483-2537" },
                    { 3, "Legros", "Wilfredo5@hotmail.com", "35330 Sim Parks, New Dustybury, French Southern Territories", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/949.jpg", "Litzy", "nlkpihhfc0", "(461) 790-9044 x495" },
                    { 4, "Homenick", "Clemens96@yahoo.com", "2590 Hobart Inlet, East Wendell, Suriname", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/950.jpg", "Josephine", "it66feevy5", "891.847.6218 x85874" },
                    { 5, "Schimmel", "Coleman41@hotmail.com", "80680 Earline Parkway, Port Chelsey, Dominican Republic", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1056.jpg", "Raleigh", "3vtis9dr4l", "1-566-570-9949" },
                    { 6, "Kutch", "Jacklyn69@gmail.com", "2085 Benedict Fords, Ovastad, Republic of Korea", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/999.jpg", "Leola", "yhyetifr4c", "523.998.5217 x2255" },
                    { 7, "Hansen", "Justyn_Wintheiser@hotmail.com", "03066 Leif Ways, Schowalterfurt, Antarctica (the territory South of 60 deg S)", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1080.jpg", "Cruz", "kcn99gauyv", "1-711-241-6708" },
                    { 8, "Grant", "Bennett.Armstrong@gmail.com", "3771 Jensen Alley, Towneburgh, Chile", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/254.jpg", "Shaniya", "wfcehq5iwn", "(517) 329-3140" },
                    { 9, "Bergnaum", "Marilyne.Brekke@gmail.com", "475 Johnson Corner, Dietrichmouth, South Africa", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/737.jpg", "Neal", "p7f2sdfq7i", "306-284-7590" },
                    { 10, "Leuschke", "Adelbert_Bauch64@yahoo.com", "34660 Kenna Tunnel, New Baronhaven, Pakistan", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1075.jpg", "Gussie", "es27ujkk76", "696-802-7141 x081" },
                    { 11, "Grimes", "Marquise.Nicolas@yahoo.com", "714 Schumm Mountain, Iciehaven, Nigeria", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/123.jpg", "Roman", "nas7nyu6v9", "(799) 536-6151 x91511" },
                    { 12, "Schamberger", "Jessie63@gmail.com", "416 Valentine Center, New Ada, French Guiana", "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/120.jpg", "Aurelia", "r9amn7y5ld", "610-998-7943 x6544" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "propietarios",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
