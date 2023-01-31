namespace Rock__Paper__Scissors;

public class RoundWinner
{
    public string Winner;
    public RoundWinner(int playerNum, int computerNum)
    {
        if (playerNum == computerNum)
        {
            Winner = "TIE";
        }
        else if (playerNum == 1)
        {
            if (computerNum == 2)
            {
                Winner = "COMPUTER";
            }
            else
            {
                Winner = "PLAYER";
            }
        }
        else if (playerNum == 2)
        {
            if (computerNum == 3)
            {
                Winner = "COMPUTER";
            }
            else
            {
                Winner = "PLAYER";
            }
        }
        else if (playerNum == 3)
        {
            if (computerNum == 1)
            {
                Winner = "COMPUTER";
            }
            else
            {
                Winner = "PLAYER";
            }
        }
    }
}
