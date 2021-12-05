
int[] numbers = new int[2000];

void PopulateInput()
{
    int i= 0; 

    foreach (string line in System.IO.File.ReadLines("input.txt"))
    {
        numbers.SetValue(Int32.Parse(line), i);
        i++;
    }
}

int FindCount()
{
    int increase_counter = 0;
    
    int pos_a = 1;
    int pos_b = 2;
    int pos_c = 3;

    int sum_a = numbers[pos_a] + numbers[pos_b] + numbers[pos_c];
    int sum_b = 0;

    while (pos_c <= numbers.Length - 1)
    {
        Console.WriteLine("pos_a: {0}\npos_b: {1}\npos_c: {2}\n", numbers[pos_a], numbers[pos_b], numbers[pos_c]);
        sum_b = numbers[pos_a] + numbers[pos_b] + numbers[pos_c];
        Console.WriteLine("Sum: {0}\n\n", sum_b);
        pos_a++; pos_b++; pos_c++;

        if (sum_b > sum_a)
        {
            increase_counter++;
        }
        sum_a = sum_b;
    }

    return increase_counter;
}

PopulateInput();
Console.WriteLine("Total increases: {0}", FindCount());