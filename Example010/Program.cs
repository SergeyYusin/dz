

int[] array = { 15, 28, 37, 44, 56, 56, 473, 82, 91 };

int n = array.Length;
int find = 56;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index ++;
}