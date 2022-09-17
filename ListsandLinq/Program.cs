

using ListsandLinq;

try
{
    List<Contact> people = ListManager.LoadSampleData;

    foreach (var Contact in people)
    {
        Console.WriteLine($"{Contact.firstName} {Contact.lastName} {Contact.number} {Contact.yearsExperience} {Contact.birthday}");
    }

    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine("invalid.");
}
