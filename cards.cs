namespace finalproject{
    class Card
    {
        public enum Suit
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
        public enum Value
        {
            two = 2,  three, four, five, six, seven
        , eight, nine, ten, jack, queen, king                
        }  
        public Suit mySuit{get;set;}
        public Value myValue{get;set;}
    }
}

