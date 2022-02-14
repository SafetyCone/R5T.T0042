using System;

using R5T.T0042;


namespace System
{
    public static class ICharacterOperatorExtensions
    {
        public static bool IsUppercase(this ICharacterOperator _,
            char character)
        {
            var output = Char.IsUpper(character);
            return output;
        }
    }
}
