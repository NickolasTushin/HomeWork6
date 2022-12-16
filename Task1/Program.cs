//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
int count = 0;
Console.Write("Вводите числа через пробел:  ");
int[]s = Console.ReadLine().Split(" ").Select (x => int. Parse (x)) . ToArray ();
    
    for (int i = 0; i < s.Length; i ++ )
    {
         if (s[i] > 0)
        {
            count+=1;
         }

     }
    Console.Write($"Количество чисел больше  0  =  {count}  ");
 
