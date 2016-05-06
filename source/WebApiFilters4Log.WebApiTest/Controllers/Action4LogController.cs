﻿using System;
using System.Web.Http;

namespace WebApiFilters4Log.WebApiTest.Controllers
{
	public class Action4LogController : ApiController
	{
		[HttpGet]
		[Action4LogFilter()]
		public IHttpActionResult LogInfoWithHttpGet_Success()
		{
			return Ok("Success");
		}

		[HttpGet]
		[Action4LogFilter("Action4LogTest", LogLevel.INFO)]
		public IHttpActionResult LogInfoWithHttpGet_Fail()
		{
			throw new InvalidOperationException("LogInfoWithHttpGet_Fail");
		}
	}
}