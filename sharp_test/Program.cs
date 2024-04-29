string text = "gjhgggjhgy uuyiu iuyiuy";
string[] words = text.Split(new char[] { ' ' });

void PrintArray(string[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1000);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine("]");
    Console.ResetColor();
}

PrintArray(words);
