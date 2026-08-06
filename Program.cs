using System.Diagnostics;
int easyModeWinsInARow = 0;

GameStart();

void GameStart()
{
    while (true)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Numheroes!\n¡Bienvenido a Numheroes!");
        Console.ResetColor();
        Console.WriteLine("\nSelect your language:\nSelecciona tu idioma:");
        Console.WriteLine("\t1. 🇬🇧 English/Inglés\n\t2. 🇪🇸 Spanish/Español\n\t3. Exit/Salir");

        string? startupChoice = Console.ReadLine();

        switch (startupChoice)
        {
            case "1":
                Text.LoadEnglish();
                GameMenu();
                return;
            case "2":
                Text.LoadSpanish();
                GameMenu();
                return;
            case "3":
                Console.WriteLine("See you later!\n¡Nos vemos!");
                return;
            default:
                for (int i = 3; i > 0; i--)
                {
                    Console.Write($"\rInvalid selection. Try again in {i}...\tOpción incorrecta. Intenta de nuevo en {i}...");
                    Thread.Sleep(1000);
                }
                GameStart();
                return;
        }
    }
}

void GameMenu()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("===  NUMHEROES === ");
    Console.ResetColor();

    Console.WriteLine(Text.MainMenu);
    Console.WriteLine(Text.EasyDifficulty);
    Console.WriteLine(Text.HardDifficulty);
    Console.WriteLine(Text.PastResults);
    Console.WriteLine(Text.Exit);

    string? gameMenuChoice = Console.ReadLine();

    switch (gameMenuChoice)
    {
        case "1":
            EasyMode();
            break;
        case "2":
            HardMode();
            break;
        case "3":
            PastScores();
            break;
        case "4":
            Console.WriteLine(Text.OutMessage);
            Thread.Sleep(1500);
            return;

    }

}

