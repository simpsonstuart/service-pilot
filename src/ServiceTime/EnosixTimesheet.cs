






using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
     [Header( "HEADER" )]   
	
	
	[RecordKeyStructure("EnosixObjKey")]
	
	public partial class EnosixTimesheet : BusinessObject<EnosixTimesheet> 
	{
		
		
		public virtual ICollection<EnosixTimesheet_LINE_ITEM> LINE_ITEM_Collection
		{
			get 
			{
				return base.GetCollection<EnosixTimesheet_LINE_ITEM>("LINE_ITEM_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixTimesheet_PLANT> PLANT_Collection
		{
			get 
			{
				return base.GetCollection<EnosixTimesheet_PLANT>("PLANT_Collection");
			}
		}

		
		
		public virtual ICollection<EnosixTimesheet_ATT_TYPE_MAP> ATT_TYPE_MAP_Collection
		{
			get 
			{
				return base.GetCollection<EnosixTimesheet_ATT_TYPE_MAP>("ATT_TYPE_MAP_Collection");
			}
		}

		

		#region Header Properties

		

		public System.String Username
		{ 
			get { return base.Get< System.String > ("USERNAME"); } 
			set { base.Set (value, "USERNAME"); }
		}



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


		
		#endregion

		
	}
	
	[Name("LINE_ITEM")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixTimesheet_LINE_ITEM : BusinessObject<EnosixTimesheet_LINE_ITEM>
	{
		

		public System.String CounterInTimeRecording
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



		public System.String SendingPurchaseOrder
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



		public System.String Suboperation
		{ 
			get { return base.Get< System.String > ("SUB_ACTIVITY"); } 
			set { base.Set (value, "SUB_ACTIVITY"); }
		}



		public System.String WorkCenter
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



		public System.String CurrencyKey
		{ 
			get { return base.Get< System.String > ("CURRENCY"); } 
			set { base.Set (value, "CURRENCY"); }
		}



		public System.String ISOcurrencyCode
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



		public System.String Plant
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



		public System.String OperationShortText
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



		public System.String PersonWhoChangedObject
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



		public System.String ProcessingStatus
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
	
	[Name("PLANT")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixTimesheet_PLANT : BusinessObject<EnosixTimesheet_PLANT>
	{
		

		public System.String Plant
		{ 
			get { return base.Get< System.String > ("PLANT"); } 
			set { base.Set (value, "PLANT"); }
		}



		public System.String PlantName
		{ 
			get { return base.Get< System.String > ("PLANT_NAME"); } 
			set { base.Set (value, "PLANT_NAME"); }
		}



		public System.DateTime StartDate
		{ 
			get { return base.Get< System.DateTime > ("BEGDA"); } 
			set { base.Set (value, "BEGDA"); }
		}



		public System.DateTime EndDate
		{ 
			get { return base.Get< System.DateTime > ("ENDDA"); } 
			set { base.Set (value, "ENDDA"); }
		}


	}
	
	[Name("ATT_TYPE_MAP")]
	
	[RecordKeyStructure("EnosixObjKey","iindex")]
	
	public partial class EnosixTimesheet_ATT_TYPE_MAP : BusinessObject<EnosixTimesheet_ATT_TYPE_MAP>
	{
		

		public System.String SequenceNumber
		{ 
			get { return base.Get< System.String > ("SEQ_NO"); } 
			set { base.Set (value, "SEQ_NO"); }
		}



		public System.String ActivityType
		{ 
			get { return base.Get< System.String > ("ACTTYPE"); } 
			set { base.Set (value, "ACTTYPE"); }
		}



		public System.String AttendanceOrAbsenceType
		{ 
			get { return base.Get< System.String > ("ABS_ATT_TYPE"); } 
			set { base.Set (value, "ABS_ATT_TYPE"); }
		}


	}
	
}
