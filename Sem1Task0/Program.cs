// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string? inputLine = Console.ReadLine();
if (inputLine != null && inputLine != "")
{
    Console.WriteLine(inputLine);
    int inputNum = int.Parse(inputLine);
    Console.WriteLine(inputNum * inputNum);
}
