using Personal_Info_Management_System.Models;

namespace Personal_Info_Management_System.Data
{
    public class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.PersonalInfos.Any())
                return;

            var list = new List<PersonalInfo>();

            var random = new Random();

            for (int i = 1; i <= 1000; i++)
            {
                list.Add(new PersonalInfo
                {
                    FirstName = "User" + i,
                    LastName = "Test",
                    Email = $"user{i}@mail.com",
                    PhoneNumber = "017" + random.Next(10000000, 99999999),
                    DateOfBirth = DateTime.Now.AddYears(-random.Next(20, 40)),
                    Gender = random.Next(0, 2) == 0 ? "Male" : "Female",
                    Address = "Dhaka",
                    Nationality = "Bangladeshi",
                    CreatedDate = DateTime.Now
                });
            }

            context.PersonalInfos.AddRange(list);
            context.SaveChanges();
        }
    }
}
