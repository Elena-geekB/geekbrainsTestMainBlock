using System;

class Program
{
    static void Main(string[] args)
    {
        string[] inputArray;

        // Проверяем, есть ли аргументы командной строки
        if (args.Length > 0)
        {
            // Если есть, используем их как исходный массив строк
            inputArray = args;
        }
        else
        {
            // Если аргументов командной строки нет, запрашиваем ввод с клавиатуры
            Console.WriteLine("Введите строки через пробел:");
            inputArray = Console.ReadLine().Split(' ');
        }

        // Получаем новый массив строк, содержащий только строки длиной не более 3 символов
        string[] newArray = FilterStrings(inputArray);

        // Проверяем, были ли найдены строки длиной больше 3 символов
        bool foundShortStrings = false;
        foreach (string str in newArray)
        {
            if (str.Length <= 3)
            {
                foundShortStrings = true;
                break;
            }
        }

        // Если найдены строки длиной не более 3 символов, выводим новый массив на экран
        if (foundShortStrings)
        {
            Console.WriteLine("Новый массив:");
            foreach (string str in newArray)
            {
                Console.WriteLine(str);
            }
	}
	else
	{
    		Console.WriteLine("Не найден подходящий массив строк.");
	}
    }

    static string[] FilterStrings(string[] input)
    {
        // Подсчитываем количество строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in input)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] result = new string[count];

        // Заполняем новый массив строками, удовлетворяющими условию
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
