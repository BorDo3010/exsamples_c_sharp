Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "борис")
{
    Console.WriteLine("Приветствую тебя, о великолепный! ");

}
else
{
   Console.Write("Привет, "); 
   Console.WriteLine(username);
}