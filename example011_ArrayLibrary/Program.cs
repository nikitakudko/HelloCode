void FILLArray(int[] collection)
{
    int legth = collection.legth;
    int index = 0;
    while(index < legth)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

int[] array = new int[10];
