//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//строго больше 0 ввёл пользователь.  0, 7, 8, -2, -2 -> 2

int[] array1 = GetNums();
Console.WriteLine($"В Вашем массиве [{String.Join(",", array1)}] {GetCountPosElement(array1)}  положительных чисел");

Console.WriteLine(String.Empty);

//Задача 43: Написать программу, которая на вход принимает массив из любого количества 
//элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, 
//но отсортированный по возрастанию(от меньшего числа к большему).
int size = new Random().Next(1, 10);
int[] array2 = GetArray(size, 0, 100);
Console.WriteLine($"Случайный массив [{String.Join(",", array2)}]");
int[] array3 = GetSelectionSort(array2);
Console.WriteLine($" Случайный массив по возрастанию [{String.Join(",", array3)}]");


//      методы

int[] GetNums(){ //ввод массива через косоль
      Console.WriteLine($"Сколько чисел Вы хотите ввести");
      int M = int.Parse(Console.ReadLine()!);
      int [] res = new int[M];
      for(int i = 0; i < M; i++){
        Console.WriteLine($"Введите число:  ");
       
        res[i] = int.Parse(Console.ReadLine()!);
    }
    return res;
}

int GetCountPosElement(int[] array){  //считаем число положительных чисел 
    int count = 0;
    foreach(int el in array)
    {
        if(el > 0)
        {
            count++;
        }
    } 
    return count;
} 


int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] GetSelectionSort (int[] array){//сортировка массива
      int[] res = new int[array.Length];
      for (int i=0; i<array.Length; i++){
            int min = i;
            for (int j=i+1; j<array.Length; j++){
                  if(array[j]<array[min]) min=j;
            }
            res[i] = array[min];
            array[min] = array[i];
      }
      return res;
}