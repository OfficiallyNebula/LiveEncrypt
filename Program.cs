using System;
using System.IO;

namespace LiveEncrypt
{
    class Program
    {

        public static void Main(string[] args)
        {
            Encryption encryption = new Encryption();
            MessageHandler mh = new MessageHandler();

            mh.Message("Please enter your desired string");
            string input = mh.Input();
            mh.Message(encryption.CreateMD5(input));
        }

    }
}
