﻿using System;
using System.IO;
namespace LiveEncrypt
{
    class Program
    {

        //Create Encryption Key

        static void Encryption(string input)
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

        //Create Decryption Key

        static void Decryption()
        {

        }

        //Take user input


        //Concatenate user input with encryption


        //Save result to file

        //MAIN
        static void Main(string[] args)
        {
            Encryption("buzz");
        }




    }
}
