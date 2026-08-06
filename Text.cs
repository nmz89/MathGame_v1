public static class Text
{
    public static string MainMenu = "";
    public static string EasyDifficulty = "";
    public static string HardDifficulty = "";
    public static string PastResults = "";
    public static string OutMessage = "";
    public static string SolveThis = "";
    public static string Question = "";

    public static string Correct = "";
    public static string Wrong = "";
    public static string StopThat = "";
    public static string CorrectAnswers = "";
    public static string PlayAgain = "";
    public static string Streak = "";
    public static string Perfection = "";
    public static string DamnGood = "";
    public static string MainExit = "";
    public static string Time = "";
    public static string EasyAgain = "";
    public static string HardAgain = "";
    public static string TryHard = "";
    public static string Exit = "";

    public static void LoadEnglish()
    {
        MainMenu = "\nChoose an option:";
        EasyDifficulty = "\t1. Play on EASY mode (addition and subtraction)";
        HardDifficulty = "\t2. Play on HARD mode (multiplication and division)";
        PastResults = "\t3. See past scores";
        MainExit = "Exit";
        Exit = $"\t4. {MainExit}";
        OutMessage = "Too bad! See you!";
        SolveThis = "Introduce the correct answer for this equation (in numbers):";
        Question = "Question";
        Correct = "That's right!";
        Wrong = "That's wrong!";
        StopThat = "Please only enter numerical characters";
        CorrectAnswers = "You had {0} correct answers!";
        PlayAgain = "Do you want to play again? (Y/N)\nPress anything to quit the game.";
        Streak = "You had a streak of {0} correct answers in a row!";
        Perfection = "A truly perfect score!";
        DamnGood = "A really well played game!";
        EasyAgain = "Play EASY mode again!";
        TryHard = "Try HARD mode (multiplication and division)";
        HardAgain = "Play HARD mode again!";
        Time = "You finished in {0} seconds!";
    }

    public static void LoadSpanish()
    {
        MainMenu = "\nElegí una opción:";
        EasyDifficulty = "\t1. Jugar en modo FÁCIL (suma y resta)";
        HardDifficulty = "\t2. Jugar en modo DIFÍCIL (multiplicación y división)";
        PastResults = "\t3. Ver resultados anteriores";
        MainExit = "Salir";
        Exit = $"\t4. {MainExit}";
        OutMessage = "¡Qué mal! ¡Nos vemos!";
        SolveThis = "Resolvé correctamente esta cuenta (en números):";
        Question = "Pregunta";
        Correct = "¡Correcto!";
        Wrong = "¡Incorrecto!";
        StopThat = "Por favor, sólo números";
        CorrectAnswers = "¡Respondiste bien {0} preguntas!";
        PlayAgain = "¿Querés jugar de nuevo? (Y/N)\nPresioná cualquier tecla para salir del juego.";
        Streak = "¡Tuviste una racha de {0} respuestas correctas seguidas!";
        Perfection = "¡Un puntaje realmente perfecto!";
        DamnGood = "¡Muy bien jugado!";
        EasyAgain = "¡Jugar al modo FÁCIL de nuevo!";
        TryHard = "¡Probar el modo DIFÍCIL (multiplicación y división)!";
        HardAgain = "¡Jugá de nuevo al modo DIFÍCIL";
        Time = "Completaste la partida en {0} segundos.";
    }
}