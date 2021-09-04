using System;

namespace ConsoleApp.Compilertest
{
    class Program
    {
        static void Main(string[] ededler)
        {
            if (ededler.Length == 0)
            {
                Console.WriteLine("-i | info");
                Console.WriteLine("-c | config");

                return;
            }

            string param = ededler[0];

            if (param == "-i")
            {
                Console.WriteLine("Bu program P512 qrupu terefinden yazilib.");
                return;
            }
            else if (param == "-c")
            {
                if (ededler.Length > 1)
                {
                    string username = ededler[1];
                    Console.WriteLine($"Your username: {username}");

                    return;
                }
            }
        }
    }
}

/*
dotnet "C:\Program Files\dotnet\sdk\5.0.303\Roslyn\bincore\csc.dll" -r:"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.9\System.Private.CoreLib.dll" -r:"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.9\System.Console.dll" -r:"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.9\System.Runtime.dll" 
-r:"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.9\System.Runtime.InteropServices.RuntimeInformation.dll" Program.cs
*/ 
