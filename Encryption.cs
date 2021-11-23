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

            /*Take the input of "Buzz" and add foobar to every letter*/
            string key1 = "foo";
            string key2 = "bar";

            //Format Date to string and get rid of date to leave time. (HH is 24 hour, hh is 12 hour)
            var timeString = DateTime.Now.ToString("HH:mm:ss");

            //Open file 'Encryption.neb' and add the current time to the line
            using (StreamWriter writer = new StreamWriter("Encryption.neb", append: true))
            {

                writer.Write($"{timeString}");
            }
            //For every character within the string, run this code
            foreach (char c in input.ToCharArray())
            {
                //Iterate through every letter within the string and add the key's to either end then output to the file.
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
            //Add new line ready for next input
            using (StreamWriter writer = new StreamWriter("Encryption.neb", append: true))
            {
                writer.WriteLine();
            }
        }

        public string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
