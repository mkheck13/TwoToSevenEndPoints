namespace TwoToSevenEndPoints.Services.ReverseItAlpha
{
    public class RiaService
    {
        public string RevAlpha(string alphaInput)
        {
            Char[] alphaOutput = alphaInput.ToCharArray();
            Array.Reverse(alphaOutput);
            return $"You gave me {alphaInput}, now I give you {alphaOutput}";
        }
    }
}