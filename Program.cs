string[] RowSelection()
{
    string[] str1 = { "hello", "2", ":-)" };
    string[] str2 = { "1234", "1567", "-2", "computer science" };
    string[] str3 = { "Russia", "Denmark", "Kazan" };
    Console.Write("1) ");
    foreach (string item in str1) Console.Write($" \"{item}\" ");
    Console.WriteLine();
    Console.Write("2) ");
    foreach (string item in str2) Console.Write($" \"{item}\" ");
    Console.WriteLine();
    Console.Write("3) ");
    foreach (string item in str3) Console.Write($" \"{item}\" ");
    Console.WriteLine();

    Console.Write("Выберите строку ");
    int value = Convert.ToInt32(Console.ReadLine());
    
    while (true)
    {
        if (value < 1 || value > 3)
        {
            Console.WriteLine("Вы ввели не верную строку");
            Console.Write("Выберите строку снова ");
            value = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            string[] result = value switch
            {
                1 => str1,
                2 => str2,
                3 => str3,
            };
            return result;
        }
    }
}

int[] ArrayNumbers(string[] strArray)
{
    int[] array = new int[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        array[i] = strArray[i].Length;
    }
    return array;
}

void PrintNewArrey(string[] strArray, int[] array)
{
    for (int i = 0; i < strArray.Length; i++)
    {
        if (array[i] <= 3) Console.Write($" \"{strArray[i]}\" ");
    }
}

string[] line = RowSelection();
PrintNewArrey(line, ArrayNumbers(line));