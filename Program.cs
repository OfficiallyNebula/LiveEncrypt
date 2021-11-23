using System;
using System.IO;

namespace LiveEncrypt
{
    class Program
    {

        public static void Main(string[] args)
        {
            Encryption encryption = new Encryption();
            /*encryption.Encrypt("Hello");*/

            Console.WriteLine(encryption.CreateMD5("Hello"));
        }

    }
}
