internal class Program
{
    private static void Main(string[] args)
    { 
        MathTeaching();
        OperatorExamples();
    }

    private static void MathTeaching()
    {
        int forCounter = 0;
        int whileCounter = 0;

        int p = 2;
        for(int q = 2; q < 32; q = q * 2)
        {
            forCounter++;
            while (p < q)
            {
                p = p * 2;
                whileCounter++;
            }
            q = p - q;
        }
    }

    private static void OperatorExamples()
    {
        //Ta instrukcja deklaruje zmienną i ustawia jej wartość na 3.
        int width = 3;

        //Operator ++ zwiększa wartość danej zmiennej (dodaje do niej 1).
        width++;

        //Deklaracja dwóch kolejnych zmiennych typu int do przechowywania liczb
        //i użycie operatorów + oraz * do dodawania i mnożenia wartości.
        int height = 2 + 4;
        int area = width * height;
        Console.WriteLine(area);

        //Dwie kolejne instrukcje deklarują zmienne typu string
        //i używają operatora + do ich złączenia.
        string result = "Powierzchnia";
        result = result + " wynosi " + area;
        Console.WriteLine(result);

        //Zmienna logiczna (typu bool) ma wartość true lub false.
        bool truthValue = true;
        Console.WriteLine(truthValue);
    }
}