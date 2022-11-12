Console.WriteLine("N task: ");
int n = Convert.ToInt32(Console.ReadLine());

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// int CountDigit(int number)
// {
//     int count= 0;
//     number=12321;
//     if (number>0)
//     {
//        number= number/10;
       
//        count= count+1;
//     }
//     return count;
// }


int GetLengthNumber(int number)
{
    int count = 0;
    while(number > 0)
    {
        number /= 10;
        count++;
    }
    return count;
}

int[] MadeArray(int number)
{
    
    int[] array = new int[5];

    for (int i=4;i>=0;i--)
    {
    array[i]=number%10;
    number/=10;
    }
  return array;  
    
}

int[] MadeArray2(int number)
{
    
    int[] array = new int[5];

    for (int i=0;i<5;i++)
    {
    array[i]=number%10;
    number/=10;
    }
 return array;   
    
}
void PrintArray (int[] number)
{
    for (int i=0; i<number.Length;i++)
    {
    Console.Write(number[i]);
    }
}
//PrintArray(MadeArray(12345));
//PrintArray(MadeArray2(14852));

if (n==19)
{
Console.WriteLine("Enter number: ");
//bool inParseA= int.TryParse(Console.ReadLine(), out int N);
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(N);
// if (inParseA)
// {
//     Console.WriteLine("Error");
// }
Console.WriteLine(GetLengthNumber(N));


/*if (GetLengthNumber(N)==5);
{*/
     int[] result = MadeArray(N);
     int[] result2 = MadeArray(N);
   // bool result = MadeArray(N).SequenceEqual(MadeArray2(N));
   //bool result3 = Enumerable.SequenceEqual(result, result2);
   //Console.WriteLine(result3);
    if(result[0]==result2[4] & result[1]==result2[3])
    // int h=0;
    // int result = MadeArray[h];
    // int result2 = MadeArray[h];
    // if (MadeArray(N)[h]==MadeArray2(N)[h] & MadeArray(N)[h+1]==MadeArray2(N)[h+1])
     {
         Console.WriteLine("yes");
     }
     else {Console.WriteLine("No");}
  /*  }
else 
{Console.WriteLine("Error2");}*/


}



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (int x1,int y1,int z1,int x2,int y2,int z2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)));
    return result;
}

if (n==21)
{
    int xA= Convert.ToInt32(Console.ReadLine());
    int yA= Convert.ToInt32(Console.ReadLine());
    int zA= Convert.ToInt32(Console.ReadLine());
    int xB= Convert.ToInt32(Console.ReadLine());
    int yB= Convert.ToInt32(Console.ReadLine());
    int zB= Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Distance(xA,yA,zA,xB,yB,zB));
}


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void Cube (int N)
{
    double[] array = new double[N];

    int i=0;
    //for (int i = 0; i<N;i++)
    while(i<N)
    {
    array[i]=Math.Pow((i+1),3);
    Console.Write($"{array[i]} ");
    i++;
    }

}
if (n==23)
{
    int number = Convert.ToInt32(Console.ReadLine());
    Cube(number);
}