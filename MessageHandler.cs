using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LiveEncrypt
{
    class MessageHandler
    {
        //Create method that takes a string input and has an optional delay to be passed debug mode is disabled by default - message handler will not handle debugs.
        public void Message(string input, int delay = 0, bool debug = false)
        {
            if (debug == false)
            {
                Console.WriteLine($"[MH] >> {input}");
                //Some stuff here to run whenever debug is not enabled (simple messaging)
            } 
            else
            {
                Console.WriteLine($"DEBUG [MH] >> {input}");
                //If debug enabled, run this.
            }

        }

        public string Input()
        {
            return Console.ReadLine();
        }

        public void StreamWriter(string input)
        {
            string fileName = $"{System.Reflection.Assembly.GetEntryAssembly().GetName().Name}.neb";
            using (StreamWriter writer = File.AppendText(fileName))
            {
                try
                {
                    writer.Write(input.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("[MH] >> ERROR EXCEPTION OCCURED DURING WRITING TO FILE");
                    throw;
                }
                
            }
        }
    }
}
