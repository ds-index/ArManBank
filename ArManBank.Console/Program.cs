//ArMan DS
using ArManBank.APIs;

CreatedBy();

// Getting data from db:
var data = new RetrieveData();
var result = await data.Data();
foreach (var item in result)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"Id: {item.Id}\n" +
        $"First name: {item.FirstName}\n" +
        $"Last name: {item.LastName}\n" +
        $"Balance: {item.Balance}\n" +
        $"Type of Account: {item.TypeOfBalance}\n" +
        $"Create date: {item.CreateDate}");
    Console.ResetColor();

    Console.WriteLine("---------------------------------------");
}






































































static void CreatedBy()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("******* This product Created by ");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write("ArManDS ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("*******");
    Console.ResetColor();
    Console.WriteLine("\n");
}