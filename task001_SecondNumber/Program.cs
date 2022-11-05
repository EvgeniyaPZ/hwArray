Console.WriteLine("Enter number: ");
int A=Convert.ToInt32(Console.ReadLine());

bool number (int NumberEnter)
{
    return (NumberEnter>100 & NumberEnter <1000);
}

int number1 (int NumberEnter1)
{
    int D = NumberEnter1/10;
    //Console.WriteLine(D);
    D =D%10;
    return D;
    }
bool B=number(A);

if (B)
{
    //int C = A%100;
    Console.WriteLine(number1(A));
}
else
{
    Console.WriteLine("Error");
}


