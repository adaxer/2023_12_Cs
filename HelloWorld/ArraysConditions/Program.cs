int[] numbers = new int[1];
numbers[0] = 1;

int[] onetofive = new int[] { 1, 2, 3, 4, 5 };
List<int> ints = new List<int>(1) { 1 };
ints[0] = 1;
ints.Add(2);
ints.AddRange(onetofive);

// int[] many = new int[]; geht nicht
// many.Add gibts nicht

for (int i = 0; i < onetofive.Length; i++)
{
    Console.WriteLine($"Wert an der Stelle {i}: {onetofive[i]}");
}

int[,] image = new int[4,4];
for (int row=0; row < 4; row++)
{
    for (int col=0; col < 4; col++)
    {
        image[row,col] = row*col;
    }
}

// Bools und ifs
int first = 1;
int second = 2;

if(first>0 && second<5)
{
    Console.WriteLine();
}

bool bool1 = true;
bool bool2 = true;

bool isBoth = bool1 & bool2;
bool isOne = bool1 ^ bool2;

if(isBoth ^ isOne)
{
    Console.WriteLine("Xor greift");
}

// entspricht, ist aber kürzer
if((isBoth & !isOne) || (!isBoth & isOne))
{
    Console.WriteLine("Xor greift");
}

Console.WriteLine(numbers.Length);
numbers[1] = 2;