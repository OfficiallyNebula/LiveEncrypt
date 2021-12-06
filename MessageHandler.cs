using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LiveEncrypt
{
    //Call class by doing: MessageHandler mh = new MessageHandler();
    //This means you can shorten a lot of commands by simply doing: mh.message();
    class MessageHandler
    {
        public bool Debug { get; set; }


        //Example usage: MessageHandler.Message("Hello World", 100, true);
        //Create method that takes a string input and has an optional delay to be passed debug mode is disabled by default - message handler will not handle debugs.
        private void Message(string input, int delay = 0)
        {
            if (Debug == false)
                Console.WriteLine($"[MH] >> {input}");
                //Some stuff here to run whenever debug is not enabled (simple messaging)
            else
                Console.WriteLine($"DEBUG [MH] >> {input}");

        }

        //Get/set Message from Private Message method
        public void GetMessage(string input, int delay = 0)
        {
            Message(input, delay);
        }

        //Example usage: string input = MessageHandler.Input();
        public string Input()
        {
            return Console.ReadLine();
        }


        //Example usage: MessageHandler.LineBreak();
        public void LineBreak()
        {
            Console.WriteLine("--------[Message Handler]--------");
        }

        //Example usage: MessageHandler.StreamWriter("Hello World");
        public void StreamWriter(string input)
        {
            string fileName = $"{System.Reflection.Assembly.GetEntryAssembly().GetName().Name}.neb";
            using (StreamWriter writer = File.AppendText(fileName))
            {
                if (Debug == false)
                {
                    try
                    {
                        writer.Write(input.ToString());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"[MH] >> ERROR EXCEPTION OCCURED DURING WRITING TO FILE \n Exception: {e}");
                        throw;
                    }
                }
                else if (Debug == true)
                {
                    try
                    {
                        writer.Write(input.ToString());
                        Console.WriteLine($"DEBUG [MH] >> StreamWriter Called. \nDEBUG [MH] >> StreamWriter Try statement Success.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"[MH] >> ERROR EXCEPTION OCCURED DURING WRITING TO FILE \n Exception: {e}");
                        throw e;
                    }
                }
                else throw new Exception("Exception thrown in Streamwriter Debug mode");
                
            }
        }
    }
}
