






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
     [Header( "HEADER" )]   
	
	
	[RecordKeyStructure("EnosixObjKey")]
	
	public partial class EnosixServiceReport : BusinessObject<EnosixServiceReport> 
	{
		
		
		public virtual ICollection<EnosixServiceReport_SOHEADER> SOHEADER_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_SOHEADER>("SOHEADER_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_NOTIFICATION> NOTIFICATION_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_NOTIFICATION>("NOTIFICATION_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_MALFUNCTION_BREAKDOWN> MALFUNCTION_BREAKDOWN_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_MALFUNCTION_BREAKDOWN>("MALFUNCTION_BREAKDOWN_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_ADDRESS> ADDRESS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_ADDRESS>("ADDRESS_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_CONTACT> CONTACT_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_CONTACT>("CONTACT_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_TIMESHEET> TIMESHEET_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_TIMESHEET>("TIMESHEET_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_TCA_TEXT> TCA_TEXT_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_TCA_TEXT>("TCA_TEXT_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_ZZSAFETYCHKLST> ZZSAFETYCHKLST_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_ZZSAFETYCHKLST>("ZZSAFETYCHKLST_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_ZZCONTROL> ZZCONTROL_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_ZZCONTROL>("ZZCONTROL_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceReport_ZZPDF> ZZPDF_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceReport_ZZPDF>("ZZPDF_Collection");
			}
		}

		

		#region Header Properties

		

		public System.String Username
		{ 
			get { return base.Get< System.String > ("USERNAME"); } 
			set { base.Set (value, "USERNAME"); }
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


		
		#endregion

		
	}
	
	[Name("SOHEADER")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_SOHEADER : BusinessObject<EnosixServiceReport_SOHEADER>
	{
		

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



		public System.String CompanyCode
		{ 
			get { return base.Get< System.String > ("COMP_CODE"); } 
			set { base.Set (value, "COMP_CODE"); }
		}



		public System.String ProfitCenter
		{ 
			get { return base.Get< System.String > ("PROFIT_CTR"); } 
			set { base.Set (value, "PROFIT_CTR"); }
		}



		public System.String ControllingArea
		{ 
			get { return base.Get< System.String > ("CO_AREA"); } 
			set { base.Set (value, "CO_AREA"); }
		}



		public System.String ResponsibleCostCenter
		{ 
			get { return base.Get< System.String > ("RESPCCTR"); } 
			set { base.Set (value, "RESPCCTR"); }
		}



		public System.String FunctionalArea
		{ 
			get { return base.Get< System.String > ("FUNC_AREA"); } 
			set { base.Set (value, "FUNC_AREA"); }
		}



		public System.String SuperiorNetwork
		{ 
			get { return base.Get< System.String > ("SUPERIOR_NETWORK"); } 
			set { base.Set (value, "SUPERIOR_NETWORK"); }
		}



		public System.String SuperiorActivity
		{ 
			get { return base.Get< System.String > ("SUPERIOR_ACTIVITY"); } 
			set { base.Set (value, "SUPERIOR_ACTIVITY"); }
		}



		public System.String SuperiorRoutingNumber
		{ 
			get { return base.Get< System.String > ("SUPERIOR_ROUTING_NO"); } 
			set { base.Set (value, "SUPERIOR_ROUTING_NO"); }
		}



		public System.String SuperiorCounter
		{ 
			get { return base.Get< System.String > ("SUPERIOR_COUNTER"); } 
			set { base.Set (value, "SUPERIOR_COUNTER"); }
		}



		public System.String WBSElement
		{ 
			get { return base.Get< System.String > ("WBS_ELEM"); } 
			set { base.Set (value, "WBS_ELEM"); }
		}



		public System.String ProjectDefinition
		{ 
			get { return base.Get< System.String > ("PROJ_DEF"); } 
			set { base.Set (value, "PROJ_DEF"); }
		}



		public System.String ProcessingGroup
		{ 
			get { return base.Get< System.String > ("PROCESSING_GROUP"); } 
			set { base.Set (value, "PROCESSING_GROUP"); }
		}



		public System.String ObjectClass
		{ 
			get { return base.Get< System.String > ("OBJECTCLASS"); } 
			set { base.Set (value, "OBJECTCLASS"); }
		}



		public System.String TaxJurisdiction
		{ 
			get { return base.Get< System.String > ("TAXJURCODE"); } 
			set { base.Set (value, "TAXJURCODE"); }
		}



		public System.String LocationCompanyCode
		{ 
			get { return base.Get< System.String > ("LOC_COMP_CODE"); } 
			set { base.Set (value, "LOC_COMP_CODE"); }
		}



		public System.String LocationControllingArea
		{ 
			get { return base.Get< System.String > ("LOC_CO_AREA"); } 
			set { base.Set (value, "LOC_CO_AREA"); }
		}



		public System.String MainAssetNumber
		{ 
			get { return base.Get< System.String > ("ASSET_NO"); } 
			set { base.Set (value, "ASSET_NO"); }
		}



		public System.String AssetSubnumber
		{ 
			get { return base.Get< System.String > ("SUB_NUMBER"); } 
			set { base.Set (value, "SUB_NUMBER"); }
		}



		public System.String LocationBusinessArea
		{ 
			get { return base.Get< System.String > ("LOC_BUS_AREA"); } 
			set { base.Set (value, "LOC_BUS_AREA"); }
		}



		public System.String CostCenter
		{ 
			get { return base.Get< System.String > ("COSTCENTER"); } 
			set { base.Set (value, "COSTCENTER"); }
		}



		public System.String LocationWBSElement
		{ 
			get { return base.Get< System.String > ("LOC_WBS_ELEM"); } 
			set { base.Set (value, "LOC_WBS_ELEM"); }
		}



		public System.String StandingOrderNumber
		{ 
			get { return base.Get< System.String > ("STANDORDER"); } 
			set { base.Set (value, "STANDORDER"); }
		}



		public System.String SettlementOrderNumber
		{ 
			get { return base.Get< System.String > ("SETTLORDER"); } 
			set { base.Set (value, "SETTLORDER"); }
		}



		public System.String SalesOrganization
		{ 
			get { return base.Get< System.String > ("SALESORG"); } 
			set { base.Set (value, "SALESORG"); }
		}



		public System.String DistributionChannel
		{ 
			get { return base.Get< System.String > ("DISTR_CHAN"); } 
			set { base.Set (value, "DISTR_CHAN"); }
		}



		public System.String Division
		{ 
			get { return base.Get< System.String > ("DIVISION"); } 
			set { base.Set (value, "DIVISION"); }
		}



		public System.String MaintenanceOrderPlanningIndica
		{ 
			get { return base.Get< System.String > ("ORDPLANID"); } 
			set { base.Set (value, "ORDPLANID"); }
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



		public System.DateTime StartTime
		{ 
			get { return base.Get< System.DateTime > ("BASICSTART"); } 
			set { base.Set (value, "BASICSTART"); }
		}



		public System.DateTime FinishTime
		{ 
			get { return base.Get< System.DateTime > ("BASIC_FIN"); } 
			set { base.Set (value, "BASIC_FIN"); }
		}



		public System.String Priority
		{ 
			get { return base.Get< System.String > ("PRIORITY"); } 
			set { base.Set (value, "PRIORITY"); }
		}



		public System.String Revision
		{ 
			get { return base.Get< System.String > ("REVISION"); } 
			set { base.Set (value, "REVISION"); }
		}



		public System.String Version
		{ 
			get { return base.Get< System.String > ("VERSION"); } 
			set { base.Set (value, "VERSION"); }
		}



		public System.String SchedulingType
		{ 
			get { return base.Get< System.String > ("SCHED_TYPE"); } 
			set { base.Set (value, "SCHED_TYPE"); }
		}



		public System.String AutoScheduleIndicator
		{ 
			get { return base.Get< System.String > ("AUTOSCHED"); } 
			set { base.Set (value, "AUTOSCHED"); }
		}



		public System.String CalculateCapacityRequirementsI
		{ 
			get { return base.Get< System.String > ("CAP_REQMTS"); } 
			set { base.Set (value, "CAP_REQMTS"); }
		}



		public System.String SchedulingAllowingBreaksIndica
		{ 
			get { return base.Get< System.String > ("SCHEDULING_EXACT_BREAK_TIMES"); } 
			set { base.Set (value, "SCHEDULING_EXACT_BREAK_TIMES"); }
		}



		public System.String MRPRelevantIndicator
		{ 
			get { return base.Get< System.String > ("MRP_RELEVANT"); } 
			set { base.Set (value, "MRP_RELEVANT"); }
		}



		public System.DateTime ScheduledStartDate
		{ 
			get { return base.Get< System.DateTime > ("PRODUCTION_START_DATE"); } 
			set { base.Set (value, "PRODUCTION_START_DATE"); }
		}



		public System.DateTime ScheduledFinishDate
		{ 
			get { return base.Get< System.DateTime > ("PRODUCTION_FINISH_DATE"); } 
			set { base.Set (value, "PRODUCTION_FINISH_DATE"); }
		}



		public System.DateTime ScheduledStartTime
		{ 
			get { return base.Get< System.DateTime > ("PRODUCTION_START_TIME"); } 
			set { base.Set (value, "PRODUCTION_START_TIME"); }
		}



		public System.DateTime ScheduledFinishTime
		{ 
			get { return base.Get< System.DateTime > ("PRODUCTION_FINISH_TIME"); } 
			set { base.Set (value, "PRODUCTION_FINISH_TIME"); }
		}



		public System.DateTime ActualStartDate
		{ 
			get { return base.Get< System.DateTime > ("ACTUAL_START_DATE"); } 
			set { base.Set (value, "ACTUAL_START_DATE"); }
		}



		public System.DateTime ActualFinishDate
		{ 
			get { return base.Get< System.DateTime > ("ACTUAL_FINISH_DATE"); } 
			set { base.Set (value, "ACTUAL_FINISH_DATE"); }
		}



		public System.DateTime ActualStartTime
		{ 
			get { return base.Get< System.DateTime > ("ACTUAL_START_TIME"); } 
			set { base.Set (value, "ACTUAL_START_TIME"); }
		}



		public System.DateTime ActualFinishTime
		{ 
			get { return base.Get< System.DateTime > ("ACTUAL_FINISH_TIME"); } 
			set { base.Set (value, "ACTUAL_FINISH_TIME"); }
		}



		public System.DateTime ReferenceDate
		{ 
			get { return base.Get< System.DateTime > ("REFDATE"); } 
			set { base.Set (value, "REFDATE"); }
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



		public System.String AccountingIndicator
		{ 
			get { return base.Get< System.String > ("CALC_MOTIVE"); } 
			set { base.Set (value, "CALC_MOTIVE"); }
		}



		public System.String InvestmentMeasureProfile
		{ 
			get { return base.Get< System.String > ("INVEST_PROFILE"); } 
			set { base.Set (value, "INVEST_PROFILE"); }
		}



		public System.String InvestmentObjectsScale
		{ 
			get { return base.Get< System.String > ("SCALE"); } 
			set { base.Set (value, "SCALE"); }
		}



		public System.String InvestmentReason
		{ 
			get { return base.Get< System.String > ("INV_REASON"); } 
			set { base.Set (value, "INV_REASON"); }
		}



		public System.String EnvironmentalInvestmentReason
		{ 
			get { return base.Get< System.String > ("ENVIR_INVEST"); } 
			set { base.Set (value, "ENVIR_INVEST"); }
		}



		public System.Decimal EstimatedTotalOrderCosts
		{ 
			get { return base.Get< System.Decimal > ("ESTIMATED_COSTS"); } 
			set { base.Set (value, "ESTIMATED_COSTS"); }
		}



		public System.String OrderCurrency
		{ 
			get { return base.Get< System.String > ("CURRENCY"); } 
			set { base.Set (value, "CURRENCY"); }
		}



		public System.String ISOCurrencyCode
		{ 
			get { return base.Get< System.String > ("CURRENCY_ISO"); } 
			set { base.Set (value, "CURRENCY_ISO"); }
		}



		public System.String CostingSheet
		{ 
			get { return base.Get< System.String > ("CSTG_SHEET"); } 
			set { base.Set (value, "CSTG_SHEET"); }
		}



		public System.String OverheadKey
		{ 
			get { return base.Get< System.String > ("OVERHEAD_KEY"); } 
			set { base.Set (value, "OVERHEAD_KEY"); }
		}



		public System.String ResultsAnalysisKey
		{ 
			get { return base.Get< System.String > ("RES_ANAL_KEY"); } 
			set { base.Set (value, "RES_ANAL_KEY"); }
		}



		public System.String NetworkProfile
		{ 
			get { return base.Get< System.String > ("NETWORK_PROFILE"); } 
			set { base.Set (value, "NETWORK_PROFILE"); }
		}



		public System.String PlannedCostsCostingVariant
		{ 
			get { return base.Get< System.String > ("CSTGVAPPLN"); } 
			set { base.Set (value, "CSTGVAPPLN"); }
		}



		public System.String ActualCostsCostingVariant
		{ 
			get { return base.Get< System.String > ("CSTGVARACT"); } 
			set { base.Set (value, "CSTGVARACT"); }
		}



		public System.String TaskListGroupKey
		{ 
			get { return base.Get< System.String > ("TASK_LIST_GROUP"); } 
			set { base.Set (value, "TASK_LIST_GROUP"); }
		}



		public System.String GroupCounter
		{ 
			get { return base.Get< System.String > ("GROUP_COUNTER"); } 
			set { base.Set (value, "GROUP_COUNTER"); }
		}



		public System.String TaskListType
		{ 
			get { return base.Get< System.String > ("TASK_LIST_TYPE"); } 
			set { base.Set (value, "TASK_LIST_TYPE"); }
		}



		public System.String ResponsiblePlannerGroup
		{ 
			get { return base.Get< System.String > ("RESP_PLANNER_GROUP"); } 
			set { base.Set (value, "RESP_PLANNER_GROUP"); }
		}



		public System.String MaintenancePlan
		{ 
			get { return base.Get< System.String > ("MNTPLAN"); } 
			set { base.Set (value, "MNTPLAN"); }
		}



		public System.String MaintenanceItem
		{ 
			get { return base.Get< System.String > ("MAINTITEM"); } 
			set { base.Set (value, "MAINTITEM"); }
		}



		public System.Int32 MaintenancePlanCallNumber
		{ 
			get { return base.Get< System.Int32 > ("CALL_NO"); } 
			set { base.Set (value, "CALL_NO"); }
		}



		public System.String LastOrderNumber
		{ 
			get { return base.Get< System.String > ("LAST_ORD"); } 
			set { base.Set (value, "LAST_ORD"); }
		}



		public System.String EnteredBy
		{ 
			get { return base.Get< System.String > ("ENTERED_BY"); } 
			set { base.Set (value, "ENTERED_BY"); }
		}



		public System.DateTime CreatedOn
		{ 
			get { return base.Get< System.DateTime > ("ENTER_DATE"); } 
			set { base.Set (value, "ENTER_DATE"); }
		}



		public System.String LastChangedBy
		{ 
			get { return base.Get< System.String > ("CHANGED_BY"); } 
			set { base.Set (value, "CHANGED_BY"); }
		}



		public System.DateTime OrderMasterChangeDate
		{ 
			get { return base.Get< System.DateTime > ("CHANGE_DATE"); } 
			set { base.Set (value, "CHANGE_DATE"); }
		}



		public System.String ScenarioSubscreenCategory
		{ 
			get { return base.Get< System.String > ("SCENARIO"); } 
			set { base.Set (value, "SCENARIO"); }
		}



		public System.String SystemStatus
		{ 
			get { return base.Get< System.String > ("SYS_STATUS"); } 
			set { base.Set (value, "SYS_STATUS"); }
		}



		public System.String UserStatusActive
		{ 
			get { return base.Get< System.String > ("USER_ST"); } 
			set { base.Set (value, "USER_ST"); }
		}



		public System.String UserStatus
		{ 
			get { return base.Get< System.String > ("USERSTATUS"); } 
			set { base.Set (value, "USERSTATUS"); }
		}



		public System.String StatusProfile
		{ 
			get { return base.Get< System.String > ("STAT_PROF"); } 
			set { base.Set (value, "STAT_PROF"); }
		}



		public System.String Objectnumber
		{ 
			get { return base.Get< System.String > ("OBJECT_NO"); } 
			set { base.Set (value, "OBJECT_NO"); }
		}



		public System.String OperationsRoutingNumber
		{ 
			get { return base.Get< System.String > ("ROUTING_NO"); } 
			set { base.Set (value, "ROUTING_NO"); }
		}



		public System.String ReservationNumber
		{ 
			get { return base.Get< System.String > ("RESERV_NO"); } 
			set { base.Set (value, "RESERV_NO"); }
		}



		public System.String ShortText
		{ 
			get { return base.Get< System.String > ("SHORT_TEXT"); } 
			set { base.Set (value, "SHORT_TEXT"); }
		}



		public System.String LongTextExists
		{ 
			get { return base.Get< System.String > ("LONG_TEXT"); } 
			set { base.Set (value, "LONG_TEXT"); }
		}



		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("NOTIF_NO"); } 
			set { base.Set (value, "NOTIF_NO"); }
		}



		public System.String AssemblyMaterialNumber
		{ 
			get { return base.Get< System.String > ("ASSEMBLY_EXTERNAL"); } 
			set { base.Set (value, "ASSEMBLY_EXTERNAL"); }
		}



		public System.String AssemblyGUID
		{ 
			get { return base.Get< System.String > ("ASSEMBLY_GUID"); } 
			set { base.Set (value, "ASSEMBLY_GUID"); }
		}



		public System.String AssemblyVersionNumber
		{ 
			get { return base.Get< System.String > ("ASSEMBLY_VERSION"); } 
			set { base.Set (value, "ASSEMBLY_VERSION"); }
		}



		public System.String ExternalMaterialNumber
		{ 
			get { return base.Get< System.String > ("MATERIAL_EXTERNAL"); } 
			set { base.Set (value, "MATERIAL_EXTERNAL"); }
		}



		public System.String ExternalMatrerialGUID
		{ 
			get { return base.Get< System.String > ("MATERIAL_GUID"); } 
			set { base.Set (value, "MATERIAL_GUID"); }
		}



		public System.String ExternalMaterialVersionNumber
		{ 
			get { return base.Get< System.String > ("MATERIAL_VERSION"); } 
			set { base.Set (value, "MATERIAL_VERSION"); }
		}



		public System.String FactoryCalendar
		{ 
			get { return base.Get< System.String > ("CALID"); } 
			set { base.Set (value, "CALID"); }
		}



		public System.String OrderCalendarSelection
		{ 
			get { return base.Get< System.String > ("KALSN"); } 
			set { base.Set (value, "KALSN"); }
		}



		public System.String SuperiorOrderNumber
		{ 
			get { return base.Get< System.String > ("SUPERIOR_ORDERID"); } 
			set { base.Set (value, "SUPERIOR_ORDERID"); }
		}



		public System.String LeadingOrderID
		{ 
			get { return base.Get< System.String > ("LEADING_ORDERID"); } 
			set { base.Set (value, "LEADING_ORDERID"); }
		}



		public System.String StartPoint
		{ 
			get { return base.Get< System.String > ("START_POINT"); } 
			set { base.Set (value, "START_POINT"); }
		}



		public System.String EndPoint
		{ 
			get { return base.Get< System.String > ("END_POINT"); } 
			set { base.Set (value, "END_POINT"); }
		}



		public System.String Length
		{ 
			get { return base.Get< System.String > ("LINEAR_LENGTH"); } 
			set { base.Set (value, "LINEAR_LENGTH"); }
		}



		public System.String LinearUOM
		{ 
			get { return base.Get< System.String > ("LINEAR_UNIT"); } 
			set { base.Set (value, "LINEAR_UNIT"); }
		}



		public System.String LinearUOMISOCode
		{ 
			get { return base.Get< System.String > ("LINEAR_UNIT_ISO"); } 
			set { base.Set (value, "LINEAR_UNIT_ISO"); }
		}



		public System.String FirstOffsetType
		{ 
			get { return base.Get< System.String > ("FIRST_OFFSET_TYPE_CODE"); } 
			set { base.Set (value, "FIRST_OFFSET_TYPE_CODE"); }
		}



		public System.String FirstOffsetValue
		{ 
			get { return base.Get< System.String > ("FIRST_OFFSET_VALUE"); } 
			set { base.Set (value, "FIRST_OFFSET_VALUE"); }
		}



		public System.String FirstOffsetUOM
		{ 
			get { return base.Get< System.String > ("FIRST_OFFSET_UNIT"); } 
			set { base.Set (value, "FIRST_OFFSET_UNIT"); }
		}



		public System.String FirstOffsetUOMISOCode
		{ 
			get { return base.Get< System.String > ("FIRST_OFFSET_UNIT_ISO"); } 
			set { base.Set (value, "FIRST_OFFSET_UNIT_ISO"); }
		}



		public System.String SecondOffsetType
		{ 
			get { return base.Get< System.String > ("SECOND_OFFSET_TYPE_CODE"); } 
			set { base.Set (value, "SECOND_OFFSET_TYPE_CODE"); }
		}



		public System.String SecondOffsetValue
		{ 
			get { return base.Get< System.String > ("SECOND_OFFSET_VALUE"); } 
			set { base.Set (value, "SECOND_OFFSET_VALUE"); }
		}



		public System.String SecondOffsetUOM
		{ 
			get { return base.Get< System.String > ("SECOND_OFFSET_UNIT"); } 
			set { base.Set (value, "SECOND_OFFSET_UNIT"); }
		}



		public System.String SecondOffsetUOMISOCode
		{ 
			get { return base.Get< System.String > ("SECOND_OFFSET_UNIT_ISO"); } 
			set { base.Set (value, "SECOND_OFFSET_UNIT_ISO"); }
		}



		public System.String FirstOffsetTypeDescription
		{ 
			get { return base.Get< System.String > ("FIRST_OFFSET_TYPE_CODE_NAME"); } 
			set { base.Set (value, "FIRST_OFFSET_TYPE_CODE_NAME"); }
		}



		public System.String SecondOffsetTypeDescription
		{ 
			get { return base.Get< System.String > ("SECOND_OFFSET_TYPE_CODE_NAME"); } 
			set { base.Set (value, "SECOND_OFFSET_TYPE_CODE_NAME"); }
		}



		public System.String StartPointMarker
		{ 
			get { return base.Get< System.String > ("MARKER_START_POINT"); } 
			set { base.Set (value, "MARKER_START_POINT"); }
		}



		public System.String DistanceBetweenMarkerAndStartP
		{ 
			get { return base.Get< System.String > ("MARKER_DISTANCE_START_POINT"); } 
			set { base.Set (value, "MARKER_DISTANCE_START_POINT"); }
		}



		public System.String MarkerForEndPoint
		{ 
			get { return base.Get< System.String > ("MARKER_END_POINT"); } 
			set { base.Set (value, "MARKER_END_POINT"); }
		}



		public System.String LengthSpecForDistanceBetweenMa
		{ 
			get { return base.Get< System.String > ("MARKER_DISTANCE_END_POINT"); } 
			set { base.Set (value, "MARKER_DISTANCE_END_POINT"); }
		}



		public System.String DistancefromMarkerUOM
		{ 
			get { return base.Get< System.String > ("MARKER_DISTANCE_UNIT"); } 
			set { base.Set (value, "MARKER_DISTANCE_UNIT"); }
		}



		public System.String DistancefromMarkerUOMISOCode
		{ 
			get { return base.Get< System.String > ("MARKER_DISTANCE_UNIT_ISO"); } 
			set { base.Set (value, "MARKER_DISTANCE_UNIT_ISO"); }
		}



		public System.String EquipmentNumberDescription
		{ 
			get { return base.Get< System.String > ("EQKTX"); } 
			set { base.Set (value, "EQKTX"); }
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
	
	[Name("NOTIFICATION")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_NOTIFICATION : BusinessObject<EnosixServiceReport_NOTIFICATION>
	{
		

		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("QMNUM"); } 
			set { base.Set (value, "QMNUM"); }
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



		public System.String NotificationDescription
		{ 
			get { return base.Get< System.String > ("QMTXT"); } 
			set { base.Set (value, "QMTXT"); }
		}



		public System.String NotificationSystemStatus
		{ 
			get { return base.Get< System.String > ("QMSTTXT"); } 
			set { base.Set (value, "QMSTTXT"); }
		}



		public System.String OrderNumber
		{ 
			get { return base.Get< System.String > ("AUFNR"); } 
			set { base.Set (value, "AUFNR"); }
		}



		public System.String PersonIDReportingNotification
		{ 
			get { return base.Get< System.String > ("QMNAM"); } 
			set { base.Set (value, "QMNAM"); }
		}



		public System.String PersonReportingName
		{ 
			get { return base.Get< System.String > ("QMNAM_NAME"); } 
			set { base.Set (value, "QMNAM_NAME"); }
		}



		public System.String CustomerPONumber
		{ 
			get { return base.Get< System.String > ("BSTNK"); } 
			set { base.Set (value, "BSTNK"); }
		}



		public System.DateTime CustomerPurchaseOrderDate
		{ 
			get { return base.Get< System.DateTime > ("BSTDK"); } 
			set { base.Set (value, "BSTDK"); }
		}



		public System.DateTime DateofNotification
		{ 
			get { return base.Get< System.DateTime > ("QMDAT"); } 
			set { base.Set (value, "QMDAT"); }
		}



		public System.DateTime TimeofNotification
		{ 
			get { return base.Get< System.DateTime > ("MZEIT"); } 
			set { base.Set (value, "MZEIT"); }
		}



		public System.String SalesDocument
		{ 
			get { return base.Get< System.String > ("KDAUF"); } 
			set { base.Set (value, "KDAUF"); }
		}



		public System.String SalesDocumentItem
		{ 
			get { return base.Get< System.String > ("KDPOS"); } 
			set { base.Set (value, "KDPOS"); }
		}



		public System.String FunctionalLocation
		{ 
			get { return base.Get< System.String > ("TPLNR"); } 
			set { base.Set (value, "TPLNR"); }
		}



		public System.String FunctionalLocationDescription
		{ 
			get { return base.Get< System.String > ("PLTXT"); } 
			set { base.Set (value, "PLTXT"); }
		}



		public System.String EquipmentNumber
		{ 
			get { return base.Get< System.String > ("EQUNR"); } 
			set { base.Set (value, "EQUNR"); }
		}



		public System.String EquipmentNumberDescription
		{ 
			get { return base.Get< System.String > ("EQKTX"); } 
			set { base.Set (value, "EQKTX"); }
		}



		public System.String Assembly
		{ 
			get { return base.Get< System.String > ("BAUTL"); } 
			set { base.Set (value, "BAUTL"); }
		}



		public System.String AssemblyDescription
		{ 
			get { return base.Get< System.String > ("BAUTX"); } 
			set { base.Set (value, "BAUTX"); }
		}



		public System.String UniqueItemIdentifier
		{ 
			get { return base.Get< System.String > ("UII"); } 
			set { base.Set (value, "UII"); }
		}



		public System.String PriorityType
		{ 
			get { return base.Get< System.String > ("ARTPR"); } 
			set { base.Set (value, "ARTPR"); }
		}



		public System.String PriorityTypeText
		{ 
			get { return base.Get< System.String > ("ARTPRX"); } 
			set { base.Set (value, "ARTPRX"); }
		}



		public System.String Priority
		{ 
			get { return base.Get< System.String > ("PRIOK"); } 
			set { base.Set (value, "PRIOK"); }
		}



		public System.String PriorityText
		{ 
			get { return base.Get< System.String > ("PRIOKX"); } 
			set { base.Set (value, "PRIOKX"); }
		}



		public System.String EffectonOperation
		{ 
			get { return base.Get< System.String > ("AUSWK"); } 
			set { base.Set (value, "AUSWK"); }
		}



		public System.String EffectonOperationText
		{ 
			get { return base.Get< System.String > ("AUSWKT"); } 
			set { base.Set (value, "AUSWKT"); }
		}



		public System.DateTime RequiredStartDate
		{ 
			get { return base.Get< System.DateTime > ("STRMN"); } 
			set { base.Set (value, "STRMN"); }
		}



		public System.DateTime RequiredStartTime
		{ 
			get { return base.Get< System.DateTime > ("STRUR"); } 
			set { base.Set (value, "STRUR"); }
		}



		public System.DateTime RequiredEndDate
		{ 
			get { return base.Get< System.DateTime > ("LTRMN"); } 
			set { base.Set (value, "LTRMN"); }
		}



		public System.DateTime RequestedEndTime
		{ 
			get { return base.Get< System.DateTime > ("LTRUR"); } 
			set { base.Set (value, "LTRUR"); }
		}



		public System.DateTime StartDateofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUSVN"); } 
			set { base.Set (value, "AUSVN"); }
		}



		public System.DateTime StartTimeofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUZTV"); } 
			set { base.Set (value, "AUZTV"); }
		}



		public System.DateTime EndDateofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUSBS"); } 
			set { base.Set (value, "AUSBS"); }
		}



		public System.DateTime EndTimeofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUZTB"); } 
			set { base.Set (value, "AUZTB"); }
		}



		public System.String WorkCenter
		{ 
			get { return base.Get< System.String > ("ARBPL"); } 
			set { base.Set (value, "ARBPL"); }
		}



		public System.String WorkCenterText
		{ 
			get { return base.Get< System.String > ("ARBPL_TEXT"); } 
			set { base.Set (value, "ARBPL_TEXT"); }
		}



		public System.String PlannerGroup
		{ 
			get { return base.Get< System.String > ("INGRP"); } 
			set { base.Set (value, "INGRP"); }
		}



		public System.String PlannerGroupName
		{ 
			get { return base.Get< System.String > ("INNAM"); } 
			set { base.Set (value, "INNAM"); }
		}



		public System.String SalesOrganization
		{ 
			get { return base.Get< System.String > ("VKORG"); } 
			set { base.Set (value, "VKORG"); }
		}



		public System.String SalesOrganizationName
		{ 
			get { return base.Get< System.String > ("VKORG_VTEXT"); } 
			set { base.Set (value, "VKORG_VTEXT"); }
		}



		public System.String DistributionChannel
		{ 
			get { return base.Get< System.String > ("VTWEG"); } 
			set { base.Set (value, "VTWEG"); }
		}



		public System.String DistributionChannelName
		{ 
			get { return base.Get< System.String > ("VTWEG_VTEXT"); } 
			set { base.Set (value, "VTWEG_VTEXT"); }
		}



		public System.String Division
		{ 
			get { return base.Get< System.String > ("SPART"); } 
			set { base.Set (value, "SPART"); }
		}



		public System.String DivisionName
		{ 
			get { return base.Get< System.String > ("SPART_VTEXT"); } 
			set { base.Set (value, "SPART_VTEXT"); }
		}



		public System.String SalesOffice
		{ 
			get { return base.Get< System.String > ("VKBUR"); } 
			set { base.Set (value, "VKBUR"); }
		}



		public System.String SalesOfficeName
		{ 
			get { return base.Get< System.String > ("VKBUR_BEZEI"); } 
			set { base.Set (value, "VKBUR_BEZEI"); }
		}



		public System.String SalesGroup
		{ 
			get { return base.Get< System.String > ("VKGRP"); } 
			set { base.Set (value, "VKGRP"); }
		}



		public System.String SalesGroupName
		{ 
			get { return base.Get< System.String > ("VKGRP_BEZEI"); } 
			set { base.Set (value, "VKGRP_BEZEI"); }
		}


	}
	
	[Name("MALFUNCTION_BREAKDOWN")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_MALFUNCTION_BREAKDOWN : BusinessObject<EnosixServiceReport_MALFUNCTION_BREAKDOWN>
	{
		

		public System.DateTime StartDateofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUSVN"); } 
			set { base.Set (value, "AUSVN"); }
		}



		public System.DateTime StartTimeofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUZTV"); } 
			set { base.Set (value, "AUZTV"); }
		}



		public System.DateTime EndDateofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUSBS"); } 
			set { base.Set (value, "AUSBS"); }
		}



		public System.DateTime EndTimeofMalfunction
		{ 
			get { return base.Get< System.DateTime > ("AUZTB"); } 
			set { base.Set (value, "AUZTB"); }
		}



		public System.String BreakdownIndicator
		{ 
			get { return base.Get< System.String > ("MSAUS"); } 
			set { base.Set (value, "MSAUS"); }
		}



		public System.Single BreakdownDuration
		{ 
			get { return base.Get< System.Single > ("AUSZT"); } 
			set { base.Set (value, "AUSZT"); }
		}



		public System.String BreakdownDurationUnit
		{ 
			get { return base.Get< System.String > ("MAUEH"); } 
			set { base.Set (value, "MAUEH"); }
		}


	}
	
	[Name("ADDRESS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_ADDRESS : BusinessObject<EnosixServiceReport_ADDRESS>
	{
		

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



		public System.String PartnerName2
		{ 
			get { return base.Get< System.String > ("NAME2"); } 
			set { base.Set (value, "NAME2"); }
		}



		public System.String Name3
		{ 
			get { return base.Get< System.String > ("NAME3"); } 
			set { base.Set (value, "NAME3"); }
		}



		public System.String Name4
		{ 
			get { return base.Get< System.String > ("NAME4"); } 
			set { base.Set (value, "NAME4"); }
		}



		public System.String NameText
		{ 
			get { return base.Get< System.String > ("NAME_TXT"); } 
			set { base.Set (value, "NAME_TXT"); }
		}



		public System.String COName
		{ 
			get { return base.Get< System.String > ("NAME_CO"); } 
			set { base.Set (value, "NAME_CO"); }
		}



		public System.String City
		{ 
			get { return base.Get< System.String > ("CITY1"); } 
			set { base.Set (value, "CITY1"); }
		}



		public System.String District
		{ 
			get { return base.Get< System.String > ("CITY2"); } 
			set { base.Set (value, "CITY2"); }
		}



		public System.String CityCode
		{ 
			get { return base.Get< System.String > ("CITY_CODE"); } 
			set { base.Set (value, "CITY_CODE"); }
		}



		public System.String DistrictCode
		{ 
			get { return base.Get< System.String > ("CITYP_CODE"); } 
			set { base.Set (value, "CITYP_CODE"); }
		}



		public System.String HomeCity
		{ 
			get { return base.Get< System.String > ("HOME_CITY"); } 
			set { base.Set (value, "HOME_CITY"); }
		}



		public System.String HomeCityCode
		{ 
			get { return base.Get< System.String > ("CITYH_CODE"); } 
			set { base.Set (value, "CITYH_CODE"); }
		}



		public System.String CityFileTestStatus
		{ 
			get { return base.Get< System.String > ("CHCKSTATUS"); } 
			set { base.Set (value, "CHCKSTATUS"); }
		}



		public System.String RegionGroup
		{ 
			get { return base.Get< System.String > ("REGIOGROUP"); } 
			set { base.Set (value, "REGIOGROUP"); }
		}



		public System.String PostalCode
		{ 
			get { return base.Get< System.String > ("POST_CODE1"); } 
			set { base.Set (value, "POST_CODE1"); }
		}



		public System.String POBoxPostalCode
		{ 
			get { return base.Get< System.String > ("POST_CODE2"); } 
			set { base.Set (value, "POST_CODE2"); }
		}



		public System.String CompanyPostalCode
		{ 
			get { return base.Get< System.String > ("POST_CODE3"); } 
			set { base.Set (value, "POST_CODE3"); }
		}



		public System.String PostalCodeExtension1
		{ 
			get { return base.Get< System.String > ("PCODE1_EXT"); } 
			set { base.Set (value, "PCODE1_EXT"); }
		}



		public System.String PostalCodeExtension2
		{ 
			get { return base.Get< System.String > ("PCODE2_EXT"); } 
			set { base.Set (value, "PCODE2_EXT"); }
		}



		public System.String PostalCodeExtension3
		{ 
			get { return base.Get< System.String > ("PCODE3_EXT"); } 
			set { base.Set (value, "PCODE3_EXT"); }
		}



		public System.String POBox
		{ 
			get { return base.Get< System.String > ("PO_BOX"); } 
			set { base.Set (value, "PO_BOX"); }
		}



		public System.String NotSupportedDontUseP
		{ 
			get { return base.Get< System.String > ("DONT_USE_P"); } 
			set { base.Set (value, "DONT_USE_P"); }
		}



		public System.String POBoxFlag
		{ 
			get { return base.Get< System.String > ("PO_BOX_NUM"); } 
			set { base.Set (value, "PO_BOX_NUM"); }
		}



		public System.String POBoxCity
		{ 
			get { return base.Get< System.String > ("PO_BOX_LOC"); } 
			set { base.Set (value, "PO_BOX_LOC"); }
		}



		public System.String POBoxCityCode
		{ 
			get { return base.Get< System.String > ("CITY_CODE2"); } 
			set { base.Set (value, "CITY_CODE2"); }
		}



		public System.String POBoxRegion
		{ 
			get { return base.Get< System.String > ("PO_BOX_REG"); } 
			set { base.Set (value, "PO_BOX_REG"); }
		}



		public System.String POBoxCountry
		{ 
			get { return base.Get< System.String > ("PO_BOX_CTY"); } 
			set { base.Set (value, "PO_BOX_CTY"); }
		}



		public System.String NotSupportedPostDeliveryDistri
		{ 
			get { return base.Get< System.String > ("POSTALAREA"); } 
			set { base.Set (value, "POSTALAREA"); }
		}



		public System.String TransportationZone
		{ 
			get { return base.Get< System.String > ("TRANSPZONE"); } 
			set { base.Set (value, "TRANSPZONE"); }
		}



		public System.String Street
		{ 
			get { return base.Get< System.String > ("STREET"); } 
			set { base.Set (value, "STREET"); }
		}



		public System.String NotSupportedStreetAddressUndel
		{ 
			get { return base.Get< System.String > ("DONT_USE_S"); } 
			set { base.Set (value, "DONT_USE_S"); }
		}



		public System.String CityStreetNumber
		{ 
			get { return base.Get< System.String > ("STREETCODE"); } 
			set { base.Set (value, "STREETCODE"); }
		}



		public System.String NotSupportedStreetNameAbbrevia
		{ 
			get { return base.Get< System.String > ("STREETABBR"); } 
			set { base.Set (value, "STREETABBR"); }
		}



		public System.String HouseNumber
		{ 
			get { return base.Get< System.String > ("HOUSE_NUM1"); } 
			set { base.Set (value, "HOUSE_NUM1"); }
		}



		public System.String HouseNumberSupplement
		{ 
			get { return base.Get< System.String > ("HOUSE_NUM2"); } 
			set { base.Set (value, "HOUSE_NUM2"); }
		}



		public System.String NotsupportedHouseNumberRange
		{ 
			get { return base.Get< System.String > ("HOUSE_NUM3"); } 
			set { base.Set (value, "HOUSE_NUM3"); }
		}



		public System.String Street2
		{ 
			get { return base.Get< System.String > ("STR_SUPPL1"); } 
			set { base.Set (value, "STR_SUPPL1"); }
		}



		public System.String Street3
		{ 
			get { return base.Get< System.String > ("STR_SUPPL2"); } 
			set { base.Set (value, "STR_SUPPL2"); }
		}



		public System.String Street4
		{ 
			get { return base.Get< System.String > ("STR_SUPPL3"); } 
			set { base.Set (value, "STR_SUPPL3"); }
		}



		public System.String AssetLocation
		{ 
			get { return base.Get< System.String > ("LOCATION"); } 
			set { base.Set (value, "LOCATION"); }
		}



		public System.String BuildingNumber
		{ 
			get { return base.Get< System.String > ("BUILDING"); } 
			set { base.Set (value, "BUILDING"); }
		}



		public System.String FloorInbuilding
		{ 
			get { return base.Get< System.String > ("FLOOR"); } 
			set { base.Set (value, "FLOOR"); }
		}



		public System.String RoomApartmentNumber
		{ 
			get { return base.Get< System.String > ("ROOMNUMBER"); } 
			set { base.Set (value, "ROOMNUMBER"); }
		}



		public System.String Country
		{ 
			get { return base.Get< System.String > ("COUNTRY"); } 
			set { base.Set (value, "COUNTRY"); }
		}



		public System.String Language
		{ 
			get { return base.Get< System.String > ("LANGU"); } 
			set { base.Set (value, "LANGU"); }
		}



		public System.String Region
		{ 
			get { return base.Get< System.String > ("REGION"); } 
			set { base.Set (value, "REGION"); }
		}



		public System.String SearchTerm1
		{ 
			get { return base.Get< System.String > ("SORT1"); } 
			set { base.Set (value, "SORT1"); }
		}



		public System.String SearchTerm2
		{ 
			get { return base.Get< System.String > ("SORT2"); } 
			set { base.Set (value, "SORT2"); }
		}



		public System.String NotSupportedPhoneticSearchSort
		{ 
			get { return base.Get< System.String > ("SORT_PHN"); } 
			set { base.Set (value, "SORT_PHN"); }
		}



		public System.String NotSupportedAddressDataSourceK
		{ 
			get { return base.Get< System.String > ("ADDRORIGIN"); } 
			set { base.Set (value, "ADDRORIGIN"); }
		}



		public System.String Extension1
		{ 
			get { return base.Get< System.String > ("EXTENSION1"); } 
			set { base.Set (value, "EXTENSION1"); }
		}



		public System.String Extension2
		{ 
			get { return base.Get< System.String > ("EXTENSION2"); } 
			set { base.Set (value, "EXTENSION2"); }
		}



		public System.String TimeZone
		{ 
			get { return base.Get< System.String > ("TIME_ZONE"); } 
			set { base.Set (value, "TIME_ZONE"); }
		}



		public System.String TaxJurisdiction
		{ 
			get { return base.Get< System.String > ("TAXJURCODE"); } 
			set { base.Set (value, "TAXJURCODE"); }
		}



		public System.String NotsupportedPhysicalAddressID
		{ 
			get { return base.Get< System.String > ("ADDRESS_ID"); } 
			set { base.Set (value, "ADDRESS_ID"); }
		}



		public System.String AddressNotes
		{ 
			get { return base.Get< System.String > ("REMARK"); } 
			set { base.Set (value, "REMARK"); }
		}



		public System.String AddressOriginalLanguage
		{ 
			get { return base.Get< System.String > ("LANGU_CREA"); } 
			set { base.Set (value, "LANGU_CREA"); }
		}



		public System.String POBoxLobby
		{ 
			get { return base.Get< System.String > ("PO_BOX_LOBBY"); } 
			set { base.Set (value, "PO_BOX_LOBBY"); }
		}



		public System.String DeliveryServiceType
		{ 
			get { return base.Get< System.String > ("DELI_SERV_TYPE"); } 
			set { base.Set (value, "DELI_SERV_TYPE"); }
		}



		public System.String DeliveryServiceNumber
		{ 
			get { return base.Get< System.String > ("DELI_SERV_NUMBER"); } 
			set { base.Set (value, "DELI_SERV_NUMBER"); }
		}



		public System.String DefaultCommunicationMethod
		{ 
			get { return base.Get< System.String > ("DEFLT_COMM"); } 
			set { base.Set (value, "DEFLT_COMM"); }
		}


	}
	
	[Name("CONTACT")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_CONTACT : BusinessObject<EnosixServiceReport_CONTACT>
	{
		

		public System.String PartnerFunction
		{ 
			get { return base.Get< System.String > ("PARTN_ROLE"); } 
			set { base.Set (value, "PARTN_ROLE"); }
		}



		public System.String Partner
		{ 
			get { return base.Get< System.String > ("PARTNER"); } 
			set { base.Set (value, "PARTNER"); }
		}



		public System.String Name
		{ 
			get { return base.Get< System.String > ("NAME1"); } 
			set { base.Set (value, "NAME1"); }
		}



		public System.String TelephoneNumber
		{ 
			get { return base.Get< System.String > ("TEL_NUMBER"); } 
			set { base.Set (value, "TEL_NUMBER"); }
		}


	}
	
	[Name("TIMESHEET")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_TIMESHEET : BusinessObject<EnosixServiceReport_TIMESHEET>
	{
		

		public System.String Counter
		{ 
			get { return base.Get< System.String > ("COUNTER"); } 
			set { base.Set (value, "COUNTER"); }
		}



		public System.DateTime WorkDate
		{ 
			get { return base.Get< System.DateTime > ("WORKDATE"); } 
			set { base.Set (value, "WORKDATE"); }
		}



		public System.String EmployeeNumber
		{ 
			get { return base.Get< System.String > ("EMPLOYEENUMBER"); } 
			set { base.Set (value, "EMPLOYEENUMBER"); }
		}



		public System.String SenderCostCenter
		{ 
			get { return base.Get< System.String > ("SEND_CCTR"); } 
			set { base.Set (value, "SEND_CCTR"); }
		}



		public System.String SenderBusinessProcess
		{ 
			get { return base.Get< System.String > ("SENBUSPROC"); } 
			set { base.Set (value, "SENBUSPROC"); }
		}



		public System.String ActivityType
		{ 
			get { return base.Get< System.String > ("ACTTYPE"); } 
			set { base.Set (value, "ACTTYPE"); }
		}



		public System.String PurchaseOrderNr
		{ 
			get { return base.Get< System.String > ("PO_NUMBER"); } 
			set { base.Set (value, "PO_NUMBER"); }
		}



		public System.String SendingPurchaseOrderItem
		{ 
			get { return base.Get< System.String > ("PO_ITEM"); } 
			set { base.Set (value, "PO_ITEM"); }
		}



		public System.String Service
		{ 
			get { return base.Get< System.String > ("SERVICE"); } 
			set { base.Set (value, "SERVICE"); }
		}



		public System.String ReceiverCostCenter
		{ 
			get { return base.Get< System.String > ("REC_CCTR"); } 
			set { base.Set (value, "REC_CCTR"); }
		}



		public System.String ReceiverOrder
		{ 
			get { return base.Get< System.String > ("REC_ORDER"); } 
			set { base.Set (value, "REC_ORDER"); }
		}



		public System.String NetworkNumber
		{ 
			get { return base.Get< System.String > ("NETWORK"); } 
			set { base.Set (value, "NETWORK"); }
		}



		public System.String ActivityNumber
		{ 
			get { return base.Get< System.String > ("AVTIVITY"); } 
			set { base.Set (value, "AVTIVITY"); }
		}



		public System.String SubOperation
		{ 
			get { return base.Get< System.String > ("SUB_ACTIVITY"); } 
			set { base.Set (value, "SUB_ACTIVITY"); }
		}



		public System.String Workcenter
		{ 
			get { return base.Get< System.String > ("WORK_CNTR"); } 
			set { base.Set (value, "WORK_CNTR"); }
		}



		public System.String CapacityCategory
		{ 
			get { return base.Get< System.String > ("CAPA_CATEGORY"); } 
			set { base.Set (value, "CAPA_CATEGORY"); }
		}



		public System.SByte SplitNumber
		{ 
			get { return base.Get< System.SByte > ("SPLIT"); } 
			set { base.Set (value, "SPLIT"); }
		}



		public System.String WBSElement
		{ 
			get { return base.Get< System.String > ("WBS_ELEMENT"); } 
			set { base.Set (value, "WBS_ELEMENT"); }
		}



		public System.String ReceiverSalesOrder
		{ 
			get { return base.Get< System.String > ("RECSALEORD"); } 
			set { base.Set (value, "RECSALEORD"); }
		}



		public System.String ReceiverSalesOrderItemNumber
		{ 
			get { return base.Get< System.String > ("RECITEM"); } 
			set { base.Set (value, "RECITEM"); }
		}



		public System.String ReceiverCostObject
		{ 
			get { return base.Get< System.String > ("RECCOSTOBJ"); } 
			set { base.Set (value, "RECCOSTOBJ"); }
		}



		public System.String ReceiverBusinessProcess
		{ 
			get { return base.Get< System.String > ("RECBUSPROC"); } 
			set { base.Set (value, "RECBUSPROC"); }
		}



		public System.String AttendanceOrAbsenceType
		{ 
			get { return base.Get< System.String > ("ABS_ATT_TYPE"); } 
			set { base.Set (value, "ABS_ATT_TYPE"); }
		}



		public System.String WageType
		{ 
			get { return base.Get< System.String > ("WAGETYPE"); } 
			set { base.Set (value, "WAGETYPE"); }
		}



		public System.String TripNumber
		{ 
			get { return base.Get< System.String > ("TRIPNO"); } 
			set { base.Set (value, "TRIPNO"); }
		}



		public System.String OvertimeCompensationType
		{ 
			get { return base.Get< System.String > ("OT_COMP_TYPE"); } 
			set { base.Set (value, "OT_COMP_TYPE"); }
		}



		public System.String WorkCenterTaxArea
		{ 
			get { return base.Get< System.String > ("WORKTAXAREA"); } 
			set { base.Set (value, "WORKTAXAREA"); }
		}



		public System.Decimal ValuationBasis
		{ 
			get { return base.Get< System.Decimal > ("VALUATION_BASIS"); } 
			set { base.Set (value, "VALUATION_BASIS"); }
		}



		public System.String OrderCurrency
		{ 
			get { return base.Get< System.String > ("CURRENCY"); } 
			set { base.Set (value, "CURRENCY"); }
		}



		public System.String ISOCurrencyCode
		{ 
			get { return base.Get< System.String > ("CURRENCY_ISO"); } 
			set { base.Set (value, "CURRENCY_ISO"); }
		}



		public System.String ExtraPayIndicator
		{ 
			get { return base.Get< System.String > ("EXTRA_PAY_INDIC"); } 
			set { base.Set (value, "EXTRA_PAY_INDIC"); }
		}



		public System.String PayScaleGroup
		{ 
			get { return base.Get< System.String > ("PAYSCALEGROUP"); } 
			set { base.Set (value, "PAYSCALEGROUP"); }
		}



		public System.String PayScaleLevel
		{ 
			get { return base.Get< System.String > ("PAYSCALELEVEL"); } 
			set { base.Set (value, "PAYSCALELEVEL"); }
		}



		public System.String PremiumNumber
		{ 
			get { return base.Get< System.String > ("BONUSTYPE"); } 
			set { base.Set (value, "BONUSTYPE"); }
		}



		public System.String PremiumIndicator
		{ 
			get { return base.Get< System.String > ("BONUSVALUE"); } 
			set { base.Set (value, "BONUSVALUE"); }
		}



		public System.String Position
		{ 
			get { return base.Get< System.String > ("POSITION"); } 
			set { base.Set (value, "POSITION"); }
		}



		public System.String ControllingArea
		{ 
			get { return base.Get< System.String > ("CO_AREA"); } 
			set { base.Set (value, "CO_AREA"); }
		}



		public System.String TransactionCurrency
		{ 
			get { return base.Get< System.String > ("TRANS_CURR"); } 
			set { base.Set (value, "TRANS_CURR"); }
		}



		public System.String TransactionISOcurrencyCode
		{ 
			get { return base.Get< System.String > ("TRANS_CURR_ISO"); } 
			set { base.Set (value, "TRANS_CURR_ISO"); }
		}



		public System.Decimal Price
		{ 
			get { return base.Get< System.Decimal > ("PRICE"); } 
			set { base.Set (value, "PRICE"); }
		}



		public System.String MainWorkcenterPlant
		{ 
			get { return base.Get< System.String > ("PLANT"); } 
			set { base.Set (value, "PLANT"); }
		}



		public System.String AccountingIndicator
		{ 
			get { return base.Get< System.String > ("CALC_MOTIVE"); } 
			set { base.Set (value, "CALC_MOTIVE"); }
		}



		public System.Decimal Hours
		{ 
			get { return base.Get< System.Decimal > ("CATSHOURS"); } 
			set { base.Set (value, "CATSHOURS"); }
		}



		public System.String UnitOfMeasure
		{ 
			get { return base.Get< System.String > ("UNIT"); } 
			set { base.Set (value, "UNIT"); }
		}



		public System.String ISOcodeUnitOfMeasurement
		{ 
			get { return base.Get< System.String > ("ISOCODE_UNIT"); } 
			set { base.Set (value, "ISOCODE_UNIT"); }
		}



		public System.DateTime StartTime
		{ 
			get { return base.Get< System.DateTime > ("STARTTIME"); } 
			set { base.Set (value, "STARTTIME"); }
		}



		public System.DateTime EndTime
		{ 
			get { return base.Get< System.DateTime > ("ENDTIME"); } 
			set { base.Set (value, "ENDTIME"); }
		}



		public System.String PreviousDayIndicator
		{ 
			get { return base.Get< System.String > ("PREVIOUS_DAY"); } 
			set { base.Set (value, "PREVIOUS_DAY"); }
		}



		public System.String RecordForFullDay
		{ 
			get { return base.Get< System.String > ("ALL_DAY_FLAG"); } 
			set { base.Set (value, "ALL_DAY_FLAG"); }
		}



		public System.Decimal RemainingWork
		{ 
			get { return base.Get< System.Decimal > ("REM_WORK"); } 
			set { base.Set (value, "REM_WORK"); }
		}



		public System.DateTime ForecastFinishDate
		{ 
			get { return base.Get< System.DateTime > ("FCST_FIN_DATE"); } 
			set { base.Set (value, "FCST_FIN_DATE"); }
		}



		public System.String FinalConfirmation
		{ 
			get { return base.Get< System.String > ("FIN_CONF"); } 
			set { base.Set (value, "FIN_CONF"); }
		}



		public System.String ShortText
		{ 
			get { return base.Get< System.String > ("SHORTTEXT"); } 
			set { base.Set (value, "SHORTTEXT"); }
		}



		public System.String PartialConfirmation
		{ 
			get { return base.Get< System.String > ("PART_CONF"); } 
			set { base.Set (value, "PART_CONF"); }
		}



		public System.String ExternalLogicalSystem
		{ 
			get { return base.Get< System.String > ("EXTSYSTEM"); } 
			set { base.Set (value, "EXTSYSTEM"); }
		}



		public System.String ExternalApplication
		{ 
			get { return base.Get< System.String > ("EXTAPPLICATION"); } 
			set { base.Set (value, "EXTAPPLICATION"); }
		}



		public System.String ExternalDocumentNumber
		{ 
			get { return base.Get< System.String > ("EXTDOCUMENTNO"); } 
			set { base.Set (value, "EXTDOCUMENTNO"); }
		}



		public System.DateTime CreatedOn
		{ 
			get { return base.Get< System.DateTime > ("CREATIONDATE"); } 
			set { base.Set (value, "CREATIONDATE"); }
		}



		public System.DateTime TimeOfEntry
		{ 
			get { return base.Get< System.DateTime > ("ENTRYTIME"); } 
			set { base.Set (value, "ENTRYTIME"); }
		}



		public System.String UserWhoCreatedRecord
		{ 
			get { return base.Get< System.String > ("CREATING_ADMIN"); } 
			set { base.Set (value, "CREATING_ADMIN"); }
		}



		public System.DateTime DateLastChanged
		{ 
			get { return base.Get< System.DateTime > ("LASTCHANGED_ON"); } 
			set { base.Set (value, "LASTCHANGED_ON"); }
		}



		public System.DateTime TimeLastChanged
		{ 
			get { return base.Get< System.DateTime > ("LASTCHANGED_AT"); } 
			set { base.Set (value, "LASTCHANGED_AT"); }
		}



		public System.String LastChangedBy
		{ 
			get { return base.Get< System.String > ("CHANGED_BY"); } 
			set { base.Set (value, "CHANGED_BY"); }
		}



		public System.String PersonWhoApprovedData
		{ 
			get { return base.Get< System.String > ("APPROVING_ADMIN"); } 
			set { base.Set (value, "APPROVING_ADMIN"); }
		}



		public System.DateTime DateOfApproval
		{ 
			get { return base.Get< System.DateTime > ("DATE_OF_APPROVAL"); } 
			set { base.Set (value, "DATE_OF_APPROVAL"); }
		}



		public System.String WorkitemID
		{ 
			get { return base.Get< System.String > ("WORKITEMID"); } 
			set { base.Set (value, "WORKITEMID"); }
		}



		public System.String LogicalSystem
		{ 
			get { return base.Get< System.String > ("LOG_SYSTEM"); } 
			set { base.Set (value, "LOG_SYSTEM"); }
		}



		public System.String SearchResultStatus
		{ 
			get { return base.Get< System.String > ("STATUS"); } 
			set { base.Set (value, "STATUS"); }
		}



		public System.String ReferenceCounter
		{ 
			get { return base.Get< System.String > ("REFCOUNTER"); } 
			set { base.Set (value, "REFCOUNTER"); }
		}



		public System.String ReasonForRejection
		{ 
			get { return base.Get< System.String > ("REASON"); } 
			set { base.Set (value, "REASON"); }
		}



		public System.String DocumentNumber
		{ 
			get { return base.Get< System.String > ("CATS_DOC_NO"); } 
			set { base.Set (value, "CATS_DOC_NO"); }
		}



		public System.String StatisticalKeyFigure
		{ 
			get { return base.Get< System.String > ("STATKEYFIG"); } 
			set { base.Set (value, "STATKEYFIG"); }
		}



		public System.Decimal Quantity
		{ 
			get { return base.Get< System.Decimal > ("QUANTITY"); } 
			set { base.Set (value, "QUANTITY"); }
		}



		public System.String QuantityUnitOfMeasurement
		{ 
			get { return base.Get< System.String > ("UNITQ"); } 
			set { base.Set (value, "UNITQ"); }
		}



		public System.String QuantityISOcodeUnitOfMeasureme
		{ 
			get { return base.Get< System.String > ("ISO_UNITQ"); } 
			set { base.Set (value, "ISO_UNITQ"); }
		}



		public System.Decimal Amount
		{ 
			get { return base.Get< System.Decimal > ("AMOUNT"); } 
			set { base.Set (value, "AMOUNT"); }
		}



		public System.String LongText
		{ 
			get { return base.Get< System.String > ("LONGTEXT"); } 
			set { base.Set (value, "LONGTEXT"); }
		}



		public System.String Fund
		{ 
			get { return base.Get< System.String > ("FUND"); } 
			set { base.Set (value, "FUND"); }
		}



		public System.String FunctionalArea
		{ 
			get { return base.Get< System.String > ("FUNC_AREA"); } 
			set { base.Set (value, "FUNC_AREA"); }
		}



		public System.String Grant
		{ 
			get { return base.Get< System.String > ("GRANT_NBR"); } 
			set { base.Set (value, "GRANT_NBR"); }
		}



		public System.String SenderFund
		{ 
			get { return base.Get< System.String > ("SEND_FUND"); } 
			set { base.Set (value, "SEND_FUND"); }
		}



		public System.String SendingFunctionalArea
		{ 
			get { return base.Get< System.String > ("SEND_FUNCTION"); } 
			set { base.Set (value, "SEND_FUNCTION"); }
		}



		public System.String SenderGrant
		{ 
			get { return base.Get< System.String > ("SEND_GRANT"); } 
			set { base.Set (value, "SEND_GRANT"); }
		}



		public System.String ProjectIDGUID
		{ 
			get { return base.Get< System.String > ("CPR_GUID"); } 
			set { base.Set (value, "CPR_GUID"); }
		}



		public System.String ExternalProjectID
		{ 
			get { return base.Get< System.String > ("CPR_EXTID"); } 
			set { base.Set (value, "CPR_EXTID"); }
		}



		public System.String ObjectID
		{ 
			get { return base.Get< System.String > ("CPR_OBJGUID"); } 
			set { base.Set (value, "CPR_OBJGUID"); }
		}



		public System.String ExternalIDofProjectSubobject
		{ 
			get { return base.Get< System.String > ("CPR_OBJGEXTID"); } 
			set { base.Set (value, "CPR_OBJGEXTID"); }
		}



		public System.String ProjectsObjectType
		{ 
			get { return base.Get< System.String > ("CPR_OBJTYPE"); } 
			set { base.Set (value, "CPR_OBJTYPE"); }
		}



		public System.String FundLong
		{ 
			get { return base.Get< System.String > ("FUND_LONG"); } 
			set { base.Set (value, "FUND_LONG"); }
		}



		public System.String SenderFundLong
		{ 
			get { return base.Get< System.String > ("SEND_FUND_LONG"); } 
			set { base.Set (value, "SEND_FUND_LONG"); }
		}



		public System.String BudgetPeriod
		{ 
			get { return base.Get< System.String > ("BUDGET_PERIOD"); } 
			set { base.Set (value, "BUDGET_PERIOD"); }
		}



		public System.String SenderBudgetPeriod
		{ 
			get { return base.Get< System.String > ("SEND_BUDGET_PERIOD"); } 
			set { base.Set (value, "SEND_BUDGET_PERIOD"); }
		}


	}
	
	[Name("TCA_TEXT")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_TCA_TEXT : BusinessObject<EnosixServiceReport_TCA_TEXT>
	{
		

		public System.DateTime CreateDate
		{ 
			get { return base.Get< System.DateTime > ("ERDAT"); } 
			set { base.Set (value, "ERDAT"); }
		}



		public System.String ObjectPartCodeGroup
		{ 
			get { return base.Get< System.String > ("OTGRP"); } 
			set { base.Set (value, "OTGRP"); }
		}



		public System.String ObjectPartCode
		{ 
			get { return base.Get< System.String > ("OTEIL"); } 
			set { base.Set (value, "OTEIL"); }
		}



		public System.String ProblemCodeGroup
		{ 
			get { return base.Get< System.String > ("FEGRP"); } 
			set { base.Set (value, "FEGRP"); }
		}



		public System.String ProblemorDamageCode
		{ 
			get { return base.Get< System.String > ("FECOD"); } 
			set { base.Set (value, "FECOD"); }
		}



		public System.String ItemLongText
		{ 
			get { return base.Get< System.String > ("ITEM_LONGTXT"); } 
			set { base.Set (value, "ITEM_LONGTXT"); }
		}



		public System.String TaskCodeGroup
		{ 
			get { return base.Get< System.String > ("MNGRP"); } 
			set { base.Set (value, "MNGRP"); }
		}



		public System.String TaskCode
		{ 
			get { return base.Get< System.String > ("MNCOD"); } 
			set { base.Set (value, "MNCOD"); }
		}



		public System.String TaskLongText
		{ 
			get { return base.Get< System.String > ("TASK_LONGTXT"); } 
			set { base.Set (value, "TASK_LONGTXT"); }
		}



		public System.String CauseCodeGroup
		{ 
			get { return base.Get< System.String > ("URGRP"); } 
			set { base.Set (value, "URGRP"); }
		}



		public System.String CauseCode
		{ 
			get { return base.Get< System.String > ("URCOD"); } 
			set { base.Set (value, "URCOD"); }
		}



		public System.String CauseLongText
		{ 
			get { return base.Get< System.String > ("CAUSE_LONGTXT"); } 
			set { base.Set (value, "CAUSE_LONGTXT"); }
		}



		public System.String ActivityCodeGroup
		{ 
			get { return base.Get< System.String > ("MFGRP"); } 
			set { base.Set (value, "MFGRP"); }
		}



		public System.String ActivityCode
		{ 
			get { return base.Get< System.String > ("MFCOD"); } 
			set { base.Set (value, "MFCOD"); }
		}



		public System.String ActivityLongText
		{ 
			get { return base.Get< System.String > ("ACTIVITY_LONGTXT"); } 
			set { base.Set (value, "ACTIVITY_LONGTXT"); }
		}


	}
	
	[Name("ZZSAFETYCHKLST")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_ZZSAFETYCHKLST : BusinessObject<EnosixServiceReport_ZZSAFETYCHKLST>
	{
		

		public System.Decimal DateTime
		{ 
			get { return base.Get< System.Decimal > ("ZDATETIME"); } 
			set { base.Set (value, "ZDATETIME"); }
		}



		public System.String ItemNum
		{ 
			get { return base.Get< System.String > ("ITEM_NUM"); } 
			set { base.Set (value, "ITEM_NUM"); }
		}



		public System.String Selected
		{ 
			get { return base.Get< System.String > ("SELECTED"); } 
			set { base.Set (value, "SELECTED"); }
		}



		public System.String Sort
		{ 
			get { return base.Get< System.String > ("SORT"); } 
			set { base.Set (value, "SORT"); }
		}



		public System.String Question
		{ 
			get { return base.Get< System.String > ("QUESTION"); } 
			set { base.Set (value, "QUESTION"); }
		}


	}
	
	[Name("ZZCONTROL")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_ZZCONTROL : BusinessObject<EnosixServiceReport_ZZCONTROL>
	{
		

		public System.String ControlModel
		{ 
			get { return base.Get< System.String > ("ZZMODEL"); } 
			set { base.Set (value, "ZZMODEL"); }
		}



		public System.String ControlSerialNumber
		{ 
			get { return base.Get< System.String > ("ZZSERIALNO"); } 
			set { base.Set (value, "ZZSERIALNO"); }
		}



		public System.String ControlManufacturer
		{ 
			get { return base.Get< System.String > ("ZZMANUFACTURER"); } 
			set { base.Set (value, "ZZMANUFACTURER"); }
		}


	}
	
	[Name("ZZPDF")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceReport_ZZPDF : BusinessObject<EnosixServiceReport_ZZPDF>
	{
		

		public System.String ZZPDFB64STR
		{ 
			get { return base.Get< System.String > ("ZZPDFB64STR"); } 
			set { base.Set (value, "ZZPDFB64STR"); }
		}


	}
	
}
