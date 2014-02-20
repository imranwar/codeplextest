using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banckle
{
	/// <summary>
	/// 
	/// </summary>
	public class ResponseStatus : BanckleCRM
	{
		//ErrorCode (string, optional),
		/// <summary>
		/// 
		/// </summary>
		string ErrorCode { get; set; }
		//Message (string, optional),
		/// <summary>
		/// 
		/// </summary>
		string Messgae { get; set; }
		//StackTrace (string, optional),
		/// <summary>
		/// 
		/// </summary>
		string StackTrace { get; set; }
		//Errors (Array[ResponseError], optional)
		/// <summary>
		/// 
		/// </summary>
		ResponseError[] responseError;
	}
}