






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
     [Header( "HEADER" )]   
	
	
	[RecordKeyStructure("EnosixObjKey")]
	
	public partial class EnosixServiceOrder : BusinessObject<EnosixServiceOrder> 
	{
		
		
		public virtual ICollection<EnosixServiceOrder_ADDRESS> ADDRESS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceOrder_ADDRESS>("ADDRESS_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceOrder_OPERATIONS> OPERATIONS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceOrder_OPERATIONS>("OPERATIONS_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceOrder_OBJECTLIST> OBJECTLIST_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceOrder_OBJECTLIST>("OBJECTLIST_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceOrder_PARTNERS> PARTNERS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceOrder_PARTNERS>("PARTNERS_Collection");
			}
		}

		

		#region Header Properties

		

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



		public System.String Description
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



		public System.String AssemblyExternalGUID
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



		public System.String LinearLength
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



		public System.String EquipmentDescription
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


		
		#endregion

		
	}
	
	[Name("ADDRESS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceOrder_ADDRESS : BusinessObject<EnosixServiceOrder_ADDRESS>
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



		public System.String Name1
		{ 
			get { return base.Get< System.String > ("NAME1"); } 
			set { base.Set (value, "NAME1"); }
		}



		public System.String Name2
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



		public System.String CityPostalCode
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



		public System.String TransportationZoneToFrom
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



		public System.String Street5
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



		public System.String CountryKey
		{ 
			get { return base.Get< System.String > ("COUNTRY"); } 
			set { base.Set (value, "COUNTRY"); }
		}



		public System.String LanguageKey
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



		public System.String AddressTimeZone
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



		public System.String CommunicationMethod
		{ 
			get { return base.Get< System.String > ("DEFLT_COMM"); } 
			set { base.Set (value, "DEFLT_COMM"); }
		}


	}
	
	[Name("OPERATIONS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceOrder_OPERATIONS : BusinessObject<EnosixServiceOrder_OPERATIONS>
	{
		

		public System.String OperationActivityNumber
		{ 
			get { return base.Get< System.String > ("ACTIVITY"); } 
			set { base.Set (value, "ACTIVITY"); }
		}



		public System.String SubOperation
		{ 
			get { return base.Get< System.String > ("SUB_ACTIVITY"); } 
			set { base.Set (value, "SUB_ACTIVITY"); }
		}



		public System.String ControlKey
		{ 
			get { return base.Get< System.String > ("CONTROL_KEY"); } 
			set { base.Set (value, "CONTROL_KEY"); }
		}



		public System.String Workcenter
		{ 
			get { return base.Get< System.String > ("WORK_CNTR"); } 
			set { base.Set (value, "WORK_CNTR"); }
		}



		public System.String Plant
		{ 
			get { return base.Get< System.String > ("PLANT"); } 
			set { base.Set (value, "PLANT"); }
		}



		public System.String StandardTextKey
		{ 
			get { return base.Get< System.String > ("STANDARD_TEXT_KEY"); } 
			set { base.Set (value, "STANDARD_TEXT_KEY"); }
		}



		public System.String OperationShortText
		{ 
			get { return base.Get< System.String > ("DESCRIPTION"); } 
			set { base.Set (value, "DESCRIPTION"); }
		}



		public System.String LanguageKey
		{ 
			get { return base.Get< System.String > ("LANGU"); } 
			set { base.Set (value, "LANGU"); }
		}



		public System.String LanguageKeyISOCode
		{ 
			get { return base.Get< System.String > ("LANGU_ISO"); } 
			set { base.Set (value, "LANGU_ISO"); }
		}



		public System.Decimal NumberOfTimeTickets
		{ 
			get { return base.Get< System.Decimal > ("NO_OF_TIME_TICKETS"); } 
			set { base.Set (value, "NO_OF_TIME_TICKETS"); }
		}



		public System.String WageType
		{ 
			get { return base.Get< System.String > ("WAGETYPE"); } 
			set { base.Set (value, "WAGETYPE"); }
		}



		public System.String Suitability
		{ 
			get { return base.Get< System.String > ("SUITABILITY"); } 
			set { base.Set (value, "SUITABILITY"); }
		}



		public System.String Wagegroup
		{ 
			get { return base.Get< System.String > ("WAGEGROUP"); } 
			set { base.Set (value, "WAGEGROUP"); }
		}



		public System.String Sortfield
		{ 
			get { return base.Get< System.String > ("SORT_FLD"); } 
			set { base.Set (value, "SORT_FLD"); }
		}



		public System.String VendorAccountNumber
		{ 
			get { return base.Get< System.String > ("VENDOR_NO"); } 
			set { base.Set (value, "VENDOR_NO"); }
		}



		public System.Decimal OperationQuantity
		{ 
			get { return base.Get< System.Decimal > ("QUANTITY"); } 
			set { base.Set (value, "QUANTITY"); }
		}



		public System.String BaseUOM
		{ 
			get { return base.Get< System.String > ("BASE_UOM"); } 
			set { base.Set (value, "BASE_UOM"); }
		}



		public System.String BaseUOMISOCode
		{ 
			get { return base.Get< System.String > ("BASE_UOM_ISO"); } 
			set { base.Set (value, "BASE_UOM_ISO"); }
		}



		public System.Decimal Price
		{ 
			get { return base.Get< System.Decimal > ("PRICE"); } 
			set { base.Set (value, "PRICE"); }
		}



		public System.Decimal PriceUnit
		{ 
			get { return base.Get< System.Decimal > ("PRICE_UNIT"); } 
			set { base.Set (value, "PRICE_UNIT"); }
		}



		public System.String CostElement
		{ 
			get { return base.Get< System.String > ("COST_ELEMENT"); } 
			set { base.Set (value, "COST_ELEMENT"); }
		}



		public System.String CurrencyKey
		{ 
			get { return base.Get< System.String > ("CURRENCY"); } 
			set { base.Set (value, "CURRENCY"); }
		}



		public System.String CurrencyKeyISOCode
		{ 
			get { return base.Get< System.String > ("CURRENCY_ISO"); } 
			set { base.Set (value, "CURRENCY_ISO"); }
		}



		public System.String PurchasingInfoRecordNumber
		{ 
			get { return base.Get< System.String > ("INFO_REC"); } 
			set { base.Set (value, "INFO_REC"); }
		}



		public System.String PurchasingOrganization
		{ 
			get { return base.Get< System.String > ("PURCH_ORG"); } 
			set { base.Set (value, "PURCH_ORG"); }
		}



		public System.String PurchasingGroup
		{ 
			get { return base.Get< System.String > ("PUR_GROUP"); } 
			set { base.Set (value, "PUR_GROUP"); }
		}



		public System.String MaterialGroup
		{ 
			get { return base.Get< System.String > ("MATL_GROUP"); } 
			set { base.Set (value, "MATL_GROUP"); }
		}



		public System.String PurchaseAgreementNumber
		{ 
			get { return base.Get< System.String > ("AGREEMENT"); } 
			set { base.Set (value, "AGREEMENT"); }
		}



		public System.String PurchaseAgreementItem
		{ 
			get { return base.Get< System.String > ("AGMT_ITEM"); } 
			set { base.Set (value, "AGMT_ITEM"); }
		}



		public System.String RequesterName
		{ 
			get { return base.Get< System.String > ("PREQ_NAME"); } 
			set { base.Set (value, "PREQ_NAME"); }
		}



		public System.String RequirementTrackingNumber
		{ 
			get { return base.Get< System.String > ("TRACKINGNO"); } 
			set { base.Set (value, "TRACKINGNO"); }
		}



		public System.SByte NumberOfCapacitiesRequired
		{ 
			get { return base.Get< System.SByte > ("NUMBER_OF_CAPACITIES"); } 
			set { base.Set (value, "NUMBER_OF_CAPACITIES"); }
		}



		public System.SByte WorkPercentage
		{ 
			get { return base.Get< System.SByte > ("PERCENT_OF_WORK"); } 
			set { base.Set (value, "PERCENT_OF_WORK"); }
		}



		public System.String CalculationKey
		{ 
			get { return base.Get< System.String > ("CALC_KEY"); } 
			set { base.Set (value, "CALC_KEY"); }
		}



		public System.String ActivityType
		{ 
			get { return base.Get< System.String > ("ACTTYPE"); } 
			set { base.Set (value, "ACTTYPE"); }
		}



		public System.String SystemCondition
		{ 
			get { return base.Get< System.String > ("SYSTCOND"); } 
			set { base.Set (value, "SYSTCOND"); }
		}



		public System.String Assembly
		{ 
			get { return base.Get< System.String > ("ASSEMBLY"); } 
			set { base.Set (value, "ASSEMBLY"); }
		}



		public System.String DistrCapRequirements
		{ 
			get { return base.Get< System.String > ("INT_DISTR"); } 
			set { base.Set (value, "INT_DISTR"); }
		}



		public System.String ShipToParty
		{ 
			get { return base.Get< System.String > ("GR_RCPT"); } 
			set { base.Set (value, "GR_RCPT"); }
		}



		public System.String UnloadingPoint
		{ 
			get { return base.Get< System.String > ("UNLOAD_PT"); } 
			set { base.Set (value, "UNLOAD_PT"); }
		}



		public System.String PersonnelNumber
		{ 
			get { return base.Get< System.String > ("PERS_NO"); } 
			set { base.Set (value, "PERS_NO"); }
		}



		public System.String FrameworkOrder
		{ 
			get { return base.Get< System.String > ("FW_ORDER"); } 
			set { base.Set (value, "FW_ORDER"); }
		}



		public System.String FrameworkOrderItem
		{ 
			get { return base.Get< System.String > ("ORDER_ITEM"); } 
			set { base.Set (value, "ORDER_ITEM"); }
		}



		public System.Decimal PlannedDeliveryTimeinDays
		{ 
			get { return base.Get< System.Decimal > ("PLND_DELRY"); } 
			set { base.Set (value, "PLND_DELRY"); }
		}



		public System.Decimal NormalDuration
		{ 
			get { return base.Get< System.Decimal > ("DURATION_NORMAL"); } 
			set { base.Set (value, "DURATION_NORMAL"); }
		}



		public System.String NormalDurationUOM
		{ 
			get { return base.Get< System.String > ("DURATION_NORMAL_UNIT"); } 
			set { base.Set (value, "DURATION_NORMAL_UNIT"); }
		}



		public System.String NormalDurationUOMISOCode
		{ 
			get { return base.Get< System.String > ("DURATION_NORMAL_UNIT_ISO"); } 
			set { base.Set (value, "DURATION_NORMAL_UNIT_ISO"); }
		}



		public System.String StartDateConstraintType
		{ 
			get { return base.Get< System.String > ("CONSTRAINT_TYPE_START"); } 
			set { base.Set (value, "CONSTRAINT_TYPE_START"); }
		}



		public System.String FinishDateConstraintType
		{ 
			get { return base.Get< System.String > ("CONSTRAINT_TYPE_FINISH"); } 
			set { base.Set (value, "CONSTRAINT_TYPE_FINISH"); }
		}



		public System.Decimal WorkActivity
		{ 
			get { return base.Get< System.Decimal > ("WORK_ACTIVITY"); } 
			set { base.Set (value, "WORK_ACTIVITY"); }
		}



		public System.String WorkActivityUOM
		{ 
			get { return base.Get< System.String > ("UN_WORK"); } 
			set { base.Set (value, "UN_WORK"); }
		}



		public System.String WorkActivityUOMISOCode
		{ 
			get { return base.Get< System.String > ("UN_WORK_ISO"); } 
			set { base.Set (value, "UN_WORK_ISO"); }
		}



		public System.DateTime ActivityStartConstraint
		{ 
			get { return base.Get< System.DateTime > ("START_CONS"); } 
			set { base.Set (value, "START_CONS"); }
		}



		public System.DateTime StartDateConstraint
		{ 
			get { return base.Get< System.DateTime > ("STRTTIMCON"); } 
			set { base.Set (value, "STRTTIMCON"); }
		}



		public System.DateTime FinishDateConstraint
		{ 
			get { return base.Get< System.DateTime > ("FIN_CONSTR"); } 
			set { base.Set (value, "FIN_CONSTR"); }
		}



		public System.DateTime FinishTimeConstraint
		{ 
			get { return base.Get< System.DateTime > ("FINTIMCONS"); } 
			set { base.Set (value, "FINTIMCONS"); }
		}



		public System.Decimal ExecutionFactor
		{ 
			get { return base.Get< System.Decimal > ("EXECFACTOR"); } 
			set { base.Set (value, "EXECFACTOR"); }
		}



		public System.String MRPRelevantIndicator
		{ 
			get { return base.Get< System.String > ("MRP_RELEVANT"); } 
			set { base.Set (value, "MRP_RELEVANT"); }
		}



		public System.String UserDefinedFieldKey
		{ 
			get { return base.Get< System.String > ("FIELD_KEY"); } 
			set { base.Set (value, "FIELD_KEY"); }
		}



		public System.String UserField00
		{ 
			get { return base.Get< System.String > ("USR00"); } 
			set { base.Set (value, "USR00"); }
		}



		public System.String UserField01
		{ 
			get { return base.Get< System.String > ("USR01"); } 
			set { base.Set (value, "USR01"); }
		}



		public System.String UserField02
		{ 
			get { return base.Get< System.String > ("USR02"); } 
			set { base.Set (value, "USR02"); }
		}



		public System.String UserField03
		{ 
			get { return base.Get< System.String > ("USR03"); } 
			set { base.Set (value, "USR03"); }
		}



		public System.Decimal UserField04
		{ 
			get { return base.Get< System.Decimal > ("USR04"); } 
			set { base.Set (value, "USR04"); }
		}



		public System.String UserField04UOM
		{ 
			get { return base.Get< System.String > ("USE04"); } 
			set { base.Set (value, "USE04"); }
		}



		public System.String UserField04UOMISOCode
		{ 
			get { return base.Get< System.String > ("USE04_ISO"); } 
			set { base.Set (value, "USE04_ISO"); }
		}



		public System.Decimal UserField05
		{ 
			get { return base.Get< System.Decimal > ("USR05"); } 
			set { base.Set (value, "USR05"); }
		}



		public System.String UserField05UOM
		{ 
			get { return base.Get< System.String > ("USE05"); } 
			set { base.Set (value, "USE05"); }
		}



		public System.String UserField05UOMISOCode
		{ 
			get { return base.Get< System.String > ("USE05_ISO"); } 
			set { base.Set (value, "USE05_ISO"); }
		}



		public System.Decimal UserField06
		{ 
			get { return base.Get< System.Decimal > ("USR06"); } 
			set { base.Set (value, "USR06"); }
		}



		public System.String UserField06Currency
		{ 
			get { return base.Get< System.String > ("USE06"); } 
			set { base.Set (value, "USE06"); }
		}



		public System.String UserField06CurrencyISOCode
		{ 
			get { return base.Get< System.String > ("USE06_ISO"); } 
			set { base.Set (value, "USE06_ISO"); }
		}



		public System.Decimal UserField07
		{ 
			get { return base.Get< System.Decimal > ("USR07"); } 
			set { base.Set (value, "USR07"); }
		}



		public System.String UserField07Currency
		{ 
			get { return base.Get< System.String > ("USE07"); } 
			set { base.Set (value, "USE07"); }
		}



		public System.String UserField07CurrencyISOCode
		{ 
			get { return base.Get< System.String > ("USE07_ISO"); } 
			set { base.Set (value, "USE07_ISO"); }
		}



		public System.DateTime UserField08
		{ 
			get { return base.Get< System.DateTime > ("USR08"); } 
			set { base.Set (value, "USR08"); }
		}



		public System.DateTime UserField09
		{ 
			get { return base.Get< System.DateTime > ("USR09"); } 
			set { base.Set (value, "USR09"); }
		}



		public System.String UserField10
		{ 
			get { return base.Get< System.String > ("USR10"); } 
			set { base.Set (value, "USR10"); }
		}



		public System.String UserField11
		{ 
			get { return base.Get< System.String > ("USR11"); } 
			set { base.Set (value, "USR11"); }
		}



		public System.String ConfirmationNumber
		{ 
			get { return base.Get< System.String > ("CONF_NO"); } 
			set { base.Set (value, "CONF_NO"); }
		}



		public System.String PurchaseRequisitionNumber
		{ 
			get { return base.Get< System.String > ("PREQ_NO"); } 
			set { base.Set (value, "PREQ_NO"); }
		}



		public System.String PurchaseRequisitionItem
		{ 
			get { return base.Get< System.String > ("PREQ_ITEM"); } 
			set { base.Set (value, "PREQ_ITEM"); }
		}



		public System.String CompleteIndicator
		{ 
			get { return base.Get< System.String > ("COMPLETE"); } 
			set { base.Set (value, "COMPLETE"); }
		}



		public System.Decimal ActualWork
		{ 
			get { return base.Get< System.Decimal > ("WORK_ACTUAL"); } 
			set { base.Set (value, "WORK_ACTUAL"); }
		}



		public System.DateTime EarliestStartDate
		{ 
			get { return base.Get< System.DateTime > ("EARL_SCHED_START_DATE"); } 
			set { base.Set (value, "EARL_SCHED_START_DATE"); }
		}



		public System.DateTime EarliestStartTIme
		{ 
			get { return base.Get< System.DateTime > ("EARL_SCHED_START_TIME"); } 
			set { base.Set (value, "EARL_SCHED_START_TIME"); }
		}



		public System.DateTime EarliestFinishDate
		{ 
			get { return base.Get< System.DateTime > ("EARL_SCHED_FIN_DATE"); } 
			set { base.Set (value, "EARL_SCHED_FIN_DATE"); }
		}



		public System.DateTime EarliestFinishTime
		{ 
			get { return base.Get< System.DateTime > ("EARL_SCHED_FIN_TIME"); } 
			set { base.Set (value, "EARL_SCHED_FIN_TIME"); }
		}



		public System.DateTime LatestStartDate
		{ 
			get { return base.Get< System.DateTime > ("LATE_SCHED_START_DATE"); } 
			set { base.Set (value, "LATE_SCHED_START_DATE"); }
		}



		public System.DateTime LatestStartTime
		{ 
			get { return base.Get< System.DateTime > ("LATE_SCHED_START_TIME"); } 
			set { base.Set (value, "LATE_SCHED_START_TIME"); }
		}



		public System.DateTime LatestFinishDate
		{ 
			get { return base.Get< System.DateTime > ("LATE_SCHED_FIN_DATE"); } 
			set { base.Set (value, "LATE_SCHED_FIN_DATE"); }
		}



		public System.DateTime LatestFinishTime
		{ 
			get { return base.Get< System.DateTime > ("LATE_SCHED_FIN_TIME"); } 
			set { base.Set (value, "LATE_SCHED_FIN_TIME"); }
		}



		public System.DateTime ActualStartDate
		{ 
			get { return base.Get< System.DateTime > ("ACT_START_DATE"); } 
			set { base.Set (value, "ACT_START_DATE"); }
		}



		public System.DateTime ActualStartTime
		{ 
			get { return base.Get< System.DateTime > ("ACT_START_TIME"); } 
			set { base.Set (value, "ACT_START_TIME"); }
		}



		public System.DateTime ActualEndDate
		{ 
			get { return base.Get< System.DateTime > ("ACT_END_DATE"); } 
			set { base.Set (value, "ACT_END_DATE"); }
		}



		public System.DateTime ActualEndTime
		{ 
			get { return base.Get< System.DateTime > ("ACT_END_TIME"); } 
			set { base.Set (value, "ACT_END_TIME"); }
		}



		public System.DateTime ForecastFinishDate
		{ 
			get { return base.Get< System.DateTime > ("FCST_FIN_DATE"); } 
			set { base.Set (value, "FCST_FIN_DATE"); }
		}



		public System.DateTime ForecastFinishTime
		{ 
			get { return base.Get< System.DateTime > ("FCST_FIN_TIME"); } 
			set { base.Set (value, "FCST_FIN_TIME"); }
		}



		public System.Decimal FreeFloat
		{ 
			get { return base.Get< System.Decimal > ("FREE_BUFFER"); } 
			set { base.Set (value, "FREE_BUFFER"); }
		}



		public System.Decimal TotalFloat
		{ 
			get { return base.Get< System.Decimal > ("TOTAL_BUFFER"); } 
			set { base.Set (value, "TOTAL_BUFFER"); }
		}



		public System.Decimal ForecastedWork
		{ 
			get { return base.Get< System.Decimal > ("WORK_FORECAST"); } 
			set { base.Set (value, "WORK_FORECAST"); }
		}



		public System.String SystemStatus
		{ 
			get { return base.Get< System.String > ("SYSTEM_STATUS_TEXT"); } 
			set { base.Set (value, "SYSTEM_STATUS_TEXT"); }
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



		public System.String EquipmentNumber
		{ 
			get { return base.Get< System.String > ("EQUIPMENT"); } 
			set { base.Set (value, "EQUIPMENT"); }
		}



		public System.String FunctionalLocation
		{ 
			get { return base.Get< System.String > ("FUNCT_LOC"); } 
			set { base.Set (value, "FUNCT_LOC"); }
		}



		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("NOTIF_NO"); } 
			set { base.Set (value, "NOTIF_NO"); }
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



		public System.String LengthUOM
		{ 
			get { return base.Get< System.String > ("LINEAR_UNIT"); } 
			set { base.Set (value, "LINEAR_UNIT"); }
		}



		public System.String LengthUOMISOCode
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



		public System.String CompanyCode
		{ 
			get { return base.Get< System.String > ("COMP_CODE"); } 
			set { base.Set (value, "COMP_CODE"); }
		}



		public System.String MaintenanceActivityType
		{ 
			get { return base.Get< System.String > ("MAINTENANCE_ACTIVITY_TYPE"); } 
			set { base.Set (value, "MAINTENANCE_ACTIVITY_TYPE"); }
		}



		public System.String BusinessArea
		{ 
			get { return base.Get< System.String > ("BUS_AREA"); } 
			set { base.Set (value, "BUS_AREA"); }
		}



		public System.String WBSElement
		{ 
			get { return base.Get< System.String > ("WBS_ELEM"); } 
			set { base.Set (value, "WBS_ELEM"); }
		}



		public System.String ProfitCenter
		{ 
			get { return base.Get< System.String > ("PROFIT_CTR"); } 
			set { base.Set (value, "PROFIT_CTR"); }
		}



		public System.String CostingSheet
		{ 
			get { return base.Get< System.String > ("CSTG_SHEET"); } 
			set { base.Set (value, "CSTG_SHEET"); }
		}



		public System.String Overheadkey
		{ 
			get { return base.Get< System.String > ("OVERHEAD_KEY"); } 
			set { base.Set (value, "OVERHEAD_KEY"); }
		}



		public System.String TaxJurisdiction
		{ 
			get { return base.Get< System.String > ("TAXJURCODE"); } 
			set { base.Set (value, "TAXJURCODE"); }
		}



		public System.String ObjectClass
		{ 
			get { return base.Get< System.String > ("OBJECTCLASS"); } 
			set { base.Set (value, "OBJECTCLASS"); }
		}



		public System.String FunctionalArea
		{ 
			get { return base.Get< System.String > ("FUNC_AREA"); } 
			set { base.Set (value, "FUNC_AREA"); }
		}


	}
	
	[Name("OBJECTLIST")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceOrder_OBJECTLIST : BusinessObject<EnosixServiceOrder_OBJECTLIST>
	{
		

		public System.Int32 Counter
		{ 
			get { return base.Get< System.Int32 > ("COUNTER"); } 
			set { base.Set (value, "COUNTER"); }
		}



		public System.String FunctionalLocation
		{ 
			get { return base.Get< System.String > ("FUNCT_LOC"); } 
			set { base.Set (value, "FUNCT_LOC"); }
		}



		public System.String FunctionalLocationLabel
		{ 
			get { return base.Get< System.String > ("FUNCLOC_DISP"); } 
			set { base.Set (value, "FUNCLOC_DISP"); }
		}



		public System.String EquipmentNumber
		{ 
			get { return base.Get< System.String > ("EQUIPMENT"); } 
			set { base.Set (value, "EQUIPMENT"); }
		}



		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("NOTIF_NO"); } 
			set { base.Set (value, "NOTIF_NO"); }
		}



		public System.String Assembly
		{ 
			get { return base.Get< System.String > ("ASSEMBLY"); } 
			set { base.Set (value, "ASSEMBLY"); }
		}



		public System.String Sortfield
		{ 
			get { return base.Get< System.String > ("SORTFIELD"); } 
			set { base.Set (value, "SORTFIELD"); }
		}



		public System.String ProcessingIndicator
		{ 
			get { return base.Get< System.String > ("PROCESSING_IND"); } 
			set { base.Set (value, "PROCESSING_IND"); }
		}



		public System.String SerialNumber
		{ 
			get { return base.Get< System.String > ("SERIALNO"); } 
			set { base.Set (value, "SERIALNO"); }
		}



		public System.String MaterialNumber
		{ 
			get { return base.Get< System.String > ("SERMAT"); } 
			set { base.Set (value, "SERMAT"); }
		}



		public System.String PMAssemblyDescription
		{ 
			get { return base.Get< System.String > ("DESCRIPTN"); } 
			set { base.Set (value, "DESCRIPTN"); }
		}



		public System.String TechnicalObjectDescription
		{ 
			get { return base.Get< System.String > ("EQUIDESCR"); } 
			set { base.Set (value, "EQUIDESCR"); }
		}



		public System.String FunctionalLocationDescription
		{ 
			get { return base.Get< System.String > ("FUNCLDESCR"); } 
			set { base.Set (value, "FUNCLDESCR"); }
		}



		public System.String MaterialDescription
		{ 
			get { return base.Get< System.String > ("MATL_DESC"); } 
			set { base.Set (value, "MATL_DESC"); }
		}



		public System.String ShortText
		{ 
			get { return base.Get< System.String > ("SHORT_TEXT"); } 
			set { base.Set (value, "SHORT_TEXT"); }
		}



		public System.String SermaMaterialNumber
		{ 
			get { return base.Get< System.String > ("SERMAT_EXTERNAL"); } 
			set { base.Set (value, "SERMAT_EXTERNAL"); }
		}



		public System.String SermaGUID
		{ 
			get { return base.Get< System.String > ("SERMAT_GUID"); } 
			set { base.Set (value, "SERMAT_GUID"); }
		}



		public System.String SermaVersion
		{ 
			get { return base.Get< System.String > ("SERMAT_VERSION"); } 
			set { base.Set (value, "SERMAT_VERSION"); }
		}


	}
	
	[Name("PARTNERS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceOrder_PARTNERS : BusinessObject<EnosixServiceOrder_PARTNERS>
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



		public System.String PhoneNumber
		{ 
			get { return base.Get< System.String > ("TEL_NUMBER"); } 
			set { base.Set (value, "TEL_NUMBER"); }
		}


	}
	
}
