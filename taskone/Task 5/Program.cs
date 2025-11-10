// Step 1: Create a DateTime variable for birthdate
DateTime birthDate = new DateTime(2000, 6, 25); 

// Step 2: Create a DateTime variable for current date and time
DateTime currentDate = DateTime.Now;

// Step 3: Calculate age using TimeSpan
TimeSpan ageSpan = currentDate - birthDate;

// Convert TimeSpan to years (approximate)
double ageInYears = ageSpan.TotalDays / 365.25;

// Step 4: Print birthdate, current date, and age
Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
Console.WriteLine($"Age (in years): {Math.Floor(ageInYears)}");

// Step 5: Add 10 days to birthdate and print
DateTime newDate = birthDate.AddDays(10);
Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");