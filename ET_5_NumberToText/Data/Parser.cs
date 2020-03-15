﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_5_NumberToText.Data
{
    public static class Parser
    {
        public static InputData Parse(string[] args)
        {
            if (args == null)
            {
                throw new NullReferenceException("Array of parameters is null"); //81
            }
            if (args.Length != InputData.CountParams)
            {
                throw new ArgumentException(
                    "The number of parameters is incorrect. " +
                    "There must be: " + InputData.CountParams);
            }
            if(GetMode(args[1]) == 0)
            {
                throw new ArgumentException("Algorithm not found");
            }

            return new InputData
            {
                Number = Int64.Parse(args[0]),
                Algorithm = GetMode(args[1])
            };
        }

        private static InputData.Algorithms GetMode(string str)
        {
            foreach (InputData.Algorithms item in Enum.GetValues(typeof(InputData.Algorithms)))
            {
                if (str == item.ToString())
                {
                    return item;
                }
            }
            
            return 0;
        }
    }
}