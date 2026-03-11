// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

static double CalculateAverage(int[] values)
{
    int sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }
    return sum / values.Length;
}
Console.WriteLine("cośtam zmieniam");

static int CalculateMax(int[] values)
{
    int tmp = values[0];
    foreach (int value in values)
    {
        if (value > tmp)
        {
            tmp = value;
        }
    }

    return tmp;
}
Console.WriteLine("casdadasdsadasdasda");
Console.WriteLine("Hello, World!");
Console.WriteLine("ostatnie");


static int CalculateMin(int[] values)
{
    return 0;
}



