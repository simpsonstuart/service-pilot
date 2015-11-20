






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{

	public partial class EnosixServiceOrder_SC : SearchContext<EnosixServiceOrder_SC>
	{

		
		public virtual ICollection<EnosixServiceOrder_SEARCHPARAMS> SEARCHPARAMS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceOrder_SEARCHPARAMS>("SEARCHPARAMS_Collection");
			}
		}

		
	}


	[Name("SEARCHPARAMS")]
	
	public partial class EnosixServiceOrder_SEARCHPARAMS : SearchCriteria<EnosixServiceOrder_SEARCHPARAMS>
	{
		

		public System.String X_Open
		{ 
			get { return base.Get< System.String > ("X_OPEN"); } 
			set { base.Set (value, "X_OPEN"); }
		}



		public System.String X_Completed
		{ 
			get { return base.Get< System.String > ("X_COMPLETED"); } 
			set { base.Set (value, "X_COMPLETED"); }
		}



		public System.String X_Mineonly
		{ 
			get { return base.Get< System.String > ("X_MINEONLY"); } 
			set { base.Set (value, "X_MINEONLY"); }
		}



		public System.String ServiceOderNumberLow
		{ 
			get { return base.Get< System.String > ("SRVORD_NUMBER_LOW"); } 
			set { base.Set (value, "SRVORD_NUMBER_LOW"); }
		}



		public System.String ServiceOderNumberHigh
		{ 
			get { return base.Get< System.String > ("SRVORD_NUMBER_HIGH"); } 
			set { base.Set (value, "SRVORD_NUMBER_HIGH"); }
		}



		public System.DateTime DocumentCreateDateLow
		{ 
			get { return base.Get< System.DateTime > ("DOCUMENT_CREATE_DATE_LOW"); } 
			set { base.Set (value, "DOCUMENT_CREATE_DATE_LOW"); }
		}



		public System.DateTime DocumentCreateDateHigh
		{ 
			get { return base.Get< System.DateTime > ("DOCUMENT_CREATE_DATE_HIGH"); } 
			set { base.Set (value, "DOCUMENT_CREATE_DATE_HIGH"); }
		}



		public System.String CustomerNumber
		{ 
			get { return base.Get< System.String > ("CUSTOMER_NUMBER"); } 
			set { base.Set (value, "CUSTOMER_NUMBER"); }
		}



		public System.String CustomerName
		{ 
			get { return base.Get< System.String > ("CUSTOMER_NAME"); } 
			set { base.Set (value, "CUSTOMER_NAME"); }
		}



		public System.String EmployeeNumber
		{ 
			get { return base.Get< System.String > ("EMPLOYEENUMBER"); } 
			set { base.Set (value, "EMPLOYEENUMBER"); }
		}



		public System.String Username
		{ 
			get { return base.Get< System.String > ("USERNAME"); } 
			set { base.Set (value, "USERNAME"); }
		}


	}
	

}
