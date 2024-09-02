internal class Program
{
    private static void Main(string[] args)
    {
        CustomConverter converter = new CustomConverter();
        string input = "123";
        
        converter.Convert(input,out int result1);
        Console.WriteLine(result1);
        converter.Convert(input,out string result2);
        Console.WriteLine(result2);
        converter.Convert(input,out double result3);
        Console.WriteLine(result3);
    }
    
}
class CustomConverter()
{
    public void Convert(string input,out int result)
    {
        result = System.Convert.ToInt32(input);
    }
    public void Convert(string input, out string result)
    {
        result = System.Convert.ToString(input);
    }
    public void Convert(string input, out double result)
    {
        result = System.Convert.ToDouble(input);
    }

}
