using System;

namespace CASolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateFinder = new StateFinder();

            //For Us
            try
            {
                var addressVerifier = new AddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(11, addressVerifier));
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, addressVerifier));
            }
            catch (InvalidOperationException exception)
            {
                System.Console.WriteLine(exception.Message);
            }

            //For Germany
            try
            {
                var germanyAddressVerifier = new GermanyAddressVerifier();
                Console.WriteLine(stateFinder.GetStateNameForZipCode(11, germanyAddressVerifier));
                Console.WriteLine(stateFinder.GetStateNameForZipCode(9, germanyAddressVerifier));
            }
            catch (InvalidOperationException exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}