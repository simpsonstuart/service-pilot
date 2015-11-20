using System;
using System.Collections.Generic;
using enosiX.App.Framework.Mobile;
using Xamarin.Forms;
using ServiceTime.Converters;
using System.Linq.Expressions;

namespace ServiceTime.Pages
{
    public class ServiceOrderInfoPage : BaseDetailPage
    {
        public static readonly IValueConverter AddressConverter = new ValueConverter<EnosixServiceOrder_ADDRESS, string>(address =>
           null != address ? string.Join(" ", address.Street, address.City, address.Region, address.CityPostalCode) : null
        );

        public static class Styles
        {
            public static readonly Style PageStyle = EnosixStyles.StyleFor<ContentPage>(style => {
                style.SetValue(Page.TitleProperty, "Service Order");
                style.SetValue(Page.IconProperty, "tab-icon/serviceorder.png");

            });

            public static readonly Style LayoutStyle = EnosixStyles.StyleFor<Grid>(style => {
                style.SetValue(Grid.PaddingProperty, EnosixStyles.DefaultPadding);
                style.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection{
                        new ColumnDefinition{ Width = GridLength.Auto},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) },
                    });

            });

            public static readonly Style SeperatorStyle = EnosixStyles.StyleFor<BoxView>(style => {
                style.SubscribeTo(EnosixStyles.Values.PrimaryColor, BoxView.BackgroundColorProperty);
                style.SetValue(BoxView.HeightRequestProperty, 1);

            });

            public static readonly Style KeyLabelStyle = EnosixStyles.Labels.CaptionStyle.Extend<Label>(style => {

            });
            public static readonly Style ValueLabelStyle = EnosixStyles.Labels.BodyStyle.Extend<Label>(style => {

            });

            public static readonly Style LinkActionStyle = EnosixStyles.Buttons.ActionStyle.Extend<Button>(style => {
                style.HorizontalAlignLeft();
                style.SetFontSize(12);
            });

        }

        public ServiceOrderInfoPage()
        {

            //adds the "Add New button to the top bar near the text
            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Report",
                //Icon = "ExitIcon.png",
                Command = new Command(so_report)
            });

        

            Style = Styles.PageStyle;

            //sets the content too service order
            Content = new ScrollView
            {
                Content = Styles.LayoutStyle.CreateView<Grid>(grid =>
                {
                    grid.AddRow(LabelText("Service Desc."), LabelFor(vm => vm.ServiceOrder.Description));
                    grid.AddRow(AddSeperator);
                    grid.AddRow(LabelText("Contact Name."), LabelFor(vm => vm.ContactPerson.Name));
                    grid.AddRow(LabelText("Contact Number."), Styles.LinkActionStyle.CreateView<Button>(button =>
                    {
                        button.SetBinding(Button.TextProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ContactPerson.PhoneNumber));
                        button.SetBinding(Button.CommandParameterProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ContactPerson));
                        button.Command = new Command<EnosixServiceOrder_PARTNERS>(OnCallPartner);
                    }));
                    grid.AddRow(AddSeperator);

                    grid.AddRow(LabelText("Customer"), LabelFor(vm => vm.Address.Name1));
                    grid.AddRow(LabelText("Address"), Styles.LinkActionStyle.CreateView<Button>(button =>
                    {
                        button.SetBinding(Button.TextProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.Address, converter: AddressConverter));
                        button.SetBinding(Button.CommandParameterProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.Address));
                        button.Command = new Command<EnosixServiceOrder_ADDRESS>(OnShowMap);
                        //Grid.SetColumnSpan(button, 2);
                    }));
                    grid.AddRow(AddSeperator);

                    grid.AddRow(LabelText("Notification #"), LabelFor(vm => vm.ServiceOrder.NotificationNumber));
                    grid.AddRow(LabelText("Equipment Desc."), LabelFor(vm => vm.ServiceOrder.EquipmentDescription));
                }),
            };
        }

        //event for report button
        void so_report()
        {
            //navigates to the new checklist page
            Navigation.PushAsync(new SafetyChecklistPage());
        }

        //opens a map popup on address touch
        async void OnShowMap(EnosixServiceOrder_ADDRESS address)
        {
            if (null != address && !string.IsNullOrWhiteSpace(address.Street))
            {

                var mappAddress = string.Join(" ", address.Street, address.City, address.Region, address.CityPostalCode);

                if (await DisplayAlert("Display Directions To", mappAddress, "Yes", "No"))
                {
                    Device.OpenUri(new Uri("http://maps.apple.com/?daddr=" + mappAddress));
                }


            }
        }

        //opens the call dialog
        async void OnCallPartner(EnosixServiceOrder_PARTNERS partner)
        {
            if (null != partner && !string.IsNullOrWhiteSpace(partner.PhoneNumber))
            {

                var message = string.Format("{0} ({1}) ", partner.Name, partner.PhoneNumber);

                if (await DisplayAlert("Call", message, "Yes", "No"))
                {
                    Device.OpenUri(new Uri("tel:" + partner.PhoneNumber));
                }


            }
        }

        IEnumerable<View> AddSeperator(Grid grid)
        {
            var columns = grid.ColumnDefinitions.Count;

            yield return Styles.SeperatorStyle.CreateView<BoxView>(boxView => {
                Grid.SetColumnSpan(boxView, columns);
            });
        }

        Label LabelText(string text)
        {
            return Styles.KeyLabelStyle.CreateView<Label>(label => {
                label.Text = text;
            });
        }

        Label LabelFor(Expression<Func<ServiceOrderDetailViewModel, object>> value, IValueConverter converter = null)
        {
            return Styles.ValueLabelStyle.CreateView<Label>(label => {
                label.SetBinding(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel>(value, converter: converter));
            });
        }

    }
}
