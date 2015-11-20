
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
	
	[Name("SEARCHRESULT")]
	
	public partial class EnosixTimesheet_SEARCHRESULT : BusinessObject<EnosixTimesheet_SEARCHRESULT>
	{
		

		public System.String EmployeeNumber
		{ 
			get { return base.Get< System.String > ("EMPLOYEENUMBER"); } 
			set { base.Set (value, "EMPLOYEENUMBER"); }
		}



		public System.DateTime DateFrom
		{ 
			get { return base.Get< System.DateTime > ("DATE_FROM"); } 
			set { base.Set (value, "DATE_FROM"); }
		}



		public System.DateTime DateTo
		{ 
			get { return base.Get< System.DateTime > ("DATE_TO"); } 
			set { base.Set (value, "DATE_TO"); }
		}



		public System.String Week
		{ 
			get { return base.Get< System.String > ("WEEK"); } 
			set { base.Set (value, "WEEK"); }
		}



		public System.Decimal TotalTimeEntered
		{ 
			get { return base.Get< System.Decimal > ("TOTALHOURS"); } 
			set { base.Set (value, "TOTALHOURS"); }
		}



		public System.String UnitOfMeasure
		{ 
			get { return base.Get< System.String > ("UNIT"); } 
			set { base.Set (value, "UNIT"); }
		}


	}
	}
