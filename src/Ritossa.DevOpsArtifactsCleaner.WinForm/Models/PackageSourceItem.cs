using Equin.ApplicationFramework;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Models
{
    public class PackageSourceItem : PackageModel
    {
        public new BindingListView<VersionModel> Versions { get; set; }
    }
}
