
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
	public partial interface IServiceTimeBusinessObjectContext : IBusinessObjectContext
	{
		IBusinessObjectRepository<EnosixServiceOrder> EnosixServiceOrderRepository {get;}
		IBusinessObjectRepository<EnosixTimesheet> EnosixTimesheetRepository {get;}
		IBusinessObjectRepository<EnosixServiceNotification> EnosixServiceNotificationRepository {get;}
		IBusinessObjectRepository<EnosixServiceReport> EnosixServiceReportRepository {get;}

		IBusinessObjectSearch<EnosixServiceOrder_SEARCHRESULT,EnosixServiceOrder_SC,EnosixServiceOrder_SEARCHPARAMS> EnosixServiceOrderSearch{get;}
		IBusinessObjectSearch<EnosixTimesheet_SEARCHRESULT,EnosixTimesheet_SC,EnosixTimesheet_SEARCHPARAMS> EnosixTimesheetSearch{get;}
		IBusinessObjectSearch<EnosixServiceNotification_SEARCHRESULT,EnosixServiceNotification_SC,EnosixServiceNotification_SEARCHPARAMS> EnosixServiceNotificationSearch{get;}
		IBusinessObjectSearch<EnosixServiceReport_SEARCHRESULT,EnosixServiceReport_SC,EnosixServiceReport_SEARCHPARAMS> EnosixServiceReportSearch{get;}

		IFunctionObject<Z_ENSX_CS_GET_SAFETY_CHECKLIST> Z_ENSX_CS_GET_SAFETY_CHECKLIST {get;}
		IFunctionObject<CS_GET_REPORT_CODES> CS_GET_REPORT_CODES {get;}
	}



