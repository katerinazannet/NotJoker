using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    class Statistics
    {
        //Μεθοδος για τα 3 πιο δημοφιλη κ τα 3 λιγοτερο δημοφιλη νουμερα

        public static void FindMostAndLeastDrawNumbers()
        {
            int mostCommon1, mostCommon2, mostCommon3, lessCommon1, lessCommon2, lessCommon3;

            // απο την λιστα με ολα τα νουμερα που κληρωθηκαν διαλεγει το πιο δημοφιλες νουμερο
            var query = (from l in LotteryResults.ListAllDrawNumbers
                         group l by l into gr
                         orderby gr.Count() descending
                         select gr.Key);

            mostCommon1 =query.First();
            // αφου το διαλεξει το αφαιρει απο την υπαρχουσα λιστα κ συνεχιζω την διαδικασια αλλες δυο φορες 
            //για τα επομενα 2 νουμερα

            for (int i = 0; i < LotteryResults.ListAllDrawNumbers.Count; i++)
            {

                if (LotteryResults.ListAllDrawNumbers[i] == mostCommon1)
                    LotteryResults.ListAllDrawNumbers.Remove(LotteryResults.ListAllDrawNumbers[i]);
            }



            query = (from l in LotteryResults.ListAllDrawNumbers
                     group l by l into gr
                     orderby gr.Count() descending
                     select gr.Key);

            mostCommon2 = query.First();

            for (int i = 0; i < LotteryResults.ListAllDrawNumbers.Count; i++)
            {
                if (LotteryResults.ListAllDrawNumbers[i] == mostCommon2)
                    LotteryResults.ListAllDrawNumbers.Remove(LotteryResults.ListAllDrawNumbers[i]);
            }

            query = (from l in LotteryResults.ListAllDrawNumbers
                     group l by l into gr
                     orderby gr.Count() descending
                     select gr.Key);

            mostCommon3 = query.First();

            // απο εδω με το last κανει την αναλογη διαδικασια αλλα αμφανιζει κ επειτα βγαζει απο την λιστα
            // το λιγοτερο δημοφιλες νουμερο 
         
            query = (from l in LotteryResults.ListAllDrawNumbers
                     group l by l into gr
                     orderby gr.Count() descending
                     select gr.Key);

            lessCommon1 = query.Last();


            for (int i = 0; i < LotteryResults.ListAllDrawNumbers.Count; i++)
            {

                if (LotteryResults.ListAllDrawNumbers[i] == lessCommon1)
                    LotteryResults.ListAllDrawNumbers.Remove(LotteryResults.ListAllDrawNumbers[i]);
            }


            query = (from l in LotteryResults.ListAllDrawNumbers
                     group l by l into gr
                     orderby gr.Count() descending
                     select gr.Key);

            lessCommon2 = query.Last();

            for (int i = 0; i < LotteryResults.ListAllDrawNumbers.Count; i++)
            {
                if (LotteryResults.ListAllDrawNumbers[i] == lessCommon2)
                    LotteryResults.ListAllDrawNumbers.Remove(LotteryResults.ListAllDrawNumbers[i]);
            }

            query = (from l in LotteryResults.ListAllDrawNumbers
                     group l by l into gr
                     orderby gr.Count() descending
                     select gr.Key);

            lessCommon3 = query.Last();


            Console.WriteLine($"The three most common numbers are: {mostCommon1}, {mostCommon2}, {mostCommon3}");
            Console.WriteLine($"The three least numbers are: {lessCommon1}, {lessCommon2}, {lessCommon3}");



        }

        public Delegate FinalResultsAnnouncement; // public πεδιο τυπου delegate

    }
}
