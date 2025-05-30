using ConsoleApp1;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;


class Program
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        CompparisonOperaters();
        ConditionalStatements();
        Loops();
        Arrays();
        Collections();
        Methods();
        Classes();
        ExceptionHandling();
    }

    static void PrintToConsole()
    {
        Console.WriteLine("Hello, World!");
    }

    static void VariablesAndDataTypes()
    {
        int age = 30;
        Console.WriteLine(age);

        float temperature = 36.5f;
        Console.WriteLine(temperature);

        double interest = 5.53;
        Console.WriteLine("Interest : " + interest);

        decimal stockPrice = 100.5023323323m;
        Console.WriteLine("Stock Price : " + stockPrice);

        char grade = 'A';
        Console.WriteLine("Grade : " + grade);

        string name = "Tonnam";
        Console.WriteLine($"My name is {name}.");

        bool isStudent = false;
        Console.WriteLine("Is student: " + isStudent);

        int quantity;
        string product;

        quantity = 5;
        product = "bananas";
        Console.WriteLine($"Product : {product}, Quantity : {quantity}");

        const double Pi = 3.14;
        Console.WriteLine(Pi);

    }

    static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;

        int addition = num1 + num2;
        Console.WriteLine(addition);

        int subtraction = num1 - num2;
        Console.WriteLine(subtraction);

        int multiplication = num1 * num2;
        Console.WriteLine(multiplication);

        int division = num1 / num2;
        Console.WriteLine(division);

        int modulus = 11 % 5;
        Console.WriteLine(modulus);

        int num3 = 5;
        int num4 = 0;

        try
        {
            int quotient = num3 / num4;
            Console.WriteLine(quotient);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        int num5 = 105;
        double num5AsDouble = (double)num5;
        Console.WriteLine(num5AsDouble);
    }

    static void CompparisonOperaters()
    {
        int a = 10;
        int b = 5;

        bool isEqual = (a == b);
        Console.WriteLine("Is Equal: " + isEqual);

        bool isNotEqual = (a != b);
        Console.WriteLine("Is Not Equal: " + isNotEqual);

        bool isGreater = (a > b);
        Console.WriteLine("Is Greater: " + isGreater);

    }

    static void ConditionalStatements()
    {
        int age = 20;
        if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }
        string day = "Monday";
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Start of the week.");
                break;
            case "Friday":
                Console.WriteLine("End of the week.");
                break;
            default:
                Console.WriteLine("Midweek day.");
                break;
        }
    }
    static void Loops()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("For Loop: " + i);
        }
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("While Loop: " + j);
            j++;
        }
        int k = 0;
        do
        {
            Console.WriteLine("Do While Loop: " + k);
            k++;
        } while (k < 5);

        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("Foreach Loop: " + number);
        }
    }

    static void Arrays()
    {
        string[] names = new string[3];
        names[0] = "one";
        names[1] = "two";
        names[2] = "three";
        Console.WriteLine(names.Length);

    }

    static void Collections()
    {
        List<string> cities = new List<string>();
        cities.Add("New York");
        cities.Add("Los Angeles");
        cities.Add("Chicago");
        cities.Add("New York");

        Console.WriteLine("Count: " + cities.Count);

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        HashSet<string> coutrys = new HashSet<string>();
        coutrys.Add("USA");
        coutrys.Add("Canada");
        coutrys.Add("Mexico");
        coutrys.Add("USA");

        // HashSet does not allow duplicates
        Console.WriteLine("Count: " + coutrys.Count);
        foreach (string country in coutrys)
        {
            Console.WriteLine(country);
        }

        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        string dictKey = "John";
        ageDict[dictKey] = 30;

        ageDict["Jane"] = 25;
        ageDict["Bob"] = 35;



        if (ageDict.ContainsKey(dictKey))
        {
            Console.WriteLine($"{dictKey} exists in the dictionary they age is {ageDict[dictKey]}.");
        }
        else
        {
            Console.WriteLine($"{dictKey} does not exist in the dictionary.");
        }

        foreach (var entry in ageDict)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());

        }
    }

    static void Methods()
    {
        SayHello();

        int a = 10;
        int b = 20;

        int sum = Add(a,b);
        Console.WriteLine($"Sum of {a} and {b} is {sum}.");



    }

    private static void SayHello()
    {
        Console.WriteLine("Hello from method!");
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static void Classes()
    {
        Person p = new Person("John", 30);
        p.Greet();
        p.Name = "Jane";
        p.Age = 25;
        p.Greet();
    }

    static void ExceptionHandling()
    {
        int a = 10;
        int b = 0;

        try
        {
            int result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        List<string> shapes = new List<string> { "square", "circle", "triangle" };

        try
        {
            Console.WriteLine(shapes[1]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);

        }
        finally
        {
            Console.WriteLine("Finally block executed.");
        }

        bool isSudent = false;
        try
        {
            if (isSudent)
            {
                Console.WriteLine("You are a student.");
            }
            else
            {
                throw new CustomException("You are not a student.");
            }
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }
}