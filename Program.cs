using System;
using System.IO;

namespace LiveEncrypt
{
    class Program
    {

        public static void Main(string[] args)
        {
            MessageHandler mh = new MessageHandler();
            
            while (true)
            {
                mh.Message("-----[Live Encrypt]-----");
                mh.Message("Please choose one of the following options");
                mh.Message("");
                mh.Message("1) Create MD5 Sum of input");
                mh.Message("2) Check MD5 Sum matches");
                mh.Message("3) Check two files are the same");
                mh.Message("");
                mh.Message("5) Enable Debug Mode");
                int choice = 0;

                while(true)
                {
                    try
                    {
                        choice = Convert.ToInt32(mh.Input());
                        break;
                    }
                    catch (Exception e)
                    {
                        mh.Message($"Exception thrown when converting string to int32 - Exception code: {e}");
                        throw;
                    }
                }
                if (choice == 1)
                {
                    Encryption encryption = new Encryption();
                    mh.Message("Please enter the phrase you wish to encrypt.");
                    string input = mh.Input();
                    mh.Message($"Your MD5 Hash is: {encryption.CreateMD5(input)}");
                    break;
                }else if (choice == 2)
                {
                    Encryption encryption = new Encryption();
                    mh.Message("Please enter the first phrase you wish to encrypt.");
                    string answer1 = mh.Input();
                    string md5result1 = encryption.CreateMD5(answer1);
                    mh.Message("Please enter the second phrase you wish to encrypt.");
                    string answer2 = mh.Input();
                    string md5result2 = encryption.CreateMD5(answer2);

                    if (md5result1 == md5result2)
                    {
                        mh.Message("Your MD5 Hash's are the same.");
                        mh.Message($"Hash 1 = {md5result1}");
                        mh.Message($"Hash 2 = {md5result2}");
                        mh.LineBreak();
                    } else
                    {
                        mh.Message("Your MD5 Hash's are NOT the same.");
                        mh.Message($"Hash 1 = {md5result1}");
                        mh.Message($"Hash 2 = {md5result2}");
                        mh.LineBreak();
                    }

                } else if (choice == 3)
                {
                    Encryption encryption = new Encryption();
                    string filePath = @"C:\Users\ben.harris\Downloads\test.txt";
                    if (!File.Exists(filePath))
                    {
                        mh.Message("File does not exist.");
                        return;
                    }
                    string argument = "/select, \"" + filePath + "\"";
                    System.Diagnostics.Process.Start("explorer.exe", argument);
                    
                } else if (choice == 5)
                {
                    mh.SetDebug(true);
                    Console.Clear();
                    mh.Message("Debug Mode enabled");
                    continue;
                }
            }
        }

    }
}
