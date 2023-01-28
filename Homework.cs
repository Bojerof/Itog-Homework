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
int FindSize(string[] array, int findSize)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= findSize) size++;
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
    System.Console.WriteLine("Enter positiv number: ");
    string? bollSize = Console.ReadLine();
    int size;
    if (int.TryParse(bollSize, out size) && size > 0)
        {
            return size;
        }
    else if (bollSize == "")
    {
        Console.WriteLine("Вы хотите выйти из программы?");
        Console.WriteLine("Если да нажмите Y, если нет N");
        char simb = Convert.ToChar(Console.ReadLine());
        if (simb == 'Y' || simb == 'y') Environment.Exit(0);
       
        return Number();
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
Console.WriteLine("Элементы до скольки символов вы хотите увидеть?");
int findSize = Number();
int newSize = FindSize(array, findSize);
string[] newArray = NewArray(array, newSize);
ShowArray(newArray);