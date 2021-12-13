using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NickysModMenu.gui
{
    class RegisterGui
    {
        // this is where i can interface with registerting all the actions for the gui stuff


        // Registers the Actions of the gui
        public void registerGuiAction()
        {
            MelonLogger.Msg(ConsoleColor.DarkYellow, "Registering GUI actions....");


            MelonLogger.Msg(ConsoleColor.DarkGreen, "Registered GUI actions Successsfully!");

        }


        // Registers the buttons 
        public void registerGuiLayout()
        {
            MelonLogger.Msg(ConsoleColor.DarkYellow, "Registering UI Layout.. ");



            MelonLogger.Msg(ConsoleColor.DarkGreen, "Registered UI Layout Successfully!");

        }

       

    }
}
