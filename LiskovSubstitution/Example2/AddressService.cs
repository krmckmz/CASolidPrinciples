public class AddressService
{
    protected const int USZipCodeBase = 1000;

    public virtual Address GetAddressForUser(int userId)
    {
        Require.That(() => userId > 10);

        var address = new Address()
        {
            Street = "Street",
            City = "Murray",
            Country = "USA",
            ZipCode =24509
        };

        Require.That(()=>address.ZipCode>1000);

        return address;
    }
}