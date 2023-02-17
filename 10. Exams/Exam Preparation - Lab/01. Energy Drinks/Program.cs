
Stack<int> caffeine = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


Queue<int> energyDrinks = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int stamatCaffeine = 0;
int stamatCouldAccept = 300;

while (caffeine.Any() && energyDrinks.Any())
{
    if (caffeine.Peek() * energyDrinks.Peek() <= stamatCouldAccept)
    {
        stamatCaffeine += caffeine.Peek() * energyDrinks.Peek();
        stamatCouldAccept -= caffeine.Peek() * energyDrinks.Peek();
        energyDrinks.Dequeue();
        caffeine.Pop();
    }
    else
    {
        if (stamatCouldAccept + 30 > 300)
        {
            stamatCouldAccept = 300;
        }
        else
        {
            stamatCouldAccept += 30;
        }
        if (stamatCaffeine - 30 < 0)
        {
            stamatCaffeine = 0;
        }
        else
        {
            stamatCaffeine -= 30;
        }
        energyDrinks.Enqueue(energyDrinks.Dequeue());
        caffeine.Pop();
    }
}

if (energyDrinks.Any())
{
    Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");

}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}
Console.WriteLine($"Stamat is going to sleep with {stamatCaffeine} mg caffeine.");