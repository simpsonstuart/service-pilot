using System;
using enosiX.App.Framework.Mobile;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Diagnostics;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.Specialized;
using System.ComponentModel;

namespace ServiceTime
{
	public class ServiceOrderDetailViewModel : BaseViewModel
	{
		private readonly IServiceTimeContext  _app;

		public ServiceOrderDetailViewModel (IServiceTimeContext app)
		{
			_app = app;
		}

		private EnosixServiceOrder _serviceOrder;

		public EnosixServiceOrder ServiceOrder
		{
			get { return _serviceOrder; }
			set { if (base.Set (() => ServiceOrder, ref _serviceOrder, value)) {
					UpdateOperations ();
					RaisePropertyChanged(()=>Operations);
					RaisePropertyChanged(()=>ContactPerson);
					RaisePropertyChanged(()=>Address);
				}
			}
		}

		private IEnumerable<ServiceOrderOperationViewModel> _operations = Enumerable.Empty<ServiceOrderOperationViewModel>();

		public IEnumerable<ServiceOrderOperationViewModel> Operations
		{
			get { 
				return _operations;
			}
		}

		protected virtual void UpdateOperations()
		{
			EnosixServiceOrder_OPERATIONS[] operations = new EnosixServiceOrder_OPERATIONS[]{ };

			if (null != ServiceOrder && null != ServiceOrder.OPERATIONS_Collection) {
				operations = ServiceOrder.OPERATIONS_Collection.ToArray ();
			}


			// If any plants are defined on the timesheet then filter the operations list
			if (null != TimeSheet && 
				null != TimeSheet.PLANT_Collection && 
				TimeSheet.PLANT_Collection
				.Any(p=>p.StartDate < p.EndDate && !string.IsNullOrWhiteSpace(p.Plant))) {

				var dateFrom = TimeSheet.DateFrom;
				var dateTo = TimeSheet.DateTo;

				// Only select plants that are valid for the timesheet range
				var plants = TimeSheet.PLANT_Collection
					.Where(p=>p.StartDate <= dateFrom && p.EndDate >= dateTo)
					.Select (p => p.Plant).ToArray ();

				// Filter the operations by plant
				operations = operations
					.Where (o => plants.Contains (o.Plant))
					.ToArray ();
			}

			lock (_operations) {
				int i = 0;


				_operations = Enumerable.ToArray(
					from operation in operations
					select new ServiceOrderOperationViewModel(this, i++, operation)
				);
			}

			RaisePropertyChanged(()=>Operations);

		}


		private EnosixTimesheet _timeSheet;

		public EnosixTimesheet TimeSheet
		{
			get { return _timeSheet; }
			set { _timeSheet = value; }
		}

		void TimesheetUpdated ()
		{
			UpdateDays ();
			UpdateOperations ();
			AttachToLineItems ();
		}

		public string TimesheetHeading {
			get { return null != this.TimeSheet ? string.Format ("Week of {0:d} to {1:d}", this.TimeSheet.DateFrom, TimeSheet.DateTo) : string.Empty; }
		}


		private DateTime _week;

		public DateTime Week
		{
			get { return _week; }
			set { 
				if( base.Set(() => Week, ref _week, value)) {
				}; 
			}
		}

		private IEnumerable<DayOfWeekViewModel> _days = Enumerable.Empty<DayOfWeekViewModel>();

		public IEnumerable<DayOfWeekViewModel> Days
		{
			get { 
				return _days;
			}
		}

		protected virtual void UpdateDays()
		{
			var totalDays = Math.Max(7, (int)(this.TimeSheet.DateTo - this.TimeSheet.DateFrom).TotalDays);

			lock (_days) {
				_days = Enumerable.ToArray (
					from i in Enumerable.Range (0, totalDays)
					select new DayOfWeekViewModel (this, i)
				);
			}


			RaisePropertyChanged (() => Days);
		}

		private bool _editMode;

		public bool EditMode
		{
			get { return _editMode; }
			set { base.Set(() => EditMode, ref _editMode, value); }
		}

