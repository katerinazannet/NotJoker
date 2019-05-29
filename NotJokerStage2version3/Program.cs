using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Let's start our game! Good Luck!");

            Player player = new Player();        
            player.TypeOfPlayerGame();

            LotteryResults lottery = new LotteryResults();          
            lottery.GenerateNumbers();

            FinalResults.FinalCompare(player, lottery);
        
            FinalResults.Print();

            Statistics.FindMostAndLeastDrawNumbers();
           
        }
    }
}
