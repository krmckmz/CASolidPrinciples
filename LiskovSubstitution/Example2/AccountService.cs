public class AccountService
{
    public void ChangeAddress(Address address)
    {
        Require.That(()=>address.ZipCode>1000);

        System.Console.WriteLine("Address has been changed");
    }
}