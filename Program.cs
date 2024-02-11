using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArray;

        if (args.Length > 0)
        {
            inputArray = args;
        }

        string[] newArray = FilterStrings(inputArray);

        bool foundShortStrings = false;
        foreach (string str in newArray)
        {
            if (str.Length <= 3)
            {
                foundShortStrings = true;
                break;
            }
        }

        if (foundShortStrings)
        {
            Console.WriteLine("Новый массив:");
            foreach (string str in newArray)
            {
                Console.WriteLine(str);
            }
        }    
	}
    static string[] FilterStrings(string[] input)
    {
        int count = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        
        int index = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
