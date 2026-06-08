using System;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml.Controls;
using Yugen.DJ.Uwp.Interfaces;
using Yugen.Toolkit.Uwp.Helpers;
using Yugen.DJ.Uwp.Views.Dialogs;

namespace Yugen.DJ.Uwp.StateTriggers
{
	public class WhatsNewDisplayService : IWhatsNewDisplayService
	{
		private bool isShown = false;
		private readonly DispatcherQueue _dispatcherQueue = DispatcherQueue.GetForCurrentThread();

		public async Task ShowIfAppropriateAsync()
		{
			if (SystemInfoHelper.IsAppUpdated && !isShown)
			{
				isShown = true;
				_dispatcherQueue.TryEnqueue(async () =>
				{
					var dialog = new WhatsNewDialog();
					await dialog.ShowAsync();
				});
			}
		}
	}
}