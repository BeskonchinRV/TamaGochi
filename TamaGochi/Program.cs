using stack;

Console.WriteLine("Собака или кошка?");
string answer = Console.ReadLine().ToLower();
switch (answer)
{
    case "cats": Game.gameCat(); break;
    case "dogs": Game.gameDog(); break;
}
