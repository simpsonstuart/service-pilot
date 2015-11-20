
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
	public partial class CS_GET_REPORT_CODES : FunctionParameters<CS_GET_REPORT_CODES>
	{
	

		public System.String IV_QMART
		{ 
			get { return base.Get< System.String > ("IV_QMART"); } 
			set { base.Set (value, "IV_QMART"); }
		}



		public System.String IV_RBNR
		{ 
			get { return base.Get< System.String > ("IV_RBNR"); } 
			set { base.Set (value, "IV_RBNR"); }
		}



		public System.String ES_CODES
		{ 
			get { return base.Get< System.String > ("ES_CODES"); } 
			set { base.Set (value, "ES_CODES"); }
		}

	}

	}