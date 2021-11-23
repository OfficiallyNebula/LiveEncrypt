using System;
using System.IO;

namespace LiveEncrypt
{
    class Program
    {

        static void Main(string[] args)
        {
            Encryption encryption = new Encryption();
            encryption.Encrypt("Hello");
        }

    }
}
