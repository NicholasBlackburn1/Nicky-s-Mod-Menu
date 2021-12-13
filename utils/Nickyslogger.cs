using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * this class is my own logger colors so  i can tell what is wrong with my mod
 */
namespace NickysModMenu.utils
{
    class Nickyslogger
    {

        public static void info(string message)
        {
            MelonLogger.Msg(ConsoleColor.White, message);
        }

        public static void Warning(string message)
        {
            MelonLogger.Msg(ConsoleColor.DarkYellow, message);
        }

        public static void Error(string message)
        {
            MelonLogger.Msg(ConsoleColor.DarkRed, message);
        }

        public static void Ok(string message)
        {
            MelonLogger.Msg(ConsoleColor.Green, message);
        }

        public static void Data(string message)
        {
            MelonLogger.Msg(ConsoleColor.DarkMagenta, message);
        }

    }
}
