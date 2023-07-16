using System;

using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0038
{
    public partial interface INamespaceNames
    {
        public INamespaceName System => "System".ToNamespaceName();
        public INamespaceName System_IO => "System.IO".ToNamespaceName();
        public INamespaceName System_Linq => "System.Linq".ToNamespaceName();
        public INamespaceName System_Threading => "System.Threading".ToNamespaceName();
        public INamespaceName System_Threading_Tasks => "System.Threading.Tasks".ToNamespaceName();
    }
}
