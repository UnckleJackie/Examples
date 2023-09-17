Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Ипать-стрелять, это же МАША!!!");
}
else
{
    Console.Write("Ну йопт, привет, мазафака ");
    Console.WriteLine(username);
}