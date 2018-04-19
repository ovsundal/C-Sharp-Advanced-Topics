using System;
using System.Linq;

//Added to system namespace to prevent import code bloat
namespace System
{
    //Convention is to derive from original class if possible (ClassWithNewMethod : OriginalClass)
    public static class StringExtensions
    {
        //Shorten a string to max 5 letters, followed by ... using a custom extension method
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");
            }

            if (numberOfWords == 0)
            {
                return "";
            }

            var words = str.Split(' ');
            
            if (words.Length <= numberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}