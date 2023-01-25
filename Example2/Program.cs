int Max(int arg1, int arg2, int arg3)
{
    int result= arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int [] array = { 11, 13, 51, 56, 16, 646, 6, 354, 5756, 56 };
// array[0]=12;
// Console.WriteLine(array[0]);

int max = Max( Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);

int n= array.Length; //Длинна массива

int find=56;
int index =0;
while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // остановка работы условного оператора после первого срабатывания
    }
    index++;
}

void FILLArray (int[] collection)
{
    int lenght =collection.Length;
    int index=0;
    while (index<lenght)
    {
        collection[index] = new Random().Next(1,50);
        index++;

    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position< count)
    {
        Console.WriteLine (col[position]);
        position++;

    }
}

int Indexfind (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position= -1;
    while(index<count)
    {
        if (collection [index] == find) 
        {
            position= index;
            break;
        }

        index++;


    }
    return position;

}


int [] massiv = new int [10]; // создание нового массива с 10 элемнтами , по умолчанию с нолями
FILLArray(massiv); // согласно метода (функции), заполнили массив massiv числами в случайными числами от 1 до 49

massiv[5]=44;

PrintArray(massiv); // распечатали массив mssiv, согласно метода



Console.WriteLine ();

int pos= Indexfind(massiv, 44);
Console.WriteLine (pos);