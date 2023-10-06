namespace blackjack.Structs;

public struct Card
{
    private const string _back = "🂠";
    private readonly string _symbol = string.Empty;

    public bool IsHidden { get; set; }
    public int Value { get; set; }
    public bool IsRemoved { get; set; }

    public readonly string Symbol
    {
        get { return IsHidden ? _back : _symbol; }
    }

    public Card(string symbol, int value, bool isHidden = false)
    {
        _symbol = symbol;
        Value = value;
        IsHidden = isHidden;
        IsRemoved = false;
    }
}
