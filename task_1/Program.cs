// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом(первое == последнему, второе == предпоследнему).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
string numstr = num.ToString();
if (numstr.Length == 5) {

if(numstr[0] == numstr[4] && numstr[1] == numstr[3]){
    Console.WriteLine("Да, это палиндром!");

} 
else Console.WriteLine("Нет, это не палиндром!");
}
else Console.WriteLine("Это не пятизначное число!");

