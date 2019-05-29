using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    public class Player
    {
        const int lenght = 5;
        const int min = 1;
        const int max = 45;
        public List<int> PlayerListNumbers;
        public int luckyRandomNumber;    
        public int typeOfGame;
        public static int numberOfPlayers;
        public static List<Player> TotalPlayers;
        public int score;
        public int hasJoker;



        public Player()
        {
            PlayerListNumbers = new List<int>();
            luckyRandomNumber = 0;     
            
        }

        // Μεθοδος που αναλογα με τον τυπο παιχνιδιου που θα διαλεξει ο παικτης κανει τις αναλογες ενεργειες

        public void TypeOfPlayerGame()
         {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());


            Console.WriteLine("If you want to choose your numbers please press 0! Else press 1 and relax! System will give your numbers");
            int typeOfGame = int.Parse(Console.ReadLine());


            TotalPlayers = new List<Player>();

            Random rp = new Random();
            Random rpp = new Random();
          
            while (numberOfPlayers > 0)
            {
                //Ask from user to enter the lucky number from 1 - 45.

                if (typeOfGame == 0)
                {
                    Console.WriteLine("\nGive me FIVE numbers between 1 - 45!");

                    Player player = new Player();
                    TotalPlayers.Add(player);//γεμιζω λιστα με τους παικτες

                    PlayerListNumbers = new List<int>(); // δημιουργω λιστα με τα νουμερα


                    for (int i = 0; PlayerListNumbers.Count() < 5; i++)
                        {
                           
                            int playerNumber = int.Parse(Console.ReadLine());

                            if (playerNumber >= 1 && playerNumber <= 45 && !PlayerListNumbers.Contains(playerNumber))
                            {
                                PlayerListNumbers.Add(playerNumber);
                            }
                            else
                            {
                                Console.WriteLine("You gave this number again or this number is out of limits! Please give it a try!");
                            }
                           
                    }

                        //Ask from user to enter the lucky number from 1 - 20.

                        Console.WriteLine("Give me your lucky number between 1 - 20");
                        {
                                                    
                                int luckyRandomNumber = int.Parse(Console.ReadLine());
                                PlayerListNumbers.Add(luckyRandomNumber);

                                if (luckyRandomNumber < 1 || luckyRandomNumber > 20)
                                {
                                    throw new ArgumentOutOfRangeException("This number  is out of limits! Please give it a try!");
                               
                                }                                                          
                        }

                    player.PlayerListNumbers = PlayerListNumbers;
                    player.luckyRandomNumber = luckyRandomNumber;
                   
                    numberOfPlayers--;
                              
                }

                ////Draw 5 Random Numbers from 1 - 45.

                if (typeOfGame == 1)
                {
                    Console.WriteLine("\nPlayer's random numbers are: ");

                    Player player = new Player();

                    TotalPlayers.Add(player);//γεμιζω λιστα με τους παικτες

                    PlayerListNumbers = new List<int>();  // δημιουργω λιστα με τα νουμερα

                    for (int i = 0; PlayerListNumbers.Count() < 5; i++)
                    {                        
                        int playerNumber = rp.Next(1, 46);
                        if (!PlayerListNumbers.Contains(playerNumber))
                        {
                            PlayerListNumbers.Add(playerNumber);
                            
                        }
                        Console.WriteLine(playerNumber);
                    }

                    //Draw 1 Number from 1 - 20.

                    Console.WriteLine("Player's random lucky number is: ");
                

                    int luckyRandomNumber = rpp.Next(1, 21);
                    Console.WriteLine(luckyRandomNumber);
                    
                    player.PlayerListNumbers = PlayerListNumbers;
                    player.luckyRandomNumber = luckyRandomNumber;
     
                    numberOfPlayers--;                

                }
                //Ιδανικα θα χρησιμοποιουσα κ εδω το interface για random νουμερα αλλα τα εχω ολα σε μια μεθοδο. 
                // Σε επομενη 'εκδοση' θα την σπασω για να το βαλω κ εδω
            }
        }

       
    }
}