namespace Rock__Paper__Scissors;

public class ComputerChoice
{
    public int Choice;
    public ComputerChoice()
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(1, 4);
        Choice = rndNum;
    }
}
