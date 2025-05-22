public class Fraction
{
    private int _topNum;
    private int _bottomNum;

    public Fraction()
    {
        _topNum = 1;
        _bottomNum = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNum = wholeNumber;
        _bottomNum = 1;
    }

    public Fraction(int top, int bottom)
    {
        _topNum = top;
        _bottomNum = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_topNum}/{_bottomNum}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_topNum / (double)_bottomNum;
    }
}