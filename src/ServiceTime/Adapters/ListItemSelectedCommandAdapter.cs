using System;
using Xamarin.Forms;

namespace ServiceTime.Adapters
{
	public class ListItemSelectedCommandAdapter : EventCommandAdapter<ListView, SelectedItemChangedEventArgs>
	{
		/// <summary>
		/// When set the selected item is reset after the command is executed
		/// </summary>
		/// <value><c>true</c> if reset item; otherwise, <c>false</c>.</value>
		public bool ResetItem { get; set; }

		public ListItemSelectedCommandAdapter(BindableObject dest, BindableProperty property, ListView source) 
			: base(dest, property, source, (s, e) => s.ItemSelected += e, (s, e) => e.SelectedItem)
		{
		}

		protected override void EventHandler (object sender, SelectedItemChangedEventArgs e)
		{
			base.EventHandler (sender, e);

			if (null != e.SelectedItem && ResetItem) 
			{
				var list = sender as ListView;
				if (null != list) 
				{
					list.SelectedItem = null;
				}
			}
		}
	}

}

