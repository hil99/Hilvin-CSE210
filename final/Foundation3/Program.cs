using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("  Welcome to HILX Event Planner   ");
        Console.WriteLine("====================================\n");

        List<Address> addresses = new List<Address>
        {
            new Address("Orchard Road", "Singapore", "SG", "Singapore"),
            new Address("Bonifacio High Street", "Taguig", "PH", "Philippines"),
            new Address("Sukhumvit Road", "Bangkok", "TH", "Thailand")
        };

        List<Event> eventList = new List<Event>();
        List<string> eventNames = new List<string>();

        eventNames.Add("Business Summit");
        eventList.Add(new Lecture("ASEAN Business Summit", "Exploring economic growth in Southeast Asia", new DateTime(2024, 10, 15), "10:00 AM", addresses[0], "Dr. Lim Wei", 200));

        eventNames.Add("Networking Night");
        eventList.Add(new Reception("Marina Bay Networking Night", "Exclusive networking event for industry leaders", new DateTime(2024, 11, 20), "7:00 PM", addresses[1], "rsvp@hilxevents.com"));

        eventNames.Add("Beach Cleanup");
        eventList.Add(new Outdoor("Phi Phi Island Cleanup", "Join us in keeping our beaches pristine", new DateTime(2024, 12, 5), "9:00 AM", addresses[2], "Sunny with a light breeze"));

        for (int i = 0; i < eventList.Count; i++)
        {
            Console.WriteLine("Event: " + eventNames[i]);
            Console.WriteLine(eventList[i].GetShortDescription());
            Console.WriteLine(eventList[i].GetStandardDetails());
            Console.WriteLine(eventList[i].GetFullDetails());
            Console.WriteLine("------------------------------");
        }
    }
}
