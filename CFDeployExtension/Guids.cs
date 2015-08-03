// Guids.cs
// MUST match guids.h
using System;

namespace Pivotal.CFDeployExtension
{
    static class GuidList
    {
        public const string guidMyExtensionPkgString = "14796bd1-9ea5-4eff-b4c0-bee11efbb734";
        public const string guidMyExtensionCmdSetString = "6abb0b81-9bb9-450d-849d-554a6501b931";

        public static readonly Guid guidMyExtensionCmdSet = new Guid(guidMyExtensionCmdSetString);
    };
}