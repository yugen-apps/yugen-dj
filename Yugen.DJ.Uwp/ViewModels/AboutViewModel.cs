using Windows.ApplicationModel;
using Yugen.Toolkit.Standard.Mvvm;

namespace Yugen.DJ.Uwp.ViewModels
{
    public class AboutViewModel: ViewModelBase
    {
        private string _version;

        public AboutViewModel()
        {
            Version = $"{GetType().Assembly.GetName().Version} ({Package.Current.Id.Architecture.ToString().ToUpperInvariant()})";
        }

        public string Version
        {
            get => _version;
            set => SetProperty(ref _version, value);
        }
    }
}
