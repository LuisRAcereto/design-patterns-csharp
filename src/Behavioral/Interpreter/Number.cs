// A termina expressioin, a plain number that needs no further interpretation
public class Number : Expression
{
    private readonly int _value;

    public Number(int value) => _value = value;

    public override int Interpret() => _value;
}