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

int GetIncreases()
{
    int previous_depth = 0;
    int current_depth = 1;
    int increase_counter = 0;

    while (current_depth <= numbers.Length - 1)
    {
        if (numbers[previous_depth] < numbers[current_depth])
        {
            increase_counter++;
        }
        previous_depth++;
        current_depth++;
    }
    return increase_counter;
}

PopulateInput();
Console.WriteLine(GetIncreases());