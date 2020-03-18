using ET_5_NumberToText.Logics;
using ET_5_NumberToText.Logics.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_5_NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.ExecuteProgramm(args);
            //ConsoleMenu.ShowConsoleMenu(args);
        }
    }
}
