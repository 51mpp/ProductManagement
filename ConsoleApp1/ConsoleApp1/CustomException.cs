using System;
using ConsoleApp1;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CustomException : Exception
{
	public CustomException()
	{
	}

	public CustomException(string message):base(message) { 
	}
}
