string[] inputs = new string[1000];

//Positions
int pos_hori = 0;
int pos_vert = 0;
int aim = 0; 

void PopulateInput()
{
	int i= 0; 

    foreach (string line in System.IO.File.ReadLines("input.txt"))
    {
        inputs.SetValue(line, i);
        i++;
    }
}

int ProcessInput()
{
	foreach(string line in inputs)
	{
		string[] instruction = line.Split(" ");
		
		switch (instruction[0].ToLower())
		{
			case "forward":
				pos_hori += System.Int32.Parse(instruction[1]);
				pos_vert += aim * System.Int32.Parse(instruction[1]);
				break;
			case "down":
				aim += System.Int32.Parse(instruction[1]);
				break;
			case "up":
				aim -= System.Int32.Parse(instruction[1]);
				break;
			default:
				Console.WriteLine("Command not found.");
				break;
		}
	}
	return pos_hori * pos_vert;
}

PopulateInput();
Console.WriteLine($"Answer: {ProcessInput()}");