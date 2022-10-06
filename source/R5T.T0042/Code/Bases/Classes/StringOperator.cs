using System;


namespace R5T.T0042
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class StringOperator : IStringOperator
    {
        #region Static

        public static IStringOperator Instance { get; } = new StringOperator();

        #endregion
    }
}