void EasyMode()
{
    Console.WriteLine($"{Text.SolveThis}\n");
    Stopwatch timeElapsed = Stopwatch.StartNew();

    int correctAnswers = 0;
    int currentStreak = 0;
    int bestStreak = 0;

    for (int i = 1; i <= 5; i++)
    {
        Question question;

        switch (Random.Shared.Next(4))
        {
            case 0:
                question = QuestionGenerator.EasyAddition();
                break;
            case 1:
                question = QuestionGenerator.EasySubtraction();
                break;
            case 2:
                question = QuestionGenerator.EasyDivision();
                break;
            default:
                question = QuestionGenerator.EasyMultiplication();
                break;
        }

        Console.WriteLine($"{Text.Question} {i}/5");
        Console.WriteLine($"{question.FirstNumber} {question.Operator} {question.SecondNumber} = ?");

        string? input = Console.ReadLine();

        if (int.TryParse(input, out int userAnswer))
        {
            if (userAnswer == question.CorrectAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{Text.Correct}\n");
                Console.ResetColor();
                correctAnswers++;
                currentStreak++;

                if (currentStreak > bestStreak)
                    bestStreak = currentStreak;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Text.Wrong}\n");
                Console.ResetColor();
                currentStreak = 0;
            }
        }
        else
        {
            Console.WriteLine(Text.StopThat);
        }

        Console.WriteLine();
    }

    timeElapsed.Stop();
    int finalTime = (int)Math.Round(timeElapsed.Elapsed.TotalSeconds);

    if (correctAnswers == 5)
    {
        easyModeWinsInARow++;
        WinnersMenu(correctAnswers, finalTime);
    }
    else if (correctAnswers >= 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n{string.Format(Text.CorrectAnswers, correctAnswers)}");
        Console.WriteLine($"{string.Format(Text.Streak, bestStreak)}");
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
        Console.ResetColor();

        easyModeWinsInARow++;

        if (easyModeWinsInARow == 2)
        {
            WinnersMenu(correctAnswers, finalTime);
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{string.Format(Text.CorrectAnswers, correctAnswers)}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{string.Format(Text.Streak, bestStreak)}");
        Console.ResetColor();
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");

        easyModeWinsInARow = 0;

    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{Text.PlayAgain}\n");
    Console.ResetColor();

    string answerPlayAgain = Console.ReadLine()?.ToLower() ?? "n";

    if (answerPlayAgain == "y")
    {
        EasyMode();
    }
    else if (answerPlayAgain == "n")
    {
        GameMenu();
    }
}

void HardMode()
{
    Console.WriteLine($"{Text.SolveThis}\n");
    Stopwatch timeElapsed = Stopwatch.StartNew();

    int correctAnswers = 0;
    int currentStreak = 0;
    int bestStreak = 0;

    for (int i = 1; i <= 5; i++)
    {
        Question question;

        switch (Random.Shared.Next(4))
        {
            case 0:
                question = QuestionGenerator.HardAddition();
                break;
            case 1:
                question = QuestionGenerator.HardSubtraction();
                break;
            case 2:
                question = QuestionGenerator.HardDivision();
                break;
            default:
                question = QuestionGenerator.HardMultiplication();
                break;
        }

        Console.WriteLine($"{Text.Question} {i}/5");
        Console.WriteLine($"{question.FirstNumber} {question.Operator} {question.SecondNumber} = ?");

        string? input = Console.ReadLine();

        if (int.TryParse(input, out int userAnswer))
        {
            if (userAnswer == question.CorrectAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{Text.Correct}\n");
                Console.ResetColor();
                correctAnswers++;
                currentStreak++;

                if (currentStreak > bestStreak)
                    bestStreak = currentStreak;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Text.Wrong}\n");
                Console.ResetColor();
                currentStreak = 0;
            }
        }
        else
        {
            Console.WriteLine(Text.StopThat);
        }
        Console.WriteLine();
    }

    timeElapsed.Stop();
    int finalTime = (int)Math.Round(timeElapsed.Elapsed.TotalSeconds);

    if (correctAnswers == 5)
    {
        HardWinnersMenu(correctAnswers, finalTime);
    }
    else if (correctAnswers >= 3)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n{string.Format(Text.CorrectAnswers, correctAnswers)}");
        Console.WriteLine($"{string.Format(Text.Streak, bestStreak)}");
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n{string.Format(Text.CorrectAnswers, correctAnswers)}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{string.Format(Text.Streak, bestStreak)}");
        Console.ResetColor();
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{Text.PlayAgain}\n");
    Console.ResetColor();

    string answerPlayAgain = Console.ReadLine()?.ToLower() ?? "n";

    if (answerPlayAgain == "y")
    {
        HardMode();
    }
    else if (answerPlayAgain == "n")
    {
        GameMenu();
    }
}

void PastScores()
{
    Console.WriteLine("Feature in progress");
}

void WinnersMenu(int correctAnswers, int finalTime)
{
    if (correctAnswers == 5)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Text.Perfection}\n");
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Text.DamnGood}\n");
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
        Console.ResetColor();
    }

    Console.WriteLine($"1. {Text.EasyAgain}");
    Console.WriteLine($"2. {Text.TryHard}");
    Console.WriteLine($"3. {Text.MainExit}");

    string? winnersChoice = Console.ReadLine();

    switch (winnersChoice)
    {
        case "1":
            EasyMode();
            return;

        case "2":
            HardMode();
            return;

        case "3":
            GameMenu();
            return;
    }
}

void HardWinnersMenu(int correctAnswers, int finalTime)
{
    if (correctAnswers == 5)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Text.Perfection}\n");
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Text.DamnGood}\n");
        Console.WriteLine($"{string.Format(Text.Time, finalTime)}");
        Console.ResetColor();
    }

    Console.WriteLine($"1. {Text.HardAgain}");
    Console.WriteLine($"2. {Text.MainExit}");

    string? winnersChoice = Console.ReadLine();

    switch (winnersChoice)
    {
        case "1":
            HardMode();
            return;

        case "2":
            GameMenu();
            return;

        default:
            return;
    }
}