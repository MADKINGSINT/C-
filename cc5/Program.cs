// See https://aka.ms/new-console-template for more information
Console.Write("введите имя пользователя:  ");
string username = Console.ReadLine();


if(username == "мария") {
    Console.WriteLine("Здравствуйте, госпожа");
}
else if (username == "дмитрий")  {
    Console.WriteLine("Здравствуйте господин");

}
else if (username == "илья") {
    Console.WriteLine("Здравствуйте о великий хозяин");
}
else {
    Console.Write("Привет, " );
    Console.Write(username );
    Console.WriteLine(" ");
}