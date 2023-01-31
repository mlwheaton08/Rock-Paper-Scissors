namespace Rock__Paper__Scissors;

public class Match
{
    private int _playerPoints = 0;
    private int _computerPoints = 0;
    private string _victor = "";

    public void Play()
    {
        while (_victor == "")
        {
            Console.Clear();
            Console.WriteLine($@"---------------------------
| Player: {_playerPoints} | Computer: {_computerPoints} |
---------------------------
Choose:
1) Rock
2) Paper
3) Scissors");
            int playerChoice = int.Parse(Console.ReadLine());
            ComputerChoice computerChoice = new ComputerChoice();
            new Art(playerChoice);
            Thread.Sleep(1000);
            new Art(computerChoice.Choice);

            RoundWinner winner = new RoundWinner(playerChoice, computerChoice.Choice);
            switch (winner.Winner)
            {
                case "PLAYER":
                    _playerPoints++;
                    Console.WriteLine($"WINNER: {winner.Winner}");
                    break;
                case "COMPUTER":
                    _computerPoints++;
                    Console.WriteLine($"WINNER: {winner.Winner}");
                    break;
                case "TIE":
                    Console.WriteLine($"WINNER: {winner.Winner}");
                    break;
                default:
                    break;
            }

            if (_playerPoints == 3)
            {
                _victor = "PLAYER";
            }
            else if (_computerPoints == 3)
            {
                _victor = "COMPUTER";
            }
            else
            {
                Console.Write("Press Enter to start next round.");
                Console.ReadLine();
            }
        }
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine($@"---------------------------
| Player: {_playerPoints} | Computer: {_computerPoints} |
---------------------------

WINNER: {_victor}");
    }
}