using System;


namespace R5T.T0042
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class CharacterOperator : ICharacterOperator
    {
        #region Static
        
        public static CharacterOperator Instance { get; } = new();

        #endregion
    }
}