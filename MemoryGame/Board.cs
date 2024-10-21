using System.Dynamic;

public class Board
{
    private int rows;
    private int cols;
    private Card[,] cards;
    private int matches;

    public bool IsGameOver{
        get{
            //if all cards are flipped
            return matches*2 == rows* cols;
        }
    }

    public Board(int rows, int cols)
    {
        this.cards = new Card[rows,cols];
        this.rows = rows;
        this.cols = cols;

        RandomCreateCards();
    }

    public void RandomCreateCards()
    {
        string[] cardsToGenerate = {
            "Turtle:Red",
            "Fish:Yellow",
            "Frog:Green",
            "Bird:Blue"
        };

        foreach(string cardCandidate in cardsToGenerate)
        {
            int cardPlaced = 0;
            string[] token = cardCandidate.Split(":");
            while(cardPlaced!=2) {
                Random random  = new Random();
                int row = random.Next(rows);
                int col = random.Next(cols);


                //the spot is available
                if(this.cards[row,col] == null) {
                    Card card = new Card(token[0], token[1]);
                    this.cards[row,col] = card;
                    cardPlaced++;
                }
            }
        }
    }

    public void ShowBoard()
    {

        for(int row = 0; row < this.rows; row++) {
            for(int col = 0; col < this.cols; col++) {
                Console.Write(cards[row,col] + " ");
            }

            Console.WriteLine();
        }
    }


    public Card Get(int row, int col)
    {
        Card card = this.cards[row,col];
        return card;
    }

    public bool IsMatch(Card card1, Card card2)
    {
        bool match = card1.Equals(card2);
        if(match == true){
            matches++;
        } 
        return match;
    }
}