//using log4net;

//using ValidatorLibrary;

//namespace ET_5_NumberToText.Data
//{
//    public class Validator : BaseValidator
//    {
//        public Validator(ILog logger) : base(logger)
//        {
//        }

//        public override bool IsValid(string[] args)
//        {
//            return IsEmptyArr(args) 
//                && IsCorrectLength(args, InputData.CountParams) 
//                && DoesNotContainNull(args) 
//                && CanParseToInt64(args[0], false) 
//                && DoesContainEnum(args[1], typeof(InputData.Algorithms));

//            //if (args == null)
//            //{
//            //    return false;
//            //}
//            //if (args.Length != InputData.CountParams)
//            //{
//            //    return false;
//            //}

//            //for (int i = 0; i < args.Length; i++)
//            //{
//            //    if (args[i] == null)
//            //    {
//            //        return false;
//            //    }
//            //}

//            //if (!Int64.TryParse(args[0], out _))
//            //{
//            //    return false;
//            //}
//            //if (!IsContainMode(args[1]))
//            //{
//            //    return false;
//            //}


//            //return true;
//        }

//        //private static bool IsContainMode(string str)
//        //{
//        //    foreach (InputData.Algorithms item in Enum.GetValues(typeof(InputData.Algorithms)))
//        //    {
//        //        if (str == item.ToString())
//        //        {
//        //            return true;
//        //        }
//        //    }
            
//        //    return false;
//        //}
//    }
//}
