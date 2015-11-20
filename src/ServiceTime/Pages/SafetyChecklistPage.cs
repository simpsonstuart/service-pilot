using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace ServiceTime.Pages
{

   


    public class SafetyChecklistPage : ContentPage
    {

        public static ObservableCollection<string> SafetyItems { get; set; }
        public static String Safety_Enosix_Name { get; set; }

        // Dictionary to get Color from item name in this case will be updated with dynamic function
        Dictionary<string, String> nameToSafetyItem = new Dictionary<string, String>
        {
            { "Hard Hat & Face Sheild", "EnsosixName" },
            { "Class II FR clothing", "EnsosixName" },
            { "Lock Out / Tag Out", "EnsosixName" }, 
            { "Near Loss Incident", "EnsosixName" },
            { "Safety Barrier Tape", "EnsosixName" },
        };


        public SafetyChecklistPage()
        {
            //create new added items collection
            SafetyItems = new ObservableCollection<string>();
            ListView AddedItems_listView = new ListView();
            AddedItems_listView.ItemSelected += (sender, e) => {
                ((ListView)sender).SelectedItem = null;
            };
            AddedItems_listView.ItemsSource = SafetyItems;
            var temp = new DataTemplate(typeof(textViewCell));
            AddedItems_listView.ItemTemplate = temp;
            
            //adds the "Add New button to the top bar near the text
            ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Preview",
                //Icon = "ExitIcon.png",
                Command = new Command(preview_click)
            });

            //create a text label for the page
            Label header = new Label
            {
                Text = "Safety Items",
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            //create a new picker
            Picker spicker = new Picker
            {
                Title = "Safety Item Selection",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                SelectedIndex = 0
            };

            //add the safety items to the picker
            foreach (string SafetyItemName in nameToSafetyItem.Keys)
            {
                spicker.Items.Add(SafetyItemName);
            }

            //sets the selected item to the enosix name 
            spicker.SelectedIndexChanged += (sender, args) =>
            {
                    string ItemName = spicker.Items[spicker.SelectedIndex];
                    Safety_Enosix_Name = ItemName;
            };


            //create a button that adds    
            Button addnewSafetyItem = new Button
            {
                Text = "Add Safety Item",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            addnewSafetyItem.Clicked += OnaddnewSafetyItemClicked;

            //create a save button
            Button SaveChecklistBtn = new Button
            {
                Text = "Save Items",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            SaveChecklistBtn.Clicked += saveChecklistItems_click;


            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 10);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    spicker,
                    addnewSafetyItem,
                    AddedItems_listView
                }
            };

        }



        //add new safety item click event
        void OnaddnewSafetyItemClicked(object sender, EventArgs e)
        {
            //display an alert if nothing is selected
            if (Safety_Enosix_Name == null)
            {
                //display message box
                DisplayAlert("Failed to Add", "You must make a selection!", "OK");
            }

            //if the item isn't in the list already and the selected item isn't null add the item to list
                if (!SafetyItems.Contains(Safety_Enosix_Name)  && Safety_Enosix_Name != null )
            {

                //if we select add new item then we que up a text box to type it in instead
                if (Safety_Enosix_Name == "Add New Item")
                {
                    //add new textbox for manual entry
                }
                else
                {
                    //add selected item from picker to collection
                    SafetyItems.Add(Safety_Enosix_Name);
                }
            }
            else
            {
                //display message box
                DisplayAlert("Failed to Add", "The safety item has already been added!", "OK");
            }

        }

        //event for report button
        void preview_click()
        {

        }

        //event for report button
        void saveChecklistItems_click(object sender, EventArgs e)
        {

        }

        public class textViewCell : ViewCell
        {
            public textViewCell()
            {
                StackLayout layout = new StackLayout();
                layout.Padding = new Thickness(15, 0);
                Label SafetyLabel = new Label();
                SafetyLabel.SetBinding(Label.TextProperty, ".");
                SafetyLabel.TextColor = Color.Black;
                layout.Children.Add(SafetyLabel);


                var deleteAction = new MenuItem { Text = "Delete", IsDestructive = true }; // red background shown on iphone  
                deleteAction.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
                deleteAction.Clicked += OnDelete;

                ContextActions.Add(deleteAction);
                View = layout;
            }

            void OnDelete(object sender, EventArgs e)
            {
                var item = (MenuItem)sender;
                SafetyItems.Remove(item.CommandParameter.ToString());
            }
        }

    }
}
