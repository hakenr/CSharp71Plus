using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp71PlusApp
{
	// C# 7.2 - Leading underscores in numeric literal
	public class LeadingUnderscoresInNumericLiterals
	{
		// C# 7
		int binaryValue7 = 0b0101_0101;
		long hexValue7 = 0xFFAB_1586;

		// C# 7.2 - Hex and binary numeric literals may now begin with an _
		int binaryValue72 = 0b_0101_0101;
		long hexValue72 = 0x_FFAB_1586;
	}
}
