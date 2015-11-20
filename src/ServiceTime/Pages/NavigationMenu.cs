using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ServiceTime;

namespace ServiceTime.Pages
{
   public class NavigationMenu : ContentPage
    {
        public NavigationMenu()
        {
           

            //set page title and padding
            Padding = new Thickness(20);
            Title = "Fives Feature Selection";
            BackgroundColor = Colours.GreyBrown;

            //add the fives logo to the page
            Image Fives_Logo = new Image
            {
                HeightRequest = 101,
                Source = ImageSource.FromFile("fives.png"),
            };

            //begin button create
            //Create a service order button
            Button ServiceOrderButton = new Button
            {
                Text = "Service Order",
                BorderRadius = 5,
                TextColor = Colours.NavText,
                BackgroundColor = Colours.BackgroundGrey,
                BorderColor = Colours.SubTitle,
                BorderWidth = 3,
                Image = "InfoTabIcon.png",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            ServiceOrderButton.Clicked += ServiceOrder_Click;
            ServiceOrderButton.SetBinding(BackgroundColorProperty, new Binding("LoginButtonColour"));

            //Create a time button
            Button TimeButton = new Button
            {
                Text = "Time",
                BorderRadius = 5,
                TextColor = Colours.NavText,
                BackgroundColor = Colours.BackgroundGrey,
                BorderColor = Colours.SubTitle,
                BorderWidth = 3,
                Image = "TimeTabIcon.png",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            TimeButton.Clicked += Time_Click;
            TimeButton.SetBinding(BackgroundColorProperty, new Binding("LoginButtonColour"));

            //Create a expenses button
            Button ExpensesButton = new Button
            {
                Text = "Expenses",
                BorderRadius = 5,
                TextColor = Colours.NavText,
                BackgroundColor = Colours.BackgroundGrey,
                BorderColor = Colours.SubTitle,
                BorderWidth = 3,
                Image = "RefreshIcon.png",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            ExpensesButton.Clicked += Expenses_Click;
            ExpensesButton.SetBinding(BackgroundColorProperty, new Binding("LoginButtonColour"));
            //end button create

            //sets the page main stack panel and adds the items such as buttons too it
            var mainstack = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children =
                          {
                              Fives_Logo,
                              ServiceOrderButton,
                              TimeButton,
                              ExpensesButton
                          },
                Spacing = 45,
                Orientation = StackOrientation.Vertical,

            };
            //adds the main stack panel too a scroll view so it fits all iphones and orientations
            Content = new ScrollView
            {
                Content = mainstack,
                Orientation = ScrollOrientation.Vertical,
            };
        }

        //passes the service order list
        public Page sOrder { get; set; }

        //begin button click events

        //service order event
        async void ServiceOrder_Click(object sender, EventArgs eventArgs)
        {
            //navigates to the new page
            await Navigation.PushAsync(sOrder);
        }

        //time button event
        async void Time_Click(object sender, EventArgs eventArgs)
        {
            //navigates to the new page
            await Navigation.PushAsync(new TimeEntryPage_NSO());

        }
        //expenses event
        async void Expenses_Click(object sender, EventArgs eventArgs)
        {
            //navigates to the new page
            await Navigation.PushAsync(new Expenses());

        }
        //end button click events
    }
}
