﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name , int numtime = 1)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numtime;
        return View();
    }
}