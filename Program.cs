string[] arr = {"hello", "2", "world", ":-)"};
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    int length = arr[i].Length;
    if (length <= 3)
    {
        count++;
    }
}
string[] array = new string[count];
int j = 0;
while (j < array.Length)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int length = arr[i].Length;
        if (length <= 3)
        {
            array[j] = arr[i];
            j++;
        }
    }
}
void ShowArray(string[] myarray)
{
    for (int a = 0; a < myarray.Length; a++)
    {
        Console.Write(myarray[a] + " ");
    }
}
ShowArray(array);
