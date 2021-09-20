using System;

using R5T.T0042;


namespace System
{
    public static class IStringOperatorExtensions
    {
        public static bool BeginsWith(this IStringOperator _,
            string @string,
            string beginning)
        {
            var output = StringHelper.BeginsWith(@string, beginning);
            return output;
        }

        public static bool ContainsAny(this IStringOperator _,
            string @string,
            char[] characters)
        {
            var index = @string.IndexOfAny(characters);

            var wasFound = StringHelper.IsFound(index);
            return wasFound;
        }

        public static string ToVerbatimString(this IStringOperator _,
            string @string)
        {
            var output = $"{Characters.At}\"{@string}\"";
            return output;
        }
    }
}
