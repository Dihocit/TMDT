using Core.database.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Web.Models.EF
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions<FoodContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group()
                {
                    Id = Guid.Parse("E3E148AF-0576-466E-B783-736C0F27F989"),
                    Name = "Quản trị viên"
                }
                );
            modelBuilder.Entity<Member>().HasData(new Member()
            {
                Id = Guid.Parse("E3D1CF68-A04C-4FF8-89D8-40266246C86E"),
                Name = "Ngô Văn Linh",
                Picture = "/img/users/ngolinh.jpg",
                LoginName = "ngo.linh",
                Password = "c4ca4238a0b923820dcc509a6f75849b",
                Email = "ngolinh@gmail.com",
                CreatedOn = DateTime.Now,
                GroupId = Guid.Parse("E3E148AF-0576-466E-B783-736C0F27F989")
            },
            new Member()
            {
                Id = Guid.Parse("8C7E1501-422E-47E1-8F81-BFB3D226653B"),
                Name = "Lê Thượng Long",
                Picture = "/img/users/wean.jpg",
                LoginName = "lethuonglong",
                Password = "12345",
                Email = "lethuonglong@gmail.com",
                CreatedOn = DateTime.Now,
                GroupId = Guid.Parse("E3E148AF-0576-466E-B783-736C0F27F989")
            }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id= Guid.Parse("2D6349BA-B2B6-49CE-8F9B-4531EC7372DD"),
                    Name= "Root",
                    CreatedBy = Guid.Parse("E3D1CF68-A04C-4FF8-89D8-40266246C86E"),
                    CreatedOn= DateTime.Now
                },
                 new Category()
                 {
                     Id = Guid.Parse("3A70FB4A-B22C-469F-8F50-5E3047D5B599"),
                     Name = "Authorized",
                     CreatedBy = Guid.Parse("E3D1CF68-A04C-4FF8-89D8-40266246C86E"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("2D6349BA-B2B6-49CE-8F9B-4531EC7372DD")
                 },
                 new Category()
                 {
                     Id = Guid.Parse("1E1CA786-81C5-4C4C-B3A7-2E79E1CE0894"),
                     Name = "Nhóm quyền",
                     CreatedBy = Guid.Parse("E3D1CF68-A04C-4FF8-89D8-40266246C86E"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("3A70FB4A-B22C-469F-8F50-5E3047D5B599")
                 },
                 new Category()
                 {
                     Id = Guid.Parse("22E62DDA-EEC5-40C2-872D-F5C495025D7C"),
                     Name = "Article",
                     CreatedBy = Guid.Parse("E3D1CF68-A04C-4FF8-89D8-40266246C86E"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("2D6349BA-B2B6-49CE-8F9B-4531EC7372DD")
                 },
                 new Category()
                 {
                     Id = Guid.Parse("74175C1D-096C-4274-97EE-0EA5CC3A7117"),
                     Name = "Product",
                     CreatedBy = Guid.Parse("E3D1CF68-A04C-4FF8-89D8-40266246C86E"),
                     CreatedOn = DateTime.Now,
                     ParentId = Guid.Parse("2D6349BA-B2B6-49CE-8F9B-4531EC7372DD")
                 }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = Guid.Parse("8CBC6A66-DCE6-44C5-96C9-F8D700434016"),
                    Name = "Xem Danh Sách ",
                    Code = "view-groups",
                    CategoryId= Guid.Parse("1E1CA786-81C5-4C4C-B3A7-2E79E1CE0894")

                },
                new Role()
                {
                    Id = Guid.Parse("92BA2AD6-B980-41B0-9E65-F513D3C5AE21"),
                    Name = "Cập nhật ",
                    Code = "edit-group",
                    CategoryId = Guid.Parse("1E1CA786-81C5-4C4C-B3A7-2E79E1CE0894")

                },
                new Role()
                {
                    Id = Guid.Parse("610F1BA6-CD51-4610-B1E5-BF8E53B5014C"),
                    Name = "Lưu",
                    Code = "save-group",
                    CategoryId = Guid.Parse("1E1CA786-81C5-4C4C-B3A7-2E79E1CE0894")

                },
                new Role()
                {
                    Id = Guid.Parse("068CBA2F-3879-44E8-A3D8-F3A80199B786"),
                    Name = "Xóa ",
                    Code = "delete-group",
                    CategoryId = Guid.Parse("1E1CA786-81C5-4C4C-B3A7-2E79E1CE0894")

                }


                );
            modelBuilder.Entity<Authorized>().HasData(
                new Authorized()
                {
                    Id= Guid.NewGuid(),
                    GroupId = Guid.Parse("E3E148AF-0576-466E-B783-736C0F27F989"),
                    RoleId = Guid.Parse("8CBC6A66-DCE6-44C5-96C9-F8D700434016")
                }
                );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Authorized> Authorizeds { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Order> Orders { get; set; }
        public DbSet<Details> Details { get; set; }

    }
}
