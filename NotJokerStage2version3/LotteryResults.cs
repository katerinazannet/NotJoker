using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    public class LotteryResults : IGenerateRandomNumbers
    {
        public static List<int> ListFiveRandomNumbers;
        public int OneLuckyRandomNumber { get; set; }
        public static List<LotteryResults> TotalDraws;
        public static int numberOfDraws;
        public static double budget;
        public static double remainMoney;
        public static List<int> ListAllDrawNumbers;

        //public List<int> ListFiveRandomNumbers
        //{
        //    get
        //    {
        //        return ListFiveRandomNumbers;
        //    }
        //    set
        //    {
        //        if (value.Equals(null))
        //            throw new ArgumentNullException("DrawList can not be null");
        //        ListFiveRandomNumbers = value;
        //    }
        //}

        public LotteryResults()
        {
            ListFiveRandomNumbers = new List<int>();
            OneLuckyRandomNumber = 0;
        }


        //Draw 5 Random Numbers from 1 - 45.

        public void GenerateNumbers()

        {
            Console.WriteLine("\nHow many draws?");
            int numberOfDraws = int.Parse(Console.ReadLine());

            TotalDraws = new List<LotteryResults>();
            ListAllDrawNumbers = new List<int>();

            Random r = new Random();
            Random rn = new Random(); 

            while (numberOfDraws > 0)
            {
                Console.WriteLine("\nIt's time for the final lotteries!!!");

                LotteryResults lottery = new LotteryResults();
                TotalDraws.Add(lottery);//γεμιζω λιστα 
             

                for (int i = 0; ListFiveRandomNumbers.Count() < 5; i++)
                {
                    int randomNumber = r.Next(1, 46);
                    if (!ListFiveRandomNumbers.Contains(randomNumber))
                    {
                        ListFiveRandomNumbers.Add(randomNumber);
                        ListAllDrawNumbers.Add(randomNumber);
                    }
                    Console.WriteLine(randomNumber);
                    
                }
               
                //Draw 1 Number from 1 - 20.

                Console.WriteLine("Draw lucky number is: ");
                {
                    
                    int oneLuckyRandomNumber = rn.Next(1, 21);
                    Console.WriteLine(oneLuckyRandomNumber);

                }
               
                numberOfDraws--;
              
            }
        }
       // το interface δεν μου δουλεψε κ με την λιστα, θα ψαξω να βρω τον τροπο...
    }
}











