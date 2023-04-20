void addElement(string[] array)
{
    Console.WriteLine("Введите элементы в массив");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void filterArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    Console.WriteLine($"Конечный массив: [{string.Join(", ", newArray)}]");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
string[] infoArray = new string[n];
addElement(infoArray);
Console.WriteLine($"Наш массив: [{string.Join(", ", infoArray)}]");
filterArray(infoArray);