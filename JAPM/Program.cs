using JAPM.ClassLibrary.Services;
Inputs inputs = new Inputs();
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
Console.WriteLine(selection);
Console.ReadLine();