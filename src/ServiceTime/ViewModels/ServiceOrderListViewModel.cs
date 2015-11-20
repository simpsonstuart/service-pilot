using System;
using enosiX.App.Framework.Mobile;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using ServiceTime.Pages;

namespace ServiceTime
{
	public class ServiceOrderListViewModel : BaseViewModel
	{
		private readonly IServiceTimeContext  _app;
		private static readonly DayOfWeek StartOfWeek = DayOfWeek.Monday;


		public ServiceOrderListViewModel (IServiceTimeContext app)
		{
			_app = app;
		}

        public ServiceOrderListViewModel(NavigationMenu navigationMenu)
        {
            this.navigationMenu = navigationMenu;
        }

        //      private IEnumerable<ServiceOrderListItemViewModel> _groupedServiceOrders;

        //public IEnumerable<ServiceOrderListItemViewModel> GroupedServiceOrders
        //{
        //	get { return _groupedServiceOrders; }
        //	set
        //	{
        //		if (base.Set(() => GroupedServiceOrders, ref _groupedServiceOrders, value))
        //		{

        //		}
        //	}
        //}
        private IEnumerable<ServiceOrderGroupingViewModel> _groupedServiceOrders;

        public IEnumerable<ServiceOrderGroupingViewModel> GroupedServiceOrders
        {
            get { return _groupedServiceOrders; }
            set
            {
                if (base.Set(() => GroupedServiceOrders, ref _groupedServiceOrders, value))
                {

                }
            }
        }

        private bool _refreshing;

		public bool Refreshing
		{
			get { return _refreshing; }
			set { base.Set(() => Refreshing, ref _refreshing, value); }
		}


		public enum ServiceOrderStatus
		{
			Open,
			Completed
		}

		private ServiceOrderStatus _status;

		public ServiceOrderStatus Status
		{
			get { return _status; }
			set { 
				if(base.Set(() => Status, ref _status, value))
				{
					OnRefreshCommand();
				} 
			}
		}

        //gets current date
		private DateTime _startDate = DateTime.Now.Date;

        private NavigationMenu navigationMenu;

        //sets the start date
        public DateTime StartDate
		{
			get { return _app.StartDate; }
		}

		public ICommand RefreshCommand
		{
			get { return new Command(OnRefreshCommand); }
		}

		private async void OnRefreshCommand()
		{
			try
			{
				Refreshing = true;
				//GenerateTestData();
				await _app.WithContext(RefreshServiceOrders);
			}
			finally
			{
				Refreshing = false;
			}
		}

    


        async Task RefreshServiceOrders(enosiX.IOnlineContext<IServiceTimeBusinessObjectContext> context)
        {
            var startOfthisWeek = StartDate.StartOfWeek(StartOfWeek).Date.AddDays(7);
            var weeks = Enumerable.Range(1, _app.NumberOFWeeks).Select(w => startOfthisWeek.AddDays(-7 * w));
            var start = weeks.Min();
            var end = weeks.Max().AddDays(7);

            //set the username for the search order query
            var serviceOrderSearchParams = new EnosixServiceOrder_SEARCHPARAMS()
            {
                Username = _app.UserName
            };

            //logic for completed and open buttons at bottom of page switches between the two types
            switch (Status)
            {
                case ServiceOrderStatus.Open:
                    serviceOrderSearchParams.X_Open = "X";
                    break;
                case ServiceOrderStatus.Completed:
                    serviceOrderSearchParams.X_Completed = "X";
                    break;
            }

            //defines the service orders search parameter
            var serviceOrders = await context.Online.EnosixServiceOrderSearch.Execute(serviceOrderSearchParams);


            //gets time sheets associated with service order
            var timeSheets =
                await
                context.Online.EnosixTimesheetSearch.Execute(
                    new EnosixTimesheet_SEARCHPARAMS()
                    {
                        DateFrom = weeks.Min(),
                        DateTo = weeks.Max().AddDays(7),
                        UserName = _app.UserName,
                    });

            var index = 0;

            //the week grouping list
            var query =
                from week in weeks
                let timesheet = timeSheets.SingleOrDefault(ts => ts.DateFrom >= week && ts.DateTo <= week.AddDays(7))
                select new ServiceOrderGroupingViewModel
                {
                    Items = Enumerable.ToArray(
                    from serviceOrder in serviceOrders
                    where !string.IsNullOrWhiteSpace(serviceOrder.ServiceOrderNumber)
                    select new ServiceOrderListItemViewModel()
                    {
                        ServcieOrderSearchResult = serviceOrder,
                        Week = week,
                        Timesheet = timesheet,
                        Index = index++,
                    }),
                    Week = week,
                    Timesheet = timesheet
                };


            var query1 =
               from week in weeks
               let timesheet = timeSheets.SingleOrDefault(ts => ts.DateFrom >= week && ts.DateTo <= week.AddDays(7))
               select new ServiceOrderListItemViewModel
               {
                   Items = Enumerable.ToArray(
                   from serviceOrder in serviceOrders
                   where !string.IsNullOrWhiteSpace(serviceOrder.ServiceOrderNumber)
                   select new ServiceOrderListItemViewModel()
                   {
                       ServcieOrderSearchResult = serviceOrder,
                       Week = week,
                       Timesheet = timesheet,
                       Index = index++,
                   }),
                   Week = week,
                   Timesheet = timesheet
               };




            //var test = Enumerable.AsEnumerable(
            //    from serviceOrder in serviceOrders
            //        let timesheet = timeSheets.SingleOrDefault(ts => ts.DateFrom >= Week && ts.DateTo <= Week.AddDays(7))
            //    where !string.IsNullOrWhiteSpace(serviceOrder.ServiceOrderNumber)
            //    select new ServiceOrderListItemViewModel()
            //    {
            //        ServcieOrderSearchResult = serviceOrder,
            //        Timesheet = timesheet,
            //        Index = index++,
            //    });


            //this adds the service orders to the list view on the page
            //GroupedServiceOrders = test;
            GroupedServiceOrders = query.ToArray();

        }

