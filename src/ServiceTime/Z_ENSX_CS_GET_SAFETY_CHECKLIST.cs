
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using enosiX;

namespace ServiceTime
{
	public partial class Z_ENSX_CS_GET_SAFETY_CHECKLIST : FunctionParameters<Z_ENSX_CS_GET_SAFETY_CHECKLIST>
	{
	

		public System.DateTime IV_DATE
		{ 
			get { return base.Get< System.DateTime > ("IV_DATE"); } 
			set { base.Set (value, "IV_DATE"); }
		}



		public System.String ET_CHKLST
		{ 
			get { return base.Get< System.String > ("ET_CHKLST"); } 
			set { base.Set (value, "ET_CHKLST"); }
		}

	}

	}