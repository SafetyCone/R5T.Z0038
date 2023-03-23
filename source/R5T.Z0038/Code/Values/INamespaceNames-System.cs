using System;

using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0038
{
    public partial interface INamespaceNames
    {
        public NamespaceName System => "System".ToNamespaceName();
        public NamespaceName System_IO => "System.IO".ToNamespaceName();
        public NamespaceName System_Linq => "System.Linq".ToNamespaceName();
        public NamespaceName System_Threading => "System.Threading".ToNamespaceName();
        public NamespaceName System_Threading_Tasks => "System.Threading.Tasks".ToNamespaceName();
    }
}
