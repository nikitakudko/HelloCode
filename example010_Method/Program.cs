int[] array = {1, 12, 32, 38, 4, 35, 76, 71, 38};

int n = array.Length;
int find = 38;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}