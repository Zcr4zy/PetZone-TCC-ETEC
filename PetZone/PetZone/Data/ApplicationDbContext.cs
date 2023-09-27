using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetZone.Models;
using System.Reflection.Emit;
using System.Security.Claims;

namespace PetZone.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Curiosidade> Curiosidades { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Ficha> Fichas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Cadastrar Generos
            List<Genero> generos = new()
            {
                new Genero()
                {
                    GeneroId = 1,
                    Nome = "Macho"
                },
                new Genero()
                {
                    GeneroId = 2,
                    Nome = "Fêmea"
                }
            };
            builder.Entity<Genero>().HasData(generos);
            #endregion

            #region Cadastrar Especies
            List<Especie> especies = new()
            {
                new Especie()
                {
                    EspecieId = 1,
                    Nome = "Gato"
                },
                new Especie()
                {
                    EspecieId = 2,
                    Nome = "Cachorro"
                }
            };
            builder.Entity<Especie>().HasData(especies);
            #endregion

            #region Cadastrar Raças
            List<Raca> racas = new()
            {
                new Raca()
                {
                    RacaId = 1,
                    EspecieId = 1,
                    Nome = "Sem Raça Definida(Gato)"
                },

                new Raca()
                {
                    RacaId = 2,
                    EspecieId = 1,
                    Nome = "Siames(Gato)"
                },

                new Raca()
                {
                    RacaId= 3,
                    EspecieId= 1,
                    Nome= "Persa(Gato)"
                },

                new Raca()
                {
                    RacaId= 4,
                    EspecieId= 1,
                    Nome= "Pelo Curto Britânico(Gato)"
                },

                new Raca()
                {
                    RacaId= 5,
                    EspecieId= 1,
                    Nome= "Gato-de-Bengala(Gato)"
                },

                new Raca()
                {
                    RacaId= 6,
                    EspecieId= 1,
                    Nome= "Sphynx(Sem Pelo)(Gato)"
                },

                new Raca()
                {
                    RacaId= 7,
                    EspecieId= 1,
                    Nome= "Ragdoll(Gato)"
                },

                new Raca()
                {
                    RacaId= 8,
                    EspecieId= 1,
                    Nome= "Munchkin(Pernas Curtas)(Gato)"
                },

                new Raca()
                {
                    RacaId= 9,
                    EspecieId= 1,
                    Nome= "Angorá(Gato)"
                },

                new Raca()
                {
                    RacaId= 10,
                    EspecieId= 1,
                    Nome= "Siberiano(Gato)"
                },



                new Raca()
                {
                    RacaId = 11,
                    EspecieId = 2,
                    Nome = "Sem Raça Definida(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 12,
                    EspecieId = 2,
                    Nome = "Poodle(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 13,
                    EspecieId = 2,
                    Nome = "Pastor Alemão(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 14,
                    EspecieId = 2,
                    Nome = "Pinscher(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 15,
                    EspecieId = 2,
                    Nome = "Rottweiler(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 16,
                    EspecieId = 2,
                    Nome = "Pug(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 17,
                    EspecieId = 2,
                    Nome = "Buldogue(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 18,
                    EspecieId = 2,
                    Nome = "Golden Retriever(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 19,
                    EspecieId = 2,
                    Nome = "Chihuahua(Cachorro)"
                },

                new Raca()
                {
                    RacaId = 20,
                    EspecieId = 2,
                    Nome = "Dobermann(Cachorro)"
                },

            };
            builder.Entity<Raca>().HasData(racas);
            #endregion

