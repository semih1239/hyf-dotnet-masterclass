namespace week3.Models;

public class ConversionRequest
{
    public double Value { get; set; }
    public ValueType TypeToConvert { get; set; }

    public enum ValueType
    {
        Miles,
        Kilometers,
        Gallons,
        Liters,
        Pound,
        Kilogram
    }
}
