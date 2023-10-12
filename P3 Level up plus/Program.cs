// Level up +

Player player1 = new Player();

void AskForExp()
{
    Console.WriteLine("How many experience do you grant?");
    string input0 = Console.ReadLine();
   
    if (input0 == "quit" || input0 == "Quit")
    {
        return;
    }
    
    int input = int.Parse(input0);
    player1.GrantExperience(input);
    
    AskForExp();
}

AskForExp();





