using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

int player1 = 2500;
int player2 = 2500;
int player3 = 2500;
int computer = 2500;
(string suit,string power)[] deck = new (string suit, string power)[52];
string [] suits = new string[] {"hearts", "spades", "diamonds","clubs"};
string [] powers = new string[]{"ace","2","3","4","5","6","7","8","9","10","jack","Queen", "King"};
void makedeck()
{
    int counter = 0;
    foreach(string suit in suits)
    {
        foreach(string power in powers)
        {
            deck[counter]= (suit, power);
    counter++;  
        }
    }
    
} makedeck();
void shufflecards()
{
    (string suit,string power)[] deck1 = new (string suit, string power)[26];
    (string suit,string power)[] deck2 = new (string suit, string power)[26];
    for(int x = 0;x<deck.Length; x++) {
    if (x < deck.Length/2)
        {
            deck1[x] = deck[x];

        }
    else {deck2[x/2+1] = deck[x];
        
        }
    
   }
    int counter = 0;
    for(int x = 0;x<deck1.Length;x++) {
        if (x % 2 == 0)
        {
            deck[x]=deck1[x/2];

        }
        else
        {if(x ==1) { deck[x] = deck2[(0)];}
            else
            {

            deck[x] = deck2[(x+1)/2];
}
        }
}}
shufflecards();
foreach((string,string)card in deck)
{
    Console.WriteLine(card);
}

Console.ReadKey();








