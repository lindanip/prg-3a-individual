Console.Write("*************************************************\n");
Console.Write("************* ROCK PAPER SCISSORS ***************\n");
Console.Write("Please choose the one of the following options\n");
Console.Write("r for rock\np for paper\ns for scissors\n");
Console.Write("*************************************************\n");
Console.Write("Please enter option\n");

string userOption = Console.ReadLine();


if (userOption == null || userOption.Length > 1)
{
    Console.Write("Incorrect value entered, please check the above available options\n");
    return ;
}

char[] options = {'r', 'p', 's'};
Random random = new Random();
char computerOption = options[random.Next(3)];

Console.WriteLine("Random = " + computerOption + "\n");

if (userOption[0] == computerOption)
    Console.WriteLine("No one won, its a tie.  computer answer = " + computerOption);
else if (userOption[0] == 'r')
{
    if (computerOption == 's')
        Console.WriteLine("You won, computer answer = " + computerOption);
    else
        Console.WriteLine("The computer won, computer answer = " + computerOption);
      }
else if (userOption[0] == 'p')
{
    if (computerOption == 'r')
        Console.WriteLine("You won, computer answer = " + computerOption);
    else
        Console.WriteLine("The computer won, computer answer = " + computerOption);
      }
else if (userOption[0] == 's')
{
    if (computerOption == 'p')
        Console.WriteLine("You won, computer answer = " + computerOption);
    else
        Console.WriteLine("The computer won, computer answer = " + computerOption);
}