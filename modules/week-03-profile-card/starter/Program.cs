namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        Console.Write("Full name: ");
        string fullName = Console.ReadLine();
        if (fullName == null) fullName = "";

        // - Hometown (city, state)
        Console.Write("Hometown (city, state): ");
        string homeTown = Console.ReadLine();
        if (homeTown == null) homeTown = "";

        // - Favorite color
        Console.Write("Favorite color: ");
        string favoriteColor = Console.ReadLine();
        if (favoriteColor == null) favoriteColor = "";

        // - Dream job
        Console.Write("Dream Job: ");
        string dreamJob = Console.ReadLine();
        if (dreamJob == null) dreamJob = "";
        // Hint: string variableName = Console.ReadLine();


        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        Console.Write("\nMajor/field of study: ");
        string major = Console.ReadLine();
        if (major == null) major = "";

        // - GPA (double, 0.0-4.0)
        Console.Write("Current GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());

        // - Graduation year (int)
        Console.Write("Graduation year: ");
        int graduationYear = int.Parse(Console.ReadLine());

        // - Is full-time student? (bool from yes/no)
        Console.Write("Full-time student? (yes/no): ");
        string fullTimeAnswer = Console.ReadLine().ToLower();
        bool isFullTimeStudent;

        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        if (fullTimeAnswer == "yes" || fullTimeAnswer == "y")
        {
            isFullTimeStudent = true;
        }
        else
        {
            isFullTimeStudent = false;
        }

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        Console.Write("\nAge: ");
        int age = int.Parse(Console.ReadLine());

        // - Height in inches (double)
        Console.Write("Height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());

        // - Favorite number (int)
        Console.Write("Favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        int currentYear = 2026;
        int birthYear = currentYear - age;
        int yearToGraduation = graduationYear - currentYear;

        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        int heightFeet = (int)(heightInches / 12);
        double remainInches = heightInches % 12;

        // - Is honor student? = gpa >= 3.5
        bool isHonorStudent;
        if (gpa >= 3.5)
        {
            isHonorStudent = true;
        }
        else
        {
            isHonorStudent = false;
        }

        // - Age in months = age * 12
        int ageInMonths = age * 12;

        // Status
        string studentStatus;
        if (isFullTimeStudent)
        {
            studentStatus = "Full-Time Student";
        }
        else
        {
            studentStatus = "Part-Time Student";
        }

        // Honor Text
        string honorText;
        if (isHonorStudent)
        {
            honorText = "Yes ⭐️";
        }
        else
        {
            honorText = "No";
        }

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\nPERSONAL INFORMATION");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine($"Name:           {fullName}");
        Console.WriteLine($"Age:            {age} years old");
        Console.WriteLine($"Hometown:       {homeTown}");
        Console.WriteLine($"Favorite Color: {favoriteColor}");
        Console.WriteLine($"Dream Job:      {dreamJob}");
        Console.WriteLine($"Height:         {heightFeet} feet {remainInches:F1} inches ({heightInches:F1} inches)");

        Console.WriteLine("\nACADEMIC DETAILS");
        Console.WriteLine("━━━━━━━━━━━━━━━━");
        Console.WriteLine($"Major:              {major}");
        Console.WriteLine($"GPA:                {gpa:F2} / 4.00");
        Console.WriteLine($"Expected Graduation: {graduationYear}");
        Console.WriteLine($"Status:             {studentStatus}");
        Console.WriteLine($"Honor Student:      {honorText}");

        Console.WriteLine("\nCALCULATED STATISTICS");
        Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━");
        Console.WriteLine($"Birth Year:         {birthYear}");
        Console.WriteLine($"Years to Graduation: {yearToGraduation} years");
        Console.WriteLine($"Age in Months:      {ageInMonths} months");
        Console.WriteLine($"Favorite Number:    {favoriteNumber}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }

}