        //protected void GenerateTestData()
        //{
        //	var index = 0;

        //	var g = Enumerable.ToArray (
        //		from w in Enumerable.Range(0, 20)
        //		let week = DateTime.Now.StartOfWeek(StartOfWeek).AddDays(-7 * w)
        //		let timesheet = new EnosixTimesheet_SEARCHRESULT{
        //			DateFrom = week,
        //			DateTo = week.AddDays(-7),

        //		}
        //		select new ServiceOrderGroupingViewModel{
        //			Week = week,
        //			Timesheet = timesheet,
        //			Items = Enumerable.ToArray (
        //				from s in Enumerable.Range(0,10)
        //				select new ServiceOrderListItemViewModel{
        //					Index = index++,
        //					ServcieOrderSearchResult = new EnosixServiceOrder_SEARCHRESULT{
        //						ServiceOrderNumber = s.ToString("0000000000"),
        //						Description = string.Format("Description for {0}", s),
        //						BusinessArea = "BusinessArea",
        //					},
        //                          Week = week,
        //                          Timesheet = timesheet,
        //				}
        //			)
        //		}

        //	);
        //}


        public class ServiceOrderListItemViewModel : BaseViewModel
        {
            public ICollection<ServiceOrderListItemViewModel> Items { get; set; }
            public DateTime Week { get; set; }
			public int Index { get; set; }

			private EnosixServiceOrder_SEARCHRESULT _serviceOrderSearchresult;

            public EnosixServiceOrder_SEARCHRESULT ServcieOrderSearchResult
			{
				get { return _serviceOrderSearchresult; }
				set { base.Set(() => ServcieOrderSearchResult, ref _serviceOrderSearchresult, value); }
			}

            public string AddressDescription {
				get { 

					if (null == ServcieOrderSearchResult)
						return string.Empty;

					var area = this._serviceOrderSearchresult.Region ?? this._serviceOrderSearchresult.BusinessArea;
					return string.Format ("{0}{1} {2}", this._serviceOrderSearchresult.City, !string.IsNullOrWhiteSpace(area) ? "," : string.Empty, area);
				}
			}


			public EnosixTimesheet_SEARCHRESULT Timesheet { get; set; }

		}

		public class ServiceOrderGroupingViewModel : BaseViewModel, IReadOnlyCollection<ServiceOrderListItemViewModel>
		{
            public ICollection<ServiceOrderListItemViewModel> Items { get; set; }

			public DateTime Week { get; set; }

			public EnosixTimesheet_SEARCHRESULT Timesheet { get; set; }

            public int Count
			{
				get { return Items.Count; }
			}

			public IEnumerator<ServiceOrderListItemViewModel> GetEnumerator()
			{
				return Items.GetEnumerator();
			}

			System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return Items.GetEnumerator();
			}
		}
	}
}

