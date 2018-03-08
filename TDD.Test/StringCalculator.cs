using System;

namespace TDD.Test
{
    public class StringCalculator
    {
        internal int Sum(string str)
        {
            var delim1 = ',';
            var delim2 = '\n';
            if (str.StartsWith("//"))
                delim1 = str[2];

            var arrayOfNumbers = str.Split(delim1, delim2);

            var result = 0;
            var number = 0;
            int i = 0;
            string[] arrayNeg = new string[5];
            foreach (var strNumber in arrayOfNumbers)
            {


                if (int.TryParse(strNumber, out number))
                    try
                    {

                        if (number > 0)
                            result += number;
                        else
                        {

                            arrayNeg.SetValue(number.ToString(), i);
                            i++;
                            System.ArgumentException argEx = new System.ArgumentException("Negatives are not allowed!" + arrayNeg[0] + arrayNeg[1]);



                        }




                    }
                    catch (Exception argEx)
                    {
                        throw argEx;
                    }








            }

            return result;
        }
    }
}