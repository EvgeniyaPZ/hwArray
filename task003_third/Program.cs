Console.WriteLine("Enter number: ");
int A=Convert.ToInt32(Console.ReadLine());

bool number (int NumberEnter)
{
    return (NumberEnter>100);
}

int countArray (int N)
 {
    int i=0;
    for (i=0; N>0; i++)
        N/=10;
    return i;
 }

bool S = number(A);
Console.WriteLine(countArray(A));

if (S)
{
    int E= A;
    int F=0;
    for(int c=0; c<countArray(A)-2;c++,E/=10)
        F = E%10;
        //E/=10;
        
    Console.WriteLine(F);

}
else
{
    Console.WriteLine("Error");
}
// void FullArray1 (int[] array)
// {
//     int count = array.Length;
//     int index= 0;
//     while (index<count);
//     {
//         array[index]= array%10;
//         array/=10;
//         index++;
//     }
// }

// int W=FullArray1(A)[3];
// Console.WriteLine(W);

// int[] array(int D)
// {
//     int i = 0;
//     for (i=0; D>0; i++)
//         D/=10;
//     int[] arr = new int(3);
//     for(int c=0;c<i;c++)
//     arr[c]=D%10;
//     D/=10;
//     return arr.ToArray;
// }

// int B = countArray(A);
// if (number(A))
// {
//     Console.WriteLine(array(A,countArray(A)))[2];
// }
// else
// {
//     Console.WriteLine("Error");
// }


// void PrintArray1 (int[] arr)
// {
//     int count =arr.Length;
//     int position = 0;
//     while (position<count)
//     {
//         Console.WriteLine(arr[position]);
//         position++;
//     }
// }

// int MaxFigure(int max)
// {
    
// }
