﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cde.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PingController : ControllerBase
	{
		// GET: api/<PingController>
		[HttpGet]
		public ActionResult<string> Get() {
			return Ok("Pong");
		}

	}
}
