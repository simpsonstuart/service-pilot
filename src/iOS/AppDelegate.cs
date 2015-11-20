using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using enosiX;
using System.Net.Http;
using enosiX.App.Framework.Mobile.Util;
using enosiX.App.Framework.Mobile;

namespace ServiceTime.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			PlatformServices.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			PlatformServices.UpdateVersionPreference ();

			#if DEBUG
			(null as IOnlineContextConfiguration).HttpClient(()=>{
				var handler = new HttpMessageHandlerWrapper();
				handler.RequestLog += Console.WriteLine;
				return new HttpClient( handler );
			});
			#endif

			LoadApplication (new App ());

			app.SetStatusBarHidden (false, false);

			return base.FinishedLaunching (app, options);
		}
	}
}

