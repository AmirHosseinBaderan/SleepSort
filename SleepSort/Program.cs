using static System.Console;

WriteLine("Welcome To Sleep Sort");
List<int> numbers = new();

while (true)
{
    Write("Enter Number To Add List : ");
    var numberStr = ReadLine();
    if (numberStr == "fin")
        break;
    if (int.TryParse(numberStr, out int parsed))
        numbers.Add(parsed);
    else WriteLine($"Exception to convert : {numberStr}");
}

WriteLine("Start Sorting");


foreach (var n in numbers)
    Task.Run(() =>
    {
        Thread.Sleep(n);
        Console.WriteLine(n);
    });


ReadKey();