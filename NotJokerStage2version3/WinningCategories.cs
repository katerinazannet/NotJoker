using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    class WinningCategories
    {
        public static double Five;
        public static double FivePlusOne;
        public static double Four;
        public static double FourPlusOne;
        public static double Three;
        public static double ThreePlusOne;
        public static double Two;
        public static double TwoPlusOne;
        public static double OnePlusOne;
        public static double Nothing;
        public static double MoneyFive;
        public static double MoneyFivePlusOne;
        public static double MoneyFour;
        public static double MoneyFourPlusOne;
        public static double MoneyThree;
        public static double MoneyThreePlusOne;
        public static double MoneyTwo;
        public static double MoneyTwoPlusOne;
        public static double MoneyOnePlusOne;
        public static double MoneyNothing;

        public WinningCategories()
        {
            Five = 0;
            FivePlusOne = 0;
            Four = 0;
            FourPlusOne = 0;
            Three = 0;
            ThreePlusOne = 0;
            Two = 0;
            TwoPlusOne = 0;
            OnePlusOne = 0;
            Nothing = 0;
            MoneyFive = Math.Round(MoneyFive, 2); // για να εμφανιζει μονο δυο δεκαδικα ψηφια
            MoneyFivePlusOne = Math.Round(MoneyFivePlusOne, 2);
            MoneyFour = Math.Round(MoneyFour, 2);
            MoneyFourPlusOne = Math.Round(MoneyFourPlusOne, 2);
            MoneyThree = Math.Round(MoneyThree, 2);
            MoneyThreePlusOne = Math.Round(MoneyThreePlusOne, 2);
            MoneyTwo = Math.Round(MoneyTwo, 2);
            MoneyTwoPlusOne = Math.Round(MoneyTwoPlusOne, 2);
            MoneyOnePlusOne = Math.Round(MoneyOnePlusOne, 2);
            MoneyNothing = 0;
        }

       
    }
}
