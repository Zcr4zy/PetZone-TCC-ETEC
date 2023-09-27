using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetZone.Migrations
{
    public partial class migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cep = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Numero = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Especie",
                columns: table => new
                {
                    EspecieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especie", x => x.EspecieId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GeneroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    RacaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EspecieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.RacaId);
                    table.ForeignKey(
                        name: "FK_Raca_Especie_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especie",
                        principalColumn: "EspecieId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Curiosidade",
                columns: table => new
                {
                    CuriosidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Imagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RacaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curiosidade", x => x.CuriosidadeId);
                    table.ForeignKey(
                        name: "FK_Curiosidade_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "RacaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    PetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Idade = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Peso = table.Column<decimal>(type: "decimal(6,3)", nullable: false),
                    ImgLink = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImgLinkII = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    RacaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ParaAdocao = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.PetId);
                    table.ForeignKey(
                        name: "FK_Pet_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Raca_RacaId",
                        column: x => x.RacaId,
                        principalTable: "Raca",
                        principalColumn: "RacaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ficha",
                columns: table => new
                {
                    FichaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Renda = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PedidoEnviado = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ficha", x => x.FichaId);
                    table.ForeignKey(
                        name: "FK_Ficha_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ficha_Pet_PetId",
                        column: x => x.PetId,
                        principalTable: "Pet",
                        principalColumn: "PetId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b38f8dbc-8e60-48ea-8fcc-bff6b6ffd177", "98c08d8e-c569-4cf0-a28f-f24a84199f23", "Administrador", "ADMINISTRADOR" },
                    { "bb15a281-2f5d-40f1-b333-16df28ec7bb2", "23d5a5cd-d973-4c78-83c3-c3744a5ad2be", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cep", "Cidade", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "Endereco", "Estado", "Foto", "LockoutEnabled", "LockoutEnd", "Nome", "NormalizedEmail", "NormalizedUserName", "Numero", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9133818c-90cf-4df8-99ad-54b28d5efa0d", 0, "17340-000", "Barra Bonita", "eb150f8a-9451-4ab0-a3ed-15810a14c12f", new DateTime(1985, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "joaofelipevt@gmail.com", true, "Sem Rua", "SP", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRqVELPNtwI_ED7sHhyFjuPqvRqcfl8VsByw&usqp=CAU", false, null, "Veterinário João", "JOAOFELIPEVT@GMAIL.COM", "JOAOFELIPEVT@GMAIL.COM", "(14) 981992299", "AQAAAAEAACcQAAAAEH45uxtr8HAzZXOvMmxOz244V41/l6lBDnO0j1kYQGte1jyTAwi17OHpz6c5fIrcQw==", null, false, "20074930", false, "joaofelipevt@gmail.com" },
                    { "95c1687a-5e1d-4679-9af7-32273fb40995", 0, "17352-464", "Igaraçu do Tietê", "bbf90bcc-289c-49b6-9f0d-ff7968d42125", new DateTime(1990, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "brunaalves@gmail.com", true, "Francisco Casamaximo", "SP", "https://img.freepik.com/vetores-premium/icone-de-mulher-feminina-de-mulher-de-negocios_24877-11467.jpg", false, null, "Bruna", "BRUNAALVES@GMAIL.COM", "BRUNAALVES@GMAIL.COM", "(14) 981883388", "AQAAAAEAACcQAAAAEHZyLQZLcl0saBsBUj9pCi8lB+8apn4YOp8VQUaLMJWzxR1xfFM+bhioDDQthK01jA==", null, false, "46456648", false, "brunaalves@gmail.com" },
                    { "b84621d3-b957-48f6-834e-518856afea6a", 0, "17345-280", "Barra Bonita", "78d1ef42-b0bb-4d0b-b968-46e440bca7fb", new DateTime(1995, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "elenasantos@gmail.com", true, "Antonio Destro ", "SP", "https://i.pinimg.com/736x/ff/24/59/ff2459fda1c779695df417283e2d02dd.jpg", false, null, "Elena", "ELENASANTOS@GMAIL.COM", "ELENASANTOS@GMAIL.COM", "(14) 981994499", "AQAAAAEAACcQAAAAEM504Er8oN3ti4HGve6JevqxBj2ZANYc8am/xOi6Im6fIY97Dff3+ScOKnoYK7fXZA==", null, false, "15456653", false, "elenasantos@gmail.com" },
                    { "d04396cc-4932-4aab-a858-bc92c83242c5", 0, "17340-000", "Barra Bonita", "d5eb449e-8388-4b62-aac4-dfeddd9166ff", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@petzone.com.br", true, "Sem Rua", "SP", "\\images\\usuarios\\avatar-01.jpg", false, null, "Administrador", "ADMIN@PETZONE.COM.BR", "ADMIN@PETZONE.COM.BR", "1", "AQAAAAEAACcQAAAAEL/yiQNNFc6Iuyx5pyPYzwYv29Ud03ol7ULd1fFmCrcVnMTx5s5GvuOSagSPCwuv1w==", null, false, "54426330", false, "admin@petzone.com.br" }
                });

            migrationBuilder.InsertData(
                table: "Especie",
                columns: new[] { "EspecieId", "Nome" },
                values: new object[,]
                {
                    { 1, "Gato" },
                    { 2, "Cachorro" }
                });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "GeneroId", "Nome" },
                values: new object[,]
                {
                    { 1, "Macho" },
                    { 2, "Fêmea" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bb15a281-2f5d-40f1-b333-16df28ec7bb2", "9133818c-90cf-4df8-99ad-54b28d5efa0d" },
                    { "bb15a281-2f5d-40f1-b333-16df28ec7bb2", "95c1687a-5e1d-4679-9af7-32273fb40995" },
                    { "bb15a281-2f5d-40f1-b333-16df28ec7bb2", "b84621d3-b957-48f6-834e-518856afea6a" },
                    { "b38f8dbc-8e60-48ea-8fcc-bff6b6ffd177", "d04396cc-4932-4aab-a858-bc92c83242c5" }
                });

            migrationBuilder.InsertData(
                table: "Raca",
                columns: new[] { "RacaId", "EspecieId", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Sem Raça Definida(Gato)" },
                    { 2, 1, "Siames(Gato)" },
                    { 3, 1, "Persa(Gato)" },
                    { 4, 1, "Pelo Curto Britânico(Gato)" },
                    { 5, 1, "Gato-de-Bengala(Gato)" },
                    { 6, 1, "Sphynx(Sem Pelo)(Gato)" },
                    { 7, 1, "Ragdoll(Gato)" },
                    { 8, 1, "Munchkin(Pernas Curtas)(Gato)" },
                    { 9, 1, "Angorá(Gato)" },
                    { 10, 1, "Siberiano(Gato)" },
                    { 11, 2, "Sem Raça Definida(Cachorro)" },
                    { 12, 2, "Poodle(Cachorro)" },
                    { 13, 2, "Pastor Alemão(Cachorro)" },
                    { 14, 2, "Pinscher(Cachorro)" },
                    { 15, 2, "Rottweiler(Cachorro)" },
                    { 16, 2, "Pug(Cachorro)" },
                    { 17, 2, "Buldogue(Cachorro)" },
                    { 18, 2, "Golden Retriever(Cachorro)" },
                    { 19, 2, "Chihuahua(Cachorro)" },
                    { 20, 2, "Dobermann(Cachorro)" }
                });

            migrationBuilder.InsertData(
                table: "Curiosidade",
                columns: new[] { "CuriosidadeId", "Descricao", "Imagem", "Nome", "RacaId" },
                values: new object[] { 1, "Aparentemente, nossos bichanos favoritos tem verdadeiras molas no lugar das patas, não é mesmo? O recorde mundial de pulo mais alto foi dado por um gato chamado Nyah-Suke, que vive no Japão, e conseguiu atingir uma altura de 1,96m de altura em seus pulos.", "https://hypescience.com/wp-content/uploads/2014/09/gatos-pulando-como-ninjas-10.jpg", "O salto de um gato pode ter até 5 vezes a sua altura", 1 });

            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "PetId", "Descricao", "GeneroId", "Idade", "ImgLink", "ImgLinkII", "Nome", "ParaAdocao", "Peso", "RacaId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "Minha gata deu a luz para 5 filhotes e esta é uma das filhotes que nasceu. Ela é muito dócil, carismática e amorosa. Infelizmente não tenho condições de cuidar dela.", 2, "1 mês e 2 semanas", "https://blog.cobasi.com.br/wp-content/webpc-passthru.php?src=https://blog.cobasi.com.br/wp-content/uploads/2020/07/gato-siames-filhote.png&nocache=1", "sdsds", "Pérola", true, 0m, 2, "95c1687a-5e1d-4679-9af7-32273fb40995" },
                    { 2, "Encontrado nas ruas de Igaraçu do Tietê perdido, com fome e buscando abrigo. Estou cuidando dele por um tempo, mas não tenho muita condição de mante-lo aqui.", 1, null, "https://cdn.osaogoncalo.com.br/img/normal/50000/0x0/IMG_2848_00053927_0-ScaleDownProportional.webp?fallback=https%3A%2F%2Fcdn.osaogoncalo.com.br%2Fimg%2Fnormal%2F50000%2FIMG_2848_00053927_0.jpg%3Fxid%3D126598%26resize%3D1000%252C500%26t%3D1655066037&xid=126598", "", null, true, 0m, 12, "d04396cc-4932-4aab-a858-bc92c83242c5" },
                    { 3, "Eu e minha família estamos de mudança e não conseguiremos levá-lo conosco. Estamos buscando um novo tutor que seja responsável, tenha condições de mante-lo e que cuide muito bem dele, dando o máximo de atenção e amor o possível. Bart é muito carinhoso, ama dormir na cama e não traz nenhum tipo de prejuízo.", 1, "1 ano e 5 meses", "https://midias.gazetaonline.com.br/_midias/jpg/2017/10/23/gato-5337982.jpg", "", "Bart", true, 0m, 1, "b84621d3-b957-48f6-834e-518856afea6a" },
                    { 4, "Olha só quem está para adoção! A pequena Mel foi encontrada em Barra Bonita toda machucada e abandonada, mas com a ajuda dos profissionais da BraPaws, ela se recuperou e está 100% pronta para arrumar uma nova família que dê a ela muito amor e carinho.", 2, "9 meses", "https://agenciabrasilia.df.gov.br/wp-conteudo/uploads/2022/11/CAPA-53-scaled.jpg", "", "Mel", true, 2m, 11, "9133818c-90cf-4df8-99ad-54b28d5efa0d" },
                    { 5, "Encontrada perto do SESI em Igaraçu do Tiête, estava abandonada e toda machucada. Estamos fornecendo abrigo para ela por um tempo até encontrar um(a) novo(a) tutor(a) para ela.", 1, null, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqYr24d2R8HOdSPqXW1EnHtvGXek1-HYrJJg&usqp=CAU", "", null, true, 0m, 6, "d04396cc-4932-4aab-a858-bc92c83242c5" },
                    { 6, "O antigo dono queria abandona-lo porque não possuía tempo para cuidar, brincar e dar atenção a Mike. Vendo isso, não deixamos que o mesmo simplesmente jogasse Mike em qualquer lugar e, pegamos este lindo caramelo para cuidar e colocar para Adoção. Mike é muito imperativo e gosta muito de atenção. ", 1, "Possui mais ou menos 2 anos e meio", "https://www.bnews.com.br/media/_versions/legacy/fotos/bocao_noticias/306181/mg/vira-lata-caramelo-mobiliza-bombeiros-apos-ficar-com-cabeca-presa-em-buraco-apos-tentar-espiar-a-vizinha-2._widexl.jpg", "https://static1.patasdacasa.com.br/articles/1/22/71/@/16746-meme-historia-de-pipi-nao-so-virou-vira-articles_media_mobile-5.jpg", "Mike", true, 6m, 11, "9133818c-90cf-4df8-99ad-54b28d5efa0d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Curiosidade_RacaId",
                table: "Curiosidade",
                column: "RacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ficha_PetId",
                table: "Ficha",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Ficha_UsuarioId",
                table: "Ficha",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_GeneroId",
                table: "Pet",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_RacaId",
                table: "Pet",
                column: "RacaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_UsuarioId",
                table: "Pet",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Raca_EspecieId",
                table: "Raca",
                column: "EspecieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Curiosidade");

            migrationBuilder.DropTable(
                name: "Ficha");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Raca");

            migrationBuilder.DropTable(
                name: "Especie");
        }
    }
}
