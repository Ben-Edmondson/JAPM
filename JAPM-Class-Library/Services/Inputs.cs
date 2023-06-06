namespace JAPM.ClassLibrary.Services
{
    public class Inputs
    {

        public string GetAppNAme()
        {
            string? appName = null;
            Console.WriteLine("Please enter an app you would like to save a password for.");
            while (appName == null)
            {
                appName = Console.ReadLine();
                if (appName == null)
                {
                    Console.WriteLine("Please enter an app you would like to save a password for. This cannot be blank.");
                }
            }
            return appName;
        }
        public string GetUsernameOrEmail()
        {
            string? username = null;
            Console.WriteLine("Please enter the Username or Email you would like to save a password for.");
            while (username == null)
            {
                username = Console.ReadLine();
                if (username == null)
                {
                    Console.WriteLine("Please enter the Username or Email you would like to save a password for. This cannot be blank.");
                }
            }
            return username;
        }

        public string GetPassword()
        {
            string? password = null;
            Console.WriteLine("Please enter the password you would like to save.");
            if (password == null)
            {
                Console.WriteLine("Please enter the password you would like to save. This cannot be blank.");
            }
            return password;
        }
    }
}