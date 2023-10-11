// Level up +

Player player1 = new Player();

void AskForExp()
{
    Console.WriteLine("How many experience do you grant?");
    if (Console.ReadLine() == "quit")
    {
        break
    }
    int input = int.Parse(Console.ReadLine());

    player1.GrantExperience(input);
    
    AskForExp();
}

AskForExp();