		private bool _locked;

//		private ServiceOrderListViewModel.ServiceOrderListItemViewModel _listItem;

		public async Task<bool> LoadFromListItem(ServiceOrderListViewModel.ServiceOrderListItemViewModel vm)
		{
           



            var result = false;

            await _app.WithContext(async context => {

				if (null != vm.ServcieOrderSearchResult)
				{
					ServiceOrder = await context.Online.EnosixServiceOrderRepository.Get(vm.ServcieOrderSearchResult);
				}

				if (null != vm.Timesheet)
				{
					// Try and lock the record
					if (await context.Online.EnosixTimesheetRepository.Lock(vm.Timesheet, (locked) => { TimeSheet = locked; }))
					{
						EditMode = true;
						_locked = true;
					}
					else
					{
						EditMode = false;
						TimeSheet = await context.Online.EnosixTimesheetRepository.Get(vm.Timesheet);
					}
				}

				if (null == TimeSheet)
				{
					TimeSheet = await context.Online.EnosixTimesheetRepository.Initialize(
						new EnosixTimesheet()
						{
							Username = _app.UserName,
							DateFrom = Week,
							DateTo = vm.Week.AddDays(7),
						}
					);

					EditMode = true;
				}

				result = true;
			});

            //sets the timesheet to the current week
            this.Week = vm.Week;
         



            TimesheetUpdated();

			return result;
		}

		private ICommand _saveCommand;

		public ICommand SaveCommand
		{
			get { return _saveCommand ?? (_saveCommand = new Command(OnSave)); }
		}



        //event that happens when the timesheet gets saved
        public async void OnSave()
		{
			bool success = false;
			await _app.WithContext(async context =>
				{
					RemoveNonServiceOrderEntries ();

					this.TimeSheet = await context.Online.EnosixTimesheetRepository.Save(this.TimeSheet);

					TimesheetUpdated ();

				}, alertErrors: true, successMessage: "Timesheet Saved");
			
			if (success) {
				MessagingCenter.Send<EnosixTimesheet> (TimeSheet, "Save");
			}
		}

        //event for on previous week click
            public void OnPrevious_Week_Click ()
            {
                //get current date and time
                var date = DateTime.Now;

                //gets the start of the previous week so we can go back a week when previous button pressed
                DateTime mondayOfLastWeek = date.AddDays(-(int)date.DayOfWeek - 6);
                Week = mondayOfLastWeek;
                //sets the week to the calculated one
                this.Week = Week;
            }



            string[] invalidStatusList = new []{ "60", "50", "40" };

		void RemoveNonServiceOrderEntries ()
		{
			var serviceOrderItems = ServiceOrderItems.ToArray ();

			foreach (var item in TimeSheet.LINE_ITEM_Collection.ToArray()) {
				if (!serviceOrderItems.Contains (item) || invalidStatusList.Contains( item.ProcessingStatus )) {
					TimeSheet.LINE_ITEM_Collection.Remove (item);
				}
			}
		}

//		private ICommand _resetCommand;
//		public ICommand ResetCommand
//		{
//			get { return _resetCommand ?? (_resetCommand = new Command(OnReset)); }
//		}
//
//		public async void OnReset()
//		{
//			if (null != _listItem) {
//				await LoadFromListItem (_listItem);
//			}
//
//
//		}

		public bool MatchTimesheetLineItemToServiceOrder(EnosixTimesheet_LINE_ITEM item)
		{
			Guard.NotNull (() => item, item);
			return string.Equals (item.ReceiverOrder, ServiceOrder.ServiceOrderNumber, StringComparison.OrdinalIgnoreCase);
		}

		public bool FilterNonEditableItems(EnosixTimesheet_LINE_ITEM item)
		{
			Guard.NotNull (() => item, item);

			return !invalidStatusList.Contains (item.ProcessingStatus);
		}

		public IEnumerable<EnosixTimesheet_LINE_ITEM> ServiceOrderItems
		{
			get 
			{
				if (null == TimeSheet || null == TimeSheet.LINE_ITEM_Collection) {
					return Enumerable.Empty<EnosixTimesheet_LINE_ITEM> ();
				}
				return TimeSheet.LINE_ITEM_Collection
					.Where (MatchTimesheetLineItemToServiceOrder)
					.Where(FilterNonEditableItems);
			}
		}

