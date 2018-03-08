using System;

namespace TDD.Test
{
    public class StringCalculator
    {
        internal int Sum(string str)
        {
            var delim1 = ',';
            var delim2 = ',';
            var newline = '\n';           
            if (str.StartsWith("//"))
                delim1 = str[2];
            if (str.Length>3 && str[3] != delim1 && !Char.IsNumber(str[3]))
                delim2 = str[3];
            var arrayOfNumbers = str.Split(delim1, delim2, newline);
            var result = 0;
            var number = 0;
            int i = 0;
            Boolean t = false;
            string[] arrayNeg = new string[5];
            foreach (var strNumber in arrayOfNumbers)
            {
                if (int.TryParse(strNumber, out number))
                {
                    if (number > 0 && number<1001)
                    {
                        result += number;
                    }
                    else if(number < 0)
                    {
                        arrayNeg.SetValue(number.ToString(), i);
                        i++;
                        Exception ex = new Exception();
                        t = true;                        
                    }
                }
            }
            if (t == true)
            {
                throw new Exception("Negatives are not allowed!" + arrayNeg[0] + arrayNeg[1]);
            }                    
            return result;
        }
    }
}