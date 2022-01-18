
using Matrix.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Matrix.DbContexts
{
    public class SkillMatrixContext : DbContext
    {
        public SkillMatrixContext(DbContextOptions<SkillMatrixContext> options)
           : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Study> Studies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             // seed the database with dummy data
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Name = "llllllllll",
                    Ocupation = "llllllllll",
                    Description = "llllllllll",
                    PhoneNumber = "llllllllll",
                    address = "llllllllll",
                    email = "llllllllll",
                    github = "llllllllll",
                    instagram = "llllllllll",
                },
                new Employee()
                {
                    Id = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                    Name = "kkkkkkkkkk",
                    Ocupation = "kkkkkkkkkk",
                    Description = "llllllllll",
                    PhoneNumber = "kkkkkkkkkk",
                    address = "kkkkkkkkkk",
                    email = "kkkkkkkkkk",
                    github = "kkkkkkkkkk",
                    instagram = "kkkkkkkkkk",
                },
                new Employee()
                {
                    Id = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                    Name = "jjjjjjjjjjj",
                    Ocupation = "jjjjjjjjjjj",
                    Description = "llllllllll",
                    PhoneNumber = "jjjjjjjjjjj",
                    address = "jjjjjjjjjjj",
                    email = "jjjjjjjjjjj",
                    github = "jjjjjjjjjjj",
                    instagram = "jjjjjjjjjjj",
                },
                new Employee()
                {
                    Id = Guid.Parse("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                    Name = "iiiiiii",
                    Ocupation = "iiiiiii",
                    Description = "llllllllll",
                    PhoneNumber = "iiiiiii",
                    address = "iiiiiii",
                    email = "iiiiiii",
                    github = "iiiiiii",
                    instagram = "iiiiiii",
                },
                new Employee()
                {
                    Id = Guid.Parse("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                    Name = "hhhhhhhhh",
                    Ocupation = "hhhhhhhhh",
                    Description = "llllllllll",
                    PhoneNumber = "hhhhhhhhh",
                    address = "hhhhhhhhh",
                    email = "hhhhhhhhh",
                    github = "hhhhhhhhh",
                    instagram = "hhhhhhhhh",
                },
                new Employee()
                {
                    Id = Guid.Parse("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                    Name = "gggggggg",
                    Ocupation = "gggggggg",
                    Description = "llllllllll",
                    PhoneNumber = "gggggggg",
                    address = "gggggggg",
                    email = "gggggggg",
                    github = "gggggggg",
                    instagram = "gggggggg",
                },
                new Employee()
                {
                    Id = Guid.Parse("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                    Name = "fffffffffffff",
                    Ocupation = "fffffffffffff",
                    Description = "llllllllll",
                    PhoneNumber = "fffffffffffff",
                    address = "fffffffffffff",
                    email = "fffffffffffff",
                    github = "fffffffffffff",
                    instagram = "fffffffffffff",
                },
                new Employee()
                {  
                    Id = Guid.Parse("71838f8b-6ab3-4539-9e67-4e77b8ede1c0"),
                    Name = "eeeeeeee",
                    Ocupation = "eeeeeeee",
                    Description = "llllllllll",
                    PhoneNumber = "eeeeeeee",
                    address = "eeeeeeee",
                    email = "eeeeeeee",
                    github = "eeeeeeee",
                    instagram = "eeeeeeee",
                },
                 new Employee()
                 {
                     Id = Guid.Parse("119f9ccb-149d-4d3c-ad4f-40100f38e918"),
                     Name = "ddddddddd",
                     Ocupation = "ddddddddd",
                     Description = "llllllllll",
                     PhoneNumber = "ddddddddd",
                     address = "ddddddddd",
                     email = "ddddddddd",
                     github = "ddddddddd",
                     instagram = "ddddddddd",
                 },
                 new Employee()
                 {
                     Id = Guid.Parse("28c1db41-f104-46e6-8943-d31c0291e0e3"),
                     Name = "cccccccccc",
                     Ocupation = "cccccccccc",
                     Description = "llllllllll",
                     PhoneNumber = "cccccccccc",
                     address = "cccccccccc",
                     email = "cccccccccc",
                     github = "cccccccccc",
                     instagram = "cccccccccc",
                 },
                 new Employee()
                 {
                     Id = Guid.Parse("d94a64c2-2e8f-4162-9976-0ffe03d30767"),
                     Name = "bbbbbbbbbb",
                     Ocupation = "bbbbbbbbbb",
                     Description = "llllllllll",
                     PhoneNumber = "bbbbbbbbbb",
                     address = "bbbbbbbbbb",
                     email = "bbbbbbbbbb",
                     github = "bbbbbbbbbb",
                     instagram = "bbbbbbbbbb"
                 },
                 new Employee()
                 {
                     Id = Guid.Parse("380c2c6b-0d1c-4b82-9d83-3cf635a3e62b"),
                     Name = "aaaaaaaaa",
                     Ocupation = "aaaaaaaaa",
                     Description = "llllllllll",
                     PhoneNumber = "aaaaaaaaa",
                     address = "aaaaaaaaa",
                     email = "aaaaaaaaa",
                     github = "boscaaaaaaaaahetar",
                     instagram = "aaaaaaaaa",
                 } 
                );

            modelBuilder.Entity<Study>().HasData(
               new Study
               {
                   Id = Guid.Parse("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                   EmployeeId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                   Name = "Commandeering a Ship Without Getting Caught",
                   Location = "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.",
                   Interval = "2002-2022"
               },
               new Study
               {
                   Id = Guid.Parse("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                   EmployeeId = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                   Name = "Overthrowing Mutiny",
                   Location = "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny.",
                   Interval = "2002-2022"
               },
               new Study
               {
                   Id = Guid.Parse("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                   EmployeeId = Guid.Parse("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                   Name = "Avoiding Brawls While Drinking as Much Rum as You Desire",
                   Location = "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk.",
                   Interval = "2002-2022"
               },
               new Study
               {
                   Id = Guid.Parse("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                   EmployeeId = Guid.Parse("2902b665-1190-4c70-9915-b9c2d7680450"),
                   Name = "Singalong Pirate Hits",
                   Location = "In this course you'll learn how to sing all-time favourite pirate songs without sounding like you actually know the words or how to hold a note.",
                   Interval = "2002-2022"
               }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
