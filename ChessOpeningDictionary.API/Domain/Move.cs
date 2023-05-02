using ChessOpeningDictionary.API.Domain.Enums;

namespace ChessOpeningDictionary.API.Domain;

public class Move
{
    public EPlayerColor EPlayerColor { get; set; }
    public EPiece EPiece { get; set; }
    public Destination Destination { get; set; }

    public Move(EPlayerColor playerColor, EPiece piece, Destination destination)
    {
        EPlayerColor = playerColor;
        EPiece = piece;
        Destination = destination;
    }
}
