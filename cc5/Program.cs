// See https://aka.ms/new-console-template for more information
Console.Write("введите имя пользователя:  ");
string username = Console.ReadLine();


if(username.ToLower == "мария") {
    Console.WriteLine("Здравствуйте, госпожа");
}
else if (username.ToLower == "дмитрий")  {
    Console.WriteLine("Здравствуйте господин");

}
else if (username.ToLower == "илья") {
    Console.WriteLine("Здравствуйте о великий хозяин");
}
else {
    Console.Write("Привет, " );
    Console.Write(username );
    Console.WriteLine(" ");
}