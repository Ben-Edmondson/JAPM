using JAPM.ClassLibrary.Services;
using JAPM_Class_Library.Repository;
using System.Security.Principal;

public class Program
{
     static void Main(string[] args)
    {
        Inputs inputs = new Inputs();
        PasswordRepository passwordRepository = new PasswordRepository();
        Console.WriteLine("Welcome to JAPM");
        Console.WriteLine("Please select a function");
        Console.WriteLine
        (
        @"1. Read all entries
2. Update an entry
3. Delete an entry
4. Read an entry"
        );

        int selection = inputs.StringToIntParser();
        inputs.GetSelection(selection);
        switch (selection)
        {
            case 1:
                foreach (var account in passwordRepository.ReadAll())
                {
                    Console.WriteLine($"ID:{account.Id}       Application: {account.Application}     Username/Email: {account.Username}        Password: {account.Password}");
                }
                break;
            case 2:

                break;
            case 3:

                break;
            case 4:
                int idSelected = inputs.StringToIntParser();
                if(passwordRepository.Read(idSelected) != null)
                {
                    Console.WriteLine(passwordRepository.Read(idSelected));
                }
                break;
            default:
                break;
        }

        Console.ReadLine();
    }
}