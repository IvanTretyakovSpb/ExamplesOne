Console.Write("Введите ваше имя: ");
String userName = Console.ReadLine();

if(userName.ToLower() == "маша")
{
    Console.WriteLine("Отлично! Это же Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName + "!");
}
