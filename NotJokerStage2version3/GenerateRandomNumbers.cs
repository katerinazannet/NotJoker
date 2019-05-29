using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotJokerStage2version3
{
    public interface IGenerateRandomNumbers
    {
        //List<int> ListFiveRandomNumbers { get; set; }
        int OneLuckyRandomNumber { get; set; }

        void GenerateNumbers();
    }
   
}
