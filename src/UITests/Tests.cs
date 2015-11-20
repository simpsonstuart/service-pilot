using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace ServiceTime.UITests
{
	[TestFixture (Platform.Android)]
	//[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void WelcomeTextIsDisplayed ()
		{
            app.Repl();
			//var ss = app.Screenshot ("Welcome screen.");
            
            //System.Diagnostics.Debug.WriteLine(ss.FullName);
            app.Tap(c => c.Marked("Completed"));
            app.Tap(c => c.Marked("Open"));
            app.Tap(c => c.Marked("811400"));
            app.Tap(c => c.Marked("Save"));
            app.Tap(c => c.Marked("Ok"));


            //Assert.IsNotNull (ss);
		}
	}
}

