// Card card1 = new Card("Red", "Bird");

// Console.WriteLine(card1);
// card1.Reveal();
// Console.WriteLine(card1);
// card1.Hide();
// Console.WriteLine(card1);

Board board = new Board(2,4);

while(!board.IsGameOver) {
    board.ShowBoard();
    Console.WriteLine();
    //Card[] cards = new Card[2];
    Console.Write("Enter the coordinate for the first card eg(0,1):");
    string pos1 = Console.ReadLine();
    Console.Write("Enter the coordinate for the second card eg(0,1):");
    string pos2 = Console.ReadLine();

    string[] coord1 = pos1.Split(",");
    string[] coord2 = pos2.Split(",");

    int row1 = int.Parse(coord1[0]);
    int col1 = int.Parse(coord1[1]);

    int row2 = int.Parse(coord2[0]);
    int col2 = int.Parse(coord2[1]);

    //get two cards from the board
    Card card1 = board.Get(row1, col1);
    Card card2 = board.Get(row2, col2);

    card1.Reveal();
    card2.Reveal();

    Console.WriteLine($"You picked:{card1} and {card2}");

    if(board.IsMatch(card1, card2)){
        Console.WriteLine("You found a match!");
    } else {
        card1.Hide();
        card2.Hide();
        Console.WriteLine("The card doesnt match!");
    }

    
}
