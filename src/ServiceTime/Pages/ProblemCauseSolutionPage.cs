using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using enosiX.App.Framework.Mobile;
using Xamarin.Forms;

namespace ServiceTime.Pages
{
    public class ProblemCauseSolutionPage : BaseDetailPage
    {
        //sets icon and name in the tabbed layout and sets up styles from ensosix
        public static class Styles
        {
            public static readonly Style PageStyle = EnosixStyles.StyleFor<ContentPage>(style =>
            {
                style.SetValue(Page.TitleProperty, "Problem Cause Solution");
                style.SetValue(Page.IconProperty, "tab-icon/PCSTabIcon.png");

            });

            public static readonly Style LayoutStyle = EnosixStyles.StyleFor<Grid>(style =>
            {
                style.SetValue(Grid.PaddingProperty, EnosixStyles.DefaultPadding);
                style.SetValue(Grid.ColumnDefinitionsProperty, new ColumnDefinitionCollection{
                        new ColumnDefinition{ Width = GridLength.Auto},
                        new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) },
                    });

            });

            public static readonly Style SeperatorStyle = EnosixStyles.StyleFor<BoxView>(style =>
            {
                style.SubscribeTo(EnosixStyles.Values.PrimaryColor, BoxView.BackgroundColorProperty);
                style.SetValue(BoxView.HeightRequestProperty, 1);

            });

            public static readonly Style KeyLabelStyle = EnosixStyles.Labels.CaptionStyle.Extend<Label>(style =>
            {

            });
            public static readonly Style ValueLabelStyle = EnosixStyles.Labels.BodyStyle.Extend<Label>(style =>
            {

            });

            public static readonly Style LinkActionStyle = EnosixStyles.Buttons.ActionStyle.Extend<Button>(style =>
            {
                style.HorizontalAlignLeft();
                style.SetFontSize(12);
            });



        }


        public ProblemCauseSolutionPage()
        {
            //sets the page style too the one created above
            Style = Styles.PageStyle;

            //set page title
            BackgroundColor = Color.White;
            Title = "Problem Cause Solutions";

            //adds the "Add New button to the top bar near the text
            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Add New",
                //Icon = "ExitIcon.png",
                Command = new Command(AddNew_PCS_Detail)
            });

            //todo add collection that sets this instead of static text
           AddRow("Date ", Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ServiceOrder.ReferenceDate));
           AddRow("Defect Location ", Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ServiceOrder.FunctionalLocation));
           AddRow("Problem ", Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ServiceOrder.MaintenanceItem));

        }

        //event for add new button
        void AddNew_PCS_Detail()
        {
            //navigates to the new page
            Navigation.PushAsync(new ProblemCauseSolutionPage_Detail());
        }

    }

   }
