Console.WriteLine("Enter number: ");
int A=Convert.ToInt32(Console.ReadLine());

bool number (int NumberEnter)
{
    return (NumberEnter>99 & NumberEnter <1000);
}

int lengthArray (int C)
{
    int count = 0;
    while (C>0)
    {
        count++;
    }
    return count;
}

int[] GetSecondNumber (int W)
{
    int length = lengthArray(W);
    int[] newArray = new int(length);
    for(int i=length-1; i<length; i--)
    {
  
        newArray[i]=W%10;
        W=W/10;

    }
}


// if (B)
// {
//     //int C = A%100;
//     Console.WriteLine(number1(A));
// }
// else
// {
//     Console.WriteLine("Error");
// }


