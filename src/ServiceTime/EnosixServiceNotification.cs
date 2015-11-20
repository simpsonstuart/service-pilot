






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
     [Header( "NOTIFICATION" )]   
	
	
	[RecordKeyStructure("EnosixObjKey")]
	
	public partial class EnosixServiceNotification : BusinessObject<EnosixServiceNotification> 
	{
		
		
		public virtual ICollection<EnosixServiceNotification_REFERENCE_OBJECT> REFERENCE_OBJECT_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_REFERENCE_OBJECT>("REFERENCE_OBJECT_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_MALFUNCTION_BREAKDOWN> MALFUNCTION_BREAKDOWN_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_MALFUNCTION_BREAKDOWN>("MALFUNCTION_BREAKDOWN_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_LOCATION_DATA> LOCATION_DATA_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_LOCATION_DATA>("LOCATION_DATA_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_ITEMS> ITEMS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_ITEMS>("ITEMS_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_CAUSES> CAUSES_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_CAUSES>("CAUSES_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_TASKS> TASKS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_TASKS>("TASKS_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_ACTIVITIES> ACTIVITIES_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_ACTIVITIES>("ACTIVITIES_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_PARTNERS> PARTNERS_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_PARTNERS>("PARTNERS_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixServiceNotification_ADD_ITEM_TCA_TEXT> ADD_ITEM_TCA_TEXT_Collection
		{
			get 
			{
				return base.GetCollection<EnosixServiceNotification_ADD_ITEM_TCA_TEXT>("ADD_ITEM_TCA_TEXT_Collection");
			}
		}

		

		#region Header Properties

		

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


		
		#endregion

		
	}
	
	[Name("REFERENCE_OBJECT")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_REFERENCE_OBJECT : BusinessObject<EnosixServiceNotification_REFERENCE_OBJECT>
	{
		

		public System.String CodeGroup
		{ 
			get { return base.Get< System.String > ("QMGRP"); } 
			set { base.Set (value, "QMGRP"); }
		}



		public System.String Coding
		{ 
			get { return base.Get< System.String > ("QMCOD"); } 
			set { base.Set (value, "QMCOD"); }
		}



		public System.String  CodingText
		{ 
			get { return base.Get< System.String > ("QMCOD_TEXT"); } 
			set { base.Set (value, "QMCOD_TEXT"); }
		}


	}
	
	[Name("MALFUNCTION_BREAKDOWN")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_MALFUNCTION_BREAKDOWN : BusinessObject<EnosixServiceNotification_MALFUNCTION_BREAKDOWN>
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
	
	[Name("LOCATION_DATA")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_LOCATION_DATA : BusinessObject<EnosixServiceNotification_LOCATION_DATA>
	{
		

		public System.String MaintenancePlant
		{ 
			get { return base.Get< System.String > ("SWERK"); } 
			set { base.Set (value, "SWERK"); }
		}



		public System.String MaintenancePlantName
		{ 
			get { return base.Get< System.String > ("SWERK_NAME"); } 
			set { base.Set (value, "SWERK_NAME"); }
		}



		public System.String MaintenanceObjectLocation
		{ 
			get { return base.Get< System.String > ("STORT"); } 
			set { base.Set (value, "STORT"); }
		}



		public System.String MaintenanceObjectLocationText
		{ 
			get { return base.Get< System.String > ("STORT_TEXT"); } 
			set { base.Set (value, "STORT_TEXT"); }
		}



		public System.String Room
		{ 
			get { return base.Get< System.String > ("MSGRP"); } 
			set { base.Set (value, "MSGRP"); }
		}



		public System.String PlantSection
		{ 
			get { return base.Get< System.String > ("BEBER"); } 
			set { base.Set (value, "BEBER"); }
		}



		public System.String CompanyAreaPersonResponsible
		{ 
			get { return base.Get< System.String > ("FING"); } 
			set { base.Set (value, "FING"); }
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



		public System.String TechnicalObjectABCindicator
		{ 
			get { return base.Get< System.String > ("ABCKZ"); } 
			set { base.Set (value, "ABCKZ"); }
		}



		public System.String TechnicalObjectABCindicatorText
		{ 
			get { return base.Get< System.String > ("ABCTX"); } 
			set { base.Set (value, "ABCTX"); }
		}



		public System.String SortField
		{ 
			get { return base.Get< System.String > ("EQFNR"); } 
			set { base.Set (value, "EQFNR"); }
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



		public System.String CompanyCode
		{ 
			get { return base.Get< System.String > ("BUKRS"); } 
			set { base.Set (value, "BUKRS"); }
		}



		public System.String CompanyCodeDescription
		{ 
			get { return base.Get< System.String > ("BUTXT"); } 
			set { base.Set (value, "BUTXT"); }
		}



		public System.String CompanyCodeCity
		{ 
			get { return base.Get< System.String > ("BUKRS_ORT01"); } 
			set { base.Set (value, "BUKRS_ORT01"); }
		}



		public System.String AssetNumber
		{ 
			get { return base.Get< System.String > ("ANLNR"); } 
			set { base.Set (value, "ANLNR"); }
		}



		public System.String AssetSubnumber
		{ 
			get { return base.Get< System.String > ("ANLUN"); } 
			set { base.Set (value, "ANLUN"); }
		}



		public System.String BusinessArea
		{ 
			get { return base.Get< System.String > ("GSBER"); } 
			set { base.Set (value, "GSBER"); }
		}



		public System.String BusinessAreaDescription
		{ 
			get { return base.Get< System.String > ("GTEXT"); } 
			set { base.Set (value, "GTEXT"); }
		}



		public System.String CostCenter
		{ 
			get { return base.Get< System.String > ("KOSTL"); } 
			set { base.Set (value, "KOSTL"); }
		}



		public System.String CostCenterName
		{ 
			get { return base.Get< System.String > ("KOSTL_NAME"); } 
			set { base.Set (value, "KOSTL_NAME"); }
		}



		public System.String ControllingArea
		{ 
			get { return base.Get< System.String > ("KOKRS"); } 
			set { base.Set (value, "KOKRS"); }
		}



		public System.String WBSElement
		{ 
			get { return base.Get< System.String > ("PROID"); } 
			set { base.Set (value, "PROID"); }
		}



		public System.String WBSElementDescription
		{ 
			get { return base.Get< System.String > ("PROID_TEXT"); } 
			set { base.Set (value, "PROID_TEXT"); }
		}



		public System.String StandingOrderNumber
		{ 
			get { return base.Get< System.String > ("DAUFN"); } 
			set { base.Set (value, "DAUFN"); }
		}



		public System.String SettlementOrder
		{ 
			get { return base.Get< System.String > ("AUFNR_SET"); } 
			set { base.Set (value, "AUFNR_SET"); }
		}


	}
	
	[Name("ITEMS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_ITEMS : BusinessObject<EnosixServiceNotification_ITEMS>
	{
		

		public System.String ItemRecordNumber
		{ 
			get { return base.Get< System.String > ("FENUM"); } 
			set { base.Set (value, "FENUM"); }
		}



		public System.String ItemSortNumber
		{ 
			get { return base.Get< System.String > ("QLFDPOS"); } 
			set { base.Set (value, "QLFDPOS"); }
		}



		public System.String ObjectPartCodeGroup
		{ 
			get { return base.Get< System.String > ("OTGRP"); } 
			set { base.Set (value, "OTGRP"); }
		}



		public System.String CodeGroupDescription
		{ 
			get { return base.Get< System.String > ("KURZTEXT"); } 
			set { base.Set (value, "KURZTEXT"); }
		}



		public System.String ObjectPartCode
		{ 
			get { return base.Get< System.String > ("OTEIL"); } 
			set { base.Set (value, "OTEIL"); }
		}



		public System.String ObjectPartCodeText
		{ 
			get { return base.Get< System.String > ("OTEIL_TEXT"); } 
			set { base.Set (value, "OTEIL_TEXT"); }
		}



		public System.String ObjectPartsCatalogType
		{ 
			get { return base.Get< System.String > ("OTKAT"); } 
			set { base.Set (value, "OTKAT"); }
		}



		public System.String ObjectPartsCatalogTypeText
		{ 
			get { return base.Get< System.String > ("OTKAT_TEXT"); } 
			set { base.Set (value, "OTKAT_TEXT"); }
		}



		public System.String ProblemCodeGroup
		{ 
			get { return base.Get< System.String > ("FEGRP"); } 
			set { base.Set (value, "FEGRP"); }
		}



		public System.String ProblemCodeGroupDescription
		{ 
			get { return base.Get< System.String > ("FEGRP_TEXT"); } 
			set { base.Set (value, "FEGRP_TEXT"); }
		}



		public System.String ProblemorDamageCode
		{ 
			get { return base.Get< System.String > ("FECOD"); } 
			set { base.Set (value, "FECOD"); }
		}



		public System.String ProblemorDamageCodeText
		{ 
			get { return base.Get< System.String > ("FECOD_TEXT"); } 
			set { base.Set (value, "FECOD_TEXT"); }
		}



		public System.String ProblemsorDefectsCatalogType
		{ 
			get { return base.Get< System.String > ("FEKAT"); } 
			set { base.Set (value, "FEKAT"); }
		}



		public System.String ProblemorDefectCatalogTypeText
		{ 
			get { return base.Get< System.String > ("FEKAT_TEXT"); } 
			set { base.Set (value, "FEKAT_TEXT"); }
		}



		public System.String NotificationItemText
		{ 
			get { return base.Get< System.String > ("FETXT"); } 
			set { base.Set (value, "FETXT"); }
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



		public System.Int32 NumberDefectsFound
		{ 
			get { return base.Get< System.Int32 > ("ANZFEHLER"); } 
			set { base.Set (value, "ANZFEHLER"); }
		}



		public System.String CreatedBy
		{ 
			get { return base.Get< System.String > ("ERNAM"); } 
			set { base.Set (value, "ERNAM"); }
		}



		public System.DateTime CreateDate
		{ 
			get { return base.Get< System.DateTime > ("ERDAT"); } 
			set { base.Set (value, "ERDAT"); }
		}



		public System.DateTime CreateTime
		{ 
			get { return base.Get< System.DateTime > ("ERZEIT"); } 
			set { base.Set (value, "ERZEIT"); }
		}



		public System.String ChangedBy
		{ 
			get { return base.Get< System.String > ("AENAM"); } 
			set { base.Set (value, "AENAM"); }
		}



		public System.DateTime DateChanged
		{ 
			get { return base.Get< System.DateTime > ("AEDAT"); } 
			set { base.Set (value, "AEDAT"); }
		}



		public System.DateTime TimeChanged
		{ 
			get { return base.Get< System.DateTime > ("AEZEIT"); } 
			set { base.Set (value, "AEZEIT"); }
		}



		public System.String WorkCenter
		{ 
			get { return base.Get< System.String > ("ARBPLFE"); } 
			set { base.Set (value, "ARBPLFE"); }
		}



		public System.String WorkCenterDescription
		{ 
			get { return base.Get< System.String > ("ARBPLFE_TEXT"); } 
			set { base.Set (value, "ARBPLFE_TEXT"); }
		}



		public System.String LongText
		{ 
			get { return base.Get< System.String > ("LONGTEXT"); } 
			set { base.Set (value, "LONGTEXT"); }
		}


	}
	
	[Name("CAUSES")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_CAUSES : BusinessObject<EnosixServiceNotification_CAUSES>
	{
		

		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("QMNUM"); } 
			set { base.Set (value, "QMNUM"); }
		}



		public System.String ItemRecordNumber
		{ 
			get { return base.Get< System.String > ("FENUM"); } 
			set { base.Set (value, "FENUM"); }
		}



		public System.String ItemSortNumber
		{ 
			get { return base.Get< System.String > ("QLFDPOS"); } 
			set { base.Set (value, "QLFDPOS"); }
		}



		public System.String CauseSequentialNumber
		{ 
			get { return base.Get< System.String > ("URNUM"); } 
			set { base.Set (value, "URNUM"); }
		}



		public System.String CreatedBy
		{ 
			get { return base.Get< System.String > ("ERNAM"); } 
			set { base.Set (value, "ERNAM"); }
		}



		public System.DateTime CreateDate
		{ 
			get { return base.Get< System.DateTime > ("ERDAT"); } 
			set { base.Set (value, "ERDAT"); }
		}



		public System.String ChangedBy
		{ 
			get { return base.Get< System.String > ("AENAM"); } 
			set { base.Set (value, "AENAM"); }
		}



		public System.DateTime DateChanged
		{ 
			get { return base.Get< System.DateTime > ("AEDAT"); } 
			set { base.Set (value, "AEDAT"); }
		}



		public System.String LeaveName
		{ 
			get { return base.Get< System.String > ("URTXT"); } 
			set { base.Set (value, "URTXT"); }
		}



		public System.String CauseCatalogType
		{ 
			get { return base.Get< System.String > ("URKAT"); } 
			set { base.Set (value, "URKAT"); }
		}



		public System.String CauseCatalogTypeText
		{ 
			get { return base.Get< System.String > ("KATALOGTXT"); } 
			set { base.Set (value, "KATALOGTXT"); }
		}



		public System.String CauseCodeGroup
		{ 
			get { return base.Get< System.String > ("URGRP"); } 
			set { base.Set (value, "URGRP"); }
		}



		public System.String CodeGroupDescription
		{ 
			get { return base.Get< System.String > ("KURZTEXT"); } 
			set { base.Set (value, "KURZTEXT"); }
		}



		public System.String CauseCode
		{ 
			get { return base.Get< System.String > ("URCOD"); } 
			set { base.Set (value, "URCOD"); }
		}



		public System.String CauseCodeText
		{ 
			get { return base.Get< System.String > ("URCOD_TEXT"); } 
			set { base.Set (value, "URCOD_TEXT"); }
		}



		public System.String ObjectLongTextAvailable
		{ 
			get { return base.Get< System.String > ("INDTX"); } 
			set { base.Set (value, "INDTX"); }
		}



		public System.DateTime CreateTime
		{ 
			get { return base.Get< System.DateTime > ("ERZEIT"); } 
			set { base.Set (value, "ERZEIT"); }
		}



		public System.DateTime TimeChanged
		{ 
			get { return base.Get< System.DateTime > ("AEZEIT"); } 
			set { base.Set (value, "AEZEIT"); }
		}



		public System.String CauseSortNumber
		{ 
			get { return base.Get< System.String > ("QURNUM"); } 
			set { base.Set (value, "QURNUM"); }
		}



		public System.String LongText
		{ 
			get { return base.Get< System.String > ("LONGTEXT"); } 
			set { base.Set (value, "LONGTEXT"); }
		}


	}
	
	[Name("TASKS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_TASKS : BusinessObject<EnosixServiceNotification_TASKS>
	{
		

		public System.String SequentialNumber
		{ 
			get { return base.Get< System.String > ("MANUM"); } 
			set { base.Set (value, "MANUM"); }
		}



		public System.String TaskSortNumber
		{ 
			get { return base.Get< System.String > ("QSMNUM"); } 
			set { base.Set (value, "QSMNUM"); }
		}



		public System.String TaskCodeGroup
		{ 
			get { return base.Get< System.String > ("MNGRP"); } 
			set { base.Set (value, "MNGRP"); }
		}



		public System.String CodeGroupDescription
		{ 
			get { return base.Get< System.String > ("KURZTEXT"); } 
			set { base.Set (value, "KURZTEXT"); }
		}



		public System.String TaskCode
		{ 
			get { return base.Get< System.String > ("MNCOD"); } 
			set { base.Set (value, "MNCOD"); }
		}



		public System.String TaskCodeText
		{ 
			get { return base.Get< System.String > ("MNCOD_TEXT"); } 
			set { base.Set (value, "MNCOD_TEXT"); }
		}



		public System.String TaskText
		{ 
			get { return base.Get< System.String > ("MATXT"); } 
			set { base.Set (value, "MATXT"); }
		}



		public System.String TaskStatus
		{ 
			get { return base.Get< System.String > ("SMSTTXT"); } 
			set { base.Set (value, "SMSTTXT"); }
		}



		public System.String Userstatus
		{ 
			get { return base.Get< System.String > ("SMASTXT"); } 
			set { base.Set (value, "SMASTXT"); }
		}



		public System.String PartnerFunction
		{ 
			get { return base.Get< System.String > ("PARVW"); } 
			set { base.Set (value, "PARVW"); }
		}



		public System.String PartnerFunctionDescription
		{ 
			get { return base.Get< System.String > ("PARVW_TEXT"); } 
			set { base.Set (value, "PARVW_TEXT"); }
		}



		public System.String ContactPersonNumber
		{ 
			get { return base.Get< System.String > ("PARNR"); } 
			set { base.Set (value, "PARNR"); }
		}



		public System.String ContactPersonName
		{ 
			get { return base.Get< System.String > ("PARNR_NAME"); } 
			set { base.Set (value, "PARNR_NAME"); }
		}



		public System.DateTime PlannedStartDate
		{ 
			get { return base.Get< System.DateTime > ("PSTER"); } 
			set { base.Set (value, "PSTER"); }
		}



		public System.DateTime PlannedStartTime
		{ 
			get { return base.Get< System.DateTime > ("PSTUR"); } 
			set { base.Set (value, "PSTUR"); }
		}



		public System.DateTime PlannedFinishDate
		{ 
			get { return base.Get< System.DateTime > ("PETER"); } 
			set { base.Set (value, "PETER"); }
		}



		public System.DateTime PlannedFinishTime
		{ 
			get { return base.Get< System.DateTime > ("PETUR"); } 
			set { base.Set (value, "PETUR"); }
		}



		public System.String PersonWhoCompletedTask
		{ 
			get { return base.Get< System.String > ("ERLNAM"); } 
			set { base.Set (value, "ERLNAM"); }
		}



		public System.DateTime DateTaskWasCompleted
		{ 
			get { return base.Get< System.DateTime > ("ERLDAT"); } 
			set { base.Set (value, "ERLDAT"); }
		}



		public System.DateTime TimeTaskWasCompleted
		{ 
			get { return base.Get< System.DateTime > ("ERLZEIT"); } 
			set { base.Set (value, "ERLZEIT"); }
		}



		public System.String FollowUpAction
		{ 
			get { return base.Get< System.String > ("FOLGEACT"); } 
			set { base.Set (value, "FOLGEACT"); }
		}



		public System.String FollowUpActionText
		{ 
			get { return base.Get< System.String > ("FOLGEACT_TEXT"); } 
			set { base.Set (value, "FOLGEACT_TEXT"); }
		}



		public System.String CreatedBy
		{ 
			get { return base.Get< System.String > ("ERNAM"); } 
			set { base.Set (value, "ERNAM"); }
		}



		public System.DateTime CreateDate
		{ 
			get { return base.Get< System.DateTime > ("ERDAT"); } 
			set { base.Set (value, "ERDAT"); }
		}



		public System.DateTime CreateTime
		{ 
			get { return base.Get< System.DateTime > ("ERZEIT"); } 
			set { base.Set (value, "ERZEIT"); }
		}



		public System.String ChangedBy
		{ 
			get { return base.Get< System.String > ("AENAM"); } 
			set { base.Set (value, "AENAM"); }
		}



		public System.DateTime DateChanged
		{ 
			get { return base.Get< System.DateTime > ("AEDAT"); } 
			set { base.Set (value, "AEDAT"); }
		}



		public System.DateTime TimeChanged
		{ 
			get { return base.Get< System.DateTime > ("AEZEIT"); } 
			set { base.Set (value, "AEZEIT"); }
		}



		public System.String TaskCatalogType
		{ 
			get { return base.Get< System.String > ("MNKAT"); } 
			set { base.Set (value, "MNKAT"); }
		}



		public System.String ObjectNumber
		{ 
			get { return base.Get< System.String > ("OBJNR"); } 
			set { base.Set (value, "OBJNR"); }
		}



		public System.String ObjectLongTextAvailable
		{ 
			get { return base.Get< System.String > ("INDTX"); } 
			set { base.Set (value, "INDTX"); }
		}



		public System.String ItemRecordNumber
		{ 
			get { return base.Get< System.String > ("FENUM"); } 
			set { base.Set (value, "FENUM"); }
		}



		public System.String LongText
		{ 
			get { return base.Get< System.String > ("LONGTEXT"); } 
			set { base.Set (value, "LONGTEXT"); }
		}


	}
	
	[Name("ACTIVITIES")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_ACTIVITIES : BusinessObject<EnosixServiceNotification_ACTIVITIES>
	{
		

		public System.String NotificationNumber
		{ 
			get { return base.Get< System.String > ("QMNUM"); } 
			set { base.Set (value, "QMNUM"); }
		}



		public System.String ActivityNumber
		{ 
			get { return base.Get< System.String > ("QMANUM"); } 
			set { base.Set (value, "QMANUM"); }
		}



		public System.String ActivityCodeGroup
		{ 
			get { return base.Get< System.String > ("MFGRP"); } 
			set { base.Set (value, "MFGRP"); }
		}



		public System.String CodeGroupDescription
		{ 
			get { return base.Get< System.String > ("KURZTEXT"); } 
			set { base.Set (value, "KURZTEXT"); }
		}



		public System.String ActivityCode
		{ 
			get { return base.Get< System.String > ("MFCOD"); } 
			set { base.Set (value, "MFCOD"); }
		}



		public System.String ActivityCodeText
		{ 
			get { return base.Get< System.String > ("MFCOD_TEXT"); } 
			set { base.Set (value, "MFCOD_TEXT"); }
		}



		public System.String ActivityText
		{ 
			get { return base.Get< System.String > ("MFTXT"); } 
			set { base.Set (value, "MFTXT"); }
		}



		public System.DateTime PlannedStartDate
		{ 
			get { return base.Get< System.DateTime > ("PSTER"); } 
			set { base.Set (value, "PSTER"); }
		}



		public System.DateTime PlannedStartTime
		{ 
			get { return base.Get< System.DateTime > ("PSTUR"); } 
			set { base.Set (value, "PSTUR"); }
		}



		public System.DateTime PlannedFinishDate
		{ 
			get { return base.Get< System.DateTime > ("PETER"); } 
			set { base.Set (value, "PETER"); }
		}



		public System.DateTime PlannedFinishTime
		{ 
			get { return base.Get< System.DateTime > ("PETUR"); } 
			set { base.Set (value, "PETUR"); }
		}



		public System.String CreatedBy
		{ 
			get { return base.Get< System.String > ("ERNAM"); } 
			set { base.Set (value, "ERNAM"); }
		}



		public System.DateTime CreateDate
		{ 
			get { return base.Get< System.DateTime > ("ERDAT"); } 
			set { base.Set (value, "ERDAT"); }
		}



		public System.DateTime CreateTime
		{ 
			get { return base.Get< System.DateTime > ("ERZEIT"); } 
			set { base.Set (value, "ERZEIT"); }
		}



		public System.String ChangedBy
		{ 
			get { return base.Get< System.String > ("AENAM"); } 
			set { base.Set (value, "AENAM"); }
		}



		public System.DateTime DateChanged
		{ 
			get { return base.Get< System.DateTime > ("AEDAT"); } 
			set { base.Set (value, "AEDAT"); }
		}



		public System.DateTime TimeChanged
		{ 
			get { return base.Get< System.DateTime > ("AEZEIT"); } 
			set { base.Set (value, "AEZEIT"); }
		}



		public System.String TaskCatalogType
		{ 
			get { return base.Get< System.String > ("MNKAT"); } 
			set { base.Set (value, "MNKAT"); }
		}



		public System.String SequentialNumber
		{ 
			get { return base.Get< System.String > ("MANUM"); } 
			set { base.Set (value, "MANUM"); }
		}



		public System.String INDLTX
		{ 
			get { return base.Get< System.String > ("INDLTX"); } 
			set { base.Set (value, "INDLTX"); }
		}



		public System.String ItemRecordNumber
		{ 
			get { return base.Get< System.String > ("FENUM"); } 
			set { base.Set (value, "FENUM"); }
		}



		public System.String LongText
		{ 
			get { return base.Get< System.String > ("LONGTEXT"); } 
			set { base.Set (value, "LONGTEXT"); }
		}


	}
	
	[Name("PARTNERS")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_PARTNERS : BusinessObject<EnosixServiceNotification_PARTNERS>
	{
		

		public System.String PartnerFunction
		{ 
			get { return base.Get< System.String > ("PARVW"); } 
			set { base.Set (value, "PARVW"); }
		}



		public System.String PartnerFunctionDescription
		{ 
			get { return base.Get< System.String > ("PARVW_TEXT"); } 
			set { base.Set (value, "PARVW_TEXT"); }
		}



		public System.String ContactPersonNumber
		{ 
			get { return base.Get< System.String > ("PARNR"); } 
			set { base.Set (value, "PARNR"); }
		}



		public System.String PartnerName
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



		public System.String Country
		{ 
			get { return base.Get< System.String > ("COUNTRY"); } 
			set { base.Set (value, "COUNTRY"); }
		}



		public System.String Region
		{ 
			get { return base.Get< System.String > ("REGION"); } 
			set { base.Set (value, "REGION"); }
		}



		public System.String Street
		{ 
			get { return base.Get< System.String > ("STREET"); } 
			set { base.Set (value, "STREET"); }
		}



		public System.String POBox
		{ 
			get { return base.Get< System.String > ("PO_BOX"); } 
			set { base.Set (value, "PO_BOX"); }
		}



		public System.String Language
		{ 
			get { return base.Get< System.String > ("LANGU"); } 
			set { base.Set (value, "LANGU"); }
		}



		public System.String TelephoneNumber
		{ 
			get { return base.Get< System.String > ("TEL_NUMBER"); } 
			set { base.Set (value, "TEL_NUMBER"); }
		}



		public System.String FaxNumber
		{ 
			get { return base.Get< System.String > ("FAX_NUMBER"); } 
			set { base.Set (value, "FAX_NUMBER"); }
		}



		public System.String TelexNumber
		{ 
			get { return base.Get< System.String > ("TLX_NUMBER"); } 
			set { base.Set (value, "TLX_NUMBER"); }
		}



		public System.String TeletexNumber
		{ 
			get { return base.Get< System.String > ("TTX_NUMBER"); } 
			set { base.Set (value, "TTX_NUMBER"); }
		}



		public System.String SearchTerm1
		{ 
			get { return base.Get< System.String > ("SORT1"); } 
			set { base.Set (value, "SORT1"); }
		}



		public System.String NotificationProcessName
		{ 
			get { return base.Get< System.String > ("NAME_LIST"); } 
			set { base.Set (value, "NAME_LIST"); }
		}



		public System.String AddressNotes
		{ 
			get { return base.Get< System.String > ("REMARK"); } 
			set { base.Set (value, "REMARK"); }
		}



		public System.String PartnerTimeZone
		{ 
			get { return base.Get< System.String > ("TZONSP"); } 
			set { base.Set (value, "TZONSP"); }
		}



		public System.DateTime SystemDate
		{ 
			get { return base.Get< System.DateTime > ("DATUM"); } 
			set { base.Set (value, "DATUM"); }
		}



		public System.DateTime SystemTime
		{ 
			get { return base.Get< System.DateTime > ("UZEIT"); } 
			set { base.Set (value, "UZEIT"); }
		}



		public System.String HouseNumber
		{ 
			get { return base.Get< System.String > ("HOUSE_NUM1"); } 
			set { base.Set (value, "HOUSE_NUM1"); }
		}


	}
	
	[Name("ADD_ITEM_TCA_TEXT")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixServiceNotification_ADD_ITEM_TCA_TEXT : BusinessObject<EnosixServiceNotification_ADD_ITEM_TCA_TEXT>
	{
		

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
	
}
