﻿int num = 0;
String[] array = new String[5];
String[] newArray = new String[array.Length];
Console.WriteLine("enter the words");

for (int i = 0; i < array.Length; i++)
{
    String word = Console.ReadLine();
    array[i] = word;
}

Console.WriteLine(" ");
Console.WriteLine("the original array");
arrayOutput(array);
formingNewArray(array, newArray);
Console.WriteLine("newly formed array");
arrayOutput(newArray);


void formingNewArray (String[] array, String[] newArray){
int j = 0;
for (int i = 0; i < newArray.Length; i++)
{
    if(array[i].Length <= 3) {
        newArray[j++] = array[i];
    }
}
}


void arrayOutput(String[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} "); 
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}
