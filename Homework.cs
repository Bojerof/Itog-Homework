string[] CreatArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Enter symbols: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
int FindSize(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    return size;
}
string[] NewArray(string[] array, int size)
{
    string[] newArray = new string[size];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}
int Number()
{
    System.Console.WriteLine("Enter size: ");
    string bollSize = Console.ReadLine();
    int size;
    if (int.TryParse(bollSize, out size) && size > 0)
        {
    return size;
        }
    else
    {
        Console.Clear();
        System.Console.WriteLine("Enter positiv size!");
        return Number();
    }
        
}

int size = Number();
string[] array = CreatArray(size);
int newSize = FindSize(array);
string[] newArray = NewArray(array, newSize);
ShowArray(newArray);