		public decimal TotalHoursForServiceOrder
		{
			get {
				return ServiceOrderItems.Sum (item => item.Hours);
			}
		}

		public void Update()
		{
			RaisePropertyChanged (() => TotalHoursForServiceOrder);
		}

		public void HoursEntered(OperationEntryCellViewModel cell)
		{
			Update ();
		}

		public void AddTimesheetLineItem(EnosixTimesheet_LINE_ITEM item)
		{
			Guard.NotNull (() => item, item);

			TimeSheet.LINE_ITEM_Collection.Add (item);
		}

		protected void AttachToLineItems ()
		{
			if (null == TimeSheet || null == TimeSheet.LINE_ITEM_Collection) {
				return;
			}

			var collectionChanged = TimeSheet.LINE_ITEM_Collection as INotifyCollectionChanged;

			if (null != collectionChanged) {
				collectionChanged.CollectionChanged += TimesheetLineItems_CollectionCanged;
			}

			AttachToItems (TimeSheet.LINE_ITEM_Collection);
		}

		void TimesheetLineItems_CollectionCanged (object sender, NotifyCollectionChangedEventArgs e)
		{
			AttachToItems (e.NewItems);
		}

		protected void AttachToItems(IEnumerable items)
		{
			if (null == items)
				return;

			foreach (var item in items.OfType<INotifyPropertyChanged>()) {
				item.PropertyChanged += Item_PropertyChanged;
			}
		}

		void Item_PropertyChanged (object sender, PropertyChangedEventArgs e)
		{
			foreach (var operation in Operations) {
				operation.Update ();
			}
		}

		public static readonly string ContactPersonPartnerFunction = "AP";
		public static readonly string PresonResponsibleFunction = "VW";

		public EnosixServiceOrder_PARTNERS ContactPerson
		{
			get
			{
				if (null == this.ServiceOrder || null == this.ServiceOrder.PARTNERS_Collection) {
					return null;
				}

				var contact = 
					this.ServiceOrder.PARTNERS_Collection.FirstOrDefault(
						p => ContactPersonPartnerFunction.Equals(p.PartnerFunction, StringComparison.OrdinalIgnoreCase)
					)
					??
					this.ServiceOrder.PARTNERS_Collection.FirstOrDefault(
						p => PresonResponsibleFunction.Equals(p.PartnerFunction, StringComparison.OrdinalIgnoreCase)
					)
					??
					this.ServiceOrder.PARTNERS_Collection.FirstOrDefault()
					;
				return contact;
			}
		}

		public EnosixServiceOrder_ADDRESS Address
		{
			get { 

				if (null == this.ServiceOrder || null == this.ServiceOrder.ADDRESS_Collection) {
					return null;
				}

				var address =  this.ServiceOrder.ADDRESS_Collection.FirstOrDefault(); 
				return address;
			}
		}


		public class ServiceOrderOperationViewModel : BaseViewModel
		{
			private readonly int _index;
			private readonly EnosixServiceOrder_OPERATIONS _operation;
			private readonly ServiceOrderDetailViewModel _parent;
			private readonly IDictionary<int, OperationEntryCellViewModel> _entryCells = new Dictionary<int, OperationEntryCellViewModel> (7);

			public ServiceOrderOperationViewModel(ServiceOrderDetailViewModel parent, int index, EnosixServiceOrder_OPERATIONS operation)
			{
				Guard.NotNull(()=> parent, parent);
				Guard.NotNull(()=> operation, operation);

				this._parent = parent;
				this._operation = operation;
				this._index = index;
			}

			public int Index
			{
				get { return _index; }
			}

			public EnosixServiceOrder_OPERATIONS Operation
			{
				get { return _operation; }
			}

			public ServiceOrderDetailViewModel Parent
			{
				get { return _parent; }
			}

