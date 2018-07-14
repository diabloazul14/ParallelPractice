public class FakeObject
{
    public int Number {get;set;}

    public FakeObject(int number)
    {
        Number = number;
    }

    public double Square()
    {
        return Number * Number;
    }
}