using System;


namespace R5T.T0042
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class Character : ICharacter
    {
        #region Static
        
        public static ICharacter Instance { get; } = new Character();

        #endregion
    }
}