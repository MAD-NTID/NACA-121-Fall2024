using System.Linq.Expressions;
using System.Net;

public class Board
{
    private Piece[,] board;
    private const int SIZE = 3;

    public Board()
    {
        this.board = new Piece[SIZE,SIZE];

    }

    public bool Place(int row, int col, Piece piece)
    {
        //the piece cannot be placed at the spot as it is already occupied
        if(board[row,col]!=null){
            return false;
        }

        //we can place the piece at the spot
        this.board[row,col] = piece; //put it down
        return true; //true indicated that the piece was successfully placed
    }

    public Piece Get(int row, int col)
    {
        return this.board[row,col];
    }

    public bool IsWon()
    {
        for(int row = 0; row < SIZE; row++)
        {
            int count = 0;
            Piece piece = this.board[0,0];
            for(int col = 0; col < SIZE; col++)
            {
                Piece column = this.board[col,row];
                if(column is not null && piece is not null && piece.Equals(column))
                {
                    count++;
                }
                
            }

            if(count == 3)
                return true;
        }

        return false;
    }




}