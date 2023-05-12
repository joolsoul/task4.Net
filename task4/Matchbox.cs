using System.Text;

namespace task4;

public class Matchbox
{
    private string _manufacturerCompany;
    private int _numberOfMatches;
    private double _burnTime;

    public Matchbox(string manufacturerCompany, int numberOfMatches, double burnTime)
    {
        _manufacturerCompany = manufacturerCompany;
        _numberOfMatches = numberOfMatches;
        _burnTime = burnTime;
    }

    public string ManufacturerCompany
    {
        get => _manufacturerCompany;
        set => _manufacturerCompany = value;
    }

    public int NumberOfMatches
    {
        get => _numberOfMatches;
        set => _numberOfMatches = value;
    }

    public double BurnTime
    {
        get => _burnTime;
        set => _burnTime = value;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder($"Manufacturer company of this matchbox is the {_manufacturerCompany} \n");
        sb.Append($"Number of matches: {_numberOfMatches}; \n");
        sb.Append($"Burn time: {_burnTime} s; \n");
        return sb.ToString();
    }

    public virtual double GetQ()
    {
        return _numberOfMatches * _burnTime;
    }
    
}