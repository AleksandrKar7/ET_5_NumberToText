using System;

using ValidatorLibrary;

namespace ET_5_NumberToText.Data
{
    public static class Parser
    {
        public static InputDTO Parse(string[] args)
        {
            if (BaseValidator.IsEmptyArr(args))
            {
                throw new NullReferenceException("Array of parameters is null"); //81
            }
            if (BaseValidator.IsCorrectLength(args, InputDTO.CountParams))
            {
                throw new ArgumentException(
                    "The number of parameters is incorrect. " +
                    "There must be: " + InputDTO.CountParams);
            }

            return new InputDTO
            {
                Number = Int64.Parse(args[0]),
                Algorithm = (InputDTO.Algorithms)
                    Enum.Parse(typeof(InputDTO.Algorithms), args[1])
            };
        }

    }
}
