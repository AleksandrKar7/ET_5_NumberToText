//using System;

//using ConsoleUILibrary;
//using ET_5_NumberToText.Data;
//using log4net;

//namespace ET_5_NumberToText
//{
//    class ConsoleMenu /*: BaseConsoleUI*/
//    {
//        //public ConsoleMenu(ILog logger) : base(logger)
//        //{
//        //}

//        public override string[] AskInputParams()
//        {
//            string[] result = new string[InputData.CountParams];

//            Console.WriteLine("Enter a number");
//            result[0] = Console.ReadLine();

//            result[1] = ((InputData.Algorithms)
//                AskMenuItem("Choose language"
//                , typeof(InputData.Algorithms))).ToString();

//            return result;
//        }

//        //public static void ShowConsoleMenu(string[] inputParams)
//        //{
//        //    bool isNewTry = false;
//        //    Validator validator = new Validator(Logger.Log);

//        //    do
//        //    {
//        //        if (isNewTry)
//        //        {
//        //            inputParams = AskInputParams(InputData.CountParams);
//        //            isNewTry = false;
//        //        }

//        //        if (!validator.IsValid(inputParams))
//        //        {
//        //            Console.WriteLine("Your data is not valid");
//        //            if (!AskBoolValue("Do you want to retype them?",
//        //                new string[] { "YES", "Y" }))
//        //            {
//        //                break;
//        //            }

//        //            inputParams = AskInputParams(InputData.CountParams);

//        //            continue;
//        //        }

//        //        InputData inputData = Parser.Parse(inputParams);
//        //        NumberToTextConverter converter;
//        //        switch (inputData.Algorithm)
//        //        {
//        //            case InputData.Algorithms.English:
//        //                converter = new EnglishNumberToTextConverter();
//        //                break;
//        //            default:
//        //                converter = new EnglishNumberToTextConverter();
//        //                break;
//        //        }

//        //        Number number = new Number(inputData.Number, converter);
//        //        if (number.CanConvertToText())
//        //        {
//        //            Console.WriteLine(number.ConvertToText());
//        //        }
//        //        else
//        //        {
//        //            Console.WriteLine(
//        //                "This converter can't convert the number. " +
//        //                "The number is too big.");
//        //        }

//        //        if (AskBoolValue("Do you want to continue?",
//        //            new string[] { "YES", "Y" }))
//        //        {
//        //            isNewTry = true;
//        //        }
//        //        else
//        //        {
//        //            break;
//        //        }
//        //    } while (true);
//        //}

//        //public static string[] AskInputParams(int countParams)
//        //{
//        //    string[] result = new string[countParams];

//        //    Console.WriteLine("Enter a number");
//        //    result[0] = Console.ReadLine();

//        //    string[] menuItems = InputData.GetAlgorithmsArr();
//        //    result[1] = menuItems[AskMenuItem("Choose language", menuItems) - 1];

//        //    return result;
//        //}

//        //public static int AskMenuItem(string message, string[] menuItems)
//        //{
//        //    int i = 1;
//        //    int result;
//        //    Console.WriteLine(message);
//        //    foreach (string item in menuItems)
//        //    {
//        //        Console.WriteLine(i + " - " + item);
//        //        i++;
//        //    }

//        //    do
//        //    {
//        //        Int32.TryParse(Console.ReadLine(), out result);
//        //        if (result >= 1 && result <= menuItems.Length)
//        //        {
//        //            break;
//        //        }
//        //        else
//        //        {
//        //            Console.WriteLine("Wrong item. Choose again");
//        //        }
//        //    } while (true);

//        //    return result;
//        //}

//        //public static bool? AskBoolValue(string message)
//        //{
//        //    string text;
//        //    string insturction;
//        //    string[] trueArray = { "T", "TRUE" };
//        //    string[] falseArray = { "F", "FALSE" };

//        //    insturction = String.Format("For true: {0}; For false: '{1}'",
//        //        String.Join("', ", trueArray), String.Join("', ", falseArray));

//        //    Console.WriteLine(message);
//        //    Console.WriteLine(insturction);

//        //    text = Console.ReadLine();
//        //    text.Trim();
//        //    text = text.ToUpper();

//        //    if (text == null)
//        //    {
//        //        return null;
//        //    }

//        //    if (trueArray.Contains(text))
//        //    {
//        //        return true;
//        //    }
//        //    if (falseArray.Contains(text))
//        //    {
//        //        return false;
//        //    }

//        //    return null;
//        //}

//        //public static bool AskBoolValue(string message, string[] trueArray)
//        //{
//        //    if (trueArray == null)
//        //    {
//        //        return false;
//        //    }
//        //    string text;
//        //    string insturction;


//        //    insturction = String.Format("For true: {0}; For false: '{1}'",
//        //        String.Join("', ", trueArray), "Press enter");

//        //    Console.WriteLine(message);
//        //    Console.WriteLine(insturction);

//        //    text = Console.ReadLine();
//        //    text.Trim();
//        //    text = text.ToUpper();

//        //    if (text == null)
//        //    {
//        //        return false;
//        //    }

//        //    if (trueArray.Contains(text))
//        //    {
//        //        return true;
//        //    }
//        //    else
//        //    {
//        //        return false;
//        //    }
//        //}

//        //public static bool? AskBoolValue(string message, string[] trueArray, string[] falseArray)
//        //{
//        //    if (trueArray == null)
//        //    {
//        //        return null;
//        //    }
//        //    if (falseArray == null)
//        //    {
//        //        return null;
//        //    }
//        //    string text;
//        //    string insturction;

//        //    insturction = String.Format("For agree: {0}; For disagree: '{1}'",
//        //        String.Join("', ", trueArray), String.Join("', ", falseArray));

//        //    Console.WriteLine(message);
//        //    Console.WriteLine(insturction);

//        //    text = Console.ReadLine();
//        //    text.Trim();
//        //    text = text.ToUpper();

//        //    if (text == null)
//        //    {
//        //        return null;
//        //    }
//        //    if (trueArray.Contains(text))
//        //    {
//        //        return true;
//        //    }
//        //    if (falseArray.Contains(text))
//        //    {
//        //        return false;
//        //    }

//        //    return null;
//        //}

//    }
//}
