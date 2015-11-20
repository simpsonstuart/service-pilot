using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using enosiX.App.Framework.Mobile;
using enosiX.App.Framework.Mobile.Behaviors;
using Xamarin.Forms;
using System.Reflection;
using System.Windows.Input;

namespace ServiceTime.Pages
{
    public class TimeEntryPage_NSO : ContentPage
    {
        public static readonly BindableProperty EntryCellHeightProperty =
                BindableProperty.Create<TimeEntryPage_NSO, GridLength>(v => v.EntryCellHeight, GridLength.Auto);

        public GridLength EntryCellHeight
        {
            get { return (GridLength)GetValue(EntryCellHeightProperty); }
            set { SetValue(EntryCellHeightProperty, value); }
        }

        public static readonly BindableProperty EntryCellWidthProperty =
            BindableProperty.Create<TimeEntryPage_NSO, GridLength>(v => v.EntryCellWidth, GridLength.Auto);

        public GridLength EntryCellWidth
        {
            get { return (GridLength)GetValue(EntryCellWidthProperty); }
            set { SetValue(EntryCellWidthProperty, value); }
        }


        public static class Styles
        {
            public static readonly Style EntryGridStyle = EnosixStyles.StyleFor<Grid>(style => {
                var spacing = Device.OnPlatform(0, 1, 1);
                style.SetValue(Grid.RowSpacingProperty, spacing);
                style.SetValue(Grid.ColumnSpacingProperty, spacing);
                style.SetValue(Grid.BackgroundColorProperty, Color.Gray.WithLuminosity(0.9));
            });


            public static readonly Style TimeEntryPageStyle = EnosixStyles.StyleFor<TimeEntryPage_NSO>(style => {
                style.SetValue(ContentPage.TitleProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.TimesheetHeading));

                style.SetValue(EntryCellHeightProperty, Device.OnPlatform(45, 50, GridLength.Auto));
                style.SetValue(EntryCellWidthProperty, Device.OnPlatform(45, 80, GridLength.Auto));

            });

