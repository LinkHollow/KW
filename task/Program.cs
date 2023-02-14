
System.Console.WriteLine("Введите первый эллемент массива: ");
string firstEl = Console.ReadLine()!;
System.Console.WriteLine("Введите второй эллемент массива: ");
string secondEl = Console.ReadLine()!;
System.Console.WriteLine("Введите третий эллемент массива: ");
string thirdEl = Console.ReadLine()!;
string[] Array = CreateArray(firstEl, secondEl, thirdEl);
System.Console.WriteLine($"[{String.Join(" ", Array)}]");
// System.Console.WriteLine($"[{String.Join(" ",  SortArray(Array))}]");
string[] ArrayTwo = SortArray(Array);
System.Console.WriteLine($"[{String.Join(" ", ArrayTwo)}]");


// ---------------------Method--------------------

string[] CreateArray(string A,string B,string C)
{
    string[] array = new string[3];
    array[0] = A;
    array[1] = B;
    array[2] = C;
    return array;
}



string[] SortArray(string[] array)
{
    int count = 0;
    string[] newArray = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        string el = array[i];
        int l = el.Length;
        
        if(l < 4)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    string[] newArrayTwo = new string[count];
    for(int i = 0; i < count; i++)
    {
        newArrayTwo[i] = newArray[i];
    }
    
    return newArrayTwo;
}

