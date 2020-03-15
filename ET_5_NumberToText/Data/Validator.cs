using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_5_NumberToText.Data
{
    public static class Validator
    {
        public static bool IsValid(string[] args)
        {
            if (args == null)
            {
                return false;
            }
            if (args.Length != InputData.CountParams)
            {
                return false;
            }

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == null)
                {
                    return false;
                }
            }

            if (!Int64.TryParse(args[0], out _))
            {
                return false;
            }
            if (!IsContainMode(args[1]))
            {
                return false;
            }


            return true;
        }

        private static bool IsContainMode(string str)
        {
            foreach (InputData.Algorithms item in Enum.GetValues(typeof(InputData.Algorithms)))
            {
                if (str == item.ToString())
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
