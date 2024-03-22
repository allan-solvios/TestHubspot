// See https://aka.ms/new-console-template for more information
using Cannolai.Hubspot;
using Cannolai.Hubspot.Entity;
using TestConsole1;

Console.WriteLine("Adding column started.");


HubspotUtility hubspotUtility = new HubspotUtility();

var result = await hubspotUtility.AddContactColumnAsync(TestData.CustomerIDColumn, new List<string> { "pat-na1-be2e5c9a-c29b-4113-8e5b-e523b19a8209" });

Console.WriteLine("Process completed.");

Console.ReadLine();

