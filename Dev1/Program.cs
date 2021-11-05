// Задача
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные

// Задали массив
int GetRandom(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue);
}

// Наполнили массив
int [] A = new int [10];
int index = 0;

while (index<A.Length)
{
    A[index]= GetRandom(-10, 100); // получаем полуинтервал [-10;100)
    index++;
}

index=0;
while (index<A.Length)
{
    Console.WriteLine(A[index]);
     index++;
}

// Отбрасываем числа из массива, которые нарушают порядок возрастания
Console.WriteLine();
Console.WriteLine("отбрасываем числа, нарушающие порядок возрастания");
index = 1;
int firstElement = A[0];
Console.WriteLine(firstElement+ " ");
while (index<A.Length)
{
    if (A[index]>firstElement) 
    {
        Console.WriteLine(A[index]);
        firstElement = A[index];
    }
index++;

} 

// Отбрасываем числа, которые больше среднего арифметического элементов A
Console.WriteLine();
Console.WriteLine("отбрасываем числа > среднего (A)");
int sum = 0;
int avr = 0;
for (int i = 0; i < A.Length; i++)
     sum += A[i];
     avr= sum/A.Length;
Console.WriteLine(avr + "<-среднее");

Console.WriteLine();
index =0;
while (index<A.Length)
{
     if(A[index]<avr)
     Console.WriteLine (A[index]);
index++;
} 

// Отбрасываем числа, которые четные
Console.WriteLine();
Console.WriteLine("отбрасываем из массива четные числа");
index = 0;
while (index<A.Length)
{
    if(A[index]%2!=0)
    Console.WriteLine (A[index]);
index++;
}

