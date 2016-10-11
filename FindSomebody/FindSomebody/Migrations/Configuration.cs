namespace FindSomebody.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PersonDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PersonDbContext context)
        {
            context.People.AddOrUpdate(
              p => p.Email,
              new Person
              {
                  Name = "Andrew Peters",
                  Email = "andrewnoire@gmail.com",
                  Age = 48,
                  Address = "564 Waterson Ave.",
                  Interests = "Parasailing, classic films, biking"
              },
              new Person
              {
                  Name = "Brice Lambson",
                  Email = "yoloyachter@gmail.com",
                  Age = 34,
                  Address = "16 Topsbend Cove",
                  Interests = "Yachting, base jumping, kayaking"
              },
              new Person
              {
                  Name = "Rowan Miller",
                  Email = "playmaker@gmail.com",
                  Age = 24,
                  Address = "83 Lumbar St.",
                  Interests = "Reading, video games, wood carving"
              },
              new Person
              {
                  Name = "Bruce Chadwick",
                  Email = "brucebaritone@yahoo.com",
                  Age = 22,
                  Address = "99 Offpoint Dr.",
                  Interests = "Musical theatre, barbershop quartets, water polo"
              },
              new Person
              {
                  Name = "Madaline LaRouche",
                  Email = "madmaddy@yahoo.com",
                  Age = 52,
                  Address = "804 Appleseed Dr.",
                  Interests = "Cooking, fashion, interior design"
              },
              new Person
              {
                  Name = "Peter Sadive",
                  Email = "machinemind@gmail.com",
                  Age = 42,
                  Address = "112 Summer Glaive Ave.",
                  Interests = "Planes, trains, automobiles, rom coms"
              },
              new Person
              {
                  Name = "Stephanie Cane",
                  Email = "stephwins@gmail.com",
                  Age = 29,
                  Address = "33 Settled Meadows",
                  Interests = "Soccer, lacrosse, rock climbing"
              },
              new Person
              {
                  Name = "Chin Wong",
                  Email = "wongnumber@gmail.com",
                  Age = 19,
                  Address = "72 Crestpoint Rd.",
                  Interests = "Design, sketching, piano"
              }
            );
        }
    }
}