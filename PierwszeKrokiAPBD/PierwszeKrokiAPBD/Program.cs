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
    int tomp = values[0];
    foreach (int value in values)
    {
        if (value > tomp)
        {
            tomp = value;
        }
    }

    return tomp;
}
Console.WriteLine("casdadasdsadasdasda");
Console.WriteLine("Hello, World!");
Console.WriteLine("ostatnie");
Console.WriteLine("zmieniam by zrobić później Rebase");


static int CalculateMin(int[] values)
{
    int tmp = values[0];
    foreach (int value in values)
    {
        if (value < tmp)
        {
            tmp = value;
        }
    }
    return tmp;
        
}



