

using LinqPractice;

public class Program
{
    delegate int MathOperation(int a, int b);

   static void Main(string[] args)
    {
        MathOperation operation;

        operation = Add;
        int addResult = operation(7, 11);
        Console.WriteLine($"7 + 11 = {addResult}");

        operation = Substract;
        int subResult = operation(4, 3);
        Console.WriteLine($" 4 - 3 = {subResult}");

        // multicast
        operation = Add;
        operation += Substract;

        Delegate[] delegateList = operation.GetInvocationList();
        foreach (MathOperation ope in delegateList)
        {
            int result = ope(12, 4);
            Console.WriteLine($"Result = {result}");
        }

        Console.WriteLine("Hello, World!");

        var saludo = new Saludo();
        saludo.MostrarSaludo();

        var textProcessor = new TextProcessor();

        string filePath = "C:\\Users\\SIMON\\source\\repos\\LinqPractice\\LinqPractice\\TestFile.txt";
        var text = textProcessor.ProcessText(filePath);
        var countWords = textProcessor.CountWords(text);
        var frecuency = textProcessor.CalculateFrecuency(text);
        var longestWord = textProcessor.FindLongestWord(text);
        Console.WriteLine(text);
        Console.WriteLine(countWords);
        Console.WriteLine(frecuency);

        Console.WriteLine("char frecuency: ");
        foreach (var word in frecuency)
        {
            Console.WriteLine($"{word.Key} : {word.Value}");
        }

        Console.WriteLine(longestWord);


    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Substract(int a, int b)
    {
        return a - b;
    }




}

