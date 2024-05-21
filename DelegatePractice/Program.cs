

partial class Program
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
