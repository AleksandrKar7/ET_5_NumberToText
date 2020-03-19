using System;

using ConsoleUILibrary;
using ET_5_NumberToText.Data;
using ET_5_NumberToText.Logics;
using ET_5_NumberToText.Logics.Translator;
using ValidatorLibrary;

namespace ET_5_NumberToText
{
    class ProgramController
    {
        public void ExecuteProgramm(string[] args)
        {
            bool isNewTry = false;

            do
            {
                if (isNewTry)
                {
                    args = AskInputParams();
                    isNewTry = false;
                }

                if (!IsValid(args))
                {
                    Console.WriteLine("Your data is not valid");
                    if (!BaseConsoleUI.AskСonfirmation("Do you want to retype them?",
                        new string[] { "YES", "Y" }))
                    {
                        break;
                    }

                    args = AskInputParams();

                    continue;
                }

                InputDTO inputDTO = Parser.Parse(args);

                NumberToTextConverter converter;

                switch (inputDTO.Algorithm)
                {
                    case InputDTO.Algorithms.English:
                        converter = new EnglishNumberToTextConverter();
                        break;
                    default:
                        converter = new EnglishNumberToTextConverter();
                        break;
                }

                Number number = new Number(inputDTO.Number, converter);

                if (number.CanConvertToText())
                {
                    Console.WriteLine(number.ConvertToText());
                }
                else
                {
                    Console.WriteLine(
                        "This converter can't convert the number. " +
                        "The number is too big.");
                }

                if (BaseConsoleUI.AskСonfirmation("Do you want to continue?",
                    new string[] { "YES", "Y" }))
                {
                    isNewTry = true;
                }
                else
                {
                    break;
                }
            } while (true);
        }

        private bool IsValid(string[] args)
        {
            return BaseValidator.IsEmptyArr(args)
                    && BaseValidator.IsCorrectLength(args
                        , InputDTO.CountParams)
                    && BaseValidator.DoesNotContainNull(args)
                    && BaseValidator.CanParseToInt64(args[0], false)
                    && BaseValidator.DoesContainEnum(args[1]
                        , typeof(InputDTO.Algorithms));
        }

        private string[] AskInputParams()
        {
            string[] result = new string[InputDTO.CountParams];

            Console.WriteLine("Enter a number");
            result[0] = Console.ReadLine();

            result[1] = ((InputDTO.Algorithms)
                BaseConsoleUI.AskMenuItem("Choose language"
                , typeof(InputDTO.Algorithms))).ToString();

            return result;
        }
    }
}
