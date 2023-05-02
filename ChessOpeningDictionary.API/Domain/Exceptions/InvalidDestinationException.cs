namespace ChessOpeningDictionary.API.Domain.Exceptions;

public class InvalidDestinationException : Exception
{
    public InvalidDestinationException() : base("Invalid destination square")
    {

    }
}
