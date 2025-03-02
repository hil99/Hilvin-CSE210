using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Listing Log");
            Console.WriteLine("5. Exit");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                continue;
            }

            if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }

            if (choice == 4)
            {
                new ListingView().DisplayListingLog();
                continue;
            }

            Console.WriteLine("Enter the duration in seconds:");
            if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
            {
                Console.WriteLine("Invalid duration. Please enter a positive integer.");
                continue;
            }

            string activityName = "";
            int listedItems = 0;

            switch (choice)
            {
                case 1:
                    var breathing = new Breathing();
                    breathing.SetDuration(duration);
                    breathing.RunBreathingActivity();
                    activityName = "Breathing";
                    break;
                case 2:
                    var reflecting = new Reflecting();
                    reflecting.SetDuration(duration);
                    reflecting.RunReflectingActivity();
                    activityName = "Reflecting";
                    break;
                case 3:
                    var listing = new Listing();
                    listing.SetDuration(duration);
                    listedItems = listing.RunListingActivity();
                    activityName = "Listing";
                    break;
            }

            ActivityLogger.LogActivity(activityName, duration, listedItems);
        }
    }
}
