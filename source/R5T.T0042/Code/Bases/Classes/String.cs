using System;


namespace R5T.T0042
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class String : IString
    {
        #region Static

        public static String Instance { get; } = new();

        #endregion
    }
}