using Equin.ApplicationFramework;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;
using Ritossa.DevOpsArtifactsCleaner.WinForm.Models;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Converters
{
    internal static class PackageModelConverter
    {
        public static PackageSourceItem ToSourceItem(this PackageModel model)
        {
            var item = new PackageSourceItem();

            item.Id = model.Id;
            item.Name = model.Name;
            item.ProtocolType = model.ProtocolType;
            item.Url = model.Url;
            item.Versions = new BindingListView<VersionModel>(model.Versions);

            return item;
        }

        public static BindingListView<PackageSourceItem> ToDataSource(this List<PackageModel> models)
        {
            return new BindingListView<PackageSourceItem>(models.Select(ToSourceItem).ToList());
        }
    }
}
