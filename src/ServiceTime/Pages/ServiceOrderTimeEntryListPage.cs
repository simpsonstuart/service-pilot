using System;
using Xamarin.Forms;
using enosiX.App.Framework.Mobile.Controls;
using enosiX.App.Framework.Mobile;
using System.Windows.Input;
using ServiceTime.Adapters;
using ServiceTime.Converters;

namespace ServiceTime.Pages
{
	public class ServiceOrderTimeEntryListPage : ContentPage
	{
		public static readonly BindableProperty ItemSelectedCommandProperty = 
			BindableProperty.Create<ServiceOrderTimeEntryListPage, ICommand>(v=>v.ItemSelectedCommand, null);

		public ICommand ItemSelectedCommand
		{
			get { return (ICommand)GetValue (ItemSelectedCommandProperty); }
			set { SetValue (ItemSelectedCommandProperty, value); }
		}
        

		readonly ListItemSelectedCommandAdapter _itemSelctedAdapter;
		readonly ServiceOrderList _list;

		public ServiceOrderTimeEntryListPage ()
		{


            //sets the title of the page
			Title = "Service Orders";

            //sets the page content to a new stack layout
			Content = new StackLayout {
				Children = {
					(_list = new ServiceOrderList {
						VerticalOptions = LayoutOptions.FillAndExpand,
					}),
					new StatusSelector {
						HorizontalOptions = LayoutOptions.FillAndExpand,
						VerticalOptions = LayoutOptions.End,
					}
				}
			};

            //adds the refresh button to the nav bar on the top
            var refreshToolbar = new ToolbarItem { Text = "Refresh", Icon = "RefreshIcon.png" };
            refreshToolbar.SetBinding(ToolbarItem.CommandProperty, Binding.Create<ServiceOrderListViewModel>(vm => vm.RefreshCommand));
            this.ToolbarItems.Add(refreshToolbar);


            _itemSelctedAdapter = new ListItemSelectedCommandAdapter(this, ItemSelectedCommandProperty, _list)
			{
				ResetItem = true,
			};

			MessagingCenter.Subscribe<EnosixTimesheet> (this, "Save", timesheet => {
				_isDirty = true;
				// TODO: Possibly scroll the list to this timesheet after the refresh.
			});
		}

	
		bool _isDirty;

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			if (_isDirty && null != _list.RefreshCommand) {
				_isDirty = false;
				_list.RefreshCommand.Execute (null);
			}
		}

        //the list of service orders
		public class ServiceOrderList : ListView
		{
			public ServiceOrderList(){
				
				IsPullToRefreshEnabled = true;
				IsGroupingEnabled = true;
				//GroupHeaderTemplate = new DataTemplate(typeof(ServiceOrderGroupCell));
				ItemTemplate = new DataTemplate(typeof(ServiceOrderCell));
				HasUnevenRows = true;

				SetBinding(ListView.ItemsSourceProperty, Binding.Create<ServiceOrderListViewModel>(vm => vm.GroupedServiceOrders));
				SetBinding(ListView.RefreshCommandProperty, Binding.Create<ServiceOrderListViewModel>(vm => vm.RefreshCommand));
				SetBinding(ListView.IsRefreshingProperty, Binding.Create<ServiceOrderListViewModel>(vm => vm.Refreshing));

			}

			public class ServiceOrderCell : ViewCell
			{
				public static readonly Style ServiceOrderNumberStyle = EnosixStyles.Labels.TitleStyle.Extend<Label>(style=>{
					style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderListViewModel.ServiceOrderListItemViewModel>(vm => vm.ServcieOrderSearchResult.ServiceOrderNumber, converter: NumCConverter.Instance));
				});

				public static readonly Style ServiceOrderDescriptionStyle = EnosixStyles.Labels.SubheadingStyle.Extend<Label>(style=>{
					style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderListViewModel.ServiceOrderListItemViewModel>(vm => vm.ServcieOrderSearchResult.Description));
					//style.SetFontAttributes(FontAttributes.Italic);
					style.SetValue(Grid.ColumnSpanProperty, 2);
					style.SetValue(Grid.RowProperty, 1);
				});

