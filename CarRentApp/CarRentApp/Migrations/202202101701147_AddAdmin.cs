namespace CarRentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public partial class AddAdmin : DbMigration
    {
        public override void Up()
        {
            var dbContext = new CarRentDbContext();
            dbContext.Users.Add(new Entities.User
            {
                UserName = "Michael",
                Password = "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b",
                IsActive = true,
            });
            dbContext.Roles.Add(new Entities.Role
            {
                Name = "Administrator",
                ShortName = "Admin",
            });
           // var userId = dbContext.Users.FirstOrDefault(x => x.UserName == "Michael").Id;
            dbContext.UserRoles.Add(new Entities.UserRole
            {
               UserId = 1,
               RoleId = 1,
            });        
            dbContext.SaveChanges();
 }
        
        public override void Down()
        {

        }
    }
}
