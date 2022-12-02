using finalproject;

Console.SetWindowSize(65,40);
Console.BufferWidth=65;
Console.BufferHeight = 40;
Console.Title = "Poker Game";
DealCards dc= new DealCards();
bool quit = false;
while(!quit)
{
    dc.Deal();

    char selection = ' ';
    while(!selection.Equals('Y')&& !selection.Equals('N'))
    {
        Console.WriteLine("Do you want to play agian? Y/N");
        selection = Convert.ToChar(Console.ReadLine().ToUpper());
        if( selection.Equals('Y')){
            quit = false;
        }
        else if (selection.Equals('N'))
        {
            quit = true;

        }
        else
        Console.WriteLine("Invalid selection. Try again");
    }
}

Console.ReadKey();
