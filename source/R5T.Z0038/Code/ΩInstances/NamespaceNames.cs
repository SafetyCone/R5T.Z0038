using System;


namespace R5T.Z0038
{
    public class NamespaceNames : INamespaceNames
    {
        #region Infrastructure

        public static INamespaceNames Instance { get; } = new NamespaceNames();


        private NamespaceNames()
        {
        }

        #endregion
    }
}
