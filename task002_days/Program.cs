bool weekDays (int Number)
{
    return (Number ==6 || Number ==7);
}

Console.WriteLine("Enter number: ");

int A = Convert.ToInt32(Console.ReadLine());
bool B = weekDays(A);

if (B)
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Working days");
}
