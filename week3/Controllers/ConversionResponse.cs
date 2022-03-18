namespace week3.Models;

public class ConversionResponse
{
    public double Value { get; set; }
    public string ValueType { get; set; }

    public List<ConversionResponse> Conversion(ConversionRequest req)
    {
        List<ConversionResponse> result = new List<ConversionResponse>();

        if (req.TypeToConvert == ConversionRequest.ValueType.Gallons)
        {
            result.Add(new ConversionResponse { ValueType = "Gallons", Value = req.Value });
            result.Add(new ConversionResponse { ValueType = "Liters", Value = req.Value * 1.609 });
        }
        else if (req.TypeToConvert == ConversionRequest.ValueType.Liters)
        {
            result.Add(new ConversionResponse { ValueType = "Liters", Value = req.Value });
            result.Add(new ConversionResponse { ValueType = "Gallons", Value = req.Value * 0.6215 });
        }
        else if (req.TypeToConvert == ConversionRequest.ValueType.Miles)
        {
            result.Add(new ConversionResponse { ValueType = "Miles", Value = req.Value });
            result.Add(new ConversionResponse { ValueType = "Kilometers", Value = req.Value * 3.785412 });
        }
        else if (req.TypeToConvert == ConversionRequest.ValueType.Kilometers)
        {
            result.Add(new ConversionResponse { ValueType = "Kilometers", Value = req.Value });
            result.Add(new ConversionResponse { ValueType = "Miles", Value = req.Value * 0.2642 });
        }
        else if (req.TypeToConvert == ConversionRequest.ValueType.Pound)
        {
            result.Add(new ConversionResponse { ValueType = "Pound", Value = req.Value });
            result.Add(new ConversionResponse { ValueType = "Kilogram", Value = req.Value * 0.4536 });
        }
        else if (req.TypeToConvert == ConversionRequest.ValueType.Kilogram)
        {
            result.Add(new ConversionResponse { ValueType = "Kilogram", Value = req.Value });
            result.Add(new ConversionResponse { ValueType = "Pound", Value = req.Value * 2.205 });
        }

        return result;
    }
}