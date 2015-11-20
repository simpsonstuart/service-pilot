using System;
using Xamarin.Forms;
using enosiX.App.Framework.Mobile;
using ServiceTime.Converters;
using System.Linq;
using System.Reflection;
using System.Windows.Input;
using System.Linq.Expressions;
using System.Collections.Generic;
using ServiceTime.Pages;

namespace ServiceTime
{
	public static class MyGridExtensions
	{
        //adds a grid to the view
		public static Grid AddRow(this Grid grid, params View[] children)
		{
			return AddRow (grid, (_) => children);
		}

		public static Grid AddRow(this Grid grid, Func<Grid, IEnumerable<View>> children)
		{
			Guard.NotNull(()=>grid, grid);
			Guard.NotNull(()=>children, children);

			grid.RowDefinitions.Add (new RowDefinition (){ Height = GridLength.Auto });

			var row = grid.RowDefinitions.Count - 1;
			int c = 0;
			foreach (var view in children(grid)) 
			{
				Grid.SetRow (view, row);
				Grid.SetColumn (view, c);
				grid.Children.Add (view);
				c++;
			}

			return grid;
		}
	}


    //the tabbed navigation page displayed when service orders button is clicked on nav page
	public class ServiceOrderDetailPage : TabbedPage
	{
        //adds the style to the page with a binding
        public static class Styles
		{
			public static readonly Style ServiceOrderDetailPageStyle = EnosixStyles.StyleFor<ServiceOrderDetailPage>(style=>{
				style.SetValue(ServiceOrderDetailPage.TitleProperty, Binding.Create<ServiceOrderDetailViewModel>(vm => vm.ServiceOrder.ServiceOrderNumber, stringFormat: "SO# {0}", converter: NumCConverter.Instance));

			});
		}

        //adds the tabbed pages to the tabbed page
		public ServiceOrderDetailPage ()
		{

            Style = Styles.ServiceOrderDetailPageStyle;
			Children.Add ( new ServiceOrderInfoPage () );
            Children.Add(new TimeEntryPage());
            Children.Add(new ProblemCauseSolutionPage());
        

        }
	}
  }


