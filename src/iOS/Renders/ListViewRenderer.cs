using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using System.ComponentModel;
using ServiceTime.iOS;
using CoreGraphics;

[assembly:ExportRenderer (typeof(ListView), typeof(CustomListViewRenderer))]

namespace ServiceTime.iOS
{
	public class CustomListViewRenderer: ListViewRenderer
	{
		protected override void OnElementPropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);

			//https://forums.xamarin.com/discussion/40420/listview-pull-to-refresh-causes-top-cell-to-be-scrolled-off-screen
			//https://bugzilla.xamarin.com/show_bug.cgi?id=28061
			//if IsRefreshing has been flipped off, we need to fix the scroll offset
			if (e.PropertyName == ListView.IsRefreshingProperty.PropertyName) {
				if (!Element.IsRefreshing) {
					Control.SetContentOffset (new CGPoint (0, 0), false);
				}
			}
		}
	}
}

