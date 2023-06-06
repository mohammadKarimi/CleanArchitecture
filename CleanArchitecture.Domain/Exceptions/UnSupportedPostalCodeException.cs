namespace CleanArchitecture.Domain.Exceptions;

public class UnSupportedPostalCodeException : Exception
{
    public UnSupportedPostalCodeException(string postalCode)
        : base($"Postalcode \"{postalCode}\" is unsupported.")
    {
    }
}