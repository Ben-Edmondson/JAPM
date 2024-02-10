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
                username = Console.ReadLine();
                while (username == null)
                {
                    Console.WriteLine("Please enter the Username or Email you would like to save a password for. This cannot be blank.");
                username = Console.ReadLine();
            }

            return username;
        }

        public string GetPassword()
        {
            string? password = null;
            Console.WriteLine("Please enter the password you would like to save.");
            while (password == null)
            {
                Console.WriteLine("Please enter the password you would like to save. This cannot be blank.");
            }
            return password;
        }

        public int GetSelection(int selection)
        {
            while(selection < 1 || selection > 4 || selection == null)
            {
                Console.WriteLine("Thats not a valid option, try again");
                selection = StringToIntParser();
            }
            return selection;
        }

        public int StringToIntParser()
        {
            var numberToParse = Console.ReadLine();
            var numberParsed = 0;
            while (!int.TryParse(numberToParse, out numberParsed))
            {
                Console.WriteLine("Invalid number");
                numberToParse = Console.ReadLine();
            }
            return numberParsed;
        }
    }
}