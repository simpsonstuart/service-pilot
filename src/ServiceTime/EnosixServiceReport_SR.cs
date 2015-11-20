
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
	
	[Name("SEARCHRESULT")]
	
	public partial class EnosixServiceReport_SEARCHRESULT : BusinessObject<EnosixServiceReport_SEARCHRESULT>
	{
		

		public System.String CreatedBy
		{ 
			get { return base.Get< System.String > ("ERNAM"); } 
			set { base.Set (value, "ERNAM"); }
		}



		public System.DateTime WeekOf
		{ 
			get { return base.Get< System.DateTime > ("WEEKOF"); } 
			set { base.Set (value, "WEEKOF"); }
		}



		public System.DateTime WeekEnd
		{ 
			get { return base.Get< System.DateTime > ("WEEKEND"); } 
			set { base.Set (value, "WEEKEND"); }
		}



		public System.String ServiceOrderNumber
		{ 
			get { return base.Get< System.String > ("ORDERID"); } 
			set { base.Set (value, "ORDERID"); }
		}



		public System.String ServiceOrderType
		{ 
			get { return base.Get< System.String > ("ORDER_TYPE"); } 
			set { base.Set (value, "ORDER_TYPE"); }
		}



		public System.String MaintenancePlanningPlant
		{ 
			get { return base.Get< System.String > ("PLANPLANT"); } 
			set { base.Set (value, "PLANPLANT"); }
		}



		public System.String BusinessArea
		{ 
			get { return base.Get< System.String > ("BUS_AREA"); } 
			set { base.Set (value, "BUS_AREA"); }
		}



		public System.String MainWorkcenter
		{ 
			get { return base.Get< System.String > ("MN_WK_CTR"); } 
			set { base.Set (value, "MN_WK_CTR"); }
		}



		public System.String MainWorkcenterPlant
		{ 
			get { return base.Get< System.String > ("PLANT"); } 
			set { base.Set (value, "PLANT"); }
		}



		public System.String MainWorkCenterID
		{ 
			get { return base.Get< System.String > ("MN_WKCTR_ID"); } 
			set { base.Set (value, "MN_WKCTR_ID"); }
		}



		public System.String MaintenanceActivityType
		{ 
			get { return base.Get< System.String > ("PMACTTYPE"); } 
			set { base.Set (value, "PMACTTYPE"); }
		}



		public System.String PlannerGroup
		{ 
			get { return base.Get< System.String > ("PLANGROUP"); } 
			set { base.Set (value, "PLANGROUP"); }
		}



		public System.String SystemCondition
		{ 
			get { return base.Get< System.String > ("SYSTCOND"); } 
			set { base.Set (value, "SYSTCOND"); }
		}



		public System.String FunctionalLocation
		{ 
			get { return base.Get< System.String > ("FUNCT_LOC"); } 
			set { base.Set (value, "FUNCT_LOC"); }
		}



		public System.String EquipmentNumber
		{ 
			get { return base.Get< System.String > ("EQUIPMENT"); } 
			set { base.Set (value, "EQUIPMENT"); }
		}



		public System.String SerialNumber
		{ 
			get { return base.Get< System.String > ("SERIALNO"); } 
			set { base.Set (value, "SERIALNO"); }
		}



		public System.String MaterialNumber
		{ 
			get { return base.Get< System.String > ("MATERIAL"); } 
			set { base.Set (value, "MATERIAL"); }
		}



		public System.String Assembly
		{ 
			get { return base.Get< System.String > ("ASSEMBLY"); } 
			set { base.Set (value, "ASSEMBLY"); }
		}



		public System.String AdditionalDeviceData
		{ 
			get { return base.Get< System.String > ("DEVICEDATA"); } 
			set { base.Set (value, "DEVICEDATA"); }
		}



		public System.String MaintenancePlant
		{ 
			get { return base.Get< System.String > ("MAINTPLANT"); } 
			set { base.Set (value, "MAINTPLANT"); }
		}



		public System.String AssetLocation
		{ 
			get { return base.Get< System.String > ("LOCATION"); } 
			set { base.Set (value, "LOCATION"); }
		}



		public System.String Room
		{ 
			get { return base.Get< System.String > ("MAINTROOM"); } 
			set { base.Set (value, "MAINTROOM"); }
		}



		public System.String PlantSection
		{ 
			get { return base.Get< System.String > ("PLSECTN"); } 
			set { base.Set (value, "PLSECTN"); }
		}



		public System.String Workcenter
		{ 
			get { return base.Get< System.String > ("LOC_WK_CTR"); } 
			set { base.Set (value, "LOC_WK_CTR"); }
		}



		public System.String WorkcenterID
		{ 
			get { return base.Get< System.String > ("LOC_WKCTR_ID"); } 
			set { base.Set (value, "LOC_WKCTR_ID"); }
		}



		public System.String ABCIndicator
		{ 
			get { return base.Get< System.String > ("ABCINDIC"); } 
			set { base.Set (value, "ABCINDIC"); }
		}



		public System.String Sortfield
		{ 
			get { return base.Get< System.String > ("SORTFIELD"); } 
			set { base.Set (value, "SORTFIELD"); }
		}



		public System.DateTime StartDate
		{ 
			get { return base.Get< System.DateTime > ("START_DATE"); } 
			set { base.Set (value, "START_DATE"); }
		}



		public System.DateTime FinishDate
		{ 
			get { return base.Get< System.DateTime > ("FINISH_DATE"); } 
			set { base.Set (value, "FINISH_DATE"); }
		}



		public System.String SalesOrderNumber
		{ 
			get { return base.Get< System.String > ("SALES_ORD"); } 
			set { base.Set (value, "SALES_ORD"); }
		}



		public System.String SalesOrderItemNumber
		{ 
			get { return base.Get< System.String > ("S_ORD_ITEM"); } 
			set { base.Set (value, "S_ORD_ITEM"); }
		}



		public System.String Title
		{ 
			get { return base.Get< System.String > ("TITLE"); } 
			set { base.Set (value, "TITLE"); }
		}



		public System.String Name
		{ 
			get { return base.Get< System.String > ("NAME1"); } 
			set { base.Set (value, "NAME1"); }
		}



		public System.String City
		{ 
			get { return base.Get< System.String > ("CITY1"); } 
			set { base.Set (value, "CITY1"); }
		}



		public System.String PostalCode
		{ 
			get { return base.Get< System.String > ("POST_CODE1"); } 
			set { base.Set (value, "POST_CODE1"); }
		}



		public System.String Street
		{ 
			get { return base.Get< System.String > ("STREET"); } 
			set { base.Set (value, "STREET"); }
		}



		public System.String Region
		{ 
			get { return base.Get< System.String > ("REGION"); } 
			set { base.Set (value, "REGION"); }
		}



		public System.String ShortText
		{ 
			get { return base.Get< System.String > ("SHORT_TEXT"); } 
			set { base.Set (value, "SHORT_TEXT"); }
		}



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


	}
	}
