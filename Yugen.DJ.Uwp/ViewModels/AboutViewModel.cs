using Yugen.Toolkit.Standard.Mvvm;
using Yugen.Toolkit.Uwp.Helpers;

namespace Yugen.DJ.Uwp.ViewModels
{
    public class AboutViewModel: ViewModelBase
	{
		private string _version;

		public AboutViewModel()
        {
			Version = $"{SystemInfoHelper.ApplicationVersion} ({SystemInfoHelper.Architecture})";
		}

		public string Version
		{
			get => _version;
			set => SetProperty(ref _version, value);
		}
	}
}
