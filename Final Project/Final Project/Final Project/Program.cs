
Console.WriteLine("You have been traped.");
Console.WriteLine("You have to choose between three rooms: the first is full of raging fires; the second, assassins with loaded guns; and the third lions who haven’t eaten in years. Which room is the safest?");
Console.WriteLine("");
string userinput = Console.ReadLine(); 
if (userinput == "Lions"||userinput == "3" || userinput == "Door 3")
{
    Console.WriteLine("");
    Console.WriteLine("The lions starved you move on to the next room.");
    Console.WriteLine("Here you have to solve the riddle for the code.");
    Console.WriteLine(" I am a three-digit number. My second digit is 4 times bigger than the third digit. My first digit is 3 less than my second digit. Guess the number?");
    Console.WriteLine("");
    string userinput2 = Console.ReadLine();
    if (userinput2 == "141")
    {
        Console.WriteLine("");
        Console.WriteLine("You have made it the third room.");
        Console.WriteLine("You found an old man who will lead you to the next room if you guess his riddle.");
        Console.WriteLine("How do you make the number 7 even without addition, subtraction, multiplication, or division?");
        Console.WriteLine("");
        string userinput3 = Console.ReadLine();
        if(userinput3 == "Take away the s"||userinput3 == "Remove the s")
        {
            Console.WriteLine("");
            Console.WriteLine("You found a puppy and a kitten in danger but you can only save one. Who do you save?");
            Console.WriteLine("");
            string userinput4 = Console.ReadLine();
            if (userinput4 == "Puppy"||userinput4 == "puppy")
            {
                Console.WriteLine("");
                Console.WriteLine("The puppy leades you to the final room and to escape you have to guess a number 1-5.");
                Console.WriteLine("");
                Random random = new Random();
                int rnd = random.Next(1, 6);
                string userinput7 = Console.ReadLine();
                bool Winner = false;
                if (userinput7 == "1"||userinput7 == "2"||userinput7 == "3"||userinput7 == "4"||userinput7 == "5")
                {
                    Winner = true;
                    while(Winner = true)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOU WIN!");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("YOU WIN!");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("YOU WIN!");
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("YOU WIN!");
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("YOU WIN!");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("YOU WIN!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Black;
                    for (int i = 0; i < 100; i++)
                    { 
                        return;
                    }
                }
            }
            else if (userinput4 == "Kitty" || userinput4 == "Kitten" || userinput4 == "kitten")
            {
                Console.WriteLine("The cat turns into a witch and forces you to solve a riddle");
                Console.WriteLine("I Can't be seen, I can't be touched. When you see me you can't have me forever. I can give you anything you want, but when I'm gone everything is normal again. What am I?");
                Console.WriteLine("");
                string usueinput5 = Console.ReadLine();
                if(usueinput5 == "A dream")
                {
                    Console.WriteLine("You have now made it to the final room.");
                    Console.WriteLine("To leave pick a number 1-5");
                    Random random = new Random();
                    int rnd = random.Next(1,6);
                    string userinput6 = Console.ReadLine();
                    if (userinput6 == "1" || userinput6 == "2" || userinput6 == "3" || userinput6 == "4" || userinput6 == "5")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("You Lose");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Black;
                        for (int i = 0; i < 100; i++)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("He dissapears in a poor of smoke and you are left in the dark.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("The room fills with gas and you pass out.");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        //shortcut
    }
}
else if (userinput == "Fire"||userinput == "1"||userinput == "Door 1")
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("You burned to death");
    Console.BackgroundColor = ConsoleColor.Black;
    return;
}
else if (userinput == "Assassins"||userinput == "2"||userinput == "Door 2")
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("The assassins shoot you");
    Console.BackgroundColor = ConsoleColor.Black;
}
else
{
    Console.WriteLine("Make sure its spelled correctly.");
}