            #region Cadastrar Perfis 
            var roles = new List<IdentityRole>(){
                new IdentityRole{
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR"
                },
                new IdentityRole{
                    Id = Guid.NewGuid().ToString(),
                    Name = "Usuario",
                    NormalizedName = "USUARIO"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
            #endregion

            #region Cadastrar Usuario
            var hash = new PasswordHasher<Usuario>();
            var hash2 = new PasswordHasher<Usuario>();
            var hash3 = new PasswordHasher<Usuario>();
            var hash4 = new PasswordHasher<Usuario>();
            var users = new List<Usuario>(){
                new Usuario{
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Administrador",
                    UserName = "admin@petzone.com.br",
                    NormalizedUserName = "ADMIN@PETZONE.COM.BR",
                    Email = "admin@petzone.com.br",
                    NormalizedEmail = "ADMIN@PETZONE.COM.BR",
                    EmailConfirmed = true,
                    PasswordHash = hash.HashPassword(null, "123456"),
                    SecurityStamp = hash.GetHashCode().ToString(),
                    DataNascimento = DateTime.Parse("01/01/2000"),
                    Cep = "17340-000",
                    Cidade = "Barra Bonita",
                    Endereco = "Sem Rua",
                    Estado = "SP",
                    Numero = "1",
                    Foto = @"\images\Logo.png"
                },
                new Usuario
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Veterinário João",
                    UserName = "joaofelipevt@gmail.com",
                    NormalizedUserName = "JOAOFELIPEVT@GMAIL.COM",
                    Email = "joaofelipevt@gmail.com",
                    NormalizedEmail = "JOAOFELIPEVT@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash2.HashPassword(null, "1234567"),
                    SecurityStamp = hash2.GetHashCode().ToString(),
                    DataNascimento = DateTime.Parse("05/08/1985"),
                    Cep = "17340-000",
                    Cidade = "Barra Bonita",
                    Endereco = "Sem Rua",
                    Estado = "SP",
                    Numero = "(14) 981992299",
                    Foto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRRqVELPNtwI_ED7sHhyFjuPqvRqcfl8VsByw&usqp=CAU"
                },

                new Usuario
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Bruna",
                    UserName = "brunaalves@gmail.com",
                    NormalizedUserName = "BRUNAALVES@GMAIL.COM",
                    Email = "brunaalves@gmail.com",
                    NormalizedEmail = "BRUNAALVES@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash3.HashPassword(null, "12345678"),
                    SecurityStamp = hash3.GetHashCode().ToString(),
                    DataNascimento = DateTime.Parse("06/09/1990"),
                    Cep = "17352-464",
                    Cidade = "Igaraçu do Tietê",
                    Endereco = "Francisco Casamaximo",
                    Estado = "SP",
                    Numero = "(14) 981883388",
                    Foto = "https://img.freepik.com/vetores-premium/icone-de-mulher-feminina-de-mulher-de-negocios_24877-11467.jpg"
                },

                new Usuario
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Elena",
                    UserName = "elenasantos@gmail.com",
                    NormalizedUserName = "ELENASANTOS@GMAIL.COM",
                    Email = "elenasantos@gmail.com",
                    NormalizedEmail = "ELENASANTOS@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hash4.HashPassword(null, "12345678"),
                    SecurityStamp = hash4.GetHashCode().ToString(),
                    DataNascimento = DateTime.Parse("06/09/1995"),
                    Cep = "17345-280",
                    Cidade = "Barra Bonita",
                    Endereco = "Antonio Destro ",
                    Estado = "SP",
                    Numero = "(14) 981994499",
                    Foto = "https://i.pinimg.com/736x/ff/24/59/ff2459fda1c779695df417283e2d02dd.jpg"
                }
            };
            builder.Entity<Usuario>().HasData(users);
            #endregion

            #region Populate User Role
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles[0].Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[1].Id,
                    RoleId = roles[1].Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[2].Id,
                    RoleId = roles[1].Id
                },
                new IdentityUserRole<string>
                {
                    UserId = users[3].Id,
                    RoleId = roles[1].Id
                }
            );
            #endregion

            #region Cadastrar Curiosidades
            List<Curiosidade> curiosidades = new()
            {
                new Curiosidade()
                {
                    CuriosidadeId = 1,
                    Nome = "O salto de um gato pode ter até 5 vezes a sua altura",
                    Descricao = "Aparentemente, nossos bichanos favoritos tem verdadeiras molas no lugar das patas, não é mesmo? O recorde mundial de pulo mais alto foi dado por um gato chamado Nyah-Suke, que vive no Japão, e conseguiu atingir uma altura de 1,96m de altura em seus pulos.",
                    Imagem = "https://hypescience.com/wp-content/uploads/2014/09/gatos-pulando-como-ninjas-10.jpg",
                    RacaId = 1,
                }
            };
            builder.Entity<Curiosidade>().HasData(curiosidades);
            #endregion

            #region Cadastrar Pets
           List<Pet> pets = new List<Pet>()
            {
                new Pet()
                {
                    PetId = 1,
                    Nome = "Pérola",
                    Descricao = "Minha gata deu a luz para 5 filhotes e esta é uma das filhotes que nasceu. Ela é muito dócil, carismática e amorosa. Infelizmente não tenho condições de cuidar dela.",
                    Idade = "1 mês e 2 semanas",
                    Peso = 0 ,
                    ImgLink = "https://blog.cobasi.com.br/wp-content/webpc-passthru.php?src=https://blog.cobasi.com.br/wp-content/uploads/2020/07/gato-siames-filhote.png&nocache=1",
                    ImgLinkII = "sdsds",
                    GeneroId = 2,
                    RacaId = 2,
                    ParaAdocao = true,
                    UsuarioId = users[2].Id,
                },
                new Pet()
                {
                    PetId = 2,
                    Nome = null,
                    Descricao = "Encontrado nas ruas de Igaraçu do Tietê perdido, com fome e buscando abrigo. Estou cuidando dele por um tempo, mas não tenho muita condição de mante-lo aqui.",
                    Idade = null,
                    Peso = 0 ,
                    ImgLink = "https://cdn.osaogoncalo.com.br/img/normal/50000/0x0/IMG_2848_00053927_0-ScaleDownProportional.webp?fallback=https%3A%2F%2Fcdn.osaogoncalo.com.br%2Fimg%2Fnormal%2F50000%2FIMG_2848_00053927_0.jpg%3Fxid%3D126598%26resize%3D1000%252C500%26t%3D1655066037&xid=126598",
                    ImgLinkII = "",
                    GeneroId = 1,
                    RacaId = 12,
                    ParaAdocao = true,
                    UsuarioId = users[0].Id,
                },

                 new Pet()
                {
                    PetId = 3,
                    Nome = "Bart",
                    Descricao = "Eu e minha família estamos de mudança e não conseguiremos levá-lo conosco. Estamos buscando um novo tutor que seja responsável, tenha condições de mante-lo e que cuide muito bem dele, dando o máximo de atenção e amor o possível. Bart é muito carinhoso, ama dormir na cama e não traz nenhum tipo de prejuízo.",
                    Idade = "1 ano e 5 meses",
                    Peso = 0,
                    ImgLink = "https://midias.gazetaonline.com.br/_midias/jpg/2017/10/23/gato-5337982.jpg",
                    ImgLinkII = "",
                    GeneroId = 1,
                    RacaId = 1,
                    ParaAdocao = true,
                    UsuarioId = users[3].Id,
                },

                new Pet()
                {
                    PetId = 4,
                    Nome = "Mel",
                    Descricao = "Olha só quem está para adoção! A pequena Mel foi encontrada em Barra Bonita toda machucada e abandonada, mas com a ajuda dos profissionais da BraPaws, ela se recuperou e está 100% pronta para arrumar uma nova família que dê a ela muito amor e carinho.",
                    Idade = "9 meses",
                    Peso = 2 ,
                    ImgLink = "https://agenciabrasilia.df.gov.br/wp-conteudo/uploads/2022/11/CAPA-53-scaled.jpg",
                    ImgLinkII = "",
                    GeneroId = 2,
                    RacaId = 11,
                    ParaAdocao = true,
                    UsuarioId = users[1].Id,
                },

                 new Pet()
                {
                    PetId = 5,
                    Nome = null,
                    Descricao = "Encontrada perto do SESI em Igaraçu do Tiête, estava abandonada e toda machucada. Estamos fornecendo abrigo para ela por um tempo até encontrar um(a) novo(a) tutor(a) para ela.",
                    Idade = null,
                    Peso = 0 ,
                    ImgLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqYr24d2R8HOdSPqXW1EnHtvGXek1-HYrJJg&usqp=CAU",
                    ImgLinkII = "",
                    GeneroId = 1,
                    RacaId = 6,
                    ParaAdocao = true,
                    UsuarioId = users[0].Id,
                },

                 new Pet()
                {
                    PetId = 6,
                    Nome = "Mike",
                    Descricao = "O antigo dono queria abandona-lo porque não possuía tempo para cuidar, brincar e dar atenção a Mike. Vendo isso, não deixamos que o mesmo simplesmente jogasse Mike em qualquer lugar e, pegamos este lindo caramelo para cuidar e colocar para Adoção. Mike é muito imperativo e gosta muito de atenção. ",
                    Idade = "Possui mais ou menos 2 anos e meio",
                    Peso = 6 ,
                    ImgLink = "https://www.bnews.com.br/media/_versions/legacy/fotos/bocao_noticias/306181/mg/vira-lata-caramelo-mobiliza-bombeiros-apos-ficar-com-cabeca-presa-em-buraco-apos-tentar-espiar-a-vizinha-2._widexl.jpg",
                    ImgLinkII = "https://static1.patasdacasa.com.br/articles/1/22/71/@/16746-meme-historia-de-pipi-nao-so-virou-vira-articles_media_mobile-5.jpg",
                    GeneroId = 1,
                    RacaId = 11,
                    ParaAdocao = true,
                    UsuarioId = users[1].Id,
                }

            };
            builder.Entity<Pet>().HasData(pets);

            #endregion 
        }
    }
}
