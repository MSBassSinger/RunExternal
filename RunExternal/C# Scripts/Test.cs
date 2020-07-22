using System.dll;
using System.Windows.Forms.dll;
using System.Runtime.Serialization.dll;

namespace JeffJones.ExternalCode
{

	public class JJScriptTest
	{

		public int TestMemberInt = 0;

		private string m_Message = "";

		private System.String m_Caption = "";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pTestObject"></param>
		/// <param name="pCaption"></param>
		/// <param name="pTestObject"></param>
		public void ShowMessage(string pMessage, string pCaption, RunExternal.TestObject pTestObject)
		{

			m_Message = pMessage;

			m_Caption = pCaption;

			System.String String2Show = pMessage + System.Environment.NewLine + pTestObject.ComputerName;

			System.Windows.Forms.MessageBox.Show(String2Show, pCaption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);

		}  // END public void ShowMessage(System.String pMessage, System.String pCaption, RunExternal.TestObject pTestObject)

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pTestObject"></param>
		public void ShowMessage2(RunExternal.TestObject pTestObject)
		{
			if ((m_Message.Length > 0) & (m_Caption.Length > 0))
			{
			    System.String String2Show = m_Message + System.Environment.NewLine + pTestObject.ComputerName;

			    System.Windows.Forms.MessageBox.Show(String2Show, m_Caption, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
			}
			else
			{
			    throw new System.ArgumentException("Message and/or caption missing.");
			}
		}  // END public void ShowMessage2(RunExternal.TestObject pTestObject)

		/// <summary>
		/// 
		/// </summary>
		public System.String Message2Show
		{
			get
			{
				return m_Message;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public System.String Caption
		{
			get
			{
				return m_Caption;
			}
			set
			{
				m_Caption = value;
			}
		}

	}  // END public class JJScriptTest

}  // namespace JeffJones.ExternalCode