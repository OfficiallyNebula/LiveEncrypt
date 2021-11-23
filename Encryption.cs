using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LiveEncrypt
{
    class Encryption
    {
        public void Encrypt(string input)
        {

            //buzz
            //foobbar
            //fooubar
            //foozbar
            //foozbar
            //foobbarfooubarfoozbarfoozbar
            string key1 = "foo";
            string key2 = "bar";

            //Format Date to string and get rid of date to leave time. (HH is 24 hour, hh is 12 hour)
            var timeString = DateTime.Now.ToString("HH:mm:ss");

            using (StreamWriter writer = new StreamWriter("Encryption.neb", append: true))
            {

                writer.Write($"{timeString}");
            }
            foreach (char c in input.ToCharArray())
            {
                try
                {
                    string combine = key1 + c + key2;
                    Console.WriteLine(combine);
                    using (StreamWriter writer = new StreamWriter("Encryption.neb", append: true))
                    {
                        writer.Write($"{combine.ToString().ToLower().Trim()}");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine(@"Error within Try/Catch of Encryption");
                    throw;
                }

            }
            using (StreamWriter writer = new StreamWriter("Encryption.neb", append: true))
            {
                writer.WriteLine();
            }
        }
    }
}