			public OperationEntryCellViewModel GetEntryCellForDay(DayOfWeekViewModel day)
			{
				Guard.NotNull(()=> day, day);

				OperationEntryCellViewModel result = null;

				lock (_entryCells) {
					if (!_entryCells.TryGetValue (day.Index, out result)) {
						_entryCells.Add (day.Index, result = new OperationEntryCellViewModel (this, day));
					}
				}

				return result;
			}

			ICollection<EnosixTimesheet_ATT_TYPE_MAP> GetTimesheetAttendanceTypeOperationMap ()
			{
				return this.Parent.TimeSheet.ATT_TYPE_MAP_Collection;
			}

			string GetAttendanceOrAbsenceTypeForOperation ()
			{
				return Enumerable.FirstOrDefault (
					from map in GetTimesheetAttendanceTypeOperationMap ()
					where string.Equals (map.ActivityType, Operation.ActivityType, StringComparison.OrdinalIgnoreCase)
					select map.AttendanceOrAbsenceType
				);
			}

			string GetDefaultAttendanceOrAbsenceType ()
			{
				return Enumerable.FirstOrDefault (
					from map in GetTimesheetAttendanceTypeOperationMap ()
					where string.IsNullOrWhiteSpace( map.ActivityType)
					select map.AttendanceOrAbsenceType
				);
			}

			public string AttendanceOrAbsenceType
			{
				get 
				{
					return GetAttendanceOrAbsenceTypeForOperation () ?? GetDefaultAttendanceOrAbsenceType () ?? "0800"; // A safe bet?
				}
			}

			public bool MatchTimesheetLineItemToOperation(EnosixTimesheet_LINE_ITEM item)
			{
				Guard.NotNull (() => item, item);

				return 
					string.Equals( item.ActivityType, Operation.ActivityType, StringComparison.OrdinalIgnoreCase) 
					&&
					string.Equals( item.ActivityNumber, Operation.OperationActivityNumber, StringComparison.OrdinalIgnoreCase);
			}

			public IEnumerable<EnosixTimesheet_LINE_ITEM> OperationLineItems
			{
				get 
				{
					return _parent.ServiceOrderItems.Where (MatchTimesheetLineItemToOperation);
				}
			}

			public decimal TotalHoursForOperation
			{
				get 
				{
					return Enumerable.Sum (
						from item in OperationLineItems
						select item.Hours
					);
				}
			}

			public void HoursEntered(OperationEntryCellViewModel cell)
			{
				RaisePropertyChanged (() => TotalHoursForOperation);

				_parent.HoursEntered (cell);
			}

			public EnosixTimesheet_LINE_ITEM CreateNewTimeSheetItem(DayOfWeekViewModel day)
			{
				var item = new EnosixTimesheet_LINE_ITEM()
				{
					WorkDate = day.Day,

					ActivityType = Operation.ActivityType,
					ActivityNumber = Operation.OperationActivityNumber,

					AttendanceOrAbsenceType = AttendanceOrAbsenceType,
					ReceiverOrder = Parent.ServiceOrder.ServiceOrderNumber,
				};
				_parent.AddTimesheetLineItem (item);
				return item;
			}

			public void Update()
			{
				RaisePropertyChanged (() => TotalHoursForOperation);

				foreach (var cell in _entryCells.Values) 
				{
					cell.Update ();
				}
			}

			public override string ToString ()
			{
				return string.Format ("[ServiceOrderOperationViewModel: Index={0}, Operation={1}, Parent={2}, AttendanceOrAbsenceType={3}, OperationLineItems={4}, TotalHoursForOperation={5}]", Index, Operation, Parent, AttendanceOrAbsenceType, OperationLineItems, TotalHoursForOperation);
			}
		}

		public class DayOfWeekViewModel : BaseViewModel
		{
			private readonly int _index;
			private readonly ServiceOrderDetailViewModel _parent;

			public DayOfWeekViewModel(ServiceOrderDetailViewModel parent, int index)
			{
				Guard.NotNull(()=> parent, parent);
				this._parent = parent;
				this._index = index;
			}

