namespace TwoToSevenEndPoints.Services.ReverseItNum
{
    public class RinService
    {
        public string RevNum(int numInput)
        {
            string numMid = numInput.ToString();
            Char[] numOutput = numMid.ToCharArray();
            Array.Reverse(numOutput);
            return $"You gave me {numInput}, now I give you {new string(numOutput)}";
        }
    }
}