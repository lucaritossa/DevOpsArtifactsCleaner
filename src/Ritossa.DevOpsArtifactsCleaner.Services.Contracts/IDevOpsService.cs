using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts
{
    /// <summary>
    /// Service for managing Azure DevOps Artifacts operations including package retrieval, deletion, and listing management.
    /// </summary>
    public interface IDevOpsService
    {
        /// <summary>
        /// Tests the connection to Azure DevOps using the provided user settings.
        /// </summary>
        /// <param name="userSettings">User settings containing organization, project, feed, and authentication information.</param>
        /// <param name="progress">Progress reporter for status updates during the connection test.</param>
        /// <returns>True if the connection is successful; otherwise, false.</returns>
        bool TestConnection(UserSettingsModel userSettings, IProgress<string> progress);

        /// <summary>
        /// Retrieves all packages from the specified Azure DevOps feed asynchronously.
        /// </summary>
        /// <param name="settings">User settings containing organization, project, feed, protocol type, and version inclusion preferences.</param>
        /// <param name="progress">Progress reporter for status updates during package retrieval.</param>
        /// <returns>A list of package models containing package information and their versions.</returns>
        Task<List<PackageModel>> GetAllPackagesAsync(UserSettingsModel settings, IProgress<string> progress);

        /// <summary>
        /// Unlists the specified package versions asynchronously, making them unavailable for new installations while keeping existing references intact.
        /// </summary>
        /// <param name="settings">User settings containing organization, project, feed, and authentication information.</param>
        /// <param name="toUnlist">List of package versions to unlist.</param>
        /// <param name="progress">Progress reporter for status updates during the unlisting operation.</param>
        /// <returns>True if the unlisting operation is successful; otherwise, false.</returns>
        Task<bool> UnlistVersionsAsync(UserSettingsModel settings, List<PackageVersionModel> toUnlist, IProgress<string> progress);

        /// <summary>
        /// Relists the specified package versions asynchronously, making them available again for new installations.
        /// </summary>
        /// <param name="settings">User settings containing organization, project, feed, and authentication information.</param>
        /// <param name="toRelist">List of package versions to relist.</param>
        /// <param name="progress">Progress reporter for status updates during the relisting operation.</param>
        /// <returns>True if the relisting operation is successful; otherwise, false.</returns>
        Task<bool> RelistVersionsAsync(UserSettingsModel settings, List<PackageVersionModel> toRelist, IProgress<string> progress);

        /// <summary>
        /// Deletes the specified package versions asynchronously, moving them to the feed's recycle bin.
        /// </summary>
        /// <param name="settings">User settings containing organization, project, feed, and authentication information.</param>
        /// <param name="toDelete">List of package versions to delete.</param>
        /// <param name="progress">Progress reporter for status updates during the deletion operation.</param>
        /// <returns>True if the deletion operation is successful; otherwise, false.</returns>
        Task<bool> DeletePackageVersionsAsync(UserSettingsModel settings, List<PackageVersionModel> toDelete, IProgress<string> progress);

        /// <summary>
        /// Extracts and flattens all package versions from a list of packages into a single collection.
        /// </summary>
        /// <param name="source">List of packages containing their respective versions.</param>
        /// <returns>A flattened list of all package versions from all packages, ordered by version and name.</returns>
        List<PackageVersionModel> GetAllPackageVersions(List<PackageModel> source);
    }
}
