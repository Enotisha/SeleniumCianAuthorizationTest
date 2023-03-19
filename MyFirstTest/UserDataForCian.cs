using System.Runtime.CompilerServices;

namespace MyFirstTest;

public static class UserDataForCian
{
    private static string filePath = @"C:\Users\pavlova_pn\Desktop\ulearn\TelegramBot\MyFirstTest\MyFirstTest\UserDataForCian.txt";
    
    public static void GetUserDataForCian(out string login, out string pass, out string expectedUserId)
    {
        string[] lines = File.ReadAllLines(filePath);
        login = lines[0];
        pass = lines[1]; 
        expectedUserId = lines[2];
    }
}