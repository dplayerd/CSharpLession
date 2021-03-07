using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace ReadConfig
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = ConfigurationManager.AppSettings["SourceFilePath"];
            string targetPath = ConfigurationManager.AppSettings["TargetFilePath"];

            Console.WriteLine("  " + sourcePath);
            Console.WriteLine("  " + targetPath);

            Console.ReadLine();
        }

        void GOGOGO()
        {
            UserModel model = new UserModel();

            model.UserID = 0;
            model.Email = "dplayerd@gmail.com";
            model.UserProfileUrl = 
                new Uri("https://www.google.com/");

            UserModel model2 = new UserModel();

            model2.UserID = 1;
            model2.Email = "dplayerd@gmail.com";
            model2.UserProfileUrl =
                new Uri("https://www.google.com/");
        }
    }
}
