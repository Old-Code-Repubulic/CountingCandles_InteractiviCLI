// See https://aka.ms/new-console-template for more information




Console.WriteLine("Happy Birthday!");
Console.WriteLine("How Old are you?!");

string age = Console.ReadLine();
Console.WriteLine("You are "+ age + " years old? (y/n)");

string confirmation = Console.ReadLine();

switch (confirmation)
{
    case "y":
        Console.WriteLine("this will soon house a method");
        break;
    case "n":
        Console.WriteLine("I'm Sorry, what was your age?");
        break;
    default: Console.WriteLine("I don't know what you just put, but it is NOT in a 'y' or 'n' format!");
        break;
}
        
