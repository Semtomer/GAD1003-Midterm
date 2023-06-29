using System;

class Midterm_Project
{
    static void Main(string[] args)
    {
        // Here we have defined the variables required in the codes.
        string decision;
        string decision2;
        int decision3;
        string decision4;
        string decision5;
        string decision6;
        int yourGuess;
        int yourBet;
        decimal yourcredits = 50000000000000000;

        // We printed the welcome message to the casino at the first entrance.
        Console.WriteLine("Hello dear player,");
        Console.WriteLine("Welcome to our Underground Casino");

        // Here we have defined the loop of the lobby.
        bool lobby;

        do
        {
            // The game loop is here.
            lobby = false;


            if (yourcredits == 0)
            {
                Console.WriteLine("Your credit is zero and you lost the game!");
            }
            else
            {
                // This is the lobby.
                Console.WriteLine($"You have {yourcredits} credits to start the games.");
                Console.WriteLine("When your credit goes to zero, you fail in the game and the game is over.");
                Console.WriteLine("Which game do you want to play?");
                Console.WriteLine("Press 1 for Dice game.");
                Console.WriteLine("Press 2 for Guess game.");
                Console.WriteLine("Press 3 to exit the casino.");

                decision = Console.ReadLine();
                Console.WriteLine("********************************************************************************************************");

                // The player chooses which game he/she wants to play.

                if (decision == "3")
                {
                    Console.WriteLine("See you again.");
                }
                else if (decision == "1")
                {
                    // The loop of the dice game is here.

                    Console.WriteLine("Hi there, welcome to our Dice game.");
                    Console.WriteLine("Rules;");
                    Console.WriteLine("Cash box and you roll 2 dice in a round in the dice game.");
                    Console.WriteLine("Who going to roll first will be determined after the single dice you roll soon.");
                    Console.WriteLine("********************************************************************************************************");

                    // Here are the single dice codes rolled for dice priority in the game.
                    Random priority = new Random();
                    int diceofcashBox = priority.Next(1, 7);
                    int yourdice = priority.Next(1, 7);

                    Console.WriteLine($"You rolled {yourdice}.");
                    Console.WriteLine($"Cash Box rolled {diceofcashBox}.");

                    if (yourdice == diceofcashBox)
                    {
                        // Equality loop on single dice.
                        Console.WriteLine("There is an equality with the Cash Box.");
                        Console.WriteLine("********************************************************************************************************");

                        bool equality;

                        do
                        {
                            diceofcashBox = priority.Next(1, 7);
                            yourdice = priority.Next(1, 7);

                            if (yourdice == diceofcashBox)
                            {
                                Console.WriteLine($"You rolled {yourdice}.");
                                Console.WriteLine($"Cash Box rolled {diceofcashBox}.");
                                Console.WriteLine("There is an equality with the Cash Box.");
                                Console.WriteLine("********************************************************************************************************");
                                equality = true;
                            }
                            else
                            {
                                Console.WriteLine($"You rolled {yourdice}.");
                                Console.WriteLine($"Cash Box rolled {diceofcashBox}.");
                                equality = false;
                            }

                        } while (equality);
                    }

                    // We've printed who gets priority in the single dice here.
                    if (yourdice > diceofcashBox)

                    {
                        Console.WriteLine("You will roll the dice first.");
                        Console.WriteLine("********************************************************************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Cash Box will roll the dice first.");
                        Console.WriteLine("********************************************************************************************************");
                    }

                    // We ask if it is a bet or a lobby.
                    Console.WriteLine("Press 1 to place a bet.");
                    Console.WriteLine("Press 2 to go back to the lobby.");

                    decision2 = Console.ReadLine();
                    Console.WriteLine("********************************************************************************************************");

                    if (decision2 != "1" && decision2 != "2")
                    {
                        // Loop when wrong input is entered
                        bool wrongInput;
                        do
                        {
                            Console.WriteLine("You entered wrong input!!!");
                            Console.WriteLine("Press 1 to place a bet.");
                            Console.WriteLine("Press 2 to go back to the lobby.");
                            decision2 = Console.ReadLine();
                            Console.WriteLine("********************************************************************************************************");

                            if (decision2 != "1" && decision2 != "2")
                            {
                                wrongInput = true;
                            }
                            else
                            {
                                wrongInput = false;
                            }
                        } while (wrongInput);
                    }

                    if (decision2 == "1")
                    {
                        bool rebet;
                        // Here is the loop required for the player to bet again.
                        do
                        {

                            bool insufficientBalance;
                            // Here is the loop required when the player enters the wrong input.
                            do
                            {
                                Console.WriteLine("Press the numbers to place a bet.");

                                while (!int.TryParse(Console.ReadLine(), out decision3))
                                {
                                    Console.WriteLine("You entered an invalid value, try again.");
                                }

                                if (yourcredits < decision3)
                                {
                                    Console.WriteLine("You don't have that much credits! Make a bet with less credits.");
                                    Console.WriteLine("********************************************************************************************************");

                                    insufficientBalance = true;
                                }
                                else
                                {
                                    Console.WriteLine($"You bet with {decision3} credits.");
                                    insufficientBalance = false;
                                }

                            } while (insufficientBalance);

                            Console.WriteLine("Bets are over.");

                            // Double dice game loop based on priority on single dice.
                            if (yourdice > diceofcashBox)
                            {
                                // Double dice will be determined here.
                                Random dice = new Random();
                                int yourdice2 = dice.Next(1, 7);
                                int yourdice3 = dice.Next(1, 7);
                                int diceofcashBox2 = dice.Next(1, 7);
                                int diceofcashBox3 = dice.Next(1, 7);

                                Console.WriteLine($"You rolled {yourdice2}, {yourdice3}.");
                                Console.WriteLine($"Cash Box rolled {diceofcashBox2}, {diceofcashBox3}.");

                                // The result according to the sum of the rolled dice.
                                int yourdiceResult = yourdice2 + yourdice3;
                                int diceofcashBoxResult = diceofcashBox2 + diceofcashBox3;

                                if (yourdiceResult == diceofcashBoxResult)
                                {
                                    //  If this result is together, this loop begins.

                                    Console.WriteLine("There is an equality with the Cash Box.");
                                    Console.WriteLine("********************************************************************************************************");

                                    bool equality2;

                                    do
                                    {
                                        yourdice2 = dice.Next(1, 7);
                                        yourdice3 = dice.Next(1, 7);
                                        diceofcashBox2 = dice.Next(1, 7);
                                        diceofcashBox3 = dice.Next(1, 7);

                                        Console.WriteLine($"You rolled {yourdice2}, {yourdice3}.");
                                        Console.WriteLine($"Cash Box rolled {diceofcashBox2}, {diceofcashBox3}.");

                                        yourdiceResult = yourdice2 + yourdice3;
                                        diceofcashBoxResult = diceofcashBox2 + diceofcashBox3;

                                        if (yourdiceResult == diceofcashBoxResult)
                                        {
                                            equality2 = true;
                                        }
                                        else
                                        {
                                            equality2 = false;
                                        }

                                    } while (equality2);
                                }

                                // Win, lose loop according to the results of the sums.
                                if (yourdiceResult > diceofcashBoxResult)
                                {
                                    Console.WriteLine("*** < You won > ***");
                                    yourcredits += decision3;
                                    Console.WriteLine($"You have {yourcredits} credits.");
                                    Console.WriteLine("********************************************************************************************************");
                                }
                                else
                                {
                                    Console.WriteLine("Cash Box won!");
                                    yourcredits -= decision3;
                                    Console.WriteLine($"You have {yourcredits} credits.");
                                    Console.WriteLine("********************************************************************************************************");
                                }
                            }
                            else
                            {
                                // Double dice game loop when Cash box wins single dice.
                                Random dice = new Random();
                                int diceofcashBox2 = dice.Next(1, 7);
                                int diceofcashBox3 = dice.Next(1, 7);
                                int yourdice2 = dice.Next(1, 7);
                                int yourdice3 = dice.Next(1, 7);

                                Console.WriteLine($"Cash Box rolled {diceofcashBox2}, {diceofcashBox3}.");
                                Console.WriteLine($"You rolled {yourdice2}, {yourdice3}.");

                                int diceofcashBoxResult = diceofcashBox2 + diceofcashBox3;
                                int yourdiceResult = yourdice2 + yourdice3;

                                if (yourdiceResult == diceofcashBoxResult)
                                {
                                    Console.WriteLine("There is an equality with the Cash Box.");
                                    Console.WriteLine("********************************************************************************************************");

                                    bool equality2;

                                    do
                                    {
                                        diceofcashBox2 = dice.Next(1, 7);
                                        diceofcashBox3 = dice.Next(1, 7);
                                        yourdice2 = dice.Next(1, 7);
                                        yourdice3 = dice.Next(1, 7);

                                        Console.WriteLine($"Cash Box rolled {diceofcashBox2}, {diceofcashBox3}.");
                                        Console.WriteLine($"You rolled {yourdice2}, {yourdice3}.");

                                        diceofcashBoxResult = diceofcashBox2 + diceofcashBox3;
                                        yourdiceResult = yourdice2 + yourdice3;

                                        if (yourdiceResult == diceofcashBoxResult)
                                        {
                                            equality2 = true;
                                        }
                                        else
                                        {
                                            equality2 = false;
                                        }

                                    } while (equality2);
                                }


                                if (yourdiceResult > diceofcashBoxResult)
                                {
                                    Console.WriteLine("*** < You won > ***");
                                    yourcredits += decision3;
                                    Console.WriteLine($"You have {yourcredits} credits.");
                                    Console.WriteLine("********************************************************************************************************");
                                }
                                else
                                {
                                    Console.WriteLine("Cash Box won!");
                                    yourcredits -= decision3;
                                    Console.WriteLine($"You have {yourcredits} credits.");
                                    Console.WriteLine("********************************************************************************************************");
                                }
                            }


                            if (yourcredits == 0)
                            {
                                // If the player has no money as a result of him/her bet, him/her credit will work.
                                lobby = true;
                                rebet = false;
                            }
                            else
                            {
                                // This loop works if the player has money after placing a bet. It asks if the player wants to bet again.
                                Console.WriteLine("Press 1 to place another bet.");
                                Console.WriteLine("Press 2 to go back to the lobby.");

                                decision2 = Console.ReadLine();
                                Console.WriteLine("********************************************************************************************************");

                                // This returns to the rebet and lobby loops.
                                if (decision2 == "1")
                                {
                                    rebet = true;
                                }
                                else if (decision2 == "2")
                                {
                                    rebet = false;
                                    lobby = true;
                                }
                                else
                                {
                                    // If the wrong input is entered, this will work.
                                    bool wrongInput2;
                                    do
                                    {
                                        Console.WriteLine("You entered wrong input!!!");
                                        Console.WriteLine("Press 1 to place another bet.");
                                        Console.WriteLine("Press 2 to go back to the lobby.");

                                        decision2 = Console.ReadLine();
                                        Console.WriteLine("********************************************************************************************************");

                                        if (decision2 == "1")
                                        {
                                            rebet = true;
                                            wrongInput2 = false;
                                        }
                                        else if (decision2 == "2")
                                        {
                                            rebet = false;
                                            lobby = true;
                                            wrongInput2 = false;
                                        }
                                        else
                                        {
                                            wrongInput2 = true;
                                            rebet = false;
                                        }
                                    } while (wrongInput2);
                                }
                            }
                        } while (rebet);
                    }
                    else if (decision2 == "2")
                    {
                        // Here is the code for returning to the lobby after single rolls.
                        lobby = true;
                    }
                }
                else if (decision == "2")
                {
                    // The loop of the Guess game is here.
                    Console.WriteLine("Hi there, welcome to our Guess game.");
                    Console.WriteLine("Rules;");
                    Console.WriteLine("Cash box will choose a random number between 0 and 1000 in this game.");
                    Console.WriteLine("You will bet and try to find this number.");
                    Console.WriteLine("If you guessed the number correctly, you will win 3500 credits.");
                    Console.WriteLine("If you can't guess right, Cash box will tell you if your guess is higher or lower than the number.");
                    Console.WriteLine("You can bet again with this information.");
                    Console.WriteLine("********************************************************************************************************");

                    // Here is the loop required for the player to play the round again.
                    bool reround = true;
                    while (reround)
                    {
                        // Here the cash box picks random numbers.
                        Random pickNumber = new Random();
                        int theNumber = pickNumber.Next(0, 1000);
                        Console.WriteLine("Cashbox has chosen a number between 0 and 1000.");

                        // Here we have defined the lowest bet.
                        int lowestBet = 50;

                        // Here the player have the choice of betting or lobbying.
                        Console.WriteLine("Press 1 to place a bet.");
                        Console.WriteLine("Press 2 to go back to the lobby.");
                        decision4 = Console.ReadLine();
                        Console.WriteLine("********************************************************************************************************");

                        // Here is the loop where it tries to find the number again.
                        bool rebet2 = true;
                        while (rebet2)
                        {
                            // This works if the wrong input is entered.
                            if (decision4 != "1" && decision4 != "2")
                            {
                                bool wrongInput3;
                                do
                                {
                                    Console.WriteLine("You entered wrong input!");
                                    Console.WriteLine("Press 1 to place a bet.");
                                    Console.WriteLine("Press 2 to go back to the lobby.");
                                    decision4 = Console.ReadLine();
                                    Console.WriteLine("********************************************************************************************************");

                                    if (decision4 != "1" && decision4 != "2")
                                    {
                                        wrongInput3 = true;
                                    }
                                    else
                                    {
                                        wrongInput3 = false;
                                    }
                                } while (wrongInput3);
                            }

                            // Here is the loop of betting and guessing.
                            if (decision4 == "1")
                            {

                                Console.WriteLine($"You can play {lowestBet} as the lowest bet.");
                                Console.WriteLine($"You have {yourcredits} credits now.");

                                // Here the player enters the guess.
                                Console.WriteLine("Enter your guess.");

                                while (!int.TryParse(Console.ReadLine(), out yourGuess))
                                {
                                    Console.WriteLine("You entered an invalid value, try again.");
                                }

                                // This loop will work if the player doesn't have enough credits.
                                bool insufficientBalance2;
                                do
                                {
                                    // Here the player places him/her bet.
                                    Console.WriteLine("Enter your bet.");
                                    while (!int.TryParse(Console.ReadLine(), out yourBet))
                                    {
                                        Console.WriteLine("You entered an invalid value, try again.");
                                    }

                                    // Here we have defined that no lower bet than the lowest bet can be entered.
                                    bool limit;
                                    do
                                    {
                                        if (yourBet < lowestBet)
                                        {

                                            Console.WriteLine($"You can bet with at least {lowestBet} credits. Try again ");

                                            while (!int.TryParse(Console.ReadLine(), out yourBet))
                                            {
                                                Console.WriteLine("You entered an invalid value, try again!");
                                            }

                                            limit = true;
                                        }
                                        else
                                        {
                                            limit = false;
                                        }
                                    } while (limit);

                                    // These codes work when the bet entered is more than it has.
                                    if (yourcredits < yourBet)
                                    {
                                        Console.WriteLine("You don't have that much credits! Make a bet with less credits.");
                                        Console.WriteLine("************************************************************************************");

                                        insufficientBalance2 = true;
                                    }
                                    else
                                    {
                                        insufficientBalance2 = false;
                                    }

                                } while (insufficientBalance2);

                                // Here it is checked whether the predicted number is correct.
                                if (yourGuess < theNumber)
                                {
                                    Console.WriteLine("HI");
                                    Console.WriteLine("********************************************************************************************************");
                                    Console.WriteLine("Press 1 to place a bet.");
                                    Console.WriteLine("Press 2 to go back to the lobby.");

                                    decision4 = Console.ReadLine();
                                    Console.WriteLine("********************************************************************************************************");

                                    // The player running out of credit for a wrong guess.
                                    yourcredits -= yourBet;

                                    // The lowest bet is added for each new prediction.
                                    lowestBet += 25;

                                }
                                else if (theNumber < yourGuess)
                                {
                                    Console.WriteLine("LO");
                                    Console.WriteLine("********************************************************************************************************");
                                    Console.WriteLine("Press 1 to place a bet.");
                                    Console.WriteLine("Press 2 to go back to the lobby.");

                                    decision4 = Console.ReadLine();
                                    Console.WriteLine("********************************************************************************************************");

                                    // The player running out of credit for a wrong guess.
                                    yourcredits -= yourBet;

                                    // The lowest bet is added for each new prediction.
                                    lowestBet += 25;
                                }
                                else
                                {
                                    // Here are the codes that work when the player knows the number correctly.
                                    Console.WriteLine("*** < Right Guess > ***");
                                    Console.WriteLine("3500 credits are yours now!");
                                    Console.WriteLine("********************************************************************************************************");

                                    // The reward to be won is added.
                                    yourcredits += 3500;

                                    // We're asking questions for the new round.
                                    Console.WriteLine("Press 1 for another round.");
                                    Console.WriteLine("Press 2 to go back to the lobby.");

                                    decision5 = Console.ReadLine();
                                    Console.WriteLine("********************************************************************************************************");


                                    if (decision5 == "1")
                                    {
                                        // The loop is returned for the new round.
                                        reround = true;
                                        rebet2 = false;
                                    }
                                    else if (decision5 == "2")
                                    {
                                        // Returning the loop for the lobby.
                                        reround = false;
                                        rebet2 = false;
                                        lobby = true;
                                    }
                                    else
                                    {
                                        // If there is a wrong input, it works here.
                                        bool wrongInput4;
                                        do
                                        {
                                            Console.WriteLine("You entered wrong input!");
                                            Console.WriteLine("Press 1 for another round.");
                                            Console.WriteLine("Press 2 to go back to the lobby.");

                                            decision5 = Console.ReadLine();
                                            Console.WriteLine("********************************************************************************************************");

                                            if (decision5 == "1")
                                            {
                                                reround = true;
                                                rebet2 = false;
                                                wrongInput4 = false;
                                            }
                                            else if (decision5 == "2")
                                            {
                                                reround = false;
                                                rebet2 = false;
                                                lobby = true;
                                                wrongInput4 = false;
                                            }
                                            else
                                            {
                                                reround = false;
                                                wrongInput4 = true;
                                                rebet2 = false;
                                            }
                                        } while (wrongInput4);
                                    }
                                }

                                // This happens when the player doesn't have enough credits to place a bet.
                                if (yourcredits < lowestBet)
                                {
                                    Console.WriteLine($"You can play {lowestBet} as the lowest bet.");
                                    Console.WriteLine($"You have {yourcredits} credits now.");
                                    Console.WriteLine("You do not have enough credits to bet.");

                                    if (yourcredits != 0)
                                    {
                                        // If the player's credit isn't zero here's the loop for him/her last remaining credit.
                                        Console.WriteLine("Do you want to ALL IN?");
                                        decision6 = Console.ReadLine().ToLower();

                                        if (decision6 == "y" || decision6 == "yes")
                                        {
                                            // The player can't bet again because all his/her credits are gone.
                                            rebet2 = false;

                                            // The last remaining credit is drawn.
                                            yourcredits = 0;

                                            // The final guess is asked.
                                            Console.WriteLine("Enter your guess.");

                                            while (!int.TryParse(Console.ReadLine(), out yourGuess))
                                            {
                                                Console.WriteLine("You entered an invalid value, try again.");
                                            }


                                            if (yourGuess == theNumber)
                                            {
                                                // It works when guessed correctly.
                                                Console.WriteLine("*** < Right Guess > ***");
                                                Console.WriteLine("3500 credits are yours now!");
                                                Console.WriteLine("********************************************************************************************************");

                                                // The earnings are added to the credit.
                                                yourcredits += 3500;

                                                // A new tour is requested.
                                                Console.WriteLine("Press 1 for another round.");
                                                Console.WriteLine("Press 2 to go back to the lobby.");
                                                decision5 = Console.ReadLine();
                                                Console.WriteLine("********************************************************************************************************");

                                                if (decision5 == "1")
                                                {
                                                    // The new lap loop works.
                                                    reround = true;
                                                    rebet2 = false;
                                                }
                                                else if (decision5 == "2")
                                                {
                                                    // The lobby loop works.
                                                    reround = false;
                                                    rebet2 = false;
                                                    lobby = true;
                                                }
                                                else
                                                {
                                                    // It works when wrong input is entered.
                                                    bool wrongInput5;
                                                    do
                                                    {
                                                        Console.WriteLine("You entered wrong input!");
                                                        Console.WriteLine("Press 1 for another round");
                                                        Console.WriteLine("Press 2 to go back to the lobby.");

                                                        decision5 = Console.ReadLine();
                                                        Console.WriteLine("********************************************************************************************************");

                                                        if (decision5 == "1")
                                                        {
                                                            reround = true;
                                                            wrongInput5 = false;
                                                        }
                                                        else if (decision5 == "2")
                                                        {
                                                            reround = false;
                                                            lobby = true;
                                                            wrongInput5 = false;
                                                        }
                                                        else
                                                        {
                                                            rebet2 = false;
                                                            wrongInput5 = true;
                                                            reround = false;
                                                        }
                                                    } while (wrongInput5);
                                                }
                                            }
                                            else
                                            {
                                                // This place works when the player gives his/her last credit and can't guess.
                                                Console.WriteLine($"The number was {theNumber}.");
                                                Console.WriteLine("********************************************************************************************************");
                                                lobby = true;
                                                rebet2 = false;
                                                reround = false;
                                            }
                                        }
                                        else if (decision6 == "n" || decision6 == "no")
                                        {
                                            // This place works if the player doesn't bet on his/her last credit.
                                            Console.WriteLine($"The number was {theNumber}.");
                                            Console.WriteLine("********************************************************************************************************");
                                            lobby = true;
                                            rebet2 = false;
                                            reround = false;
                                        }
                                    }
                                    else
                                    {
                                        // This place works when the player's credit is zero.
                                        Console.WriteLine($"The number was {theNumber}.");
                                        Console.WriteLine("********************************************************************************************************");
                                        lobby = true;
                                        rebet2 = false;
                                        reround = false;
                                    }
                                }
                            }
                            else if (decision4 == "2")
                            {
                                // The lobby loop works.
                                lobby = true;
                                rebet2 = false;
                                reround = false;
                            }
                        }
                    }
                }
                else
                {
                    // This code will work if the wrong input is entered in the lobby.
                    Console.WriteLine("You entered wrong input!");
                    lobby = true;
                }
            }
        } while (lobby);
    }
}
