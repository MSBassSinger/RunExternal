/************************************************************************************************
 * TestObject.cs
 * 
 * This class is used as one instantiated and called through the external script to show how an
 * existing object can be used in an external script.
 * 
 * When       Who What
 * ========== === ===============================================================================
 * 05/02/2014 JDJ Genesis
 * 
 ***********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunExternal
{
	public class TestObject
	{

		public String ComputerName
		{
			get
			{
				// Just something to show in the demo
				return $"{Environment.UserName} using computer {Environment.MachineName} on {DateTime.Now.ToShortDateString()} at {DateTime.Now.ToShortTimeString()}.";
			}
		}  // END public String ComputerName

	}  // END public class TestObject

}  // END namespace RunExternal
