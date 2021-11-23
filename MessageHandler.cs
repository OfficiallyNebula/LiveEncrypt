using System;
using System.Collections.Generic;
using System.Text;

namespace LiveEncrypt
{
    class MessageHandler
    {
        //Create method that takes a string input and has an optional delay to be passed debug mode is disabled by default - message handler will not handle debugs.
        public void Message(string input, int delay = 0, bool debug = false)
        {
            if (!debug)
            {
                Console.WriteLine($"MH >> {input}");
                //Some stuff here to run whenever debug is not enabled (simple messaging)
            } else
            {
                //If debug enabled, run this.
            }




        }

    }
}
