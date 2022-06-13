static int[] IntArray()
{   int sum = 0;
    int val = 0;
    Random rnd = new Random();
    int[] numArray = new int[10];
    int max = 5;
    int min = 25;
    for (int i = 0; i < 10;i++)
    {
        val = rnd.Next(5,25);
        numArray[i] = val;
        if (val > max)
        {
            max = val;
        }
        if (val < min)
        {
            min = val;
        }
        sum += val;
    }
    Console.WriteLine($"Max = {max}, Min = {min}");
    Console.WriteLine($"Sum = {sum}");
    return numArray;
}
static string TossCoin()
{
    Console.WriteLine("Tossing a coin");
    Random rnd = new Random();
    int val = rnd.Next(2);
    if (val == 0)
    {
        Console.WriteLine("Heads");
        return "Heads";
    }
    else
    {
        Console.WriteLine("Tails");
        return "Tails";
    }
}
static List<string> newNames()
{   
    List<string> names = new List<string>();
    names.Add("Todd");
    names.Add("Tiffany");
    names.Add("Charlie");
    names.Add("Geneva");
    names.Add("Sydney");
    foreach (string name in names.ToList())    {
        if(name.Length > 6){
            names.Remove($"{name}");
        }
    }
    return names;
}
Console.WriteLine(newNames()[0]);