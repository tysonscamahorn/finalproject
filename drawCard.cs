using System.Text;
namespace finalproject
{
    class DrawCards {
        public static void DrawCardOutline (int xcoor, int ycoor){
           Console.ForegroundColor = ConsoleColor.White;
            int x = xcoor *12;
            int y = ycoor;
            //Console.SetCursorPosition(x,y);
            Console.Write(" __________\n");
            for (int i = 0; i < 10; i++){
             //   Console.SetCursorPosition(x,y+1+i);

                if(i !=9){
                Console.WriteLine("|          |");
                }
                else {
                    Console.WriteLine("|__________|");
                }
            }
        }
         public static void DrawCardSuitValue(Card card, int xcoor, int ycoor){
            char cardSuit =  ' ';
            int x = xcoor *12;
            int y = ycoor;

            switch(card.mySuit){
                case Card.Suit.Hearts :
                cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] {3}) [0];
                Console.ForegroundColor = ConsoleColor.Red;
                break;
                
            

             case Card.Suit.Diamonds :
                cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] {4}) [0];
                Console.ForegroundColor = ConsoleColor.Red;
                break;

             case Card.Suit.Clubs :
                cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] {5}) [0];
                Console.ForegroundColor = ConsoleColor.Black;
                break;

            case Card.Suit.Spades :
                cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] {6}) [0];
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            }   
            Console.SetCursorPosition(x+5,y+5);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x+4, y+7);
            Console.Write(card.myValue);
            }
        }

    }