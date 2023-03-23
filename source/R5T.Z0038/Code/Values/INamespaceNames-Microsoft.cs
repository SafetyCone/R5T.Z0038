using System;

using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0038
{
    public partial interface INamespaceNames
    {
        public NamespaceName Microsoft => "Microsoft".ToNamespaceName();
        public NamespaceName Microsoft_Extensions => "Microsoft.Extensions".ToNamespaceName();
        public NamespaceName Microsoft_Extensions_Configuration => "Microsoft.Extensions.Configuration".ToNamespaceName();
        public NamespaceName Microsoft_Extensions_DependencyInjection => "Microsoft.Extensions.DependencyInjection".ToNamespaceName();
        public NamespaceName Microsoft_Extensions_Hosting => "Microsoft.Extensions.Hosting".ToNamespaceName();
        public NamespaceName Microsoft_Extensions_Logging => "Microsoft.Extensions.Logging".ToNamespaceName();
    }
}
