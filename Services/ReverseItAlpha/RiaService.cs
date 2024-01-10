namespace TwoToSevenEndPoints.Services.ReverseItAlpha
{
    public class RiaService : IRiaService
    {
        public string RevAlpha(string alphaInput)
        {
            string alphaOutput = "";
            for (int i = alphaInput.Length - 1; i >= 0; i--)
            {
                alphaOutput += alphaInput[i];
            }
            return $"You gave me {alphaInput}, now I give you {alphaOutput}";

        }
    }
}