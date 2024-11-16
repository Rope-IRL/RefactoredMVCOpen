using RefactoredMVC.DataAccess;
using RefactoredMVC.DataAccess.Entities;


namespace RefactoredMVC.API.Middleware.Initializers
{
    public class DbInitializer
    {
        private readonly RequestDelegate _next;
        private readonly IServiceProvider _serviceProvider;

        public DbInitializer(RequestDelegate next, IServiceProvider serviceProvider)
        {
            _next = next;
            _serviceProvider = serviceProvider;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<RentDbContext>();
                await InitializeDatabaseAsync(db);
            }

            await _next(context);
        }

        private async Task InitializeDatabaseAsync(RentDbContext db)
        {
            db.Database.EnsureCreated();

            if (db.Flats.Any())
            {
                return;
            }

            Random rand = new Random();
            int numberOfLessees = 5;
            int numberOfLandLords = 5;
            int numberOfFlats = 10;
            int numberOfFlatsContracts = 20;

            for (int i = 1; i < numberOfLessees + 1; i++)
            {
                string name = $"name {i}";
                string surname = $"surName {i}";

                long startNumber = 376000000000;
                long endNumber = 376999999999;
                string telephone = Convert.ToString(rand.NextInt64(startNumber, endNumber));

                DateOnly startDate = new DateOnly(1980, 12, 11);
                DateOnly endDate = new DateOnly(2020, 12, 11);
                int range = (endDate.ToDateTime(TimeOnly.MinValue) - startDate.ToDateTime(TimeOnly.MinValue)).Days;
                int randomDays = rand.Next(range + 1);

                DateOnly birthDate = startDate.AddDays(randomDays);

                long startPassportNumber = 000000000000;
                long endPassportNumber = 999999999999;
                string pasportId = Convert.ToString(rand.NextInt64(startPassportNumber, endPassportNumber));


                int integerPart = rand.Next(0, 9);

                // Generate the fractional part (two digits between 0 and 99)
                int fractionalPart = rand.Next(0, 99);

                // Combine both parts into a decimal with two decimal places
                decimal result = integerPart + fractionalPart / 100.0m;
                decimal lAvgMark = Math.Round(result);

                LesseeAdditionalInfoEntity lesseesAdditionalInfo = new LesseeAdditionalInfoEntity
                {
                    //Id = i,
                    AverageMark = lAvgMark,
                    BirthDate = birthDate,
                    Name = name,
                    Surname = surname,
                    Telephone = telephone,
                    PassportId = pasportId,
                };
                string email = $"email {i}";
                string login = $"login {i}";
                string password = $"password {i}";

                db.Lessees.Add(new LesseeEntity { Login = login, HashedPassword = password, Email = email, AdditionalInfo = lesseesAdditionalInfo });
                await db.SaveChangesAsync();


            }

            for (int i = 1; i < numberOfLandLords + 1; i++)
            {
                string name = $"name {i}";
                string surname = $"surName {i}";

                long startNumber = 376000000000;
                long endNumber = 376999999999;
                string telephone = Convert.ToString(rand.NextInt64(startNumber, endNumber));

                DateOnly startDate = new DateOnly(1980, 12, 11);
                DateOnly endDate = new DateOnly(2020, 12, 11);
                int range = (endDate.ToDateTime(TimeOnly.MinValue) - startDate.ToDateTime(TimeOnly.MinValue)).Days;
                int randomDays = rand.Next(range + 1);
                DateOnly birthDate = startDate.AddDays(randomDays);

                long startPassportNumber = 000000000000;
                long endPassportNumber = 999999999999;
                string pasportId = Convert.ToString(rand.NextInt64(startPassportNumber, endPassportNumber));


                int integerPart = rand.Next(0, 9);

                // Generate the fractional part (two digits between 0 and 99)
                int fractionalPart = rand.Next(0, 99);

                // Combine both parts into a decimal with two decimal places
                decimal result = integerPart + fractionalPart / 100.0m;
                decimal lAvgMark = Math.Round(result);

                LandlordAdditionalInfoEntity lesseesAdditionalInfo = new LandlordAdditionalInfoEntity
                {
                    //Id = i,
                    AverageMark = lAvgMark,
                    BirthDate = birthDate,
                    Name = name,
                    Surname = surname,
                    Telephone = telephone,
                    PassportId = pasportId,
                };
                string email = $"email {i + 10}";
                string login = $"login {i}";
                string password = $"password {i}";

                db.Landlords.Add(new LandlordEntity { Login = login, HashedPassword = password, Email = email, AdditionalInfo = lesseesAdditionalInfo });
                await db.SaveChangesAsync();


            }

            for (int i = 1; i < numberOfFlats + 1; i++)
            {
                string header = $"flat {i}";
                string description = $"description of the flat{i}";
                decimal avgMark = (decimal)9.9;
                string city = $"city {i}";
                string address = $"address{i}";
                short numberOfRooms = (short)rand.Next(1, 3);
                short numberOfFloors = (short)rand.Next(1, 3);
                bool bathRoomAvailability = Convert.ToBoolean(rand.Next(0, 1));
                bool wifiAvailability = Convert.ToBoolean(rand.Next(0, 1));

                int integerPart = rand.Next(0, 9);

                // Generate the fractional part (two digits between 0 and 99)
                int fractionalPart = rand.Next(0, 99);

                // Combine both parts into a decimal with two decimal places
                decimal result = integerPart + fractionalPart / 100.0m;

                decimal cost = Math.Round(result, 2);

                int LLid = rand.Next(1, numberOfLandLords);

                db.Flats.Add(new FlatEntity
                {
                    Header = header,
                    Description = description,
                    Address = address,
                    City = city,
                    AverageMark = avgMark,
                    IsWiFiAvailable = wifiAvailability,
                    IsBathroomAvailable = bathRoomAvailability,
                    NumberOfFloors = numberOfFloors,
                    NumberOfRooms = numberOfRooms,
                    CostPerDay = cost,
                    LlId = LLid
                });
                await db.SaveChangesAsync();

            }
            for (int i = 1; i < numberOfFlatsContracts + 1; i++)
            {
                DateOnly startDate = new DateOnly(2020, 1, 11);
                DateOnly endDate = new DateOnly(2020, 12, 11);
                int range = (endDate.ToDateTime(TimeOnly.MinValue) - startDate.ToDateTime(TimeOnly.MinValue)).Days;
                int randomDays = rand.Next(range + 1);
                DateOnly rentStartDate = startDate.AddDays(randomDays);
                int rentRange = rand.Next(randomDays, range);
                DateOnly rentEndDate = startDate.AddDays(rentRange);

                int Fid = rand.Next(1, numberOfFlats + 1);
                int Lid = rand.Next(1, numberOfLessees + 1);
                int LLid = rand.Next(1, numberOfLandLords);

                int integerPart = rand.Next(0, 9);

                // Generate the fractional part (two digits between 0 and 99)
                int fractionalPart = rand.Next(0, 99);

                // Combine both parts into a decimal with two decimal places
                decimal result = integerPart + fractionalPart / 100.0m;

                decimal cost = Math.Round(result, 2);
                db.FlatContracts.Add(new FlatContractEntity
                {
                    StartDate = rentStartDate,
                    EndDate = rentEndDate,
                    FlatId = Fid,
                    LandlordId = LLid,
                    LesseeId = Lid,
                    Cost = cost,
                });
                await db.SaveChangesAsync();

            }

        }

    }
}
