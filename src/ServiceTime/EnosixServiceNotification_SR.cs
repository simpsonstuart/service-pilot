
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
	
	[Name("SEARCHRESULT")]
	
	public partial class EnosixServiceNotification_SEARCHRESULT : BusinessObject<EnosixServiceNotification_SEARCHRESULT>
	{
		

		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("QMNUM"); } 
			set { base.Set (value, "QMNUM"); }
		}



		public System.DateTime DateofNotification
		{ 
			get { return base.Get< System.DateTime > ("QMDAT"); } 
			set { base.Set (value, "QMDAT"); }
		}



		public System.String NotificationDescription
		{ 
			get { return base.Get< System.String > ("QMTXT"); } 
			set { base.Set (value, "QMTXT"); }
		}



		public System.String NotificationType
		{ 
			get { return base.Get< System.String > ("QMART"); } 
			set { base.Set (value, "QMART"); }
		}



		public System.String NotificationTypeText
		{ 
			get { return base.Get< System.String > ("QMARTX"); } 
			set { base.Set (value, "QMARTX"); }
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


	}
	}
