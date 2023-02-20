

using System.ComponentModel;

Queue<int>textile=new Queue<int>(Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> medicaments = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Dictionary<string,int>createdItems= new Dictionary<string,int>();

while(medicaments.Any()&&textile.Any())
{
    int suma=medicaments.Peek()+textile.Peek();
    if(suma==30)
    {
        if(!createdItems.ContainsKey("Patch"))
        {
            createdItems["Patch"] = 0;
        }
        createdItems["Patch"]++;
        medicaments.Pop();
        textile.Dequeue();
    }
    else if (suma == 40)
    {
        if (!createdItems.ContainsKey("Bandage"))
        {
            createdItems["Bandage"] = 0;
        }
        createdItems["Bandage"]++;
        medicaments.Pop();
        textile.Dequeue();
    }
    else if (suma == 100)
    {
        if (!createdItems.ContainsKey("MedKit"))
        {
            createdItems["MedKit"] = 0;
        }
        createdItems["MedKit"]++;
        medicaments.Pop();
        textile.Dequeue();
    }
    else if(suma>100)
    {
        if (!createdItems.ContainsKey("MedKit"))
        {
            createdItems["MedKit"] = 0;
        }
        createdItems["MedKit"]++;
        int remaining = suma - 100;
        medicaments.Pop();
        textile.Dequeue();
        medicaments.Push(remaining+medicaments.Pop());
    }
    else
    {
        textile.Dequeue();
        medicaments.Push(10 + medicaments.Pop());
    }


    //Patch   30
    //Bandage 40
    //MedKit  100

}
if(medicaments.Count==0&&textile.Count==0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textile.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else if(!medicaments.Any())
{
    Console.WriteLine("Medicaments are empty.");
}
if(createdItems.Count> 0)
{
    foreach (var item in createdItems.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}
if(medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ",medicaments)}");
}
if(textile.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ",textile)}");
}

