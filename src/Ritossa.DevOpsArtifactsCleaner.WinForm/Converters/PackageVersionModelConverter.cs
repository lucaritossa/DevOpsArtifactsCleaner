using Equin.ApplicationFramework;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Converters
{
    internal static class PackageVersionModelConverter
    {
        public static BindingListView<PackageVersionModel> ToDataSource(this List<PackageVersionModel> models)
        {
            return new BindingListView<PackageVersionModel>(models);
        }
    }
}
