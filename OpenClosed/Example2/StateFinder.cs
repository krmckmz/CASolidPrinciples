public class StateFinder
{
    public string GetStateNameForZipCode(int zipCode, AddressVerifier verifier)
    {
        if (!verifier.IsValidZipCode(zipCode))
            throw new InvalidOperationException($"Invalid code : {zipCode}");

        string city = (ZipCodes)zipCode;

        if (city is null)
            throw new InvalidOperationException($"No state found with : {zipCode}");

        return city;
    }
}