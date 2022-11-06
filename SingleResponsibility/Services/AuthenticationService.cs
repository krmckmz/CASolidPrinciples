public class AuthenticationService
{
    public void ChangePassword(Guid accountId, string newPassword) => Console.WriteLine("Password change");
    public void Login(string username, string password) => Console.WriteLine("Login");
    public void LogOut(string username) => Console.WriteLine("Logout");
}