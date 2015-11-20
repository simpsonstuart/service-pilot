






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{

	public partial class EnosixServiceNotification_SC : SearchContext<EnosixServiceNotification_SC>
	{

		
		public virtual ICollection<EnosixServiceNotification_SEARCHPARAMS> SEARCHPARAMS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_SEARCHPARAMS>("SEARCHPARAMS_Collection");
			}
		}

		
	}


	[Name("SEARCHPARAMS")]
	
	public partial class EnosixServiceNotification_SEARCHPARAMS : SearchCriteria<EnosixServiceNotification_SEARCHPARAMS>
	{
		

		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("QMNUM"); } 
			set { base.Set (value, "QMNUM"); }
		}



		public System.String CustomerNumber
		{ 
			get { return base.Get< System.String > ("KUNUM"); } 
			set { base.Set (value, "KUNUM"); }
		}



		public System.String CustomerName
		{ 
			get { return base.Get< System.String > ("CUSTOMER_NAME"); } 
			set { base.Set (value, "CUSTOMER_NAME"); }
		}



		public System.DateTime DateofNotification
		{ 
			get { return base.Get< System.DateTime > ("QMDAT"); } 
			set { base.Set (value, "QMDAT"); }
		}


	}
	

}
