using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using enosiX.App.Framework.Mobile;
using Xamarin.Forms;

namespace ServiceTime.Pages
{
    public class ProblemCauseSolutionPage_Detail : BaseDetailPage
    {
        public static class Styles
        {
            public static readonly Style PageStyle = EnosixStyles.StyleFor<ContentPage>(style => {
                style.SetValue(Page.TitleProperty, "Problem Cause Solution");
                style.SetValue(Page.IconProperty, "tab-icon/PCSTabIcon.png");

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


        //passes service order date from other page
        public string SOActlDate { get; set; }

        public ProblemCauseSolutionPage_Detail()
        {
            //force the page to landscape
            //DependencyService.Get<IOrientationHandler>().ForcePortrait();

            //sets the page style too the one created above
            Style = Styles.PageStyle;

            SOActlDate = "11/13/2015";

            //set page title and padding
            Padding = new Thickness(14);
            BackgroundColor = Color.White;

            //adds the "Add New button to the top bar near the text
            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Save",
                //Icon = "ExitIcon.png",
                Command = new Command(PCS_Detail_Save)
            });

            //create the stack panel
            var pcsstack = new StackLayout { Padding = new Thickness(5, 10) };

            //adds the main stack panel too a scroll view so it fits all iphones and orientations
            Content = new ScrollView
            {
                Content = pcsstack,
                Orientation = ScrollOrientation.Vertical,
            };

            this.Content = pcsstack;

            //begin add editors to page
            var problemeditor = new Editor();
            var causeeditor = new Editor();
            var solutioneditor = new Editor();
            //end add editors to page

            //begin editor events
            problemeditor.TextChanged += ProblemTextChanged;
            causeeditor.TextChanged += CauseTextChanged;
            solutioneditor.TextChanged += SolutionTextChanged;
            //end editor events

            //begin set colors
            problemeditor.BackgroundColor = Color.FromHex("#eaeaea");
            causeeditor.BackgroundColor = Color.FromHex("#eaeaea");
            solutioneditor.BackgroundColor = Color.FromHex("#eaeaea");
            //end set colors

            //begin set editor heights
            problemeditor.HeightRequest = 100;
            causeeditor.HeightRequest = 100;
            solutioneditor.HeightRequest = 100;
            //end set editor heights

            // add labels to editors
            //set the service order date label to the date for this service order
            var SODateLbl = new Label { Text = "Date:    " + SOActlDate, TextColor = Color.FromHex("#8f8f8f"), FontSize = 20, XAlign = TextAlignment.Start };
            var problemlabel = new Label { Text = "Problem:", TextColor = Color.FromHex("#8f8f8f"), FontSize = 20, XAlign = TextAlignment.Start };
            var causelabel = new Label { Text = "Cause:", TextColor = Color.FromHex("#8f8f8f"), FontSize = 20, XAlign = TextAlignment.Start };
            var solutionlabel = new Label { Text = "Solution:", TextColor = Color.FromHex("#8f8f8f"), FontSize = 20, XAlign = TextAlignment.Start };

            //begin add editors and labels to stack collection for display
            pcsstack.Children.Add(SODateLbl);
            pcsstack.Children.Add(problemlabel);
            pcsstack.Children.Add(problemeditor);
            pcsstack.Children.Add(causelabel);
            pcsstack.Children.Add(causeeditor);
            pcsstack.Children.Add(solutionlabel);
            pcsstack.Children.Add(solutioneditor);

            //clear the text when the problem editor has focus
            if (problemeditor.IsFocused)
            {
                problemeditor.Text = "";
                problemeditor.BackgroundColor = Color.Red;
            }
            else
            {
                problemeditor.Text = "Enter problem here";
            }

            //clear the text when the cause editor has focus
            if (causeeditor.IsFocused)
            {
                causeeditor.Text = "";
                causeeditor.BackgroundColor = Color.Red;
            }
            else
            {
                causeeditor.Text = "Enter cause here";
            }

            //clear the text when the solution editor has focus
            if (solutioneditor.IsFocused)
            {
                solutioneditor.Text = "";
                solutioneditor.BackgroundColor = Color.Red;
            }
            else
            {
                solutioneditor.Text = "Enter solution here";
            }

        }
        //event for problem entry editor
        void ProblemTextChanged(object sender, TextChangedEventArgs e)
        {

            //do text get logic here

        }

        //event for problem entry editor
        void CauseTextChanged(object sender, TextChangedEventArgs e)
        {

            //do text get logic here
        }

        //event for problem entry editor
        void SolutionTextChanged(object sender, TextChangedEventArgs e)
        {

            //do text get logic here
        }

        //event for save button
        void PCS_Detail_Save()
        {
            //do save logic here
            //navigate back to previous page
            Navigation.PopAsync();
        }

    }

}