            public static readonly Style TimeEntryStyle = EnosixStyles.StyleFor<Entry>(style => {
                style.SetValue(Entry.KeyboardProperty, Keyboard.Numeric);
                style.Behaviors.Add(new AnimateOnFocusBehavior());
                style.SetValue(Entry.MinimumWidthRequestProperty, 20);
                style.SetValue(Entry.TextProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.Hours));
                style.SetValue(Entry.IsVisibleProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.CanEdit));
            });

            public static readonly Style TimeEditButtonStyle = EnosixStyles.StyleFor<Button>(style => {
                style.SetValue(Button.TextProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.Hours));
                style.SetValue(Button.IsVisibleProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.HasMultipleItems));
            });

            public static readonly Style TimeSummaryStyle = EnosixStyles.StyleFor<Label>(style => {
                //style.SetFontAttributes(FontAttributes.Italic);
                style.VerticalAlignCenter(expand: true);
                style.HorizontalAlignLeft(expand: true);

            });

            public static readonly Style OperationTimeSummaryStyle = TimeSummaryStyle.Extend<Label>(style => {
                style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel.ServiceOrderOperationViewModel>(vm => vm.TotalHoursForOperation));
                style.HorizontalAlignRight();
            });

            public static readonly Style ServiceOrderTimeSummaryStyle = TimeSummaryStyle.Extend<Label>(style => {
                style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.TotalHoursForServiceOrder));
                style.HorizontalAlignRight();
            });

            public static readonly Style DayTimeSummaryStyle = TimeSummaryStyle.Extend<Label>(style => {
                style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel.DayOfWeekViewModel>(vm => vm.TotalHoursForServiceOrderDay));

            });

            public static readonly Style ServiceOrderTotalHeadingLabelStyle = TimeSummaryStyle.Extend<Label>(style => {
                style.VerticalAlignCenter(expand: true);
                style.HorizontalAlignLeft(expand: true);
            });

            public static readonly Style DateHeadingLabelStyle = EnosixStyles.StyleFor<Label>(style => {
                style.VerticalAlignCenter();
                style.HorizontalAlignCenter();
                style.SubscribeTo(EnosixStyles.Values.AltTextColor, Label.TextColorProperty);
                style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel.DayOfWeekViewModel>(vm => vm.Day, stringFormat: "{0:M/d}"));
            });

            public static readonly Style DayOfWeekHeadingLabelStyle = EnosixStyles.StyleFor<Label>(style => {
                style.VerticalAlignCenter();
                style.HorizontalAlignCenter();
                style.SubscribeTo(EnosixStyles.Values.DarkPrimaryColor, Label.TextColorProperty);
                style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel.DayOfWeekViewModel>(vm => vm.Day, stringFormat: "{0:ddd}"));
            });

            public static readonly Style OperationDescriptionLabelStyle = EnosixStyles.StyleFor<Label>(style => {
                style.VerticalAlignCenter();
                style.HorizontalAlignLeft();
                style.SetValue(Label.TextProperty, Binding.Create<ServiceOrderDetailViewModel.ServiceOrderOperationViewModel>(vm => vm.Operation.OperationShortText));
            });

            public static readonly Style CellContentViewStyle = EnosixStyles.StyleFor<ContentView>(style => {

                style.SetValue(ContentView.BackgroundColorProperty, Color.White);
                style.SetValue(ContentView.PaddingProperty, new Thickness(2));

            });

            //sets the style for the activity wheel
            public static readonly Style ActivityStyle = EnosixStyles.StyleFor<ActivityIndicator>(style =>
            {
                style.SubscribeTo(EnosixStyles.Values.AccentColor, ActivityIndicator.ColorProperty);
                style.SetGridPosition(0, 2);

            });



            //				public static readonly Style ResetButtonStyle = EnosixStyles.PrimaryButtonStyle.Extend<Button>(style=>{
            //					style.MakePill(40);
            //					style.SetValue(Button.CommandProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ResetCommand));
            //					style.SetValue(Grid.ColumnProperty, 2);
            //					style.SetValue(Button.BorderColorProperty, Color.Gray);
            //					style.SubscribeTo(EnosixStyles.LightPrimaryColor, Button.BackgroundColorProperty);
            //				});
        }

        private readonly Grid _timeEntryGrid;


        public TimeEntryPage_NSO()
        {
            Padding = 1;

            // Add the save button
            var saveToolbar = new ToolbarItem { Text = "Save" };
            saveToolbar.SetBinding(ToolbarItem.CommandProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.SaveCommand));
            this.ToolbarItems.Add(saveToolbar);

            //time entry grid set up
            Style = Styles.TimeEntryPageStyle;

            _timeEntryGrid = new Grid()
            {
                Style = Styles.EntryGridStyle,
                Children = {
                          Styles.ActivityStyle.CreateView<ActivityIndicator>(indicator=>{
                                indicator.SetBinding(ActivityIndicator.IsRunningProperty, App.IsBusyBindable);
								//indicator.IsRunning = true;
							}),

                        }
            };



            var scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = ScrollOrientation.Horizontal,
                Content = new ScrollView
                {
                    Orientation = ScrollOrientation.Vertical,
                    Content = _timeEntryGrid
                }
            };

            //add the scroll view with all the content
            var layout = new StackLayout { };
            layout.Children.Add(scrollView);

            Content = layout;

            this.SetBinding(OperationsProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.Operations));
            this.SetBinding(DaysProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.Days));

        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            BuildGrid(_timeEntryGrid);
        }

        void AddOperationRows(Grid grid)
        {
            if (null == Operations)
                return;

            foreach (var operation in Operations)
            {
                grid.RowDefinitions.Add(new RowDefinition
                {
                    Height = EntryCellHeight
                });
                grid.Children.Add(new ContentView
                {
                    Style = Styles.CellContentViewStyle,
                    Content = new Label
                    {
                        Style = Styles.OperationDescriptionLabelStyle,
                        BindingContext = operation,
                    },
                }, 0, 3 + operation.Index);
            }
        }

        void AddOperationTotals(Grid grid)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition()
            {
                Width = EntryCellWidth,
            });
            var totalColumn = grid.ColumnDefinitions.Count() - 1;

            if (null == Operations)
                return;

            foreach (var operation in Operations)
            {
                var entry = new Label
                {
                    Style = Styles.OperationTimeSummaryStyle,
                    BindingContext = operation,
                };
                grid.Children.Add(new ContentView
                {
                    Style = Styles.CellContentViewStyle,
                    Content = entry,
                }, totalColumn, 3 + operation.Index);
            }
        }

        void AddDayTotals(Grid grid)
        {
            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = EntryCellHeight
            });
            var totalRows = grid.RowDefinitions.Count() - 1;

            grid.Children.Add(new ContentView
            {
                Style = Styles.CellContentViewStyle,
                Content = new Label
                {
                    Style = Styles.ServiceOrderTotalHeadingLabelStyle,
                    Text = "Total",
                },
            }, 0, totalRows);

            if (null != Days)
            {

                foreach (var day in Days)
                {
                    grid.Children.Add(new ContentView
                    {
                        Style = Styles.CellContentViewStyle,
                        Content = new Label
                        {
                            Style = Styles.DayTimeSummaryStyle,
                            BindingContext = day,
                        },
                    }, 1 + day.Index, totalRows);
                }

                grid.Children.Add(new ContentView
                {
                    Style = Styles.CellContentViewStyle,
                    Content = new Label
                    {
                        Style = Styles.ServiceOrderTimeSummaryStyle,
                    },
                }, 2 + Days.Max(d => d.Index), totalRows);
            }

            var box = new BoxView
            {
                BackgroundColor = Color.Black,
                HeightRequest = 1.0,
            };

            box.VerticalAlignTop();
            box.SetGridPosition(totalRows, 0, columnspan: grid.ColumnDefinitions.Count);
            grid.Children.Add(box);
        }

        static BindableProperty OperationsProperty = BindableProperty.Create<TimeEntryPage_NSO, IEnumerable<ServiceOrderDetailViewModel.ServiceOrderOperationViewModel>>(

            p => p.Operations,
            null

        );
        protected IEnumerable<ServiceOrderDetailViewModel.ServiceOrderOperationViewModel> Operations
        {
            get { return base.GetValue(OperationsProperty) as IEnumerable<ServiceOrderDetailViewModel.ServiceOrderOperationViewModel>; }
            set { base.SetValue(OperationsProperty, value); }
        }

        static BindableProperty DaysProperty = BindableProperty.Create<TimeEntryPage_NSO, IEnumerable<ServiceOrderDetailViewModel.DayOfWeekViewModel>>(

            p => p.Days,
            null

        );
        protected IEnumerable<ServiceOrderDetailViewModel.DayOfWeekViewModel> Days
        {
            get { return base.GetValue(DaysProperty) as IEnumerable<ServiceOrderDetailViewModel.DayOfWeekViewModel>; }
            set { base.SetValue(DaysProperty, value); }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == OperationsProperty.PropertyName || propertyName == DaysProperty.PropertyName)
            {

                BuildGrid(_timeEntryGrid);
            }
        }

        void BuildGrid(Grid grid)
        {


            grid.BatchBegin();

            grid.Children.Clear();

            grid.RowDefinitions.Clear();
            grid.ColumnDefinitions.Clear();


            grid.RowDefinitions.Add(new RowDefinition { Height = 0 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 20 });
            grid.RowDefinitions.Add(new RowDefinition { Height = 25 });

            AddOperationRows(grid);

            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto, });


            var box = new BoxView { BackgroundColor = EnosixStyles.Values.DarkPrimaryColor.Value };
            grid.Children.Add(box, 0, 2);

            if (null != Days)
            {

                foreach (var day in Days)
                {
                    //grid.ColumnDefinitions.Add (new ColumnDefinition () { Width = new GridLength (w, GridUnitType.Star) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = EntryCellWidth, });

                    var previous_button = new Button
                    {
                        BackgroundColor = Color.FromRgb(222, 221, 219),
                        Image = "arrow-left",
                    };
                    previous_button.Clicked += OnPrevious_Week;
                    //add the previous week button
                    grid.Children.Add(previous_button, 1, 1);

                    grid.Children.Add(new Label
                    {
                        Style = Styles.DateHeadingLabelStyle,
                        BindingContext = day,
                    }, 1 + day.Index, 2);
                    grid.Children.Add(new Label
                    {
                        Style = Styles.DayOfWeekHeadingLabelStyle,
                        BindingContext = day,
                    }, 1 + day.Index, 1);

                    var forward_button = new Button
                    {
                        BackgroundColor = Color.FromRgb(222, 221, 219),
                        Image = "arrow-right"
                    };
                    forward_button.Clicked += OnForward_Week;
                    //add the forward week button
                    grid.Children.Add(forward_button, 8, 1);

                    if (null != Operations)
                    {

                        foreach (var operation in Operations)
                        {
                            var cell = operation.GetEntryCellForDay(day);

                            // Add the editor
                            grid.Children.Add(new ContentView
                            {
                                Style = Styles.CellContentViewStyle,
                                Content = new Entry
                                {
                                    Style = Styles.TimeEntryStyle,
                                    BindingContext = cell,
                                },
                            }, 1 + day.Index, 3 + operation.Index);

                            // Add the edit button
                            var btn = new Button
                            {
                                Style = Styles.TimeEditButtonStyle,
                                BindingContext = cell,
                            };

                            btn.Clicked += Btn_Clicked;

                            grid.Children.Add(btn, 1 + day.Index, 3 + operation.Index);

                            //								#if DEBUG
                            //								var edit = new Button {
                            //									//Style = Styles.TimeEditButtonStyle,
                            //									Text = "i",
                            //									FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
                            //									FontSize = 10,
                            //									WidthRequest = 20,
                            //									HeightRequest = 20,
                            //									VerticalOptions = LayoutOptions.Start,
                            //									HorizontalOptions = LayoutOptions.End,
                            //									BindingContext = cell,
                            //								};
                            //
                            //								edit.Clicked += Btn_Clicked;
                            //
                            //								grid.Children.Add (edit, 1 + day.Index, 3 + operation.Index);
                            //								#endif
                        }
                    }
                }
            }

            AddOperationTotals(grid);



            AddDayTotals(grid);



            Grid.SetColumnSpan(box, grid.ColumnDefinitions.Count);

            grid.BatchCommit();

        }

        void Btn_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (null != btn)
            {

                var page = new EntryListEditorPage
                {
                    BindingContext = btn.BindingContext,
                };

                this.Navigation.PushAsync(page);
            }
        }

        private void OnPrevious_Week(object sender, EventArgs e)
        {

            //fire event on service order detailview model
        }

        private void OnForward_Week(object sender, EventArgs e)
        {

            //fire event on service order detailview model
        }

        public class EntryListEditorPage : ContentPage
        {
            public static readonly BindableProperty ItemDeletedCommandProperty =
                BindableProperty.Create<EntryListEditorPage, ICommand>(v => v.ItemDeletedCommand, null);

            public ICommand ItemDeletedCommand
            {
                get { return (ICommand)GetValue(ItemDeletedCommandProperty); }
                set { SetValue(ItemDeletedCommandProperty, value); }
            }

            public static class Styles
            {
                public static readonly Style PageStyle = EnosixStyles.StyleFor<EntryListEditorPage>(style =>
                {
                    style.SetValue(EntryListEditorPage.TitleProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.Day.Day));
                    style.SetValue(EntryListEditorPage.ItemDeletedCommandProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.DeleteLineItemCommand));
                });

                public static readonly Style ListStyle = EnosixStyles.StyleFor<ListView>(style =>
                {
                    style.SetValue(ListView.ItemsSourceProperty, Binding.Create<ServiceOrderDetailViewModel.OperationEntryCellViewModel>(vm => vm.CellLineItems));
                });

                public static readonly Style DocumentNumberStyle = EnosixStyles.StyleFor<Label>(style =>
                {
                    style.SetValue(Label.TextProperty, Binding.Create<EnosixTimesheet_LINE_ITEM>(vm => vm.CounterInTimeRecording, converter: new Converters.ValueConverter<string, string>(s =>
                    {
                        if (string.IsNullOrWhiteSpace(s)) return "<NEW>";
                        return s;
                    })));
                });

                public static readonly Style HoursStyle = EnosixStyles.StyleFor<Label>(style =>
                {
                    style.SetValue(Label.TextProperty, Binding.Create<EnosixTimesheet_LINE_ITEM>(vm => vm.Hours));
                    style.SetValue(Grid.ColumnProperty, 1);
                });

                public static readonly Style StatusStyle = EnosixStyles.StyleFor<Label>(style =>
                {
                    style.SetValue(Label.TextProperty, Binding.Create<EnosixTimesheet_LINE_ITEM>(vm => vm.ProcessingStatus, converter: new Converters.ValueConverter<string, string>(s =>
                    {
                        if (string.IsNullOrWhiteSpace(s)) return s;

                        switch (s.ToUpperInvariant().Trim())
                        {
                            case "10": return "In Process";
                            case "20": return "Released For Approval";
                            case "30": return "Approved";
                            case "40": return "Approval Rejected";
                            case "50": return "Changed After Approval";
                            case "60": return "Canceled";
                        }
                        return s;
                    })));
                    style.SetValue(Grid.ColumnProperty, 2);
                });
            }

            public EntryListEditorPage()
            {
                this.Style = Styles.PageStyle;
                this.Content = new ListView
                {
                    Style = Styles.ListStyle,
                    ItemTemplate = new DataTemplate(typeof(EntryListCell)),
                };
            }

            public static ColumnDefinitionCollection ColumnBuilder(params double[] values)
            {
                var result = new ColumnDefinitionCollection();

                foreach (var value in values)
                {
                    result.Add(new ColumnDefinition { Width = new GridLength(value, GridUnitType.Auto) });
                }

                return result;
            }

            public class EntryListCell : ViewCell
            {
                public EntryListCell()
                {
                    this.View = new Grid
                    {
                        ColumnDefinitions = ColumnBuilder(0.3d, 0.2d, 0.5d),
                        Children = {
                                new Label{
                                    Style = Styles.DocumentNumberStyle,
                                },
                                new Label{
                                    Style = Styles.HoursStyle,
                                },
                                new Label{
                                    Style = Styles.StatusStyle,
                                }
                            }
                    };

                    var deleteMenu = new MenuItem
                    {
                        Text = "Delete",
                        IsDestructive = true,
                    };
                    deleteMenu.Clicked += DeleteMenu_Clicked;
                    this.ContextActions.Add(deleteMenu);
                }

                void DeleteMenu_Clicked(object sender, EventArgs e)
                {
                    var deleteCommand = this.ParentView.Parent.GetValue(ItemDeletedCommandProperty) as ICommand;
                    var parameter = this.BindingContext;

                    if (null != deleteCommand && deleteCommand.CanExecute(parameter))
                    {
                        deleteCommand.Execute(parameter);
                    }
                }


                protected override void OnTapped()
                {
                    base.OnTapped();

                    var page = this.ParentView.Parent as Page;

                    page.Navigation.PushAsync(new DynamicPage(typeof(EnosixTimesheet_LINE_ITEM))
                    {
                        BindingContext = this.BindingContext,
                    });
                }
            }
            public class DynamicPage : ContentPage
            {
                public DynamicPage(Type t)
                {
                    Content = new DynamicView(t);
                }
            }

            public class DynamicView : ContentView
            {
                public DynamicView(Type t)
                {
                    var grid = new Grid
                    {
                        ColumnDefinitions = new ColumnDefinitionCollection{
                                new ColumnDefinition{ Width = GridLength.Auto },
                                new ColumnDefinition{ Width = new GridLength(1, GridUnitType.Star) }
                            },
                        BackgroundColor = Color.Gray,
                        RowSpacing = 1,
                        ColumnSpacing = 1,
                        Padding = new Thickness(2),
                    };
                    var row = 0;
                    foreach (var prop in t.GetRuntimeProperties().OrderBy(p => p.Name))
                    {
                        var propertyNameLabel = new Label
                        {
                            Text = prop.Name,
                            TextColor = Color.Gray,
                            BackgroundColor = Color.White,
                            FontSize = 8,
                        };

                        Grid.SetRow(propertyNameLabel, row);

                        grid.Children.Add(propertyNameLabel);

                        var propertyValueLabel = new Label
                        {
                            Text = "<empty>",
                            BackgroundColor = Color.White,
                            TextColor = Color.Black,
                            FontSize = 10,
                        };
                        propertyValueLabel.SetBinding(Label.TextProperty, new Binding(prop.Name));
                        Grid.SetRow(propertyValueLabel, row);
                        Grid.SetColumn(propertyValueLabel, 1);

                        grid.Children.Add(propertyValueLabel);
                        row++;
                    }

                    Content = new ScrollView
                    {
                        Content = grid,
                    };
                }
            }
        }

   }
}
