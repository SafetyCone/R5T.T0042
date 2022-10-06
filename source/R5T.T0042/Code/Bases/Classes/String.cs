using System;


namespace R5T.T0042
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class String : IString
    {
        #region Static

        public static IString Instance { get; } = new String();

        #endregion
    }
}