﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetZone.Data;

#nullable disable

namespace PetZone.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221202173349_migracao")]
    partial class migracao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b38f8dbc-8e60-48ea-8fcc-bff6b6ffd177",
                            ConcurrencyStamp = "98c08d8e-c569-4cf0-a28f-f24a84199f23",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "bb15a281-2f5d-40f1-b333-16df28ec7bb2",
                            ConcurrencyStamp = "23d5a5cd-d973-4c78-83c3-c3744a5ad2be",
                            Name = "Usuario",
                            NormalizedName = "USUARIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "d04396cc-4932-4aab-a858-bc92c83242c5",
                            RoleId = "b38f8dbc-8e60-48ea-8fcc-bff6b6ffd177"
                        },
                        new
                        {
                            UserId = "9133818c-90cf-4df8-99ad-54b28d5efa0d",
                            RoleId = "bb15a281-2f5d-40f1-b333-16df28ec7bb2"
                        },
                        new
                        {
                            UserId = "95c1687a-5e1d-4679-9af7-32273fb40995",
                            RoleId = "bb15a281-2f5d-40f1-b333-16df28ec7bb2"
                        },
                        new
                        {
                            UserId = "b84621d3-b957-48f6-834e-518856afea6a",
                            RoleId = "bb15a281-2f5d-40f1-b333-16df28ec7bb2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PetZone.Models.Curiosidade", b =>
                {
                    b.Property<int>("CuriosidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Imagem")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RacaId")
                        .HasColumnType("int");

                    b.HasKey("CuriosidadeId");

                    b.HasIndex("RacaId");

                    b.ToTable("Curiosidade");

                    b.HasData(
                        new
                        {
                            CuriosidadeId = 1,
                            Descricao = "Aparentemente, nossos bichanos favoritos tem verdadeiras molas no lugar das patas, não é mesmo? O recorde mundial de pulo mais alto foi dado por um gato chamado Nyah-Suke, que vive no Japão, e conseguiu atingir uma altura de 1,96m de altura em seus pulos.",
                            Imagem = "https://hypescience.com/wp-content/uploads/2014/09/gatos-pulando-como-ninjas-10.jpg",
                            Nome = "O salto de um gato pode ter até 5 vezes a sua altura",
                            RacaId = 1
                        });
                });

            modelBuilder.Entity("PetZone.Models.Especie", b =>
                {
                    b.Property<int>("EspecieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EspecieId");

                    b.ToTable("Especie");

                    b.HasData(
                        new
                        {
                            EspecieId = 1,
                            Nome = "Gato"
                        },
                        new
                        {
                            EspecieId = 2,
                            Nome = "Cachorro"
                        });
                });

            modelBuilder.Entity("PetZone.Models.Ficha", b =>
                {
                    b.Property<int>("FichaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Motivo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("PedidoEnviado")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<decimal>("Renda")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("FichaId");

                    b.HasIndex("PetId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Ficha");
                });

            modelBuilder.Entity("PetZone.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("GeneroId");

                    b.ToTable("Genero");

                    b.HasData(
                        new
                        {
                            GeneroId = 1,
                            Nome = "Macho"
                        },
                        new
                        {
                            GeneroId = 2,
                            Nome = "Fêmea"
                        });
                });

            modelBuilder.Entity("PetZone.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Idade")
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ImgLink")
                        .HasColumnType("longtext");

                    b.Property<string>("ImgLinkII")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("ParaAdocao")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Peso")
                        .HasColumnType("decimal(6,3)");

                    b.Property<int>("RacaId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("PetId");

                    b.HasIndex("GeneroId");

                    b.HasIndex("RacaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pet");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            Descricao = "Minha gata deu a luz para 5 filhotes e esta é uma das filhotes que nasceu. Ela é muito dócil, carismática e amorosa. Infelizmente não tenho condições de cuidar dela.",
                            GeneroId = 2,
                            Idade = "1 mês e 2 semanas",
                            ImgLink = "https://blog.cobasi.com.br/wp-content/webpc-passthru.php?src=https://blog.cobasi.com.br/wp-content/uploads/2020/07/gato-siames-filhote.png&nocache=1",
                            ImgLinkII = "sdsds",
                            Nome = "Pérola",
                            ParaAdocao = true,
                            Peso = 0m,
                            RacaId = 2,
                            UsuarioId = "95c1687a-5e1d-4679-9af7-32273fb40995"
                        },
                        new
                        {
                            PetId = 2,
                            Descricao = "Encontrado nas ruas de Igaraçu do Tietê perdido, com fome e buscando abrigo. Estou cuidando dele por um tempo, mas não tenho muita condição de mante-lo aqui.",
                            GeneroId = 1,
                            ImgLink = "https://cdn.osaogoncalo.com.br/img/normal/50000/0x0/IMG_2848_00053927_0-ScaleDownProportional.webp?fallback=https%3A%2F%2Fcdn.osaogoncalo.com.br%2Fimg%2Fnormal%2F50000%2FIMG_2848_00053927_0.jpg%3Fxid%3D126598%26resize%3D1000%252C500%26t%3D1655066037&xid=126598",
                            ImgLinkII = "",
                            ParaAdocao = true,
                            Peso = 0m,
                            RacaId = 12,
                            UsuarioId = "d04396cc-4932-4aab-a858-bc92c83242c5"
                        },
                        new
                        {
                            PetId = 3,
                            Descricao = "Eu e minha família estamos de mudança e não conseguiremos levá-lo conosco. Estamos buscando um novo tutor que seja responsável, tenha condições de mante-lo e que cuide muito bem dele, dando o máximo de atenção e amor o possível. Bart é muito carinhoso, ama dormir na cama e não traz nenhum tipo de prejuízo.",
                            GeneroId = 1,
                            Idade = "1 ano e 5 meses",
                            ImgLink = "https://midias.gazetaonline.com.br/_midias/jpg/2017/10/23/gato-5337982.jpg",
                            ImgLinkII = "",
                            Nome = "Bart",
                            ParaAdocao = true,
                            Peso = 0m,
                            RacaId = 1,
                            UsuarioId = "b84621d3-b957-48f6-834e-518856afea6a"
                        },
                        new
                        {
                            PetId = 4,
                            Descricao = "Olha só quem está para adoção! A pequena Mel foi encontrada em Barra Bonita toda machucada e abandonada, mas com a ajuda dos profissionais da BraPaws, ela se recuperou e está 100% pronta para arrumar uma nova família que dê a ela muito amor e carinho.",
                            GeneroId = 2,
                            Idade = "9 meses",
                            ImgLink = "https://agenciabrasilia.df.gov.br/wp-conteudo/uploads/2022/11/CAPA-53-scaled.jpg",
                            ImgLinkII = "",
                            Nome = "Mel",
                            ParaAdocao = true,
                            Peso = 2m,
                            RacaId = 11,
                            UsuarioId = "9133818c-90cf-4df8-99ad-54b28d5efa0d"
                        },
                        new
                        {
                            PetId = 5,
                            Descricao = "Encontrada perto do SESI em Igaraçu do Tiête, estava abandonada e toda machucada. Estamos fornecendo abrigo para ela por um tempo até encontrar um(a) novo(a) tutor(a) para ela.",
                            GeneroId = 1,
                            ImgLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqYr24d2R8HOdSPqXW1EnHtvGXek1-HYrJJg&usqp=CAU",
                            ImgLinkII = "",
                            ParaAdocao = true,
                            Peso = 0m,
                            RacaId = 6,
                            UsuarioId = "d04396cc-4932-4aab-a858-bc92c83242c5"
                        },
                        new
                        {
                            PetId = 6,
                            Descricao = "O antigo dono queria abandona-lo porque não possuía tempo para cuidar, brincar e dar atenção a Mike. Vendo isso, não deixamos que o mesmo simplesmente jogasse Mike em qualquer lugar e, pegamos este lindo caramelo para cuidar e colocar para Adoção. Mike é muito imperativo e gosta muito de atenção. ",
                            GeneroId = 1,
                            Idade = "Possui mais ou menos 2 anos e meio",
                            ImgLink = "https://www.bnews.com.br/media/_versions/legacy/fotos/bocao_noticias/306181/mg/vira-lata-caramelo-mobiliza-bombeiros-apos-ficar-com-cabeca-presa-em-buraco-apos-tentar-espiar-a-vizinha-2._widexl.jpg",
                            ImgLinkII = "https://static1.patasdacasa.com.br/articles/1/22/71/@/16746-meme-historia-de-pipi-nao-so-virou-vira-articles_media_mobile-5.jpg",
                            Nome = "Mike",
                            ParaAdocao = true,
                            Peso = 6m,
                            RacaId = 11,
                            UsuarioId = "9133818c-90cf-4df8-99ad-54b28d5efa0d"
                        });
                });

            modelBuilder.Entity("PetZone.Models.Raca", b =>
                {
                    b.Property<int>("RacaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EspecieId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("RacaId");

                    b.HasIndex("EspecieId");

                    b.ToTable("Raca");

                    b.HasData(
                        new
                        {
                            RacaId = 1,
                            EspecieId = 1,
                            Nome = "Sem Raça Definida(Gato)"
                        },
                        new
                        {
                            RacaId = 2,
                            EspecieId = 1,
                            Nome = "Siames(Gato)"
                        },
                        new
                        {
                            RacaId = 3,
                            EspecieId = 1,
                            Nome = "Persa(Gato)"
                        },
                        new
                        {
                            RacaId = 4,
                            EspecieId = 1,
                            Nome = "Pelo Curto Britânico(Gato)"
                        },
                        new
                        {
                            RacaId = 5,
                            EspecieId = 1,
                            Nome = "Gato-de-Bengala(Gato)"
                        },
                        new
                        {
                            RacaId = 6,
                            EspecieId = 1,
                            Nome = "Sphynx(Sem Pelo)(Gato)"
                        },
                        new
                        {
                            RacaId = 7,
                            EspecieId = 1,
                            Nome = "Ragdoll(Gato)"
                        },
                        new
                        {
                            RacaId = 8,
                            EspecieId = 1,
                            Nome = "Munchkin(Pernas Curtas)(Gato)"
                        },
                        new
                        {
                            RacaId = 9,
                            EspecieId = 1,
                            Nome = "Angorá(Gato)"
                        },
                        new
                        {
                            RacaId = 10,
                            EspecieId = 1,
                            Nome = "Siberiano(Gato)"
                        },
                        new
                        {
                            RacaId = 11,
                            EspecieId = 2,
                            Nome = "Sem Raça Definida(Cachorro)"
                        },
                        new
                        {
                            RacaId = 12,
                            EspecieId = 2,
                            Nome = "Poodle(Cachorro)"
                        },
                        new
                        {
                            RacaId = 13,
                            EspecieId = 2,
                            Nome = "Pastor Alemão(Cachorro)"
                        },
                        new
                        {
                            RacaId = 14,
                            EspecieId = 2,
                            Nome = "Pinscher(Cachorro)"
                        },
                        new
                        {
                            RacaId = 15,
                            EspecieId = 2,
                            Nome = "Rottweiler(Cachorro)"
                        },
                        new
                        {
                            RacaId = 16,
                            EspecieId = 2,
                            Nome = "Pug(Cachorro)"
                        },
                        new
                        {
                            RacaId = 17,
                            EspecieId = 2,
                            Nome = "Buldogue(Cachorro)"
                        },
                        new
                        {
                            RacaId = 18,
                            EspecieId = 2,
                            Nome = "Golden Retriever(Cachorro)"
                        },
                        new
                        {
                            RacaId = 19,
                            EspecieId = 2,
                            Nome = "Chihuahua(Cachorro)"
                        },
                        new
                        {
                            RacaId = 20,
                            EspecieId = 2,
                            Nome = "Dobermann(Cachorro)"
                        });
                });

            modelBuilder.Entity("PetZone.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Foto")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d04396cc-4932-4aab-a858-bc92c83242c5",
                            AccessFailedCount = 0,
                            Cep = "17340-000",
                            Cidade = "Barra Bonita",
                            ConcurrencyStamp = "d5eb449e-8388-4b62-aac4-dfeddd9166ff",
                            DataNascimento = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@petzone.com.br",
                            EmailConfirmed = true,
                            Endereco = "Sem Rua",
                            Estado = "SP",
                            Foto = "\\images\\usuarios\\avatar-01.jpg",
                            LockoutEnabled = false,
                            Nome = "Administrador",
                            NormalizedEmail = "ADMIN@PETZONE.COM.BR",
                            NormalizedUserName = "ADMIN@PETZONE.COM.BR",
                            Numero = "1",
                            PasswordHash = "AQAAAAEAACcQAAAAEL/yiQNNFc6Iuyx5pyPYzwYv29Ud03ol7ULd1fFmCrcVnMTx5s5GvuOSagSPCwuv1w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "54426330",
                            TwoFactorEnabled = false,
                            UserName = "admin@petzone.com.br"
                        },
                        new
                        {
                            Id = "9133818c-90cf-4df8-99ad-54b28d5efa0d",
                            AccessFailedCount = 0,
                            Cep = "17340-000",
                            Cidade = "Barra Bonita",
                            ConcurrencyStamp = "eb150f8a-9451-4ab0-a3ed-15810a14c12f",
                            DataNascimento = new DateTime(1985, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "joaofelipevt@gmail.com",
                            EmailConfirmed = true,
                            Endereco = "Sem Rua",
                            Estado = "SP",
                            Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRqVELPNtwI_ED7sHhyFjuPqvRqcfl8VsByw&usqp=CAU",
                            LockoutEnabled = false,
                            Nome = "Veterinário João",
                            NormalizedEmail = "JOAOFELIPEVT@GMAIL.COM",
                            NormalizedUserName = "JOAOFELIPEVT@GMAIL.COM",
                            Numero = "(14) 981992299",
                            PasswordHash = "AQAAAAEAACcQAAAAEH45uxtr8HAzZXOvMmxOz244V41/l6lBDnO0j1kYQGte1jyTAwi17OHpz6c5fIrcQw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "20074930",
                            TwoFactorEnabled = false,
                            UserName = "joaofelipevt@gmail.com"
                        },
                        new
                        {
                            Id = "95c1687a-5e1d-4679-9af7-32273fb40995",
                            AccessFailedCount = 0,
                            Cep = "17352-464",
                            Cidade = "Igaraçu do Tietê",
                            ConcurrencyStamp = "bbf90bcc-289c-49b6-9f0d-ff7968d42125",
                            DataNascimento = new DateTime(1990, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "brunaalves@gmail.com",
                            EmailConfirmed = true,
                            Endereco = "Francisco Casamaximo",
                            Estado = "SP",
                            Foto = "https://img.freepik.com/vetores-premium/icone-de-mulher-feminina-de-mulher-de-negocios_24877-11467.jpg",
                            LockoutEnabled = false,
                            Nome = "Bruna",
                            NormalizedEmail = "BRUNAALVES@GMAIL.COM",
                            NormalizedUserName = "BRUNAALVES@GMAIL.COM",
                            Numero = "(14) 981883388",
                            PasswordHash = "AQAAAAEAACcQAAAAEHZyLQZLcl0saBsBUj9pCi8lB+8apn4YOp8VQUaLMJWzxR1xfFM+bhioDDQthK01jA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "46456648",
                            TwoFactorEnabled = false,
                            UserName = "brunaalves@gmail.com"
                        },
                        new
                        {
                            Id = "b84621d3-b957-48f6-834e-518856afea6a",
                            AccessFailedCount = 0,
                            Cep = "17345-280",
                            Cidade = "Barra Bonita",
                            ConcurrencyStamp = "78d1ef42-b0bb-4d0b-b968-46e440bca7fb",
                            DataNascimento = new DateTime(1995, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "elenasantos@gmail.com",
                            EmailConfirmed = true,
                            Endereco = "Antonio Destro ",
                            Estado = "SP",
                            Foto = "https://i.pinimg.com/736x/ff/24/59/ff2459fda1c779695df417283e2d02dd.jpg",
                            LockoutEnabled = false,
                            Nome = "Elena",
                            NormalizedEmail = "ELENASANTOS@GMAIL.COM",
                            NormalizedUserName = "ELENASANTOS@GMAIL.COM",
                            Numero = "(14) 981994499",
                            PasswordHash = "AQAAAAEAACcQAAAAEM504Er8oN3ti4HGve6JevqxBj2ZANYc8am/xOi6Im6fIY97Dff3+ScOKnoYK7fXZA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "15456653",
                            TwoFactorEnabled = false,
                            UserName = "elenasantos@gmail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PetZone.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PetZone.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetZone.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PetZone.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PetZone.Models.Curiosidade", b =>
                {
                    b.HasOne("PetZone.Models.Raca", "Raca")
                        .WithMany()
                        .HasForeignKey("RacaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raca");
                });

            modelBuilder.Entity("PetZone.Models.Ficha", b =>
                {
                    b.HasOne("PetZone.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetZone.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PetZone.Models.Pet", b =>
                {
                    b.HasOne("PetZone.Models.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetZone.Models.Raca", "Raca")
                        .WithMany()
                        .HasForeignKey("RacaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetZone.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Raca");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("PetZone.Models.Raca", b =>
                {
                    b.HasOne("PetZone.Models.Especie", "Especie")
                        .WithMany()
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Especie");
                });
#pragma warning restore 612, 618
        }
    }
}
