System.Console.Write("Please enter number: ");
var num = Console.ReadLine();

var result = CalculateFactroial(Convert.ToInt32(num));

Console.Write(string.Format("factorial: {0}" ,result));

long CalculateFactroial(int number)
{
    if (number > 1)
        return CalculateFactroial(number - 1) * number;

    return number;
}

