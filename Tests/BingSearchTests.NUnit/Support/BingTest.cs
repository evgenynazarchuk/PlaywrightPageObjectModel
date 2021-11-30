﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright.NUnit;
using Playwright.Synchronous;
using BingPageObjectModel.Pages;
using NUnit.Framework;

namespace BingSearchTests.NUnit.Support;

public class BingTest : ContextTest
{
    public MainPage OpenMainPage()
    {
        //Desktop Chrome
        //Galaxy S5
        var options = Playwright.Devices["Desktop Chrome"];
        options.Locale = "en-US";

        var context = this.NewContext(options).GetAwaiter().GetResult();
        var page = context.NewPage();

        page.Goto("https://bing.com");
        return new MainPage(page);
    }
}