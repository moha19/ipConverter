using System;

namespace ipConverter
{
    internal class CommonMethods
    {
       
        internal static string IP2Number(string inputIP)
        {
            var array = inputIP.Split('.');
            double num = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                num += ((int.Parse(array[i]) % 256) * Math.Pow(256, (3 - i)));
            }
            return num.ToString();
        }

        internal static string Number2IP(string input)
        {
            long inputNumber;
            long.TryParse(input, out inputNumber);
            return string.Format("{0}.{1}.{2}.{3}", 
                                (inputNumber >> 24), 
                                (inputNumber >> 16) & 0xff, 
                                (inputNumber >> 8) & 0xff,
                                inputNumber & 0xff);
        }

        internal static string Hex2IP(string inputHex)
        {
            if (inputHex.Length != 8) return "Not 8 Digit";
            return string.Format("{0}.{1}.{2}.{3}",
                int.Parse(inputHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
                                int.Parse(inputHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(inputHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber),
                int.Parse(inputHex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber));

        }
    }
}