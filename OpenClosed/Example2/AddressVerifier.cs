public class AddressVerifier : Verifier<Address>
{
    public virtual bool IsValid(Address address)
    {
        return true;
    }

    public virtual bool IsValidZipCode(int zipCode)
    {
        if (zipCode < 10)
            return false;

        return true;
    }
}