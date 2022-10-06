using System;
using System.Collections.Generic;
using System.Linq;

using R5T.Magyar;

using R5T.T0042;


namespace System
{
    public static class IStringOperatorExtensions
    {
        public static string AppendEllipsis(this IStringOperator _,
            string @string,
            string separator)
        {
            var output = $"{@string}{separator}{Strings.Ellipsis}";
            return output;
        }

        public static string AppendEllipsis(this IStringOperator _,
            string @string)
        {
            var output = _.AppendEllipsis(
                @string,
                Strings.CommaSeparatedListSpacedSeparator);

            return output;
        }

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

        public static bool ContainsAny(this IStringOperator _,
            string @string,
            string[] searchStrings)
        {
            var index = _.IndexOfAny(@string, searchStrings);

            var wasFound = StringHelper.IsFound(index);
            return wasFound;
        }

        public static string FormatAsList<TValue>(this IStringOperator _,
            IEnumerable<TValue> values)
        {
            var output = _.FormatAsListMaximumElementCountOfThree(values);
            return output;
        }

        public static string FormatAsListMaximumElementCount<TValue>(this IStringOperator _,
            IEnumerable<TValue> values,
            int maximumElementCount)
        {
            var hasMoreElements = values.HasMoreThan(maximumElementCount, out var elements);

            var list = _.FormatAsSeparatedList(elements);

            var modifiedList = hasMoreElements
                ? _.AppendEllipsis(list)
                : list
                ;

            return modifiedList;
        }

        public static string FormatAsListMaximumElementCountOfThree<TValue>(this IStringOperator _,
            IEnumerable<TValue> values)
        {
            var output = _.FormatAsListMaximumElementCount(values, 3);
            return output;
        }

        public static string FormatAsSeparatedList<TValue>(this IStringOperator _,
            IEnumerable<TValue> values,
            string separator)
        {
            var output = _.Join(separator, values
                .Select(xValue => xValue.ToString())
                .ToArray());

            return output;
        }

        public static string FormatAsSeparatedList<TValue>(this IStringOperator _,
            IEnumerable<TValue> values)
        {
            var output = _.FormatAsSeparatedList(values, Strings.CommaSeparatedListSpacedSeparator);
            return output;
        }

        public static int IndexOfAny(this IStringOperator _,
            string @string, 
            string[] searchStrings)
        {
            foreach (var searchString in searchStrings)
            {
                var index = @string.IndexOf(searchString);

                var wasFound = StringHelper.IsFound(index);
                if(wasFound)
                {
                    return index;
                }
            }

            return StringHelper.IndexOfNotFound;
        }

        public static int[] IndexOfEach(this IStringOperator _,
            string @string,
            string[] searchStrings)
        {
            var output = searchStrings
                .Select(xSearchString => @string.IndexOf(xSearchString))
                .ToArray();

            return output;
        }

        public static bool IsEmpty(this IStringOperator _,
            string @string)
        {
            var output = @string == Strings.Empty;
            return output;
        }

        public static bool IsNullOrEmpty(this IStringOperator _,
            string @string)
        {
            var output = String.IsNullOrEmpty(@string);
            return output;
        }

        public static bool IsNotEmpty(this IStringOperator _,
            string @string)
        {
            var isEmpty = _.IsEmpty(@string);

            var output = !isEmpty;
            return output;
        }

        public static bool IsNotNullAndNotEmpty(this IStringOperator _,
            string @string)
        {
            var isNullOrEmpty = _.IsNullOrEmpty(@string);

            var output = !isNullOrEmpty;
            return output;
        }

        public static string Join(this IStringOperator _,
            char separator,
            params string[] strings)
        {
            var output = String.Join(separator.ToString(), strings);
            return output;
        }

        public static string Join(this IStringOperator _,
            string separator,
            params string[] strings)
        {
            var output = String.Join(separator, strings);
            return output;
        }

        public static string[] Split(this IStringOperator _,
            string @string,
            char[] separators,
            StringSplitOptions stringSplitOptions = StringSplitOptions.None)
        {
            var output = @string.Split(separators, stringSplitOptions);
            return output;
        }

        public static string ToVerbatimString(this IStringOperator _,
            string @string)
        {
            var output = $"{Characters.At}\"{@string}\"";
            return output;
        }

        public static string TrimEnd(this IStringOperator _,
            string @string,
            params char[] trimCharacters)
        {
            var output = @string.TrimEnd(trimCharacters);
            return output;
        }

        public static string TrimStart(this IStringOperator _,
            string @string,
            params char[] trimCharacters)
        {
            var output = @string.TrimStart(trimCharacters);
            return output;
        }
    }
}
