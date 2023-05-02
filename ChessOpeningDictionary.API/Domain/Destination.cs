using ChessOpeningDictionary.API.Domain.Exceptions;

namespace ChessOpeningDictionary.API.Domain;

public class Destination
{
    public string Value { get; set; }

    public Destination(string value)
    {
        if (!IsValid(value))
        {
            throw new InvalidDestinationException();
        }

        Value = value;
    }
    public bool IsValid(string value)
    {
        if (value is null || value.Length != 2)
        {
            return false;
        }

        char firstChar = value[0];
        char secondChar = value[1];

        if (firstChar < 'A' || firstChar > 'H')
        {
            return false;
        }

        if (secondChar < '1' || secondChar > '8')
        {
            return false;
        }

        return true;
    }
}
