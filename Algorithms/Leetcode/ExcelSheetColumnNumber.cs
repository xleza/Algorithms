using System;

namespace Algorithms.Leetcode
{
    public sealed class ExcelSheetColumnNumber
    {
        public static int Execute(string sheet)
        {
            var result = 0;
            for (var i = 0; i < sheet.Length; i++)
            {
                var numberInAlphabet = sheet[sheet.Length - 1 - i] - 64;
                result += numberInAlphabet * (int)Math.Pow(26, i);
            }

            return result;
        }
    }
}
