using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_5_NumberToText.Data
{
    public class InputDTO
    {
        public enum Algorithms
        {
            English = 1,
        }
        //public static string[] GetAlgorithmsArr()
        //{
        //    List<string> result = new List<string>();
            
        //    foreach (InputData.Algorithms item in Enum.GetValues(typeof(InputData.Algorithms)))
        //    {
        //        result.Add(item.ToString());
        //    }

        //    return result.ToArray();
        //}


        public long Number { get; set; }
        public Algorithms Algorithm { get; set; }

        public const int CountParams = 2;
    }
}