				public static readonly Style ServiceOrderAddressStyle = EnosixStyles.Labels.BodyStyle.Extend<Label>(style=>{
					style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderListViewModel.ServiceOrderListItemViewModel>(vm => vm.AddressDescription));
					style.SetValue(Grid.ColumnProperty, 0);
					style.SetValue(Grid.ColumnSpanProperty, 2);
					style.SetValue(Grid.RowProperty, 2);
				});

				public static readonly Style ServiceOrderCustomerNameStyle = EnosixStyles.Labels.BodyStyle.Extend<Label>(style=>{
					style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderListViewModel.ServiceOrderListItemViewModel>(vm => vm.ServcieOrderSearchResult.CustomerName));
					style.VerticalAlignCenter();
					style.SetValue(Grid.ColumnProperty, 1);
				});

				public ServiceOrderCell(){
					View = new Grid{
						Padding = new Thickness(10, 5),
						ColumnDefinitions = new ColumnDefinitionCollection{
							new ColumnDefinition{Width = new GridLength(0.3, GridUnitType.Auto)},
						},
						Children = {
							new Label{
								Style = ServiceOrderNumberStyle,
							},
							new Label{
								Style = ServiceOrderDescriptionStyle,
							},
							new Label{
								Style = ServiceOrderAddressStyle,
							},
							new Label{
								Style = ServiceOrderCustomerNameStyle,
							}
						}
					};
				}
			}


			public class ServiceOrderGroupCell : ViewCell
			{
                //public static readonly Style ServiceOrderGroupCellStyle = EnosixStyles.StyleFor<Grid>(style =>
                //{
                //    style.SubscribeTo(EnosixStyles.DarkPrimaryColor, Grid.BackgroundColorProperty);
                //});

                //public static readonly Style GroupHeadingLabelStyle = EnosixStyles.HeadlineLabelStyle.Extend<Label>(style =>
                //{

                //    style.SubscribeTo(EnosixStyles.AltTextColor, Label.TextColorProperty);
                //    style.VerticalAlignCenter();

                //});

                //public static readonly Style TimeSheetWeekStyle = GroupHeadingLabelStyle.Extend<Label>(style =>
                //{
                //    //style.SetValue(Label.TextProperty, Binding.Create<ServiceTime.ServiceOrderListViewModel.ServiceOrderGroupingViewModel>(g => g.Week, converter: WeekDisplayConverter.Instance));
                //});

                //public static readonly Style TimesheetTotalHoursStyle = GroupHeadingLabelStyle.Extend<Label>(style =>
                //{
                //    style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderListViewModel.ServiceOrderGroupingViewModel>(g => g.TotalHours, stringFormat: "{0:0.0} H"));
                //    style.SetValue(Grid.ColumnProperty, 1);
                //    style.SetFontAttributes(FontAttributes.Italic);
                //});

                //public ServiceOrderGroupCell()
                //{
                //    View = new Grid
                //    {
                //        Style = ServiceOrderGroupCellStyle,
                //        Padding = new Thickness(10, 5),
                //        ColumnDefinitions = new ColumnDefinitionCollection{
                //            new ColumnDefinition{ Width = new GridLength(0.8, GridUnitType.Star) },
                //            new ColumnDefinition{ Width = new GridLength(0.2, GridUnitType.Star) },
                //        },
                //        Children = {
                //    new Label{
                //                Style = TimesheetTotalHoursStyle,
                //            },
                //        },
                //    };
                //    this.Height = 35;

                //}
            }

		}

		public class StatusSelector : EnumSelector<ServiceOrderListViewModel.ServiceOrderStatus>
		{
			public static readonly Style SelectorStyle = EnosixStyles.StyleFor<StatusSelector>(s=>
				{
					s.SubscribeTo(EnosixStyles.Values.SecondaryTextColor, StatusSelector.TextColorProperty);
					s.SubscribeTo(EnosixStyles.Values.AltTextColor, StatusSelector.SelectedTextColorProperty);
				});

			public static readonly Style ButtonStyle = EnosixStyles.StyleFor<Button>(s=>
				{
					s.SubscribeTo(EnosixStyles.Values.AccentColor, Button.BackgroundColorProperty);

					s.MakePill(40);

					s.SetFontSize(15);
				});

			public StatusSelector(): base()
			{
				this.Style = SelectorStyle;
				SetBinding(StatusSelector.ValueProperty, Binding.Create<ServiceOrderListViewModel>(vm => vm.Status));
			}

            //creates the open service orders button
            protected override Button CreateButton(string text, ServiceOrderListViewModel.ServiceOrderStatus value)
            {
                var button = base.CreateButton(text, value);
                button.Style = ButtonStyle;
                return button;
            }
        }
	}
}

