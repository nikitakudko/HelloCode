Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("Hurray, It's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}