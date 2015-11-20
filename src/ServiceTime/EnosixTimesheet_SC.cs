






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{

	public partial class EnosixTimesheet_SC : SearchContext<EnosixTimesheet_SC>
	{

		
		public virtual ICollection<EnosixTimesheet_SEARCHPARAMS> SEARCHPARAMS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixTimesheet_SEARCHPARAMS>("SEARCHPARAMS_Collection");
			}
		}

		
	}


	[Name("SEARCHPARAMS")]
	
	public partial class EnosixTimesheet_SEARCHPARAMS : SearchCriteria<EnosixTimesheet_SEARCHPARAMS>
	{
		

		public System.String ResponsibleFor
		{ 
			get { return base.Get< System.String > ("RESPONSIBLE_FOR"); } 
			set { base.Set (value, "RESPONSIBLE_FOR"); }
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



		public System.String UserName
		{ 
			get { return base.Get< System.String > ("USERNAME"); } 
			set { base.Set (value, "USERNAME"); }
		}



		public System.String EmployeeNumber
		{ 
			get { return base.Get< System.String > ("EMPLOYEENUMBER"); } 
			set { base.Set (value, "EMPLOYEENUMBER"); }
		}


	}
	

}
