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

        public long Number { get; set; }
        public Algorithms Algorithm { get; set; }

        public const int CountParams = 2;
    }
}
