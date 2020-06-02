﻿#nullable enable

namespace Microsoft.Quantum.IQSharp.AzureClient
{
    /// <summary>
    /// This class contains resources that will eventually be exposed to localization.
    /// </summary>
    internal static class Resources
    {
        public const string AzureClientErrorUnknownError =
            "An unknown error occurred.";

        public const string AzureClientErrorNotConnected =
            "Not connected to any Azure Quantum workspace.";

        public const string AzureClientErrorNoTarget =
            "No execution target has been configured for Azure Quantum job submission.";

        public const string AzureClientErrorInvalidTarget =
            "The specified execution target is not valid for Q# job submission in the current Azure Quantum workspace.";

        public const string AzureClientErrorJobNotFound =
            "No job with the given ID was found in the current Azure Quantum workspace.";

        public const string AzureClientErrorJobNotCompleted =
            "The specified Azure Quantum job has not yet completed.";

        public const string AzureClientErrorNoOperationName =
            "No Q# operation name was specified for Azure Quantum job submission.";

        public const string AzureClientErrorAuthenticationFailed =
            "Failed to authenticate to the specified Azure Quantum workspace.";

        public const string AzureClientErrorWorkspaceNotFound =
            "No Azure Quantum workspace was found that matches the specified criteria.";
    }
}