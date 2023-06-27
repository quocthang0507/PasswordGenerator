using PasswordGenerator;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string[] arguments = Environment.GetCommandLineArgs();

        int length = 1;
        var pwd = new Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: false, passwordLength: 10);

        if (arguments.Length == 2)
            if (int.TryParse(arguments[1], out length))
            {
                string[] passwords = pwd.NextGroup(length).ToArray();
                Console.WriteLine(string.Join('\n', passwords));
            }
            else
            {
                string password = pwd.Next();
                Console.WriteLine(password);
            }
        else
        {
            Console.WriteLine("Wrong number of arguments or invalid arguments");
        }
    }
}