RunExternal is a sample program to show how to use the CodeDOM to dynamcially compile C# code and run the compiloed assembly.

This example does not look at the Roslyn compiler.  That is saved for a different example program.

For an external C# script, note the "using" requires the DLL name.  For example:
  using System.dll;
instead of 
  using System;

The VS IDE knows to lookup the System namespace, and provide the DLL name to the compiler.

when using types, most type names require the full name path.  For example, if you use "String", then it must be
"System.String", but if you use the alias "string", that will work by itself.  However, objects like
System.Windows.Forms.MessageBox require the full name.

When defining a type, the full type name (except for aliases) is required.  For example:
  public void ShowMessage(System.String pMessage, System.String pCaption, RunExternal.TestObject pTestObject)
  System.Int32 TestMemberInt
instead of 
  public void ShowMessage(String pMessage, String pCaption, TestObject pTestObject)
  Int32 TestMemberInt

This works also:
  public void ShowMessage(string pMessage, string pCaption, RunExternal.TestObject pTestObject)
  int TestMemberInt

The full type name is needed for the compiler to do a lookup.  Again, the VS IDE does this lookup for you when you compile code in the project.

The code is commented so you can see how this is done by simply reading through, or stepping through, the code.