#region License
[License(@"77u/PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4NCjxMaWNlbnNlPg0KICA8SWQ+YTg1N2QyZGEtODMyNS00MzFkLWExOWUtZmUzOWU4MDFlMDY3PC9JZD4NCiAgPFR5cGU+VHJpYWw8L1R5cGU+DQogIDxFeHBpcmF0aW9uPk1vbiwgMDIgTWF5IDIwMTYgMjE6MTc6MjEgR01UPC9FeHBpcmF0aW9uPg0KICA8UHJvZHVjdEZlYXR1cmVzPg0KICAgIDxGZWF0dXJlIG5hbWU9Ik1vZGVsR2VuZXJhdG9yIj50cnVlPC9GZWF0dXJlPg0KICAgIDxGZWF0dXJlIG5hbWU9Ik9ubGluZSI+VHJ1ZTwvRmVhdHVyZT4NCiAgICA8RmVhdHVyZSBuYW1lPSJPZmZsaW5lIj5UcnVlPC9GZWF0dXJlPg0KICAgIDxGZWF0dXJlIG5hbWU9IkZ1bmN0aW9ucyI+VHJ1ZTwvRmVhdHVyZT4NCiAgICA8RmVhdHVyZSBuYW1lPSJCdXNpbmVzc09iamVjdHMiPkVub3NpeCo8L0ZlYXR1cmU+DQogIDwvUHJvZHVjdEZlYXR1cmVzPg0KICA8Q3VzdG9tZXI+DQogICAgPE5hbWU+UGl4ZWwgYW5kIExpbmU8L05hbWU+DQogICAgPEVtYWlsPnN0dWFydEBwaXhlbGFuZGxpbmUuY29tPC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPExpY2Vuc2VBdHRyaWJ1dGVzPg0KICAgIDxBdHRyaWJ1dGUgbmFtZT0iQXBwTmFtZSI+Rml2ZXMgUHJvamVjdDwvQXR0cmlidXRlPg0KICAgIDxBdHRyaWJ1dGUgbmFtZT0iQ3JlYXRlZE9uIj4xMS8yLzIwMTUgOToxNzoyMSBQTTwvQXR0cmlidXRlPg0KICA8L0xpY2Vuc2VBdHRyaWJ1dGVzPg0KICA8U2lnbmF0dXJlPk1FVUNJRTVRVHdYOFdzY1pyb0lKSHNsT2dBelpaQWtzSHNRcEd0d3l3K0ZFTTdoK0FpRUEzV0djVjRqRFRycGlxc1JRVi9hSWpzdUUvZXFVeERFVmNvVVAremVZMzEwPTwvU2lnbmF0dXJlPg0KPC9MaWNlbnNlPg==")]
#endregion"

	public partial class ServiceTimeBusinessObjectContext : OnlineBusinessObjectContext<ServiceTimeBusinessObjectContext, IServiceTimeBusinessObjectContext>, IServiceTimeBusinessObjectContext
	{
		public ServiceTimeBusinessObjectContext(IFrameworkContext framework) : base(framework)
		{
		}

		#region IServiceTimeBusinessObjectContext implementation
		IBusinessObjectRepository<EnosixServiceOrder> IServiceTimeBusinessObjectContext.EnosixServiceOrderRepository {
			get {
				return _framework.Repository<EnosixServiceOrder> ("EnosixServiceOrderRepository");
			}
		}
		IBusinessObjectRepository<EnosixTimesheet> IServiceTimeBusinessObjectContext.EnosixTimesheetRepository {
			get {
				return _framework.Repository<EnosixTimesheet> ("EnosixTimesheetRepository");
			}
		}
		IBusinessObjectRepository<EnosixServiceNotification> IServiceTimeBusinessObjectContext.EnosixServiceNotificationRepository {
			get {
				return _framework.Repository<EnosixServiceNotification> ("EnosixServiceNotificationRepository");
			}
		}
		IBusinessObjectRepository<EnosixServiceReport> IServiceTimeBusinessObjectContext.EnosixServiceReportRepository {
			get {
				return _framework.Repository<EnosixServiceReport> ("EnosixServiceReportRepository");
			}
		}

		IBusinessObjectSearch<EnosixServiceOrder_SEARCHRESULT, EnosixServiceOrder_SC,EnosixServiceOrder_SEARCHPARAMS> IServiceTimeBusinessObjectContext.EnosixServiceOrderSearch {
			get {
			return _framework.Search<EnosixServiceOrder_SEARCHRESULT, EnosixServiceOrder_SC,EnosixServiceOrder_SEARCHPARAMS> ("EnosixServiceOrderSearch", config => {config.BusinessObjectType = "EnosixServiceOrder"; config.DefaultCriteria = c => c.SEARCHPARAMS_Collection;});
			}
		}
		IBusinessObjectSearch<EnosixTimesheet_SEARCHRESULT, EnosixTimesheet_SC,EnosixTimesheet_SEARCHPARAMS> IServiceTimeBusinessObjectContext.EnosixTimesheetSearch {
			get {
			return _framework.Search<EnosixTimesheet_SEARCHRESULT, EnosixTimesheet_SC,EnosixTimesheet_SEARCHPARAMS> ("EnosixTimesheetSearch", config => {config.BusinessObjectType = "EnosixTimesheet"; config.DefaultCriteria = c => c.SEARCHPARAMS_Collection;});
			}
		}
		IBusinessObjectSearch<EnosixServiceNotification_SEARCHRESULT, EnosixServiceNotification_SC,EnosixServiceNotification_SEARCHPARAMS> IServiceTimeBusinessObjectContext.EnosixServiceNotificationSearch {
			get {
			return _framework.Search<EnosixServiceNotification_SEARCHRESULT, EnosixServiceNotification_SC,EnosixServiceNotification_SEARCHPARAMS> ("EnosixServiceNotificationSearch", config => {config.BusinessObjectType = "EnosixServiceNotification"; config.DefaultCriteria = c => c.SEARCHPARAMS_Collection;});
			}
		}
		IBusinessObjectSearch<EnosixServiceReport_SEARCHRESULT, EnosixServiceReport_SC,EnosixServiceReport_SEARCHPARAMS> IServiceTimeBusinessObjectContext.EnosixServiceReportSearch {
			get {
			return _framework.Search<EnosixServiceReport_SEARCHRESULT, EnosixServiceReport_SC,EnosixServiceReport_SEARCHPARAMS> ("EnosixServiceReportSearch", config => {config.BusinessObjectType = "EnosixServiceReport"; config.DefaultCriteria = c => c.SEARCHPARAMS_Collection;});
			}
		}

		#endregion

		#region IServiceTimeBusinessObjectContextOffline implementation


		#endregion

		#region Function Objects
		public IFunctionObject<Z_ENSX_CS_GET_SAFETY_CHECKLIST> Z_ENSX_CS_GET_SAFETY_CHECKLIST {
			get {
				return _framework.FunctionObject<Z_ENSX_CS_GET_SAFETY_CHECKLIST>("Z_ENSX_CS_GET_SAFETY_CHECKLIST");
			}
		}
		public IFunctionObject<CS_GET_REPORT_CODES> CS_GET_REPORT_CODES {
			get {
				return _framework.FunctionObject<CS_GET_REPORT_CODES>("/ENSX/CS_GET_REPORT_CODES");
			}
		}
		

		#endregion
	}
}