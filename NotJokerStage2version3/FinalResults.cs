using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    class FinalResults
    {
           //Μεθοδος συγκρισης αποτελεσματων κ εμφανιση νικητων ανα κατηγορια (κ χρηματικο επαθλο)

        public static void FinalCompare(Player newPlayer, LotteryResults lotteryResults)
        {
            var notJoker = 0;
            LotteryResults.budget = 1000;

            foreach (LotteryResults lottery in LotteryResults.TotalDraws)
            {
                foreach (Player player in Player.TotalPlayers)
                {

                    //αν αυξηθει ο counter εχουν κοινο αριθμο
                    foreach (int number in LotteryResults.ListFiveRandomNumbers)
                    {
                        if (player.PlayerListNumbers.Contains(number))
                            player.score += 1;
                       
                    }

                    // ελεγχος για joker
                    if (player.luckyRandomNumber.Equals(lottery.OneLuckyRandomNumber))
                        player.hasJoker = 1;


                    if (player.score.Equals(5) && notJoker.Equals(1))
                    {
                        WinningCategories.FivePlusOne += 1;
                        WinningCategories.MoneyFivePlusOne = (LotteryResults.budget * 0.4) / WinningCategories.FivePlusOne;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.4) - WinningCategories.MoneyFivePlusOne;

                    }
                    else if (player.score.Equals(5))
                    {
                        WinningCategories.Five += 1;
                        WinningCategories.MoneyFive = (LotteryResults.budget * 0.25) / WinningCategories.Five;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.25) - WinningCategories.MoneyFive;

                    }
                    else if (player.score.Equals(4) && notJoker.Equals(1))
                    {
                        WinningCategories.FourPlusOne += 1;
                        WinningCategories.MoneyFourPlusOne = (LotteryResults.budget * 0.15) / WinningCategories.FourPlusOne;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.15) - WinningCategories.MoneyFourPlusOne;

                    }
                    else if (player.score.Equals(4))
                    {
                        WinningCategories.Four += 1;
                        WinningCategories.MoneyFour = (LotteryResults.budget * 0.05) / WinningCategories.Four;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.05) - WinningCategories.MoneyFour;

                    }
                    else if (player.score.Equals(3) && notJoker.Equals(1))
                    {
                        WinningCategories.ThreePlusOne += 1;
                        WinningCategories.MoneyThreePlusOne = (LotteryResults.budget * 0.05) / WinningCategories.ThreePlusOne;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.05) - WinningCategories.MoneyThreePlusOne;

                    }
                    else if (player.score.Equals(3))
                    {
                        WinningCategories.Three += 1;
                        WinningCategories.MoneyThree = (LotteryResults.budget * 0.04) / WinningCategories.Three;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.04) - WinningCategories.MoneyThree;

                    }
                    else if (player.score.Equals(2) && notJoker.Equals(1))
                    {
                        WinningCategories.TwoPlusOne += 1;
                        WinningCategories.MoneyTwoPlusOne = (LotteryResults.budget * 0.035) / WinningCategories.TwoPlusOne;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.035) - WinningCategories.MoneyTwoPlusOne;

                    }
                    else if (player.score.Equals(2))
                    {
                        WinningCategories.Two += 1;
                        WinningCategories.MoneyTwo = (LotteryResults.budget * 0.035) / WinningCategories.Two;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.035) - WinningCategories.MoneyTwo;

                    }
                    else if (player.score.Equals(1) && notJoker.Equals(1))
                    {
                        WinningCategories.OnePlusOne += 1;
                        WinningCategories.MoneyOnePlusOne = (LotteryResults.budget * 0.01) / WinningCategories.OnePlusOne;
                        LotteryResults.remainMoney = (LotteryResults.budget * 0.01) - WinningCategories.MoneyOnePlusOne;

                    }
                    else if (player.score.Equals(1) || player.score.Equals(0))
                        WinningCategories.Nothing += 1;
                        LotteryResults.remainMoney = LotteryResults.budget;
                    
                }
                LotteryResults.budget = LotteryResults.budget + LotteryResults.remainMoney;
          
            }
            Console.WriteLine();
        }


        public static void Print()
        {
            StringBuilder myBuilder = new StringBuilder();
            myBuilder
                .AppendLine($"{WinningCategories.FivePlusOne} Players won 5 + 1 numbers and won {WinningCategories.MoneyFivePlusOne} euros")
                                                        .AppendLine($"{WinningCategories.Five} Players won 5 numbers and won {WinningCategories.MoneyFive} euros ")
                                                        .AppendLine($"{WinningCategories.FourPlusOne} Players won 4 + 1 numbers and won {WinningCategories.MoneyFourPlusOne} euros")
                                                        .AppendLine($"{WinningCategories.Four} Players won 4 numbers and won {WinningCategories.MoneyFour} euros")
                                                        .AppendLine($"{WinningCategories.ThreePlusOne} Players won 3 + 1 numbers and won {WinningCategories.ThreePlusOne} euros")
                                                        .AppendLine($"{WinningCategories.Three} Players won 3 numbers and won {WinningCategories.MoneyThree} euros")
                                                        .AppendLine($"{WinningCategories.TwoPlusOne} Players won 2 + 1 numbers and won {WinningCategories.MoneyTwoPlusOne} euros")
                                                        .AppendLine($"{WinningCategories.Two} Players won 2 numbers and won {WinningCategories.MoneyTwo} euros")
                                                        .AppendLine($"{WinningCategories.OnePlusOne} Players won 1 + 1 numbers and won {WinningCategories.MoneyOnePlusOne} euros")
                                                        .AppendLine($"{WinningCategories.Nothing} Players Nothing! Sorry maybe next time you will be lucky!!!");

            Console.WriteLine(myBuilder);
        }
    }
}
