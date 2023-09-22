
Console.WriteLine("Välj ett ord");


var word = Console.ReadLine().ToLower();


while (word.Length == 0)
{
    Console.WriteLine("Var vänlig och ange ett ord.");

    word = Console.ReadLine().ToLower();
}
/*
word = word.Remove(0, 1).Insert(0,"_");
Console.WriteLine(word);
Console.ReadKey();
*/
var currentGuess = string.Empty;

while (currentGuess.Length < word.Length)
{

    currentGuess = currentGuess + "_";
}



var lives = 10;
var hasWon = false;

while (lives > 0 && !hasWon)
{
    Console.WriteLine(currentGuess);
    Console.WriteLine("Please enter a letter as a guess");
    var guess = Console.ReadLine().ToLower();
    Console.WriteLine();

    for (int i = 0; i < word.Length; i++)
    {
        if (guess == word[i].ToString())
        {
            currentGuess = currentGuess.Remove(i, 1).Insert(i, guess);
        }
    }
    /*
    if (guess == word)
    {
    }

    while (guess.Length != 0 && guess.Length != word.Length)
    {
        Console.WriteLine();

        Console.WriteLine("Var vänlig att ange bara en bokstav eller ett helt ord.");

        guess = Console.ReadLine().ToLower();

    }

    if (guess.Length == 1)
    {
        var guessWasCorrect = false;
        foreach (var letter in word)
        {
            if (letter.ToString().ToLower() == guess.ToLower())
            {
                guessWasCorrect = true;
                Console.WriteLine("The letter you guessed was correct");
            }

        }

        if (guessWasCorrect)
        {
            Console.WriteLine("The letter you guessed was correct");
        }

        else
        {
            lives--;
            Console.WriteLine("You guessed wrong, try again. You have " + lives + " left");
        }

    }



    else if (guess == word)
    {
        hasWon = true;

    }

    else
    {
        lives--;
        Console.WriteLine("You Lose, you currently have " + lives + " lives left");

    }
    */
}

if (hasWon)
{
    Console.WriteLine("You win");
}

else
{
    Console.WriteLine("You lose");
}