			public int Index
			{
				get { return _index; }
			}

			public DateTime Day
			{
				get 
				{ 
					return _parent.Week.AddDays (_index);
				}
			}

			public decimal TotalHoursForServiceOrderDay
			{
				get 
				{
					return Enumerable.Sum (
						from item in DayLineItems
						select item.Hours
					);;
				}
			}

			public bool MatchTimesheetLineItemToDay(EnosixTimesheet_LINE_ITEM item)
			{
				Guard.NotNull (() => item, item);
				return DateTime.Equals( item.WorkDate.Date, this.Day);
			}

			public IEnumerable<EnosixTimesheet_LINE_ITEM> DayLineItems
			{
				get 
				{
					return _parent.ServiceOrderItems.Where (MatchTimesheetLineItemToDay);
				}
			}

			public void HoursEntered(OperationEntryCellViewModel cell)
			{
				RaisePropertyChanged (() => TotalHoursForServiceOrderDay);
			}
		}

		public class OperationEntryCellViewModel : BaseViewModel
		{
			private readonly ServiceOrderOperationViewModel _parent;
			private readonly DayOfWeekViewModel _day;

			public OperationEntryCellViewModel(ServiceOrderOperationViewModel parent, DayOfWeekViewModel day) : base()
			{
				Guard.NotNull(()=> parent, parent);
				Guard.NotNull(()=> day, day);

				this._parent = parent;
				this._day = day;
			}

			public IEnumerable<EnosixTimesheet_LINE_ITEM> CellLineItems
			{
				get {
					return _day.DayLineItems.Where (_parent.MatchTimesheetLineItemToOperation);
				}
			}

			static readonly string[] EditableStatuses = new []{"10", "20", "30"};

			public IEnumerable<EnosixTimesheet_LINE_ITEM> EditableLineItems
			{
				get {
					return CellLineItems.Where (item=> string.IsNullOrWhiteSpace(item.ProcessingStatus) || EditableStatuses.Contains( item.ProcessingStatus ) );
				}
			}

			private ICommand _deleteLineItemCommand;

			public ICommand DeleteLineItemCommand
			{
				get{ return _deleteLineItemCommand ?? (_deleteLineItemCommand = new Command<EnosixTimesheet_LINE_ITEM> (OnDeleteLineItem)); }
			}

			protected void OnDeleteLineItem(EnosixTimesheet_LINE_ITEM item)
			{
				item.Hours = 0;
				NotifyHoursUpdated();
			}

			public bool HasMultipleItems
			{
				get { return EditableLineItems.Where(i=>i.Hours > 0).Skip (1).Any (); }
			}

			public bool CanEdit
			{
				get { return ! HasMultipleItems; }
			}

			public DayOfWeekViewModel Day
			{
				get { return _day; }
			}


			private void NotifyHoursUpdated()
			{
				base.RaisePropertyChanged(() => Hours);
				_parent.HoursEntered (this);
				_day.HoursEntered (this);
			}

			public void Update()
			{
				RaisePropertyChanged (() => Hours);
				RaisePropertyChanged (() => CanEdit);
				RaisePropertyChanged (() => HasMultipleItems);
			}

			public decimal Hours
			{
				get
				{
					var lineItems = EditableLineItems;

					return lineItems.Sum (i => i.Hours);
				}
				set
				{
					if (Hours == value) return;

					var lineItems = EditableLineItems.ToArray();

					var item = lineItems.OrderBy(i=>i.ProcessingStatus).FirstOrDefault ();

					if (null != item)
					{
						if (item.Hours != value)
						{
							item.Hours = value;
							item.AttendanceOrAbsenceType = _parent.AttendanceOrAbsenceType;

							if (lineItems.Count () > 1) {
								var otherItems = lineItems.Skip (1).ToArray ();
								foreach (var r in otherItems) {
									r.Hours = 0;
								}
							}
						}

					} else if (0 != value)
					{
						item = _parent.CreateNewTimeSheetItem (_day);

						item.Hours = value;

					}

					NotifyHoursUpdated();
				}
			}
		}
	}
}

