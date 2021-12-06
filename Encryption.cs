using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LiveEncrypt
{
    class Encryption
    {
        //My version of obfuscation using strings
        public void Encrypt(string input)
        {
            MessageHandler mh = new MessageHandler();
            /*Take the input of "Buzz" and add foobar to every letter*/
            string key1 = "foo";
            string key2 = "bar";

            //Format Date to string and get rid of date to leave time. (HH is 24 hour, hh is 12 hour)
            var timeString = DateTime.Now.ToString("HH:mm:ss");

            //Open file and add the current time to the line
            mh.StreamWriter(timeString);

            //For every character within the string, run this code
            foreach (char c in input.ToCharArray())
            {
                //Iterate through every letter within the string and add the key's to either end then output to the file.
                try
                {
                    string combine = key1 + c + key2;
                    mh.GetMessage(combine.ToString());
                    mh.StreamWriter(combine);

                }
                catch (Exception)
                {
                    mh.GetMessage("Error within Try/Catch of Encryption in Encrypt");
                    throw;
                }

            }
            //Add new line ready for next input
            mh.StreamWriter("\n");
        }

        //Example usage: Encryption.CreateMD5("Hello");
            public string CreateMD5(string input)
            {
                MessageHandler mh = new MessageHandler();
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
                mh.StreamWriter(sb.ToString());
                //enter new line into file ready for next input
                mh.StreamWriter("\n");
                return sb.ToString();
                }
            }
        }
    }
