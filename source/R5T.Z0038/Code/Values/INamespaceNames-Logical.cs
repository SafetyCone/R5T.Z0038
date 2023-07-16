using System;

using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0038
{
    public partial interface INamespaceNames
    {
        /// <summary>
        /// "": ALL namespaces are contained within the namespace with this name.
        /// As in, all of "System", "global::System", "R5T", extern alias DependencyX -> "DependencyX::System" are contained within "".
        /// </summary>
        public const string AllNamespaces_Constant = "";

        /// <summary>
        /// &lt;null&gt;: No namespaces are contained within the namespace with this name.
        /// No matter was namespace name you can dream up, the result of any ContainsNamespace(parentNamespaceName, childNamespaceName) implementation will be false if the parent has this namespace name.
        /// </summary>
        public const string NoNamespaces_Constant = null;


        public INamespaceName AllNamespaces => INamespaceNames.AllNamespaces_Constant.ToNamespaceName();
        public INamespaceName NoNamespaces => INamespaceNames.NoNamespaces_Constant.ToNamespaceName();
    }
}
