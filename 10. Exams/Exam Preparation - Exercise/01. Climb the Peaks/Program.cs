
Queue<Peaks> peaks = new Queue<Peaks>();

peaks.Enqueue(new Peaks { Difficulty = 80, Name = "Vihren" });
peaks.Enqueue(new Peaks { Difficulty = 90, Name = "Kutelo" });
peaks.Enqueue(new Peaks { Difficulty = 100, Name = "Banski Suhodol" });
peaks.Enqueue(new Peaks { Difficulty = 60, Name = "Polezhan" });
peaks.Enqueue(new Peaks { Difficulty = 70, Name = "Kamenitza" });


Stack<int> foodPortions = new Stack<int>(Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

Queue<int> stamina = new Queue<int>(Console.ReadLine()
    .Split(", ")
    .Select(int.Parse));

List<Peaks> climbedPeaks = new List<Peaks>();

int climbedPeaksCount = 0;
while (true)
{
    if (foodPortions.Count == 0 || peaks.Count == 0)
    {
        break;
    }
    if ((foodPortions.Peek() + stamina.Peek()) >= peaks.Peek().Difficulty)
    {
        climbedPeaks.Add(peaks.Peek());
        foodPortions.Pop();
        stamina.Dequeue();
        peaks.Dequeue();
        climbedPeaksCount++;

    }
    else
    {
        foodPortions.Pop();
        stamina.Dequeue();
    }
}

if (climbedPeaksCount == 5)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}
if (climbedPeaksCount > 0)
{
    Console.WriteLine("Conquered peaks:");

    foreach (var item in climbedPeaks)
    {
        Console.WriteLine($"{item.Name}");
    }
}
public class Peaks
{
    public int Difficulty { get; set; }
    public string Name { get; set; }
}