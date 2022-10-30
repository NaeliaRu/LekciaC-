/*string Method4(int count, string text)
{
    int i = 0;
    string resoult = string.Empty;

    while (i < count)
    {
        resoult = resoult + text;
        i ++;
    }

    return resoult;
}

string res = Method4(10, "z");
Console.WriteLine(res);*/

/*string Method4(int count, string text)
{
    string resoult = String.Empty;
    for (int i = 0; i < count; i++)
    {
        resoult = resoult + text;
    }

    return resoult;
}

string res = Method4(10, "z");
Console.WriteLine(res);*/

/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }

    Console.WriteLine();
}*/

/*Работа с текстом.
Дан текст. в тексте нужно все пробелы заменить черточками,
маденькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".*/

string text = "— Я думаю, — сказал князь,улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винцегероде,"
            + "вы бв взяли приступом согласие прорусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
        
// string s = "qwerty"
//             012345
// s[3] // r

/*string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

