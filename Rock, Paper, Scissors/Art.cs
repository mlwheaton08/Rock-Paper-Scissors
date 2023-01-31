namespace Rock__Paper__Scissors;

public class Art
{
    public Art(int option)
    {
        switch (option)
        {
            case 1:
                Console.WriteLine($@"    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)");
                break;
            case 2:
                Console.WriteLine($@"     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)");
                break;
            case 3:
                Console.WriteLine($@"    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)");
                break;
            default:
                break;
        }
    }
}
