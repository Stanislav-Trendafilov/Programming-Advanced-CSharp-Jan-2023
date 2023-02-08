using System.Collections.Immutable;

namespace IteratorsAndComparators
{
    public class StartUp
    {
        public static void Main()
        {
            //IEnumerator<string>names=PrintNames();

            //while(names.MoveNext())
            //{
            //    Console.WriteLine(names.Current);
            //}
            //IEnumerator<string> PrintNames()
            //{
            //    Console.WriteLine(("First"));

            //    yield return "Peshka";


            //    Console.WriteLine("Second");

            //    yield return "Ivan";
            //}

            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002,
                "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }

    }
}
