using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// C# 7.3: Auto-Implemented Property Field-Targeted Attributes
	// https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.3/auto-prop-field-attrs.md
	[Serializable]
	public class AutoPropertyFieldAttributes
    {
		[field: NonSerialized]
		public string MySecret { get; set; }
	}
}
