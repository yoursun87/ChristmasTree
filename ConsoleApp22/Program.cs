using static System.Console;


ChristmasTree.Print();
Console.ReadLine();
class ChristmasTree
{
    internal static void Print()
    {
       
        int size;
        Write("Enter size:");
        while (!int.TryParse(ReadLine(), out size) || size <= 0)
            Write("Enter size, damn it: ");
        for (int i = 1; i <= size; i++)
            for (int j = 1; j <= i; j++)
                WriteLine(new string(' ', size - j) + new string('6', j * 2 - 1));

    }
}