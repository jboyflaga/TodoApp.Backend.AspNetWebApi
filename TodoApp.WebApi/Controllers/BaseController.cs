﻿namespace TodoApp.WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using TodoApp.WebApi.Entities;

[Controller]
public abstract class BaseController : ControllerBase
{
    // returns the current authenticated account (null if not logged in)
    public Account Account => (Account)HttpContext.Items["Account"];
}